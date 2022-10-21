using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using QuizMaster.Shared;
using System.Collections.Generic;

namespace BlazorApp.Api
{
    public static class QuizFunction
    {
        [FunctionName("Quiz")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {

            Quiz quiz = new Quiz();
            quiz.Title = "Test Quiz";
            quiz.Questions = new List<Question>()
            {
                new Question()
                {
                     QuestionText = "What year was Star Wars first released in the US",
                      Answers = new List<Answer>()
                      {
                           new Answer()
                           {
                                AnswerText ="1976",
                                IsCorrect = false
                           },
                            new Answer()
                           {
                                AnswerText ="1977",
                                IsCorrect = true
                           },
                            new Answer()
                           {
                                AnswerText ="1978",
                                IsCorrect = false
                           },
                            new Answer()
                           {
                                AnswerText ="1980",
                                IsCorrect = false
                           }
                      }
                }
            };
           
            return new OkObjectResult(quiz);
        }
    }
}
