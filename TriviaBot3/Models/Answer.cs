using System;

namespace TriviaBot3.Models
{
    public class Answer
    {
        public Guid AnswerId { get; set; }
        public string Statement { get; set; }
        public Question Question { get; set; }
        public bool IsCorrect { get; set; }
    }
}
