using SwdApp.Data.Dtos.Account;
using System.Threading.Tasks;

namespace SwdApp.Data.Implementation
{
    public interface IAccountService
    {
        public Task<bool> Login(LoginDto loginDto);

    }
}