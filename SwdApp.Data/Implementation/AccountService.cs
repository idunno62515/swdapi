using Dapper;
using SwdApp.Data.Dtos.Account;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SwdApp.Data.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly string connectionString;

        public AccountService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<bool> Login(LoginDto loginDto)
        {
            using (var con = new SqlConnection(connectionString))
            {
                var res = await con.QueryFirstOrDefaultAsync<int>(
                    "spAccountLogin",
                    new { Username = loginDto.Username, Password = loginDto.Password },
                    commandType: CommandType.StoredProcedure);

                return res > 0;

            }
        }

      
    }
}
