using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repository.Interfaces
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaTarefasDBcontext _dbContext;
        public UsuarioRepositorio(SistemaTarefasDBcontext sistemaTarefasDBcontext)
        {
            _dbContext = sistemaTarefasDBcontext;
        }

        // Implementação do método BuscarTodosOsUsuarios
        public async Task<List<UsuarioModel>> BuscarTodosOsUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }
        public async Task<UsuarioModel> BuscarUsuarioPorId(int id) => await _dbContext?.Usuarios?.FirstOrDefaultAsync(x => x.Id == id) ?? null;
        // Implementação do método Adicionar
        public async Task<UsuarioModel> Adicionar(UsuarioModel user)
        {
           await _dbContext.Usuarios.AddAsync(user);
           await _dbContext.SaveChangesAsync();

            return user;
        }
        // Implementação do método Atualizar
        public async Task<UsuarioModel> Atualizar(UsuarioModel user, int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioPorId(id);
            
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario para o ID: {id} (não foi encontrado no banco de dados.");
            }

            usuarioPorId.Name = user.Name;
            usuarioPorId.Email = user.Email;

            _dbContext.Usuarios.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return usuarioPorId;
        }
        // Implementação do método Apagar
        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario para o ID: {id} (não foi encontrado no banco de dados.");
            }

            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
