using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examination_System.Classes
{
    public class Exam
    {
        public DateTime ExamDuration { get; set; }
        public DateTime ExamStartDate { get; set; }
        public int numbersOfQuestion { get; set; }
        public int ExamGrade { get; set; }
        public int MarkOfExam { get; set; }
        ExamStatus? status;
        enum ExamStatus
        {
            Started,
            Finished
        }
        public Exam(DateTime ExamDuration, int numbersOfQuestion)
        {
            this.ExamDuration = ExamDuration;
            this.numbersOfQuestion = numbersOfQuestion;
            ExamStartDate = DateTime.Now;
            ExamGrade = 0;
            MarkOfExam = 0;
            ExamStatus? status = ExamStatus.Started;
        }
        public void ShowExam(List<Question> questions)
        {
            Console.WriteLine($"Exam Start Date: {ExamStartDate}");
            Console.WriteLine($"Exam Duration: {ExamDuration}");
            Console.WriteLine($"Number of Questions: {numbersOfQuestion}");
            Console.WriteLine($"Exam Grade: {ExamGrade}");
            Console.WriteLine($"Mark of Exam: {MarkOfExam}");
            Console.WriteLine($"Exam Status: {status}");
            Console.WriteLine("Questions:");
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"Question: {questions[i].QBody}, Level: {questions[i].QLevel}, Type: {questions[i].QHeader}, Mark: {questions[i].QMark}");
            }
        }
        public void ShowAnswers(List<string> answers)
        {
            Console.WriteLine("Answers:");
            foreach (var answer in answers)
            {
                Console.WriteLine(answer);
            }
        }
    }
}
