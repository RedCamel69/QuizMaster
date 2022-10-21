using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMaster.Shared
{
 
    public class Quiz
    {
        public string Title { get; set; }
        public List<Question> Questions{ get; set; }
    }
    public class Question
    {
        public string QuestionText { get; set; }
        public List<Answer> Answers { get; set; }
    }

    public class Answer { 

        public string AnswerText { get;set; }
        public bool IsCorrect { get;set;}
    }

}
