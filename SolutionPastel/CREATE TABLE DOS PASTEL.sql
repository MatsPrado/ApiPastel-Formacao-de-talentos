create table PRODUTOS(
	ID INTEGER IDENTITY(1,1),
	NOME VARCHAR (MAX),
	VALOR INTEGER,
	CONSTRAINT PK_PRODUTOS PRIMARY KEY(ID),
)
CREATE TABLE CLIENTE(
	ID INTEGER IDENTITY(1,1),
	NOME VARCHAR (MAX),
	CONSTRAINT PK_CLIENTE PRIMARY KEY(ID),
)
CREATE TABLE PEDIDO
(
	ID INTEGER IDENTITY (1,1),
	ID_CLIENTE INTEGER,
	QUANTIDADE INTEGER,
	_DATA DATETIME,
	CONSTRAINT PK_PEDIDO PRIMARY KEY(ID),
	CONSTRAINT FK_PEDIDO_ID_CLIENTE FOREIGN KEY (ID_CLIENTE) REFERENCES PRODUTOS(ID),
)
CREATE TABLE PEDIDO_ITEM
(
	ID INTEGER IDENTITY(1,1),
	ID_PEDIDO INTEGER,
	ID_PRODUTOS INTEGER,
	CONSTRAINT PK_PEDIDO_ITEM PRIMARY KEY(ID),
	CONSTRAINT FK_PEDIDO_ITEM_ID_PEDIDO FOREIGN KEY (ID_PEDIDO) REFERENCES PEDIDO(ID),
	CONSTRAINT FK_PEDIDO_ITEM_ID_PRODUTOS FOREIGN KEY (ID_PRODUTOS) REFERENCES PRODUTOS(ID)
)