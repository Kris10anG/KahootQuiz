using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootQuiz
{
    internal class Player
    {
        public string Name { get; private set; }
        public int Points { get; private set; }

        public Player(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public void IncreasePoints()
        {
            Points++;
            Console.WriteLine($"You got 1 point and has {Points} point(s)");
        }

        public void AnswerQuestion(Question question)
        {
            var questionId = Console.ReadLine();
            var id = question.GetCorrectAnswerId();
            if (id == -1)
            {
                Console.WriteLine($"Spørsmålet har ikke mangler riktigsvar");
                return;
            }
            if (id.ToString() == questionId)
            {
                Console.WriteLine($"Du valgte riktig svar");
                IncreasePoints();
            }
            else
            {
                Console.WriteLine($"Du valgte feil!");
            }
        }
    }
}
