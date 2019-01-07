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

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'ClassID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'ColID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'ColName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'ColType'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�г��ȣ���Ϊ�ַ���ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'ColLenth'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���Ƿ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'ColIsPrimarykey'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���Ƿ����Ϊ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'ColIsNull'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'Creater'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'Updater'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelDetailed', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelMain', @level2type=N'COLUMN',@level2name=N'ClassID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelMain', @level2type=N'COLUMN',@level2name=N'ClassName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelMain', @level2type=N'COLUMN',@level2name=N'TableName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelMain', @level2type=N'COLUMN',@level2name=N'Creater'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelMain', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelMain', @level2type=N'COLUMN',@level2name=N'Updater'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ModelMain', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO


INSERT INTO [UserInfo]([UserID],[UserName],[UserPwd]) VALUES('admin','����Ա','123456')
INSERT INTO [UserInfo]([UserID],[UserName],[UserPwd]) VALUES('ZQ','��ǿ','123456')