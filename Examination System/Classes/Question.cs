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
    public abstract class Question
    {
        public string? QLevel { get; set; }
        public QuestionType QHeader { get; set; }
        public string? QBody { get; set; }
        public int? QMark { get; set; }
        public Question(string? QLevel, QuestionType QHeader, string? QBody,int? QMark ) 
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
        public TrueOrFalse(string? QLevel, QuestionType QHeader, string? QBody, int? QMark) : base(QLevel, QHeader, QBody, QMark)
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
        public ChooseOne(string? QLevel, QuestionType QHeader, string? QBody, int? QMark) : base(QLevel, QHeader, QBody, QMark)
        {
        }
    }
    public class ChooseAll : Question
    {
        public ChooseAll(string? QLevel, QuestionType QHeader, string? QBody, int? QMark) : base(QLevel, QHeader, QBody, QMark)
        {
        }
    }
}

