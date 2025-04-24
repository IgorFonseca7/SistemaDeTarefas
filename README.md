# ✅ Sistema de Tarefas

Sistema desenvolvido com ASP.NET Core para gerenciamento de tarefas com funcionalidades de criação, atualização, exclusão e consulta, além de associação de tarefas a usuários e controle de status.

## 🧰 Tecnologias utilizadas

- ASP.NET Core
- Entity Framework Core
- C#
- PostgreSQL
- Swagger (se estiver usando para documentação da API)

## 📁 Estrutura do projeto

SistemaDeTarefas/ ├── Controllers/ │ └── UsuarioController.cs ├── Data/ │ ├── Map/ │ │ ├── TarefaMap.cs │ │ └── UsuarioMap.cs │ ├── Migrations/ │ │ ├── 20250424141430_InitialDB.cs │ │ └── SistemaTarefasDBcontextModelSnapshot.cs │ └── SistemaTarefasDBcontext.cs ├── Enums/ │ └── StatusTarefa.cs ├── Models/ │ └── TarefaModel.cs ├── Repository/ │ └── Interfaces/ │ └── UsuarioRepositorio.cs ├── appsettings.json └── Program.cs


## ⚙️ Como executar o projeto

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/SistemaDeTarefas.git
