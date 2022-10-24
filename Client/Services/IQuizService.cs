using QuizMaster.Shared;

namespace QuizMaster.Client.Services
{
    public interface IQuizService
    {
       Task<Quiz> GetQuiz();
    }
}
