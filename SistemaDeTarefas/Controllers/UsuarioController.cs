using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repository.Interfaces;

namespace SistemaDeTarefas.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioRepositorio _usuarioRepositorio;
    
    public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
    {
        _usuarioRepositorio = usuarioRepositorio;
    }

    [HttpGet]
    public async Task<ActionResult<List<UsuarioModel>>> BuscarTodosUsuarios() // Fixed syntax for generic type
    {
        List<UsuarioModel> usuarios = await _usuarioRepositorio.BuscarTodosOsUsuarios();
        return Ok(usuarios); 
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<UsuarioModel>> BuscarPorId(int id)
    {
    UsuarioModel usuarios = await _usuarioRepositorio.BuscarUsuarioPorId(id);
        return Ok(usuarios);
    }

    [HttpPost]
    public async Task<ActionResult<UsuarioModel>> AdicionarUsuario(UsuarioModel usuario)
    {
        UsuarioModel usuarios = await _usuarioRepositorio.Adicionar(usuario);
        return Ok(usuarios);
    }

    [HttpPut("{id}")]

    public async Task<ActionResult<UsuarioModel>> AtualizarUsuario(UsuarioModel usuario, int id)
    {
        UsuarioModel usuarios = await _usuarioRepositorio.Atualizar(usuario, id);
        return Ok(usuarios);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<UsuarioModel>> DeletarUsuario(int id)
    {
        bool apagado = await _usuarioRepositorio.Apagar(id);
        return Ok(apagado);
    }

}
