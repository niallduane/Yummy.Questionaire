using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCQuestionaire.Models
{
    public partial class QuestionaireEntities
    {
        /// <summary>
        /// Gets a User based on their User Id.
        /// Returns new user if the id == 0.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUser(int id = 0)
        {
            return (id != 0) ? this.Users.Where(m => m.UserId == id).FirstOrDefault() : new Models.User();
        }
    }
}