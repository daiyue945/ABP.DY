using System.Threading.Tasks;
using Abp.Application.Services;
using ABP.DY.Sessions.Dto;

namespace ABP.DY.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
