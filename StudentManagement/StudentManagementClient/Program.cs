using System.Net.Http.Json;
using System.Text;

class Program
{
    static void Main()
    {
        var baseApiAddress = "https://localhost:7127";

        var httpClient = new HttpClient();

        // Add student
        var requestContent = new StringContent(
            "{\"id\": \"3fa85f64-5717-4562-b3fc-2c963f66afa6\",\"firstName\": \"Alex\",\"lastName\": \"Caragia\"}",
            Encoding.UTF8,
            "application/json");

        var resultAdd = httpClient
            .PostAsync($"{baseApiAddress}/students", requestContent)
            .Result;

        // Get get students
        var resultGet = httpClient
            .GetAsync($"{baseApiAddress}/students")
            .Result;
    }
}