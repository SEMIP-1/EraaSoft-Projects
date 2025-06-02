using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    public class QuestionList
    {
        public List<Question>? Questions { get; set; }
        public List<string>? Answers { get; set; }
        public QuestionList()
        {
            Questions = new List<Question>();
            Answers = new List<string>();
        }
        public void AddQuestion(Question question, string answer)
        {
            Questions.Add(question);
            Answers.Add(answer);
        }
        public void ShowQuestions()
        {
            foreach (var question in Questions)
            {
                Console.WriteLine($"Question: {question.QBody}, Level: {question.QLevel}, Type: {question.QHeader}, Mark: {question.QMark}");
            }
        }
    }
}
