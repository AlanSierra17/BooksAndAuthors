USE [BooksAndAuthors]
GO

/****** Object:  Table [dbo].[Authors]    Script Date: 13/01/2022 3:47:02 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Authors](
	[IdAuthors] [int] IDENTITY(1,1) NOT NULL,
	[AuthorName] [nvarchar](50) NOT NULL,
	[Nationality] [int] NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[IdAuthors] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Authors]  WITH CHECK ADD  CONSTRAINT [FK_Authors_Nationalities] FOREIGN KEY([Nationality])
REFERENCES [dbo].[Nationalities] ([IdNationalities])
GO

ALTER TABLE [dbo].[Authors] CHECK CONSTRAINT [FK_Authors_Nationalities]
GO


