using Models.Insightly;

namespace Services.Insightly
{
    public class LeadStatusService : BaseService<LeadStatus>
    {
        public LeadStatusService(string apiKey) : base(apiKey, "LeadStatuses")
        {
        }
    }
}
