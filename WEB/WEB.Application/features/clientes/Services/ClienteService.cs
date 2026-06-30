using System;
using System.Collections.Generic;
using System.Text;
using WEB.Application.features.clientes.DTOs.Responses;

namespace WEB.Application
{
    public class ClienteService : IClienteRepository
    {
        //CONSTRUCTOR
        private readonly IClienteRepository
        _repository;

        public ClienteService(
            IClienteRepository repository)
        {
            _repository = repository;
        }


        public Task<IEnumerable<ClienteResponse>> ListarClientesAsync()
        {
            return 
                 _repository.ListarClientesAsync();
        }
        public async Task<ClienteResponse> ObtenerClientePorDocumentoAsync(string documento)
        {
            return await
                 _repository.ObtenerClientePorDocumentoAsync(documento);
        }


        public async Task<ClienteResponse> ActualizarEstadoClienteAsync(int idCliente)
        {
            return await
                 _repository.ActualizarEstadoClienteAsync(idCliente);
         
        }

        public async Task<ClienteResponse> ELIMINARCLIENTEAsync(int idCliente)
        {
            return await
                 _repository.ELIMINARCLIENTEAsync(idCliente);

        }

        public async Task<int>RegistrarAsync(RegistrarClienteRequest request)
        {
            RegistrarClienteResponse clienteCreado = null;
            var id = await _repository.RegistrarAsync(request);

            clienteCreado = new RegistrarClienteResponse();
            clienteCreado.IdCliente = id;
            clienteCreado.Mensaje = "Cliente registrado correctamente";

            return clienteCreado.IdCliente;
        }
}
}

