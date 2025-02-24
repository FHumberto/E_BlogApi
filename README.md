<h1 align="center">
  <br>
  <b>Blog Api</b>
  <br>
</h1>

<p align="center">
  <a href="#sobre">Sobre</a> •
  <a href="#tecnologias">Tecnologias</a> •
  <a href="#fundamentos">Fundamentos</a> •
  <a href="#como-rodar">Como rodar?</a> •
  <a href="#licença">Licença</a>
</p>

<div align="center">
  <img alt="Cover" src="about/Cover.png">
</div>

## **Sobre**

Este projeto foi desenvolvido com o propósito de exercitar a arquitetura em três camadas (API, BLL e DAL), além do design do banco de dados. Trata-se de uma API para um blog, permitindo que os usuários cadastrem posts, adicionem comentários e utilizem tags para organização do conteúdo.

O projeto inclui boas práticas como injeção de dependência, separação de responsabilidades e padronização de código. Além disso, está preparado para ser executado em um ambiente Dockerizado, garantindo maior portabilidade e facilidade de implantação.

## **Informações Técnicas**

### **Tecnologias**

Este projeto utiliza as seguintes ferramentas e tecnologias:

* `.NET 9` – Framework principal para desenvolvimento da API
* `Entity Framework Core` – ORM para acesso a dados e modelagem do banco
* `FluentValidation` – Biblioteca para validação de dados
* `AutoMapper` – Mapeamento automático entre modelos e DTOs
* `Swagger (Swashbuckle)` – Documentação interativa da API
* `Serilog` – Logging estruturado e armazenamento de logs
* `Docker` – Contêinerização para facilitar implantação e escalabilidade

### **Fundamentos**

#### **Arquitetura**

O projeto segue a arquitetura de três camadas (Three-Tier Architecture): 

* API Layer – Camada de apresentação, responsável por expor os endpoints da API
* Business Logic Layer (BLL) – Camada de regras de negócio, onde os serviços e validações são implementados
* Data Access Layer (DAL) – Camada de persistência, que interage com o banco de dados via Entity Framework

#### **Design do Banco de Dados**

O banco de dados foi projetado para suportar um sistema de blog, incluindo as seguintes entidades principais:

* Usuário – Cadastro de usuários com autenticação e permissões
* Post – Publicação de artigos no blog
* Comentário – Sistema de feedback nos posts
* Tag – Organização do conteúdo por categorias

### **Como Rodar?**


#### **1. Preparação**

Para clonar este repositório, você precisará ter o [Git](https://git-scm.com) e o .NET respectivo instalado em sua máquina sua máquina.

#### **2. Rodando**

> A aplicação pode ser executada na interface do Visual Studio ou usando o modo debug no VSCode.

Para compilar e executar a aplicação pelo terminal, utilize os seguintes comandos:

```shell
dotnet build
```

```shell
dotnet run --project <CAMINHO_DO_PROJETO>
```

## **Licença**

MIT
