using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace KahootQuiz
{
    internal class Game
    {
        public void Run()
        {
            var runGame = true;
            var questionCreater = new QuestionCreater();
            var player = new Player("Joe", 0);
            while (runGame)
            {
                Console.WriteLine("1: Spill Scuffed Kahoot\n" +
                                  "2:Lag spørsmål og svar\n");
                var command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        questionCreater.PrintQuestions(player);
                        break;
                    case "2":
                        questionCreater.CreateQuestion();
                        break;
                }
            }
        }

       
    }
}
