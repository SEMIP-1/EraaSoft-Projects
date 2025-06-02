using Examination_System.Classes;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            QuestionList questionList = new QuestionList();

            string QuestionBody1 = "A class in C# can inherit from multiple base classes.";
            TrueOrFalse question1 = new TrueOrFalse(QuestionLevel.Easy, QuestionType.TrueOrFalse, QuestionBody1, 1);
            string answer1 = "False";
            questionList.AddQuestion(question1, answer1);

            string QuestionBody2 = "Encapsulation in C# is implemented using access modifiers like private, public, and protected.";
            ChooseOne question2 = new ChooseOne(QuestionLevel.Medium, QuestionType.SingleChoice, QuestionBody2, 2);
            string answer2 = "True";
            questionList.AddQuestion(question2, answer2);

            string QuestionBody3 = "An abstract class in C# can be instantiated directly";
            ChooseAll question3 = new ChooseAll(QuestionLevel.Hard, QuestionType.MultipleChoice, QuestionBody3, 3);
            string answer3 = "False";
            questionList.AddQuestion(question3, answer3);

            string QuestionBody4 = "Polymorphism allows methods to behave differently based on the object that is calling them.";
            TrueOrFalse question4 = new TrueOrFalse(QuestionLevel.Easy, QuestionType.TrueOrFalse, QuestionBody4, 1);
            string answer4 = "True";
            questionList.AddQuestion(question4, answer4);

            string QuestionBody5 = "An interface in C# can contain private fields.";
            ChooseOne question5 = new ChooseOne(QuestionLevel.Medium, QuestionType.SingleChoice, QuestionBody5, 2);
            string answer5 = "False";
            questionList.AddQuestion(question5, answer5);

            Exam exam = new Exam(DateTime.Now.AddHours(1), questionList.Questions.Count);
            exam.ShowExam(questionList.Questions);
            exam.ShowAnswers(questionList.Answers);

            Console.WriteLine("Exam has been created successfully with the following questions and answers.");
            Console.ReadLine();

        }
    }
}
