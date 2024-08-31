CREATE TABLE Eletrodomestico (
    EletrodomesticoId INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL
);

CREATE TABLE Geladeira (
    GeladeiraId INT PRIMARY KEY IDENTITY(1,1),
    EletrodomesticoId INT FOREIGN KEY REFERENCES Eletrodomestico(EletrodomesticoId),
    Marca NVARCHAR(100),
    Modelo NVARCHAR(100)
);

CREATE TABLE Andar (
    AndarId INT PRIMARY KEY IDENTITY(1,1),
    GeladeiraId INT FOREIGN KEY REFERENCES Geladeira(GeladeiraId),
    Descricao NVARCHAR(100)
);

CREATE TABLE Container (
    ContainerId INT PRIMARY KEY IDENTITY(1,1),
    AndarId INT FOREIGN KEY REFERENCES Andar(AndarId)
);

CREATE TABLE Item (
    ItemId INT PRIMARY KEY IDENTITY(1,1),
    ContainerId INT FOREIGN KEY REFERENCES Container(ContainerId),
    Nome NVARCHAR(100),
    Posicao INT
);
