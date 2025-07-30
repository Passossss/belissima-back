# 🌟 Belíssima API 🌟

Bem-vindo ao repositório da Belíssima API! Este é o backend robusto e eficiente que alimenta o aplicativo Belíssima, fornecendo os dados e a lógica de negócio necessária para uma experiência de usuário impecável.

Desenvolvida com **.NET 8**, esta API é construída para ser performática, escalável e de fácil manutenção, seguindo as melhores práticas do desenvolvimento moderno.

## 🚀 Tecnologias Utilizadas

* **Backend**: .NET 8
* **Banco de Dados**: `SQL Server`
* **ORM**: Entity Framework Core
* **Documentação da API**: Swagger/OpenAPI

## ✨ Funcionalidades Principais (Mini-API / Minimal API)

Esta API segue o conceito de Minimal APIs do .NET, focando na simplicidade e na eficiência para expor endpoints de forma concisa. As principais funcionalidades incluem:
Gerenciamento de Revendedoras

## 📦 Estrutura do Projeto

A estrutura do projeto está organizada de forma lógica para facilitar o desenvolvimento e a manutenção:
```
├── Data/              # Contexto do Banco de Dados e Migrações
├── Migrations/        # Migrações do Entity Framework Core
├── Models/            # Classes de Modelo (Entidades do Banco de Dados)
├── Properties/        # Configurações do Projeto
├── Routes/            # Definição das Rotas e Endpoints da API
├── obj/               # Arquivos de Objeto temporários
├── .gitignore         # Arquivos e pastas a serem ignorados pelo Git
├── Program.cs         # Ponto de entrada da aplicação e configuração de serviços
├── appsettings.json   # Configurações da aplicação
├── appsettings.Development.json # Configurações para ambiente de desenvolvimento
├── belissima-back.csproj # Arquivo de projeto C#
├── belissima-back.sln # Arquivo de solução do Visual Studio
```
## 🛠️ Configuração e Execução (Desenvolvimento)

Siga os passos abaixo para configurar e rodar a Belíssima API em seu ambiente de desenvolvimento:

1.  **Pré-requisitos:**
    * .NET SDK 8.0 ou superior (Verifique com `dotnet --version`)
    * Um editor de código como Visual Studio 2022, Visual Studio Code ou JetBrains Rider.
    * (Seu Banco de Dados, ex: SQL Server LocalDB ou instância)

2.  **Clone o repositório:**
    ```bash
    git clone [URL_DO_SEU_REPOSITORIO_AQUI]
    cd belissima-back
    ```

3.  **Configuração do Banco de Dados:**
    * Abra `appsettings.Development.json` e `appsettings.json`.
    * Atualize a `ConnectionStrings` com as credenciais e o nome do seu banco de dados. Exemplo:
        ```json
        "ConnectionStrings": {
            "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=BelissimaDb;Trusted_Connection=True;MultipleActiveResultSets=true"
        }
        ```
    * Execute as migrações para criar o banco de dados e as tabelas:
        ```bash
        dotnet ef database update
        ```

4.  **Execute a Aplicação:**
    ```bash
    dotnet run
    ```
    A API será iniciada, geralmente em `https://localhost:7XXX` (verifique a porta no console ou em `launchSettings.json` dentro da pasta `Properties`).
