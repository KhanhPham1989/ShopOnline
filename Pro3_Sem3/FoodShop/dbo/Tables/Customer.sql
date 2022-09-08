CREATE TABLE [dbo].[Customer] (
    [cusid]       INT           IDENTITY (1, 1) NOT NULL,
    [username]    VARCHAR (50)  NOT NULL,
    [userpass]    VARCHAR (50)  NOT NULL,
    [cusphone]    VARCHAR (50)  NOT NULL,
    [cusaddress]  VARCHAR (250) NOT NULL,
    [cusfullname] VARCHAR (50)  NOT NULL,
    [cusstatus]   BIT           NOT NULL,
    [admin]       BIT           NOT NULL,
    [cusemail]    VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([cusid] ASC)
);

