using System.Threading.Tasks;
using Abp.Application.Services;
using ABP.DY.Authorization.Accounts.Dto;

namespace ABP.DY.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
