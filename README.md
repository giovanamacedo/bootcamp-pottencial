# 🧡Anotações do Bootcamp Pottencial
📚 Estudos de C# e .NET realizados durante o Bootcamp Pottencial feito na plataforma da DIO.
<br/>

### 1. Criando um projeto novo pelo Visual Studio

- Criar um projeto;

- Escolher o template adequado para sua necessidade;

- Ex: Para um projeto Web API escolhemos o template **API Web do ASP.NET Core**.
<br/>

### 2. Criando um projeto novo pelo Visual Studio Code

- Para verificar os possíveis templates para serem criados podemos usar o comando abaixo no terminal, assim será exibido uma lista e você pode utilizar o "Nome Curto" que corresponda sua necessidade.

  `dotnet new --list`

- Para criar um projeto com o template de **Web API** usamos o comando abaixo no terminal.

  `dotnet new webapi`

<br/> 

### 3. Estrutura de arquivos

- **Program.cs** -> Aqui acontece o builder da aplicação, é ele que inicia/roda ela.

- Arquivo com extensão "**.csproj**" -> Aqui ficam todas configurações e agrupamentos que o seu projeto precisa para rodar.

- Arquivos com "**appsettings.json**" -> Arquivo de configurações, aqui podemos guardar dados sensíveis, tal como uma senha do banco de dados.

- **Classes.cs** -> Uma classe é basicamente um bloco de código que contém dados e instruções para fazer a leitura/escrita dos comportamentos descritos dentro dela.

- **Controllers** -> São objetos responsáveis pelo processamento das requisições e por gerar respostas. Ela vai processar os dados informados repassando para outras camadas.
<br/>
  

### 4. O que é uma API?

API significa Application Programming Interface (Interface de Programação de Aplicação).

É um mecanismo que contém dados/informações que serão consumidas por um sistema. Aqui a gente usa para explicar os termos de "**Cliente e Servidor**".

Quem requisita os dados é o **cliente** e a aplicação que envia a resposta é o **servidor**.

Então em termos de **Web API**, a comunicação é feita entre um **Servidor da Web** e um **Browser**.
<br/>
<br/>

### 5. Requisições HTTP

O HTTP (Protocolo de transferência de hipertexto) é um sistema base para a comunicação que acontece na internet.

Quando se acessa digita uma URL, o navegador cria uma solicitação HTTP e envia ao endereço IP indicado na URL. Dessa forma, o servidor recebe essa solicitação e envia os arquivos associados que, nada mais são, do que os sites que acessamos na Internet.

O HTTP nos fornece alguns verbos que possibilitam que possamos fazer requisições para que possamos recuperar, criar, atualizar e deletar dados:

- **GET**: Selecionar/Buscar/Ler dados;
- **POST**: Enviar dados/Criar novos dados;
- **PUT**: Atualizar dados;
- **PATCH**: Atualizar parcialmente os dados;
- **DELETE**: Deletar os dados.
<br/>

### 6. O que é um Endpoint?

É uma das extremidades de uma conexão de API onde são recebidas as chamadas de API.

Direcionamento dos dados.

Existem 4 maneiras principais de autenticação dos endpoints de uma API:

- Chave de API;
- Autenticação básica (user e senha);
- Token OAuth;
- TLS mútuo (TLS é um protocolo que cria uma conexão autenticada entre o cliente e o servidor).

<br/>

### 7. O que é o Swagger?

É um framework composto por diversas ferramentas que auxiliam a documentação, descrição, consumo e visualização de uma API.

<br/>

### 8. DDD - Domain-Driven Development

O DDD é uma filosofia de desenvolvimento de softwares complexos usando boas práticas na qual a estrutura e a linguagem do seu código *(nomes de classe, métodos, variáveis, etc.)* devem estar focados no modelo de domínio ou negócio.

- **Apresentação**: Cuida da interação com quem vai usar a nossa aplicação. Podemos ter aqui um projeto Web, Mobile, Web API, Desktop, etc.
- **Aplicação**: Cuida da comunicação com o Domínio. Aqui podemos ter: Classes de serviços, Interfaces, DTOs, etc.
- **Domínio**: É o coração do projeto e deve representar o negócio. Aqui teremos: entidades, Interfaces, Classes de serviços, Validações, etc.
- **Infraestrutura**: Cuida do suporte geral às demais implementações e em geral possui uma outra camada que se comunica com todas as camadas do projeto; Aqui podemos ter: Repositórios, Persistência, Mapeamentos, etc.