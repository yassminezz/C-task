using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MCQ q = new MCQ("Q1", "How many days aweek", 2, new string[] { "6", "5", "3", "7" }, 4 );
            q.Show();
            Console.Write("\nHow many MCQ questions do you want to enter? ");
            int n = int.Parse(Console.ReadLine());
            MCQ[] questions = new MCQ[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Enter data for Question {i + 1} ---");
                Console.Write("Header: ");
                string header = Console.ReadLine();

                Console.Write("Body: ");
                string body = Console.ReadLine();

                Console.Write("Mark: ");
                int mark = int.Parse(Console.ReadLine());

                Console.Write("Number of choices: ");
                int c = int.Parse(Console.ReadLine());

                string[] choices = new string[c];
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"Choice {j + 1}: ");
                    choices[j] = Console.ReadLine();
                }

                Console.Write("Correct choice index (1-based): ");
                int correct = int.Parse(Console.ReadLine());

                questions[i] = new MCQ(header, body, mark, choices, correct);
            }

            int totalScore = 0;
            int possibleScore = 0;

            Console.WriteLine("¬¬¬¬¬ Answer the following Questions  ¬¬¬¬");
            foreach (MCQ question in questions)
            {
                question.Show();
                Console.Write("Your answer: ");
                int ansIndex = int.Parse(Console.ReadLine());

                possibleScore += question.Mark;
                if (question.CheckAnswer(ansIndex))
                {
                    Console.WriteLine("Correct!\n");
                    totalScore += question.Mark;
                }
                else
                {
                    Console.WriteLine("Wrong!\n");
                }
            }

            Console.WriteLine($"Your Score: {totalScore}/{possibleScore}");
        }
    }
}
