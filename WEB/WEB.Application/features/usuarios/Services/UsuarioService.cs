using System;
using System.Collections.Generic;
using System.Text;
using WEB.Application.features.usuarios.DTOS.Responses;
using WEB.Application.features.usuarios.interfaces;

namespace WEB.Application.features.usuarios.Services
{
    public class UsuarioService : IUsuarioRepository
    {
        //CONSTRUCTOR
        private readonly IUsuarioRepository
        _repository;

        public UsuarioService(
            IUsuarioRepository repository)
        {
            _repository = repository;
        }
        public Task<IEnumerable<UsuarioResponse>> ListarUsuariosAsync()
        {
            return
                 _repository.ListarUsuariosAsync();

        }
}
}