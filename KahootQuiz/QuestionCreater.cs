using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootQuiz
{
    internal class QuestionCreater
    {
        public List<Question> Questions { get; private set; }

        public QuestionCreater()
        {
            Questions = new List<Question>
            {
                new Question("Hva er Gelato på Norsk?", new List<Answer>
                {
                    new Answer("iskrem", 1, true),
                    new Answer("bildekk", 2, false),
                    new Answer("skrue", 3, false),
                    new Answer("pizza", 4, false),

                }),
                new Question("Hva er etternavnet til Obama?", new List<Answer>
                {
                    new Answer("Trump", 1, false),
                    new Answer("Stoltenberg", 2, false),
                    new Answer("Solberg", 3, false),
                    new Answer("Obama", 4, true),

                }),
                new Question("Hva står G-en i GET for?", new List<Answer>
                {
                    new Answer("Gucci", 1, false),
                    new Answer("Gant", 2, false),
                    new Answer("Geir", 3, true),
                    new Answer("Galdhøpiggen", 4, false),

                }),
                new Question("fullfør dette ordtaket: Det finnes ikke dårlig vær, bare dårlig...", new List<Answer>
                {
                    new Answer("Fjær", 1, false),
                    new Answer("Klær", 2, true),
                    new Answer("Militær", 3, false),
                    new Answer("Tacosaus", 4, false),

                }),

            };
        }
        public Question CreateQuestion()
        {
            Console.WriteLine($"Hva skal spørsmålet være?");
            var question = Console.ReadLine();
            var answers = CreateAnswer();
            var questionToAdd = new Question(question, answers);
            Questions.Insert(0, questionToAdd);
            //Questions.Add(questionToAdd);
            return questionToAdd;
        }
        public List<Answer> CreateAnswer()
        {
            var id = 0;
            List<Answer> answers = new List<Answer>();
            for (int i = 0; i < 4; i++)
            {
                id++;
                Console.WriteLine("Hva er svaralternativet du ønsker å lage?");
                var answerAlternativ = Console.ReadLine();
                Console.WriteLine("Er det riktig?");
                var rightAnswer = Console.ReadLine();
                bool rightAnswerBool = rightAnswer == "ja";
                var createAnswer = new Answer(answerAlternativ, id, rightAnswerBool);
                answers.Add(createAnswer);

            }

            return answers;
        }

        public void PrintQuestions(Player player)
        {
            foreach (var question in Questions)
            {
                Console.WriteLine($"{question.Description}\n");
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine($"{answer.AlternativAnswer}, Id: {answer.Id}");
                }

                player.AnswerQuestion(question);

            }

        }

    }
}
