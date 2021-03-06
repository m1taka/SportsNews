USE [SportsNews]
GO
/****** Object:  Table [dbo].[NewsArticleCategories]    Script Date: 5.7.2017 г. 16:11:59 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewsArticleCategories](
	[Id] [int] NOT NULL,
	[NewsCategoriesId] [int] NOT NULL,
	[NewsArticleId] [int] NOT NULL,
 CONSTRAINT [PK_NewsArticleCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NewsArticles]    Script Date: 5.7.2017 г. 16:12:01 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewsArticles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Headline] [nvarchar](255) NOT NULL,
	[PublishDate] [date] NOT NULL,
	[Text] [text] NOT NULL,
	[PhotoURL] [text] NULL,
 CONSTRAINT [PK_NewsArticles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NewsCategories]    Script Date: 5.7.2017 г. 16:12:01 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewsCategories](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_NewsCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 5.7.2017 г. 16:12:01 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[PasswordHash] [nchar](64) NOT NULL,
	[Token] [nvarchar](128) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[NewsArticleCategories]  WITH CHECK ADD  CONSTRAINT [FK_NewsArticleCategories_NewsArticles1] FOREIGN KEY([NewsArticleId])
REFERENCES [dbo].[NewsArticles] ([Id])
GO
ALTER TABLE [dbo].[NewsArticleCategories] CHECK CONSTRAINT [FK_NewsArticleCategories_NewsArticles1]
GO
ALTER TABLE [dbo].[NewsArticleCategories]  WITH CHECK ADD  CONSTRAINT [FK_NewsArticleCategories_NewsCategories] FOREIGN KEY([NewsCategoriesId])
REFERENCES [dbo].[NewsCategories] ([Id])
GO
ALTER TABLE [dbo].[NewsArticleCategories] CHECK CONSTRAINT [FK_NewsArticleCategories_NewsCategories]
GO
