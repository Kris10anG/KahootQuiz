using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootQuiz
{
    internal class Question
    {
        public string Description { get; private set; }
        public List<Answer> Answers { get; private set; }

        public Question(string description, List<Answer> answers)
        {
            Description = description;
            Answers = answers;
        }

        public int GetCorrectAnswerId()
        {
            var answerToFind = Answers.FirstOrDefault(answer => answer.RightAnswer == true);
            if (answerToFind == null)
            {
                return -1;
            }
            return answerToFind.Id;

        }
    }
}
