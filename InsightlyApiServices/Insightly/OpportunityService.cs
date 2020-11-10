using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Tools;
using Models.Insightly;

namespace Services.Insightly
{
    public class OpportunityService : CrudService<Opportunity>
    {
        public OpportunityService(string apiKey) : base(apiKey, "Opportunities")
        {
        }

        public IEnumerable<Opportunity> GetAllOpps()
        {
            try
            {
                Utils.LogMessage($"Getting all opportunities...");

                var opps = GetAll().Result;
                var s = opps != null && opps.Count() > 1 ? "ies" : "y";
                if (opps != null && opps.Count() > 0) Utils.LogMessage($"Successfully found {opps.Count()} opportunit{s}!");
                return opps;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting all opportunities: {ex.Message}");
                throw;
            }
        }

        public Opportunity GetOpp(long? oppId)
        {
            try
            {
                if (oppId == null) return null;
                Utils.LogMessage($"Getting opp #{oppId}...");

                var opp = Get((long)oppId).Result;
                if (opp != null) Utils.LogMessage($"Successfully found opp, {opp.OPPORTUNITY_NAME}");
                return opp;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting opp #{oppId}: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<Opportunity> SearchOppsByFieldValue(string fieldName, object fieldValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fieldName) || fieldValue == null) return null;
                Utils.LogMessage($"Searching for opps with {fieldValue} in {fieldName}...");

                var opps = Search(fieldName, fieldValue).Result;
                var s = opps != null && opps.Count() > 1 ? "ies" : "y";
                if (opps != null && opps.Count() > 0) Utils.LogMessage($"Successfully found {opps.Count()} opportunit{s}!");
                return opps;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Searching for opps with {fieldValue} in {fieldName}: {ex.Message}");
                throw;
            }
        }

        public Opportunity CreateOpp(Opportunity opp)
        {
            try
            {
                if (opp == null) return null;
                Utils.LogMessage($"Creating opp, {opp?.OPPORTUNITY_NAME}...");

                opp = Create(opp).Result;
                if (opp != null) Utils.LogMessage($"Successfully created opp, {opp.OPPORTUNITY_ID}!");
                return opp;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Creating opp, {opp?.OPPORTUNITY_NAME}: {ex.Message}");
                throw;
            }
        }

        public Opportunity UpdateOpp(Opportunity opp)
        {
            try
            {
                if (opp == null) return null;
                Utils.LogMessage($"Updating opp #{opp?.OPPORTUNITY_ID}...");

                opp = Update(opp).Result;
                if (opp != null) Utils.LogMessage($"Successfully updated opp, {opp.OPPORTUNITY_NAME}!");
                return opp;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Updating opp #{opp?.OPPORTUNITY_ID}: {ex.Message}");
                throw;
            }
        }

        public bool DeleteOpp(long? oppId)
        {
            try
            {
                if (oppId == null) return false;
                Utils.LogMessage($"Deleting opp #{oppId}...");

                var deleted = Delete((long)oppId).Result;
                if (deleted) Utils.LogMessage($"Successfully deleted opp #{oppId}!");
                return deleted;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Deleting opp #{oppId}: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<OpportunityLineItem>> GetLineItems(long? oppId)
        {
            try
            {
                if (oppId == null) return null;
                Utils.LogMessage($"Getting line itmes for opp #{oppId}...");

                var lineItems = await GetByUrlAsync<IEnumerable<OpportunityLineItem>>($"{oppId}/OpportunityLineItem");
                var s = lineItems != null && lineItems.Count() > 1 ? "s" : string.Empty;
                if (lineItems != null && lineItems.Count() > 0) Utils.LogMessage($"Successfully retrieved {lineItems.Count()} line item{s}!");
                return lineItems;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Updating opp #{oppId}: {ex.Message}");
                throw;
            }
        }

        public async Task<OpportunityLineItem> AddLineItem(long? oppId, OpportunityLineItem quoteLineItem)
        {
            try
            {
                if (oppId == null || quoteLineItem == null) return null;
                Utils.LogMessage($"Adding line item for opp #{oppId}...");

                var lineItem = await apiClient.PostAsync(quoteLineItem, $"{objectUrl}/{oppId}/OpportunityLineItem");
                if (lineItem != null) Utils.LogMessage($"Successfully created line item #{lineItem?.OPPORTUNITY_ITEM_ID}!");
                return lineItem;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Adding line item for opp #{oppId}: {ex.Message}");
                throw;
            }
        }

        public async Task<Opportunity> UpdatePricebook(Opportunity opp)
        {
            try
            {
                if (opp == null || opp?.PRICEBOOK_ID == null) return opp;
                Utils.LogMessage($"Adding pricebook id #{opp?.PRICEBOOK_ID} to opp #{opp?.OPPORTUNITY_ID}...");

                opp = await apiClient.PutAsync(opp, $"{objectUrl}/{opp.OPPORTUNITY_ID}/Pricebook");
                if (opp != null) Utils.LogMessage($"Successfully added pricebook to opp!");
                return opp;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Updating the pricebook for opp #{opp?.OPPORTUNITY_ID}: {ex.Message}");
                throw;
            }
        }

        public async Task<Pipeline> AddPipeline(long id, Pipeline pipeline)
        {
            return await apiClient.PostAsync(pipeline, $"{objectUrl}/{id}/Pipeline");
        }

        public static Opportunity CopyOpp(Opportunity opp)
        {
            return new Opportunity() { OPPORTUNITY_ID = opp.OPPORTUNITY_ID, CUSTOMFIELDS = new List<CustomField>() };
        }
    }
}
