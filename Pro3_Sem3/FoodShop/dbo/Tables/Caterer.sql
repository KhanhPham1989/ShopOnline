CREATE TABLE [dbo].[Caterer] (
    [caterid]       INT           IDENTITY (1, 1) NOT NULL,
    [catername]     VARCHAR (50)  NOT NULL,
    [caterpasss]    VARCHAR (50)  NOT NULL,
    [caterfullname] VARCHAR (50)  NOT NULL,
    [cateraddress]  VARCHAR (250) NOT NULL,
    [caterphone]    VARCHAR (50)  NOT NULL,
    [caterstatus]   BIT           NOT NULL,
    [cateremail]    VARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_Caterer] PRIMARY KEY CLUSTERED ([caterid] ASC)
);

