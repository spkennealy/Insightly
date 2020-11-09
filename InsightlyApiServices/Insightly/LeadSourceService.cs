using System;
using System.Collections.Generic;
using System.Linq;
using Common.Tools;
using Models.Insightly;

namespace Services.Insightly
{
    public class LeadSourceService : BaseService<LeadSource>
    {
        public LeadSourceService(string apiKey) : base(apiKey, "LeadSources")
        {
        }

        public IEnumerable<LeadSource> GetLeadSources()
        {
            try
            {
                Utils.LogMessage($"Getting a list of lead sources...");

                var leadSources = GetByUrlAsync<IEnumerable<LeadSource>>("")?.Result;
                if (leadSources != null && leadSources.Count() > 0) Utils.LogMessage($"Successfully retrieved {leadSources.Count()} lead sources!");
                return leadSources;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting lead sources: {ex.Message}");
                throw;
            }
        }
    }
}
