using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Objects;
using System.Web.Mvc;

namespace MVCQuestionaire.Models
{
    public interface IQuestionaireService
    {
        User GetUser(int id = 0);
        ObjectQuery<Question> GetQuestions();
        IList<ValidationResult> ProcessTest(User user, FormCollection form);
    }
}