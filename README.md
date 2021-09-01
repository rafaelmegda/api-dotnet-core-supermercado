# api-dotnet-core-supermercado
Em Construção.... API para estudos iniciais de DotNet Core usando EntityFrameWork core

## Iniciando o Projeto
Para criar o projeto, abra o diretório que irá criar a aplição, e abra o CMD para digitar o comandos abaixo:

> Mkdir src

> cd src

> Mdkir Supermercado.API

> cd Supermercado.API

Após criar os diretetórios, rode o comando para criar o projeto usando o template API com o seguinte comando:
> dotnet new webapi

Dentro da sua pasta, terá os seguintes arquivos:
 * Pastas: Controllers, obj e properties
 * Arquivos: appsettings.json, Program.cs, Startup.cs e Supermercado.API.csproj

 Esses passos iniciais são no caso de você desejar criar seu projeto do zero, agora caso queira clonar este repositório para iniciar seus estudos, basta seguir os passos abaixo:

 * Clonar o repositório para sua workspace local
 * Abrir na sua IDE
 * Estudar!

 ## Instalação do Pacote EntityFrameWorkCore

 Dentro da pasta do seu projeto, rode os comandos abaixo no seu CMD: (obs: é possível especificar a versão na instalar, caso não especifique será instalado a últma versão do Framework)

 > dotnet add package Microsoft.EntityFrameworkCore

 > dotnet add package Microsoft.EntityFrameworkCore.Tools

 > dotnet add package Microsoft.EntityFrameworkCore.SqlServer

 > dotnet add package Microsoft.EntityFrameworkCore.InMemory

 Após instalar os pacote confira no arquivo Supermercado.API.csproj se estão com todas as dependencias instaladas

 ## Para Rodar o código, faça os seguintes passos:

 Para restaurar o projeto após alterações, comando no CMD dentro da pasta do projeto:
 > dotnet restore

 Após o restore, é necessário bildar o projeto, rode no mesmo diretório o comando:
 > dotnet build

 Com o build finalizado, vamos rodar a aplicação com o comando abaixo no CMD:
 > dotnet run
