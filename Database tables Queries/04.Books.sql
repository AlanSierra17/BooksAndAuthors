USE [BooksAndAuthors]
GO

/****** Object:  Table [dbo].[Books]    Script Date: 13/01/2022 3:47:27 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Books](
	[IdBooks] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [nvarchar](200) NOT NULL,
	[YearOfPublication] [smallint] NOT NULL,
	[Editorial] [int] NOT NULL,
	[Author] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[IdBooks] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Authors] FOREIGN KEY([Author])
REFERENCES [dbo].[Authors] ([IdAuthors])
GO

ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Authors]
GO

ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Editorials] FOREIGN KEY([Editorial])
REFERENCES [dbo].[Editorials] ([IdEditorials])
GO

ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Editorials]
GO


