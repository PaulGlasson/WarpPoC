using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class QuestionPossibleAnswer
    {
        public int QuestionPossibleAnswerID { get; set; }
        public int QuestionID { get; set; }
        public int PossibleAnswerID { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
        public virtual Question Question { get; set; }
    }
}
