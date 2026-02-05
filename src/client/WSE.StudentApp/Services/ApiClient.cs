using System.Net.Http.Json;
using WSE.Domain;

namespace WSE.StudentApp.Services;

public class ApiClient
{
    private readonly HttpClient _http;

    public ApiClient(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Course>> GetCoursesAsync()
    {
        return await _http.GetFromJsonAsync<List<Course>>("api/courses") ?? new();
    }
}
