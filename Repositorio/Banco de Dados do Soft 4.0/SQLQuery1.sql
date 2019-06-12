


CREATE TABLE Usuario (
idUsuario int primary key,
nascimento DATE,
loginn VARCHAR(30),
funcao VARCHAR(20),
senha VARCHAR(10),
email VARCHAR(50),
regFuncional varchar unique,
nome VARCHAR(50),
ogadouroEnd VARCHAR(50),
bairroEnd VARCHAR(30),
tel VARCHAR(16),
cel VARCHAR(16),
cidade varchar (30)
)
create table Paciente
(
idCadPac INT PRIMARY KEY,
cpfPac VARCHAR (14),
workPac VARCHAR(30),
sexoPac VARCHAR(1),
nomePac VARCHAR(50),
nascPac DATE,
civilPac VARCHAR(20),
emailPac VARCHAR(50),
escolPac VARCHAR(30),
falarcom varchar(30),
endereco VARCHAR(50),
numero int,
cep VARCHAR(11),
bairro varchar (30),
estado VARCHAR(2),
idade int,
cidade varchar (30),
tel varchar(16)
)



create table Historico
(idHistorico INT PRIMARY KEY,
tipoTorax VARCHAR(2),
cardTorax VARCHAR(7),
mamasTorax VARCHAR(5),
mastecTorax VARCHAR(8),
mamilosTorax VARCHAR(6),
toracTorax VARCHAR(3),
formTorax VARCHAR(12),
nuligestaObst VARCHAR(1),
gestacaoObst VARCHAR(1),
pnObst VARCHAR(1),
pcObst VARCHAR(1),
forcepsObst VARCHAR(1),
abortoobst VARCHAR(1),
istsObst VARCHAR(1),
MenopausaObst VARCHAR(1),
DumObast VARCHAR(1),
pacObst VARCHAR(1),
leucorreriaObst VARCHAR(1),
diabete VARCHAR(1),
dislipidemia VARCHAR(1),
cardiovascular VARCHAR(1),
musculoesqueletica VARCHAR(1),
neurologica VARCHAR(1),
sexual VARCHAR(1),
outrosCM VARCHAR(MAX),
renal VARCHAR(1),
respiratoria VARCHAR(1),
tabagismo VARCHAR(1),
etilismo CHAR(1),
tipoEscol VARCHAR(30),
adventSons VARCHAR(1),
vesicSons VARCHAR(1),
outrosHabit VARCHAR(MAX),
textoAnot VARCHAR(MAX),
textoDiag VARCHAR(MAX),
textoEvol VARCHAR(MAX),
tabagismoRisc VARCHAR(1),
obesidadeRisc VARCHAR(1),
cancerRisc VARCHAR(1),
sedentaRisc VARCHAR(1),
outrosRisc VARCHAR(MAX),
etilismoRisc VARCHAR(1),
urinaria VARCHAR(1),
demencia VARCHAR(1),
queda VARCHAR(1),
hospitaliza��o VARCHAR(1),
outrosCF VARCHAR(max),
fecal VARCHAR(10),
dislipidemias VARCHAR(1),
renalF VARCHAR(1),
cardiovascularF VARCHAR(1),
neurologicas VARCHAR(1),
outrosFM VARCHAR(100),
diabetes VARCHAR(1),
derivados VARCHAR(1),
frutas VARCHAR(1),
massa VARCHAR(1),
sexyLife VARCHAR(1),
atividades VARCHAR(1),
liquidos VARCHAR(1),
verduras VARCHAR(1),
proteinas VARCHAR(1),
fkidPac int foreign key references Paciente (idCadPac)
)
