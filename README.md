# ✅ Sistema de Tarefas

Sistema desenvolvido com ASP.NET Core para gerenciamento de tarefas com funcionalidades de criação, atualização, exclusão e consulta, além de associação de tarefas a usuários e controle de status.

## 🧰 Tecnologias utilizadas

- ASP.NET Core
- Entity Framework Core
- C#
- PostgreSQL
- Swagger (opcional)

## 📁 Estrutura do projeto

```
SistemaDeTarefas/
├── Controllers/
│   └── UsuarioController.cs
├── Data/
│   ├── Map/
│   │   ├── TarefaMap.cs
│   │   └── UsuarioMap.cs
│   ├── Migrations/
│   │   ├── 20250424141430_InitialDB.cs
│   │   └── SistemaTarefasDBcontextModelSnapshot.cs
│   └── SistemaTarefasDBcontext.cs
├── Enums/
│   └── StatusTarefa.cs
├── Models/
│   └── TarefaModel.cs
├── Repository/
│   └── Interfaces/
│       └── UsuarioRepositorio.cs
├── appsettings.json
└── Program.cs
```

## ⚙️ Como executar o projeto

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/SistemaDeTarefas.git
   ```

2. Acesse a pasta do projeto:

   ```bash
   cd SistemaDeTarefas
   ```

3. Restaure os pacotes:

   ```bash
   dotnet restore
   ```

4. Configure a `ConnectionString` no `appsettings.json` com os dados do seu banco PostgreSQL.

5. Execute as migrations para criar o banco:

   ```bash
   dotnet ef database update
   ```

6. Rode o projeto:

   ```bash
   dotnet run
   ```

## ✅ Funcionalidades implementadas

- [x] Estrutura base com ASP.NET Core
- [x] Mapeamento de entidades com Entity Framework
- [x] Enum para status de tarefas
- [x] Migrations e contexto do banco de dados
- [x] Repositório para usuários
- [x] Configuração inicial no `Program.cs` e `appsettings.json`

## 📌 Próximos passos

- [ ] Implementar CRUD completo de tarefas
- [ ] Implementar CRUD de usuários
- [ ] Autenticação e autorização
- [ ] Testes unitários
- [ ] Integração com Swagger para documentação da API

## 🤝 Contribuindo

1. Faça um fork do projeto
2. Crie uma branch para sua feature:
   ```bash
   git checkout -b minha-feature
   ```
3. Faça commit das suas alterações:
   ```bash
   git commit -m 'feat: minha nova feature'
   ```
4. Envie para o repositório remoto:
   ```bash
   git push origin minha-feature
   ```
5. Abra um Pull Request

## 📄 Licença

Este projeto está sob a licença MIT. Sinta-se livre para utilizar, modificar e contribuir!
