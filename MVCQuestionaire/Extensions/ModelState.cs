using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCQuestionaire.Extensions
{
    public static class ModelState
    {

        /// <summary>
        /// Adds the list of errors to the Model State Dictionary.
        /// </summary>
        /// <param name="errors"></param>
        public static void AddModelErrors(this System.Web.Mvc.ModelStateDictionary state, IList<Models.ValidationResult> errors)
        {
            foreach (var item in errors)
            {
                state.AddModelError(item.Name, item.Message);
            }
        }
    }
}