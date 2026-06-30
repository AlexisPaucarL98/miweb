using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WEB.Application;
using WEB.Application.features.usuarios.DTOS.Responses;
using WEB.Application.features.usuarios.interfaces;

namespace WEB.Infrastructure
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IConfiguration _configuration;

        public UsuarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<UsuarioResponse>>
             ListarUsuariosAsync()
        {
            using System.Data.IDbConnection cn =
                new SqlConnection(_configuration.GetConnectionString("SqlServer"));

            var result =
                await cn.QueryAsync<UsuarioResponse>("ListarUsuarios", commandType: CommandType.StoredProcedure);

            return result;
        }
    }
}
