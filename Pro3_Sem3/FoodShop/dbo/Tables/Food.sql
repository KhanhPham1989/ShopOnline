CREATE TABLE [dbo].[Food] (
    [foodid]          INT           IDENTITY (1, 1) NOT NULL,
    [foodname]        VARCHAR (50)  NOT NULL,
    [foodimage]       VARCHAR (50)  NOT NULL,
    [foodstatus]      VARCHAR (50)  NOT NULL,
    [foodprice]       DECIMAL (18)  NOT NULL,
    [caterid]         INT           NOT NULL,
    [fooddescription] VARCHAR (250) NOT NULL,
    CONSTRAINT [PK_food] PRIMARY KEY CLUSTERED ([foodid] ASC),
    CONSTRAINT [FK_Food_Caterer] FOREIGN KEY ([caterid]) REFERENCES [dbo].[Caterer] ([caterid])
);

