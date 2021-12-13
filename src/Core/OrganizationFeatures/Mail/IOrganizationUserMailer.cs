using System.Collections.Generic;
using System.Threading.Tasks;
using Bit.Core.Models.Table;

namespace Bit.Core.OrganizationFeatures.Mail
{
    public interface IOrganizationUserMailer
    {
        Task SendInvitesAsync(IEnumerable<OrganizationUser> orgUsers, Organization organization);
        Task SendOrganizationAutoscaledEmailAsync(Organization organization, int initialSeatCount);
    }
}