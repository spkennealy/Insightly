using System;
using System.Collections.Generic;
using System.Linq;
using Common.Tools;
using Models.Insightly;

namespace Services.Insightly
{
    public class LeadService : CrudService<Lead>
    {
        public LeadService(string apiKey) : base(apiKey, "Leads")
        {
        }

        public IEnumerable<Lead> GetAllLeads()
        {
            try
            {
                Utils.LogMessage($"Getting all leads...");

                var leads = GetAll().Result;
                var s = leads != null && leads.Count() > 1 ? "s" : string.Empty;
                if (leads != null && leads.Count() > 0) Utils.LogMessage($"Successfully found {leads.Count()} lead{s}!");
                return leads;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting all leads: {ex.Message}");
                throw;
            }
        }

        public Lead GetLead(long? leadId)
        {
            try
            {
                if (leadId == null) return null;
                Utils.LogMessage($"Getting lead #{leadId}...");

                var lead = Get((long)leadId).Result;
                if (lead != null) Utils.LogMessage($"Successfully retrieved lead, {lead.FIRST_NAME} {lead.LAST_NAME}!");
                return lead;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting lead #{leadId}: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<Lead> SearchLeadsByFieldValue(string fieldName, object fieldValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fieldName) || fieldValue == null) return null;
                Utils.LogMessage($"Searching for leads with {fieldValue} in {fieldName}...");

                var leads = Search(fieldName, fieldValue).Result;
                var s = leads != null && leads.Count() > 1 ? "s" : string.Empty;
                if (leads != null && leads.Count() > 0) Utils.LogMessage($"Successfully found {leads.Count()} lead{s}!");
                return leads;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Searching for leads with {fieldValue} in {fieldName}: {ex.Message}");
                throw;
            }
        }

        public Lead CreateLead(Lead lead)
        {
            try
            {
                if (lead == null) return null;
                Utils.LogMessage($"Creating lead {lead?.FIRST_NAME} {lead?.LAST_NAME}...");

                lead = Create(lead)?.Result;
                if (lead != null) Utils.LogMessage($"Successfully created lead #{lead.LEAD_ID}!");
                return lead;
            }
            catch (Exception ex)
            {
                Utils.LogMessage($"Error creating lead {lead?.FIRST_NAME} {lead?.LAST_NAME}: {ex.Message}");
                throw;
            }
        }

        public Lead UpdateLead(Lead lead)
        {
            try
            {
                if (lead == null) return null;
                Utils.LogMessage($"Updating lead {lead?.FIRST_NAME} {lead?.LAST_NAME}...");

                lead = Update(lead)?.Result;
                if (lead != null) Utils.LogMessage($"Successfully updated lead #{lead.LEAD_ID}!");
                return lead;
            }
            catch (Exception ex)
            {
                Utils.LogMessage($"Error updating lead {lead?.FIRST_NAME} {lead?.LAST_NAME}: {ex.Message}");
                throw;
            }
        }

        public bool DeleteLead(long? leadId)
        {
            try
            {
                if (leadId == null) return false;
                Utils.LogMessage($"Deleting lead #{leadId}...");

                var deleted = Delete((long)leadId).Result;
                if (deleted) Utils.LogMessage($"Successfully deleted lead #{leadId}!");
                return deleted;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Deleting lead #{leadId}: {ex.Message}");
                throw;
            }
        }

        public static Lead CopyLead(Lead lead)
        {
            return new Lead() { LEAD_ID = lead.LEAD_ID, CUSTOMFIELDS = new List<CustomField>() };
        }
    }
}
