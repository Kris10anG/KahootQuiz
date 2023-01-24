using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootQuiz
{
    internal class Answer
    {
        public string AlternativAnswer { get; private set; }
        public int Id { get; private set; }
        public bool RightAnswer { get; private set; }

        public Answer(string alternativAnswer, int id, bool rightAnswer)
        {
            AlternativAnswer = alternativAnswer;
            Id = id;
            RightAnswer = rightAnswer;
        }
    }
}
