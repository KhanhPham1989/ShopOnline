CREATE TABLE [dbo].[PaymentDetails] (
    [detailsid] INT IDENTITY (1, 1) NOT NULL,
    [paymentid] INT NOT NULL,
    [foodid]    INT NOT NULL,
    CONSTRAINT [PK_PaymentDetails] PRIMARY KEY CLUSTERED ([detailsid] ASC),
    CONSTRAINT [FK_PaymentDetails_Food] FOREIGN KEY ([foodid]) REFERENCES [dbo].[Food] ([foodid]),
    CONSTRAINT [FK_PaymentDetails_Payment] FOREIGN KEY ([paymentid]) REFERENCES [dbo].[Payment] ([paymentid])
);

