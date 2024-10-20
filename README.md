# ApiUsuario 🌐
### Este repositório contém uma API para gerenciamento de usuários, desenvolvida em C#. A seguir, apresentamos a estrutura do projeto e suas principais funcionalidades.

##

# Estrutura do Projeto 📂

    ApiUsuario/
    │
    ├── Controllers/
    │   └── UserController.cs              # Controlador da API
    │
    ├── Models/
    │   └── User.cs                         # Modelo de dados
    │
    ├── Data/
    │   └── ApplicationDbContext.cs         # Contexto do banco de dados
    │
    ├── Migrations/                         # Pasta para migrações do Entity Framework
    │
    ├── Program.cs                          # Classe principal
    ├── Startup.cs                          # Configurações da aplicação
    │
    └── ApiUsuario.csproj                   # Arquivo de projeto

  ##

  # Descrição dos Componentes 📄
  - Controllers/UserController.cs: Controlador responsável por gerenciar as operações relacionadas aos usuários, como criação, leitura, atualização e exclusão
(CRUD). 🛠️

  - Models/User.cs: Representa o modelo de dados do usuário, incluindo as propriedades que compõem o objeto de usuário. 👤
    
  - Data/ApplicationDbContext.cs: Contexto do banco de dados que permite a interação com a base de dados usando o Entity Framework. 🗄️
    
  - Migrations/: Contém as migrações do Entity Framework, que ajudam a manter o esquema do banco de dados em sincronia com os modelos de dados. 📈
    
  - Program.cs: Classe principal que inicia a aplicação e configura os serviços e o pipeline de requisições. 🚀
    
  - Startup.cs: Contém as configurações da aplicação, como serviços, middlewares e configurações de rotas. ⚙️
  - ApiUsuario.csproj: Arquivo de projeto que contém informações sobre dependências e configurações do projeto. 📜

##

# Como Executar 🚦 

1. Clone o repositório:
   
       git clone https://seu-repositorio.git
       cd ApiUsuario
2. Restaure as dependências:
   
       dotnet restore
3.Execute as migrações (se necessário):
           
   dotnet ef database update
4. Inicie a aplicação:

    dotnet run

# Contribuições 🤝
- Sinta-se à vontade para contribuir com melhorias ou correções. Abra uma issue ou envie um pull request!

# Licença 📜
-Este projeto está sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.
