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
                    QuestionTitle = "What year was Star Wars first released in the US",
                     Options = new List<string>() { "1978", "1977", "2001", "1965" },
                       Answer=2
                },
                                new Question()
                {
                      QuestionTitle = "What year was ET first released in the US",
                     Options = new List<string>() { "1978", "1977", "1981", "1965" },
                       Answer=3
                }

            };

            return new OkObjectResult(quiz);
        }
    }
}
