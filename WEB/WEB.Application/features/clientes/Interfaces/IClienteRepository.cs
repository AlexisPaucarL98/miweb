using System;
using System.Collections.Generic;
using System.Text;
using WEB.Application.features.clientes.DTOs.Responses;

namespace WEB.Application
{
    public interface IClienteRepository
    {
        Task<IEnumerable<ClienteResponse>> ListarClientesAsync();
   
        Task<ClienteResponse> ObtenerClientePorDocumentoAsync(string documento);
        Task<int> RegistrarAsync(RegistrarClienteRequest request);

        Task<ClienteResponse> ELIMINARCLIENTEAsync(int IdCliente);

        Task<ClienteResponse> ActualizarEstadoClienteAsync(int IdCliente);

        
    }
}