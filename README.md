# Documentação do Projeto: Sistema de Login em .NET 8.0

## Sumário

1. [Introdução](#introdução)
2. [Tipo de Projeto](#tipo-de-projeto)
3. [Comando de Criação do Projeto](#comando-de-criação-do-projeto)
4. [Estrutura do Projeto](#estrutura-do-projeto)
5. [Requisitos](#requisitos)
6. [Configuração do Ambiente](#configuração-do-ambiente)
7. [Rotas da Aplicação](#rotas-da-aplicação)
8. [Arquivos Principais](#arquivos-principais)
9. [Como Executar o Projeto](#como-executar-o-projeto)
10. [Histórico de Alterações](#histórico-de-alterações)
11. [Considerações Finais](#considerações-finais)

---

## Introdução

Este projeto consiste em um sistema de login simples desenvolvido com .NET 8.0. A aplicação possui duas principais funcionalidades: criação de conta e login de usuário, com interfaces para interação através de páginas HTML.

## Tipo de Projeto

Este projeto é uma **Web API** que serve páginas HTML para o front-end, utilizando .NET 8.0. A estrutura é voltada para aplicações web, onde as interações são feitas através de rotas definidas em controladores.

## Comando de Criação do Projeto

Para criar o projeto, o seguinte comando foi utilizado no terminal:

```bash
dotnet new web -n loginapp
```

Esse comando cria uma nova aplicação web chamada "loginapp" utilizando a template padrão do .NET.

## Estrutura do Projeto

A estrutura básica do projeto é a seguinte:

```
loginapp/
├── Controllers/
│   └── LoginController.cs
├── Views/
│   ├── Login.html
│   └── Register.html
└── Program.cs
```

## Requisitos

- .NET 8.0  
- Visual Studio Code ou qualquer editor de código de sua preferência  
- Navegador para acessar as páginas HTML  

## Configuração do Ambiente

1. **Instalação do .NET**: Certifique-se de ter o .NET 8.0 instalado em seu sistema.  
2. **Editor de Código**: Use o Visual Studio Code ou outro editor para desenvolver e testar o código.  
3. **Serviço de Hosting**: O projeto deve ser executado em um servidor local, como o Kestrel, que já vem com o .NET.  

## Rotas da Aplicação

A aplicação disponibiliza as seguintes rotas:

- **Login**: [http://localhost:5000/Login](http://localhost:5000/Login)  
- **Registrar**: [http://localhost:5000/Register](http://localhost:5000/Register)  

## Arquivos Principais

### Program.cs, LoginController.cs, Login.html, RegisterController.cs e Register.html.
Os códigos estão no repositório.

## Como Executar o Projeto

1. Navegue até o diretório do projeto no terminal.  
2. Execute o comando:  
```bash
   dotnet run
```

Abra um navegador e acesse:  
- [http://localhost:5000/Login](http://localhost:5000/Login)  
- [http://localhost:5000/Register](http://localhost:5000/Register)  

para ver as respectivas telas.

---

## Histórico de Alterações

- **2024-10-28**: Criação do projeto básico como uma Web API, incluindo a estrutura inicial e páginas de login e registro.  
- **2024-10-29**: Implementação do controlador `LoginController` para gerenciar as rotas de Login e Registro.  
- **2024-10-29**: Ajustes nas páginas HTML para melhorar a interface do usuário, centralizando os formulários e atualizando o layout dos botões.  
- **2024-10-29**: Adição de documentação inicial, incluindo detalhes sobre a estrutura do projeto, tipo de projeto e requisitos.

---

## Considerações Finais

Este sistema de login é um ponto de partida e pode ser expandido para incluir funcionalidades adicionais, como autenticação real, armazenamento de dados de usuários, etc. A documentação pode ser atualizada à medida que novas funcionalidades forem adicionadas ao projeto.