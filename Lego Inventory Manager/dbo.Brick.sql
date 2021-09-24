CREATE TABLE [dbo].[Brick] (
    [BrickElementID] INT          NOT NULL,
    [BrickID]        INT          NULL,
    [BrickName]           VARCHAR (50) NULL,
    [TypeID]         INT          NULL,
    [ColorID]        INT          NULL,
    [Quantity]       INT          NULL,
    PRIMARY KEY CLUSTERED ([BrickElementID] ASC),
    CONSTRAINT [FK_Brick_Type] FOREIGN KEY ([TypeID]) REFERENCES [dbo].[Type] ([TypeID]),
    CONSTRAINT [FK_Brick_Color] FOREIGN KEY ([ColorID]) REFERENCES [dbo].[Color] ([ColorID])
);

