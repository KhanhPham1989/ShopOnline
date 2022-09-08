CREATE TABLE [dbo].[Payment] (
    [paymentid]     INT          IDENTITY (1, 1) NOT NULL,
    [order_date]    DATE         NOT NULL,
    [cusid]         INT          NOT NULL,
    [status]        BIT          NOT NULL,
    [amount]        DECIMAL (18) NOT NULL,
    [delivery_date] DATE         NOT NULL,
    [caterid]       INT          NOT NULL,
    CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED ([paymentid] ASC),
    CONSTRAINT [FK_Payment_Caterer] FOREIGN KEY ([caterid]) REFERENCES [dbo].[Caterer] ([caterid]),
    CONSTRAINT [FK_Payment_Customer] FOREIGN KEY ([cusid]) REFERENCES [dbo].[Customer] ([cusid])
);

