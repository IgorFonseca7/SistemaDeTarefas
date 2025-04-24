using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repository.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosOsUsuarios();
        Task<UsuarioModel> BuscarUsuarioPorId(int id);
        Task<UsuarioModel> Adicionar (UsuarioModel user);
        Task<UsuarioModel> Atualizar(UsuarioModel user, int id);
        Task<bool> Apagar(int id);
    }
}
