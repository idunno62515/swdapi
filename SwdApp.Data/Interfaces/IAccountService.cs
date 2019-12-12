using SwdApp.Data.Dtos.Account;
using System.Threading.Tasks;

namespace SwdApp.Data.Implementation
{
    public interface IAccountService
    {
        public Task<string> Login(LoginDto loginDto);

    }
}