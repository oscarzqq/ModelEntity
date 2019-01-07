USE [ModelEntiy]
GO

/****** Object:  Table [dbo].[ModelDetailed]    Script Date: 2019/1/3 19:53:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ModelDetailed](
	[ClassID] [nvarchar](50) NOT NULL,
	[ColID] [nvarchar](50) NOT NULL,
	[ColName] [nvarchar](50) NOT NULL,
	[ColType] [nvarchar](50) NOT NULL,
	[ColLenth] [int] NULL,
	[ColIsPrimarykey] [bit] NULL,
	[ColIsNull] [bit] NULL,
	[Creater] [nvarchar](50) NOT NULL,
	[CreateTime] [datetime] NULL,
	[Updater] [nvarchar](50) NULL,
	[UpdateTime] [datetime] NULL,
 CONSTRAINT [PK_ModelDetailed] PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC,
	[ColID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ModelMain]    Script Date: 2019/1/3 19:53:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ModelMain](
	[ClassID] [nvarchar](50) NOT NULL,
	[ClassName] [nvarchar](50) NOT NULL,
	[TableName] [nvarchar](50) NULL,
	[Creater] [nvarchar](50) NOT NULL,
	[CreateTime] [datetime] NULL,
	[Updater] [nvarchar](50) NULL,
	[UpdateTime] [datetime] NULL,
 CONSTRAINT [PK_ModelMain_1] PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[UserInfo]    Script Date: 2019/1/3 19:53:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserInfo](
	[UserID] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[UserPwd] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'ClassID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'列名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'ColID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'列中文名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'ColName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'列类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'ColType'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'列长度（当为字符串时）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'ColLenth'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'列是否主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'ColIsPrimarykey'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'列是否可以为空' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'ColIsNull'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建者' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'Creater'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'Updater'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelMain', @level2type=N'COLUMN',@level2name=N'ClassID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类中文名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelMain', @level2type=N'COLUMN',@level2name=N'ClassName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'表名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelMain', @level2type=N'COLUMN',@level2name=N'TableName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建者' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelMain', @level2type=N'COLUMN',@level2name=N'Creater'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelMain', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelMain', @level2type=N'COLUMN',@level2name=N'Updater'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelMain', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO


INSERT INTO [UserInfo]([UserID],[UserName],[UserPwd]) VALUES('admin','管理员','123456')
INSERT INTO [UserInfo]([UserID],[UserName],[UserPwd]) VALUES('ZQ','张强','123456')