using System;
using System.Collections.Generic;
using System.Linq;
using Common.Tools;
using Models.Insightly;

namespace Services.Insightly
{
    public class PricebookEntryService : CrudService<PricebookEntry>
    {
        public PricebookEntryService(string apiKey) : base(apiKey, "PricebookEntry")
        {
        }

        public IEnumerable<PricebookEntry> GetAllPricebookEntries()
        {
            try
            {
                Utils.LogMessage($"Getting all pricebook entries...");

                var pricebookEntries = GetAll().Result;
                var s = pricebookEntries != null && pricebookEntries.Count() > 1 ? "ies" : "y";
                if (pricebookEntries != null && pricebookEntries.Count() > 0) Utils.LogMessage($"Successfully found {pricebookEntries.Count()} pricebook entr{s}!");
                return pricebookEntries;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting all quotes: {ex.Message}");
                throw;
            }
        }

        public PricebookEntry GetPricebookEntry(long? pricebookEntryId)
        {
            try
            {
                if (pricebookEntryId == null) return null;
                Utils.LogMessage($"Getting pricebook entry #{pricebookEntryId}...");

                var pricebookEntry = Get((long)pricebookEntryId).Result;
                if (pricebookEntry != null) Utils.LogMessage($"Successfully found pricebook entry #{pricebookEntryId}");
                return pricebookEntry;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting quote #{pricebookEntryId}: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<PricebookEntry> SearchPricebookEntriesByFieldValue(string fieldName, object fieldValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fieldName) || fieldValue == null) return null;
                Utils.LogMessage($"Searching for pricebook entries with {fieldValue} in {fieldName}...");

                var pricebookEntries = Search(fieldName, fieldValue).Result;
                var s = pricebookEntries != null && pricebookEntries.Count() > 1 ? "ies" : "y";
                if (pricebookEntries != null && pricebookEntries.Count() > 0) Utils.LogMessage($"Successfully found {pricebookEntries.Count()} pricebook entr{s}!");
                return pricebookEntries;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Searching for pricebook entries with {fieldValue} in {fieldName}: {ex.Message}");
                throw;
            }
        }

        public PricebookEntry CreatePricebookEntry(PricebookEntry pricebookEntry)
        {
            try
            {
                if (pricebookEntry == null) return null;
                Utils.LogMessage($"Creating pricebook entry...");

                pricebookEntry = Create(pricebookEntry).Result;
                if (pricebookEntry != null) Utils.LogMessage($"Successfully created pricebook entry #{pricebookEntry.PRICEBOOK_ENTRY_ID}!");
                return pricebookEntry;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Creating pricebook entry: {ex.Message}");
                throw;
            }
        }

        public PricebookEntry UpdatePricebookEntry(PricebookEntry pricebookEntry)
        {
            try
            {
                if (pricebookEntry == null) return null;
                Utils.LogMessage($"Updating pricebook entry #{pricebookEntry.PRICEBOOK_ENTRY_ID}...");

                pricebookEntry = Update(pricebookEntry).Result;
                if (pricebookEntry != null) Utils.LogMessage($"Successfully updated pricebook entry #{pricebookEntry.PRICEBOOK_ENTRY_ID}!");
                return pricebookEntry;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Updating pricebook entry #{pricebookEntry.PRICEBOOK_ENTRY_ID}: {ex.Message}");
                throw;
            }
        }

        public bool DeletePricebookEntry(long? pricebookEntryId)
        {
            try
            {
                if (pricebookEntryId == null) return false;
                Utils.LogMessage($"Deleting pricebook entry #{pricebookEntryId}...");

                var deleted = Delete((long)pricebookEntryId).Result;
                if (deleted) Utils.LogMessage($"Successfully deleted pricebook entry #{pricebookEntryId}!");
                return deleted;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Deleting pricebook entry #{pricebookEntryId}: {ex.Message}");
                throw;
            }
        }
    }
}
