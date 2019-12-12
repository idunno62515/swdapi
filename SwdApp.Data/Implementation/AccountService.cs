using SwdApp.Data.Dtos.Account;
using System;
using System.Collections.Generic;
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

        public Task<string> Login(LoginDto loginDto)
        {
            throw new NotImplementedException();
        }
    }
}
