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
        enum ExamStatus
        {
            Started,
            Queued,
            Finished
        }
        public Exam(DateTime ExamDuration, int numbersOfQuestion) 
        {
            this.ExamDuration = ExamDuration;
            this.numbersOfQuestion = numbersOfQuestion;
            ExamStartDate = DateTime.Now;
            ExamGrade = 0;
            MarkOfExam = 0;
        }
        public void ShowExam() { }
    }
}
