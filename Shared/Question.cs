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
        public string QuestionTitle { get; set; } = string.Empty;
        public IEnumerable<string> Options { get; set; } = new List<string>();
        public string Answer { get; set; } = String.Empty;
    }
}
