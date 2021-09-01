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

 Com o build finalizado, você tera uma mensagem no CMD "Compilação com Exito 00 erros", ae então vamos rodar a aplicação com o comando abaixo no CMD:
 > dotnet run

 Você receberá no CMD a seguinte mensagem: "

 Quando a aplicação estiver rodando, abra seu browser e digite o endereço abaixo para consultar o GET
 
 http://localhost:5000/api/categorias

 Pronto! Você terá o retorno do JSON com o produtos que cadastramos em memória.

 Este projeto não implementei os métodos de PUT, UPDATE e DELETE, apenas o GET. Foi um projeto inicial para estudos da estrutura MVC utilizando o .NetCore, saindo da zona de conforto. Pretendo publicar um projeto completo, se possível com um front-end consumindo a API utilizando Angular.