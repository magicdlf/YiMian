USE [YiMianDB]
GO

/****** Object:  Table [dbo].[Problem]    Script Date: 08/24/2014 15:06:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Problem](
	[ProblemId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Content] [nvarchar](4000) NOT NULL,
	[Creator] [nvarchar](100) NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[ChangeTime] [datetime] NOT NULL,
	[ProblemType] [tinyint] NOT NULL,
 CONSTRAINT [PK_Problem] PRIMARY KEY CLUSTERED 
(
	[ProblemId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Problem] ADD  CONSTRAINT [DF_Problem_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO

ALTER TABLE [dbo].[Problem] ADD  CONSTRAINT [DF_Problem_ChangeTime]  DEFAULT (getdate()) FOR [ChangeTime]
GO

/****** Object:  Table [dbo].[ProblemExt]    Script Date: 08/24/2014 15:07:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProblemExt](
	[ProblemId] [int] NOT NULL,
	[Attempted] [int] NOT NULL,
	[LikeCount] [int] NOT NULL,
	[FavoriteCount] [int] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[ChangeTime] [datetime] NOT NULL
) ON [PRIMARY]

GO


