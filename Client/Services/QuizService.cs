using QuizMaster.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace QuizMaster.Client.Services
{
    public class QuizService : IQuizService
    {
        private readonly HttpClient _httpClient;

        public QuizService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Quiz> GetQuiz()
        {
            var res =  await _httpClient.GetFromJsonAsync<Quiz>("/api/Quiz") ?? new Quiz() { };
            return res;
        }
    }
}
