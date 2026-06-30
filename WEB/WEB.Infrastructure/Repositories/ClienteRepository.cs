using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WEB.Application;
using WEB.Application.features.clientes.DTOs.Responses;


namespace WEB.Infrastructure.Repositories
{
    public class ClienteRepository: IClienteRepository
    {
        private readonly IConfiguration _configuration;

        public ClienteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<ClienteResponse>>
            ListarClientesAsync()
        {
            using System.Data.IDbConnection cn =
                new SqlConnection(_configuration.GetConnectionString("SqlServer"));

            var result =
                await cn.QueryAsync<ClienteResponse>("ListarClientes",commandType:CommandType.StoredProcedure);

            return result;
        }
         public async Task<ClienteResponse>ObtenerClientePorDocumentoAsync(string numeroDocumento)
        {
            using System.Data.IDbConnection cn =
                new SqlConnection(_configuration.GetConnectionString("SqlServer"));
            return await cn.QueryFirstOrDefaultAsync<
            ClienteResponse>( "ObtenerClientePorDocumento",
            new
            {
                NumeroDocumento = numeroDocumento
            },
            commandType:
            CommandType.StoredProcedure);
        }


        public async Task<ClienteResponse> ActualizarEstadoClienteAsync(int idCliente)
        {
            using System.Data.IDbConnection cn =
                new SqlConnection(_configuration.GetConnectionString("SqlServer"));
            return await cn.QueryFirstOrDefaultAsync<
            ClienteResponse>("ActualizarEstadoCliente",
            new
            {
                IdCliente = idCliente
            },
            commandType:
            CommandType.StoredProcedure);

        }

        public async Task<ClienteResponse> ELIMINARCLIENTEAsync(int idCliente)
        {
            using System.Data.IDbConnection cn =
                new SqlConnection(_configuration.GetConnectionString("SqlServer"));
            return await cn.QueryFirstOrDefaultAsync<
            ClienteResponse>("ELIMINARCLIENTE",
            new
            {
                IdCliente = idCliente
            },
            commandType:
            CommandType.StoredProcedure);

        }




        public async Task<int> RegistrarAsync(RegistrarClienteRequest request)
        {
            using var cn =
                new SqlConnection(
                    _configuration.GetConnectionString("SqlServer"));

            return await cn.ExecuteScalarAsync<int>(
                "RegistrarCliente",
                new
                {
                    request.IdTipoDocumento,
                    request.NumeroDocumento,
                    request.Nombres,
                    request.Apellidos,
                    request.RazonSocial,
                    request.Telefono,
                    request.Correo,
                    request.Direccion,
                    request.Ciudad,
                    request.UsuarioAuditoria
                },
                commandType:
                CommandType.StoredProcedure);

        }
        
    }
}
