/****** Object:  User [questionaire_login]    Script Date: 11/01/2011 16:00:49 ******/
CREATE USER [questionaire_login] FOR LOGIN [questionaire_login] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 11/01/2011 16:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[QuestionId] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[QuestionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Question Text.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Question', @level2type=N'COLUMN',@level2name=N'Question'
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/01/2011 16:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionOption]    Script Date: 11/01/2011 16:00:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionOption](
	[QuestionOptionId] [int] IDENTITY(1,1) NOT NULL,
	[QuestionId] [int] NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[IsAnswer] [bit] NOT NULL,
 CONSTRAINT [PK_QuestionOption] PRIMARY KEY CLUSTERED 
(
	[QuestionOptionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Text for option.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'QuestionOption', @level2type=N'COLUMN',@level2name=N'Description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Is correct option.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'QuestionOption', @level2type=N'COLUMN',@level2name=N'IsAnswer'
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 11/01/2011 16:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answer](
	[AnswerId] [int] IDENTITY(1,1) NOT NULL,
	[TestId] [int] NOT NULL,
	[QuestionOptionId] [int] NOT NULL,
 CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED 
(
	[AnswerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'selected option for question.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Answer', @level2type=N'COLUMN',@level2name=N'QuestionOptionId'
GO
/****** Object:  Table [dbo].[Test]    Script Date: 11/01/2011 16:00:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[TestId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[TestId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date/Time Test has been taken' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Test', @level2type=N'COLUMN',@level2name=N'DateCreated'
GO
/****** Object:  ForeignKey [FK_Answer_QuestionOption]    Script Date: 11/01/2011 16:00:43 ******/
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD  CONSTRAINT [FK_Answer_QuestionOption] FOREIGN KEY([QuestionOptionId])
REFERENCES [dbo].[QuestionOption] ([QuestionOptionId])
GO
ALTER TABLE [dbo].[Answer] CHECK CONSTRAINT [FK_Answer_QuestionOption]
GO
/****** Object:  ForeignKey [FK_Answer_Test]    Script Date: 11/01/2011 16:00:44 ******/
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD  CONSTRAINT [FK_Answer_Test] FOREIGN KEY([TestId])
REFERENCES [dbo].[Test] ([TestId])
GO
ALTER TABLE [dbo].[Answer] CHECK CONSTRAINT [FK_Answer_Test]
GO
/****** Object:  ForeignKey [FK_QuestionOption_Question]    Script Date: 11/01/2011 16:00:46 ******/
ALTER TABLE [dbo].[QuestionOption]  WITH CHECK ADD  CONSTRAINT [FK_QuestionOption_Question] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([QuestionId])
GO
ALTER TABLE [dbo].[QuestionOption] CHECK CONSTRAINT [FK_QuestionOption_Question]
GO
/****** Object:  ForeignKey [FK_Test_User]    Script Date: 11/01/2011 16:00:47 ******/
ALTER TABLE [dbo].[Test]  WITH CHECK ADD  CONSTRAINT [FK_Test_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Test] CHECK CONSTRAINT [FK_Test_User]
GO

SET IDENTITY_INSERT [dbo].[Question] ON
INSERT INTO [dbo].[Question] ([QuestionId], [Question]) VALUES (1,'What country has the greatest population?');
INSERT INTO [dbo].[Question] ([QuestionId], [Question]) VALUES (2, 'What is the deepest ocean in the world?');

SET IDENTITY_INSERT [dbo].[Question] OFF

INSERT INTO [dbo].[QuestionOption] ([QuestionId], [Description], IsAnswer) VALUES (1,'United States',1);
INSERT INTO [dbo].[QuestionOption] ([QuestionId], [Description], IsAnswer) VALUES (1,'Indonesia', 0);

INSERT INTO [dbo].[QuestionOption] ([QuestionId], [Description], IsAnswer) VALUES (1,'Pacific', 1);
INSERT INTO [dbo].[QuestionOption] ([QuestionId], [Description], IsAnswer) VALUES (1,'Indian', 0);
INSERT INTO [dbo].[QuestionOption] ([QuestionId], [Description], IsAnswer) VALUES (1,'Gulf of Mexico', 0);