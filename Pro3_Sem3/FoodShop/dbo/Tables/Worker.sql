CREATE TABLE [dbo].[Worker] (
    [workerid]      INT          NOT NULL,
    [wokername]     VARCHAR (50) NOT NULL,
    [workerphone]   VARCHAR (50) NOT NULL,
    [workeraddress] VARCHAR (50) NOT NULL,
    [status]        BIT          NOT NULL,
    [workersalary]  DECIMAL (18) NOT NULL,
    [workertype]    VARCHAR (50) NOT NULL,
    [caterid]       INT          NOT NULL,
    CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED ([workerid] ASC),
    CONSTRAINT [FK_Worker_Caterer] FOREIGN KEY ([caterid]) REFERENCES [dbo].[Caterer] ([caterid])
);

