namespace WSE.Api.Services;

public interface IAiService
{
    Task<string> SummarizeLessonAsync(string transcript);
}

public class AiService : IAiService
{
    public async Task<string> SummarizeLessonAsync(string transcript)
    {
        // This is where you'd call OpenAI, Anthropic, or Gemini APIs
        await Task.Delay(100); // Simulate network call
        return $"Summary: This lesson covers the fundamental properties of {transcript.Length % 10} different math functions.";
    }
}
