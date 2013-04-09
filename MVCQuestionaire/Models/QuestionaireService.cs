using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Objects;
using System.Web.Mvc;

namespace MVCQuestionaire.Models
{
    public class QuestionaireService : IQuestionaireService
    {
        private Models.QuestionaireEntities context;

        public QuestionaireService()
        {
            context = new Models.QuestionaireEntities();
        }

        /// <summary>
        /// Gets the User Entity.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUser(int id = 0)
        {
            return context.GetUser(id);   
        }

        /// <summary>
        /// Gets the Questions and their "options" entities.
        /// </summary>
        /// <returns></returns>
        public ObjectQuery<Question> GetQuestions()
        {
            return context.Questions.Include("QuestionOptions");
        }

        /// <summary>
        /// Processes Test
        /// </summary>
        /// <param name="form"></param>
        /// <param name="user"></param>
        /// <returns>The list of errors for the test.</returns>
        /// <remarks>
        /// 1. creates new Test entity.
        /// 2. loops each question and creates a Answer entity for each question.
        ///     I have added validation so that the user has to answer all questions.
        /// 3. I add the test to the user.
        /// 4. Save Changes to Database and redirect to Completed Page.
        /// </remarks>
        public IList<ValidationResult> ProcessTest(User user, FormCollection form)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            try
            {
                this.AttachUserToContext(user);

                var test = new Models.Test()
                {
                    DateCreated = DateTime.Now
                };

                foreach (var item in context.Questions)
                {
                    var optionid = form[item.QuestionId.ToString()];
                    if (optionid != null)
                    {
                        test.Answers.Add(new Models.Answer()
                        {
                            QuestionOptionId = int.Parse(optionid)
                        });
                    }
                    else
                    {
                        errors.Add(new ValidationResult()
                        {
                            Name = item.QuestionId.ToString(),
                            Message = "Please Answer the question"
                        });
                    }
                }

                if (errors.Count() > 0)
                    return errors;

                user.Tests.Add(test);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                errors.Add(new ValidationResult()
                {
                    Name = "",
                    Message = ex.Message
                });
            }

            return errors;
        }

        /// <summary>
        /// Attaches/Adds the user to the context.
        /// </summary>
        /// <param name="user"></param>
        private void AttachUserToContext(User user)
        {
            if (user.UserId != 0)
            {
                context.Users.Attach(user);
            }
            else
            {
                context.Users.AddObject(user);
            }
        }
    }
}