CREATE TABLE [dbo].[Wishlist] (
    [wishlistid] INT IDENTITY (1, 1) NOT NULL,
    [caterid]    INT NOT NULL,
    [cusid]      INT NOT NULL,
    [status]     BIT NOT NULL,
    CONSTRAINT [PK_Wishlist] PRIMARY KEY CLUSTERED ([wishlistid] ASC),
    CONSTRAINT [FK_Wishlist_Caterer] FOREIGN KEY ([wishlistid]) REFERENCES [dbo].[Caterer] ([caterid]),
    CONSTRAINT [FK_Wishlist_Customer] FOREIGN KEY ([cusid]) REFERENCES [dbo].[Customer] ([cusid])
);

