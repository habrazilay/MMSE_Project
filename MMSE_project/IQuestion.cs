using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSE_project
{
    interface IQuestion
    {
        QuestionResult  QuestionResult { get; set; }
        void            NextButtonClick();
        double          CheckAnswers();
        bool            CheckValidation();
        int             GetQuestionNumber();

    }
}
