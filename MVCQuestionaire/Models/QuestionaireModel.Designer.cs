﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Questionaire.Models", "FK_Answer_QuestionOption", "QuestionOption", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(MVCQuestionaire.Models.QuestionOption), "Answer", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MVCQuestionaire.Models.Answer), true)]
[assembly: EdmRelationshipAttribute("Questionaire.Models", "FK_Answer_Test", "Test", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(MVCQuestionaire.Models.Test), "Answer", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MVCQuestionaire.Models.Answer), true)]
[assembly: EdmRelationshipAttribute("Questionaire.Models", "FK_QuestionOption_Question", "Question", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(MVCQuestionaire.Models.Question), "QuestionOption", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MVCQuestionaire.Models.QuestionOption), true)]
[assembly: EdmRelationshipAttribute("Questionaire.Models", "FK_Test_User", "User", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(MVCQuestionaire.Models.User), "Test", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MVCQuestionaire.Models.Test), true)]

#endregion

namespace MVCQuestionaire.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class QuestionaireEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new QuestionaireEntities object using the connection string found in the 'QuestionaireEntities' section of the application configuration file.
        /// </summary>
        public QuestionaireEntities() : base("name=QuestionaireEntities", "QuestionaireEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new QuestionaireEntities object.
        /// </summary>
        public QuestionaireEntities(string connectionString) : base(connectionString, "QuestionaireEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new QuestionaireEntities object.
        /// </summary>
        public QuestionaireEntities(EntityConnection connection) : base(connection, "QuestionaireEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Answer> Answers
        {
            get
            {
                if ((_Answers == null))
                {
                    _Answers = base.CreateObjectSet<Answer>("Answers");
                }
                return _Answers;
            }
        }
        private ObjectSet<Answer> _Answers;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Question> Questions
        {
            get
            {
                if ((_Questions == null))
                {
                    _Questions = base.CreateObjectSet<Question>("Questions");
                }
                return _Questions;
            }
        }
        private ObjectSet<Question> _Questions;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<QuestionOption> QuestionOptions
        {
            get
            {
                if ((_QuestionOptions == null))
                {
                    _QuestionOptions = base.CreateObjectSet<QuestionOption>("QuestionOptions");
                }
                return _QuestionOptions;
            }
        }
        private ObjectSet<QuestionOption> _QuestionOptions;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Test> Tests
        {
            get
            {
                if ((_Tests == null))
                {
                    _Tests = base.CreateObjectSet<Test>("Tests");
                }
                return _Tests;
            }
        }
        private ObjectSet<Test> _Tests;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Answers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAnswers(Answer answer)
        {
            base.AddObject("Answers", answer);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Questions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToQuestions(Question question)
        {
            base.AddObject("Questions", question);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the QuestionOptions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToQuestionOptions(QuestionOption questionOption)
        {
            base.AddObject("QuestionOptions", questionOption);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tests EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTests(Test test)
        {
            base.AddObject("Tests", test);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Questionaire.Models", Name="Answer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Answer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Answer object.
        /// </summary>
        /// <param name="answerId">Initial value of the AnswerId property.</param>
        /// <param name="testId">Initial value of the TestId property.</param>
        /// <param name="questionOptionId">Initial value of the QuestionOptionId property.</param>
        public static Answer CreateAnswer(global::System.Int32 answerId, global::System.Int32 testId, global::System.Int32 questionOptionId)
        {
            Answer answer = new Answer();
            answer.AnswerId = answerId;
            answer.TestId = testId;
            answer.QuestionOptionId = questionOptionId;
            return answer;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AnswerId
        {
            get
            {
                return _AnswerId;
            }
            set
            {
                if (_AnswerId != value)
                {
                    OnAnswerIdChanging(value);
                    ReportPropertyChanging("AnswerId");
                    _AnswerId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("AnswerId");
                    OnAnswerIdChanged();
                }
            }
        }
        private global::System.Int32 _AnswerId;
        partial void OnAnswerIdChanging(global::System.Int32 value);
        partial void OnAnswerIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TestId
        {
            get
            {
                return _TestId;
            }
            set
            {
                OnTestIdChanging(value);
                ReportPropertyChanging("TestId");
                _TestId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TestId");
                OnTestIdChanged();
            }
        }
        private global::System.Int32 _TestId;
        partial void OnTestIdChanging(global::System.Int32 value);
        partial void OnTestIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 QuestionOptionId
        {
            get
            {
                return _QuestionOptionId;
            }
            set
            {
                OnQuestionOptionIdChanging(value);
                ReportPropertyChanging("QuestionOptionId");
                _QuestionOptionId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("QuestionOptionId");
                OnQuestionOptionIdChanged();
            }
        }
        private global::System.Int32 _QuestionOptionId;
        partial void OnQuestionOptionIdChanging(global::System.Int32 value);
        partial void OnQuestionOptionIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Questionaire.Models", "FK_Answer_QuestionOption", "QuestionOption")]
        public QuestionOption QuestionOption
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuestionOption>("Questionaire.Models.FK_Answer_QuestionOption", "QuestionOption").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuestionOption>("Questionaire.Models.FK_Answer_QuestionOption", "QuestionOption").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<QuestionOption> QuestionOptionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuestionOption>("Questionaire.Models.FK_Answer_QuestionOption", "QuestionOption");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<QuestionOption>("Questionaire.Models.FK_Answer_QuestionOption", "QuestionOption", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Questionaire.Models", "FK_Answer_Test", "Test")]
        public Test Test
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Test>("Questionaire.Models.FK_Answer_Test", "Test").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Test>("Questionaire.Models.FK_Answer_Test", "Test").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Test> TestReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Test>("Questionaire.Models.FK_Answer_Test", "Test");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Test>("Questionaire.Models.FK_Answer_Test", "Test", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Questionaire.Models", Name="Question")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Question : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Question object.
        /// </summary>
        /// <param name="questionId">Initial value of the QuestionId property.</param>
        /// <param name="question1">Initial value of the Question1 property.</param>
        public static Question CreateQuestion(global::System.Int32 questionId, global::System.String question1)
        {
            Question question = new Question();
            question.QuestionId = questionId;
            question.Question1 = question1;
            return question;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 QuestionId
        {
            get
            {
                return _QuestionId;
            }
            set
            {
                if (_QuestionId != value)
                {
                    OnQuestionIdChanging(value);
                    ReportPropertyChanging("QuestionId");
                    _QuestionId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("QuestionId");
                    OnQuestionIdChanged();
                }
            }
        }
        private global::System.Int32 _QuestionId;
        partial void OnQuestionIdChanging(global::System.Int32 value);
        partial void OnQuestionIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Question1
        {
            get
            {
                return _Question1;
            }
            set
            {
                OnQuestion1Changing(value);
                ReportPropertyChanging("Question1");
                _Question1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Question1");
                OnQuestion1Changed();
            }
        }
        private global::System.String _Question1;
        partial void OnQuestion1Changing(global::System.String value);
        partial void OnQuestion1Changed();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Questionaire.Models", "FK_QuestionOption_Question", "QuestionOption")]
        public EntityCollection<QuestionOption> QuestionOptions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<QuestionOption>("Questionaire.Models.FK_QuestionOption_Question", "QuestionOption");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<QuestionOption>("Questionaire.Models.FK_QuestionOption_Question", "QuestionOption", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Questionaire.Models", Name="QuestionOption")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class QuestionOption : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new QuestionOption object.
        /// </summary>
        /// <param name="questionOptionId">Initial value of the QuestionOptionId property.</param>
        /// <param name="questionId">Initial value of the QuestionId property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="isAnswer">Initial value of the IsAnswer property.</param>
        public static QuestionOption CreateQuestionOption(global::System.Int32 questionOptionId, global::System.Int32 questionId, global::System.String description, global::System.Boolean isAnswer)
        {
            QuestionOption questionOption = new QuestionOption();
            questionOption.QuestionOptionId = questionOptionId;
            questionOption.QuestionId = questionId;
            questionOption.Description = description;
            questionOption.IsAnswer = isAnswer;
            return questionOption;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 QuestionOptionId
        {
            get
            {
                return _QuestionOptionId;
            }
            set
            {
                if (_QuestionOptionId != value)
                {
                    OnQuestionOptionIdChanging(value);
                    ReportPropertyChanging("QuestionOptionId");
                    _QuestionOptionId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("QuestionOptionId");
                    OnQuestionOptionIdChanged();
                }
            }
        }
        private global::System.Int32 _QuestionOptionId;
        partial void OnQuestionOptionIdChanging(global::System.Int32 value);
        partial void OnQuestionOptionIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 QuestionId
        {
            get
            {
                return _QuestionId;
            }
            set
            {
                OnQuestionIdChanging(value);
                ReportPropertyChanging("QuestionId");
                _QuestionId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("QuestionId");
                OnQuestionIdChanged();
            }
        }
        private global::System.Int32 _QuestionId;
        partial void OnQuestionIdChanging(global::System.Int32 value);
        partial void OnQuestionIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsAnswer
        {
            get
            {
                return _IsAnswer;
            }
            set
            {
                OnIsAnswerChanging(value);
                ReportPropertyChanging("IsAnswer");
                _IsAnswer = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsAnswer");
                OnIsAnswerChanged();
            }
        }
        private global::System.Boolean _IsAnswer;
        partial void OnIsAnswerChanging(global::System.Boolean value);
        partial void OnIsAnswerChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Questionaire.Models", "FK_Answer_QuestionOption", "Answer")]
        public EntityCollection<Answer> Answers
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Answer>("Questionaire.Models.FK_Answer_QuestionOption", "Answer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Answer>("Questionaire.Models.FK_Answer_QuestionOption", "Answer", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Questionaire.Models", "FK_QuestionOption_Question", "Question")]
        public Question Question
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Question>("Questionaire.Models.FK_QuestionOption_Question", "Question").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Question>("Questionaire.Models.FK_QuestionOption_Question", "Question").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Question> QuestionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Question>("Questionaire.Models.FK_QuestionOption_Question", "Question");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Question>("Questionaire.Models.FK_QuestionOption_Question", "Question", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Questionaire.Models", Name="Test")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Test : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Test object.
        /// </summary>
        /// <param name="testId">Initial value of the TestId property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="dateCreated">Initial value of the DateCreated property.</param>
        public static Test CreateTest(global::System.Int32 testId, global::System.Int32 userId, global::System.DateTime dateCreated)
        {
            Test test = new Test();
            test.TestId = testId;
            test.UserId = userId;
            test.DateCreated = dateCreated;
            return test;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TestId
        {
            get
            {
                return _TestId;
            }
            set
            {
                if (_TestId != value)
                {
                    OnTestIdChanging(value);
                    ReportPropertyChanging("TestId");
                    _TestId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("TestId");
                    OnTestIdChanged();
                }
            }
        }
        private global::System.Int32 _TestId;
        partial void OnTestIdChanging(global::System.Int32 value);
        partial void OnTestIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private global::System.Int32 _UserId;
        partial void OnUserIdChanging(global::System.Int32 value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateCreated
        {
            get
            {
                return _DateCreated;
            }
            set
            {
                OnDateCreatedChanging(value);
                ReportPropertyChanging("DateCreated");
                _DateCreated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateCreated");
                OnDateCreatedChanged();
            }
        }
        private global::System.DateTime _DateCreated;
        partial void OnDateCreatedChanging(global::System.DateTime value);
        partial void OnDateCreatedChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Questionaire.Models", "FK_Answer_Test", "Answer")]
        public EntityCollection<Answer> Answers
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Answer>("Questionaire.Models.FK_Answer_Test", "Answer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Answer>("Questionaire.Models.FK_Answer_Test", "Answer", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Questionaire.Models", "FK_Test_User", "User")]
        public User User
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("Questionaire.Models.FK_Test_User", "User").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("Questionaire.Models.FK_Test_User", "User").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> UserReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("Questionaire.Models.FK_Test_User", "User");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("Questionaire.Models.FK_Test_User", "User", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Questionaire.Models", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="phone">Initial value of the Phone property.</param>
        public static User CreateUser(global::System.Int32 userId, global::System.String name, global::System.String phone)
        {
            User user = new User();
            user.UserId = userId;
            user.Name = name;
            user.Phone = phone;
            return user;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if (_UserId != value)
                {
                    OnUserIdChanging(value);
                    ReportPropertyChanging("UserId");
                    _UserId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("UserId");
                    OnUserIdChanged();
                }
            }
        }
        private global::System.Int32 _UserId;
        partial void OnUserIdChanging(global::System.Int32 value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                OnPhoneChanging(value);
                ReportPropertyChanging("Phone");
                _Phone = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Phone");
                OnPhoneChanged();
            }
        }
        private global::System.String _Phone;
        partial void OnPhoneChanging(global::System.String value);
        partial void OnPhoneChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Questionaire.Models", "FK_Test_User", "Test")]
        public EntityCollection<Test> Tests
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Test>("Questionaire.Models.FK_Test_User", "Test");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Test>("Questionaire.Models.FK_Test_User", "Test", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
