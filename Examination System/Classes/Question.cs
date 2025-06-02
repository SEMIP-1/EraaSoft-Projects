using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examination_System 
{
    public enum QuestionType
    {
        TrueOrFalse=1,
        SingleChoice=2,
        MultipleChoice=3,
    }
    public enum QuestionLevel
    {
        Easy = 1,
        Medium = 2,
        Hard = 3,
    }
    public abstract class Question
    {
        public QuestionLevel QLevel { get; set; }
        public QuestionType QHeader { get; set; }
        public string? QBody { get; set; }
        public int? QMark { get; set; }
        public Question(QuestionLevel QLevel, QuestionType QHeader, string? QBody,int? QMark ) 
        {
            this.QLevel = QLevel;
            this.QHeader = QHeader;
            this.QBody = QBody;
            this.QMark = QMark;
        }
    }
    public enum Qanswer1
    {
        True = 1,
        False = 2,
    }
    public class TrueOrFalse : Question
    {
        public TrueOrFalse(QuestionLevel QLevel, QuestionType TrueOrFalse, string? QBody, int? QMark) : base(QLevel, TrueOrFalse, QBody, QMark)
        {

        }
    }
    public enum Qanswer2
    {
        A = 1,
        B = 2,
        C = 3,
        D = 4,
    }
    public class ChooseOne : Question
    {
        public ChooseOne(QuestionLevel QLevel, QuestionType ChooseOne, string? QBody, int? QMark) : base(QLevel, ChooseOne, QBody, QMark)
        {

        }
    }
    public class ChooseAll : Question
    {
        public ChooseAll(QuestionLevel QLevel, QuestionType ChooseAll, string? QBody, int? QMark) : base(QLevel, ChooseAll, QBody, QMark)
        {

        }
    }
}

