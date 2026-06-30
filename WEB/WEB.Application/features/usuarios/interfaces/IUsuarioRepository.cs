using System;
using System.Collections.Generic;
using System.Text;
using WEB.Application.features.usuarios.DTOS.Responses;

namespace WEB.Application.features.usuarios.interfaces
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<UsuarioResponse>> ListarUsuariosAsync();

    }
}
