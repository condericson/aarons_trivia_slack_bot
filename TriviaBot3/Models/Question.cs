using System;
using System.Collections.Generic;

namespace TriviaBot3.Models
{
    public class Question
    {
        public Guid QuestionId { get; set; }
        public string Statement { get; set; }
        public DateTime Date { get; set; }
        public List<Answer> Answers { get; set; }
        public List<Attempt> Attempts { get; set; }
    }
}
