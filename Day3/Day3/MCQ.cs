using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class MCQ:Question
    {
        public string[] Choices { get; set; }
        public int Correct_Answer {  get; set; }
        public MCQ(string header, string body, int mark, string[] choices, int correctIndex)
            : base(header, body, mark)
        {
            Choices = choices;
            Correct_Answer = correctIndex;
        }


        public override void Show()
        {
            base.Show();
            for (int i = 0; i < Choices.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Choices[i]}");
            }
        }

        public bool CheckAnswer(int answerIndex)
        {
            return answerIndex == Correct_Answer;
        }
    }
}

