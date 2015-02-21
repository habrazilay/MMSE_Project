using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSE_project
{
    public class QuestionResult
    {
        public int      QuestionNumber { get; set; }
        public double   Score { get; set; }
        public TimeSpan TimeToQuestion { get; set; }
        
    }
}
