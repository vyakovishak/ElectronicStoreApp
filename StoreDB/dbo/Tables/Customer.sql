CREATE TABLE [dbo].[Customer] (
    [Username]  VARCHAR (50)  NOT NULL,
    [Password]  VARCHAR (50)  NOT NULL,
    [LastName]  VARCHAR (50)  NOT NULL,
    [FirstName] VARCHAR (50)  NOT NULL,
    [Address]   VARCHAR (250) NOT NULL,
    [State]     VARCHAR (50)  NOT NULL,
    [Zip]       INT           NOT NULL,
    [Cart]      VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Username] ASC)
);

