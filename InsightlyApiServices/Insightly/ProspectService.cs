using System;
using System.Collections.Generic;
using System.Linq;
using Common.Tools;
using Models.Insightly;

namespace Services.Insightly
{
    public class ProspectService : CrudService<Prospect>
    {
        public ProspectService(string apiKey) : base(apiKey, "Prospect")
        {
        }

        public IEnumerable<Prospect> GetAllProspects()
        {
            try
            {
                Utils.LogMessage($"Getting all prospects...");

                var prospects = GetAll().Result;
                var s = prospects != null && prospects.Count() > 1 ? "s" : string.Empty;
                if (prospects != null && prospects.Count() > 0) Utils.LogMessage($"Successfully found {prospects.Count()} prospect{s}!");
                return prospects;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting all prospects: {ex.Message}");
                throw;
            }
        }

        public Prospect GetProspect(long? prospectId)
        {
            try
            {
                if (prospectId == null) return null;
                Utils.LogMessage($"Getting prospect #{prospectId}...");

                var prospect = Get((long)prospectId).Result;
                if (prospect != null) Utils.LogMessage($"Successfully found prospect, {prospect.FIRST_NAME} {prospect.LAST_NAME}!");
                return prospect;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting prospect #{prospectId}: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<Prospect> SearchProspectsByFieldValue(string fieldName, object fieldValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fieldName) || fieldValue == null) return null;
                Utils.LogMessage($"Searching for prospects with {fieldValue} in {fieldName}...");

                var prospects = Search(fieldName, fieldValue).Result;
                var s = prospects != null && prospects.Count() > 1 ? "s" : string.Empty;
                if (prospects != null && prospects.Count() > 0) Utils.LogMessage($"Successfully found {prospects.Count()} prospect{s}!");
                return prospects;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Searching for prospects with {fieldValue} in {fieldName}: {ex.Message}");
                throw;
            }
        }

        public Prospect CreateProspect(Prospect prospect)
        {
            try
            {
                if (prospect == null) return null;
                Utils.LogMessage($"Creating prospect, {prospect?.FIRST_NAME} {prospect?.LAST_NAME}...");

                prospect = Create(prospect).Result;
                if (prospect != null) Utils.LogMessage($"Successfully created prospect #{prospect.PROSPECT_ID}!");
                return prospect;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Creating prospect, {prospect?.FIRST_NAME} {prospect?.LAST_NAME}: {ex.Message}");
                throw;
            }
        }

        public Prospect UpdateProspect(Prospect prospect)
        {
            try
            {
                if (prospect == null) return null;
                Utils.LogMessage($"Updating prospect #{prospect?.PROSPECT_ID}...");

                prospect = Update(prospect).Result;
                if (prospect != null) Utils.LogMessage($"Successfully updated prospect, {prospect?.FIRST_NAME} {prospect?.LAST_NAME}!");
                return prospect;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Updating prospect #{prospect?.PROSPECT_ID}: {ex.Message}");
                throw;
            }
        }

        public bool DeleteProspect(long? prospectId)
        {
            try
            {
                if (prospectId == null) return false;
                Utils.LogMessage($"Deleting prospect #{prospectId}...");

                var deleted = Delete((long)prospectId).Result;
                if (deleted) Utils.LogMessage($"Successfully deleted prospect #{prospectId}!");
                return deleted;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Deleting prospect #{prospectId}: {ex.Message}");
                throw;
            }
        }
    }
}
