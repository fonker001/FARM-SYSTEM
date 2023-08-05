Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class WEATHER
    Private apiKey As String = "b2ca934821dba48f5868e093d5d7e5c1" ' My OpenWeather API key


    Private Sub GunaCircleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FetchWeatherButton.Click
        Dim cityName As String = CityTextBox.Text.Trim()
        If String.IsNullOrEmpty(cityName) Then
            MessageBox.Show("Please enter a city name.")
            Return
        End If

        Dim weatherData As JObject = GetWeatherData(cityName)

        If weatherData IsNot Nothing Then
            Dim temperature As Double = weatherData.SelectToken("main.temp").ToObject(Of Double)()
            Dim weatherDescription As String = weatherData.SelectToken("weather[0].description").ToString()
            Dim formattedTemperature As String = temperature.ToString("0.0") & "°C"

            WeatherLabel.Text = $"Temperature: {formattedTemperature}, Description: {weatherDescription}"
        Else
            MessageBox.Show("Failed to fetch weather data.")
        End If
    End Sub

    Private Function GetWeatherData(ByVal cityName As String) As JObject
        Dim apiUrl As String = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=metric&appid={apiKey}"

        Try
            Using client As New WebClient()
                Dim response As String = client.DownloadString(apiUrl)
                Return JObject.Parse(response)
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click

        Me.Close()

    End Sub
End Class