using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Tools;
using Models.Insightly;

namespace Services.Insightly
{
    public class QuoteService : CrudService<Quote>
    {
        public QuoteService(string apiKey) : base(apiKey, "Quotation")
        {
        }

        public IEnumerable<Quote> GetAllQuotes()
        {
            try
            {
                Utils.LogMessage($"Getting all quotes...");

                var quotes = GetAll().Result;
                var s = quotes != null && quotes.Count() > 1 ? "s" : string.Empty;
                if (quotes != null && quotes.Count() > 0) Utils.LogMessage($"Successfully found {quotes.Count()} quote{s}!");
                return quotes;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting all quotes: {ex.Message}");
                throw;
            }
        }

        public Quote GetQuote(long? quoteId)
        {
            try
            {
                if (quoteId == null) return null;
                Utils.LogMessage($"Getting quote #{quoteId}...");

                var quote = Get((long)quoteId).Result;
                if (quote != null) Utils.LogMessage($"Successfully retrieved quote, {quote.QUOTATION_NAME}");
                return quote;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting quote #{quoteId}: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<Quote> SearchQuotesByFieldValue(string fieldName, object fieldValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fieldName) || fieldValue == null) return null;
                Utils.LogMessage($"Searching for quotes with {fieldValue} in {fieldName}...");

                var quotes = Search(fieldName, fieldValue).Result;
                var s = quotes != null && quotes.Count() > 1 ? "s" : string.Empty;
                if (quotes != null && quotes.Count() > 0) Utils.LogMessage($"Successfully found {quotes.Count()} quote{s}!");
                return quotes;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Searching for quotes with {fieldValue} in {fieldName}: {ex.Message}");
                throw;
            }
        }

        public Quote CreateQuote(Quote quote)
        {
            try
            {
                if (quote == null) return null;
                Utils.LogMessage($"Creating quote, {quote?.QUOTATION_NAME}...");

                quote = Create(quote).Result;
                if (quote != null) Utils.LogMessage($"Successfully created quote, {quote.QUOTE_ID}!");
                return quote;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Creating quote, {quote?.QUOTATION_NAME}: {ex.Message}");
                throw;
            }
        }

        public Quote UpdateQuote(Quote quote)
        {
            try
            {
                if (quote == null) return null;
                Utils.LogMessage($"Updating quote #{quote?.QUOTE_ID}...");

                quote = Update(quote).Result;
                if (quote != null) Utils.LogMessage($"Successfully updated quote, {quote.QUOTATION_NAME}!");
                return quote;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Updating quote #{quote?.QUOTE_ID}: {ex.Message}");
                throw;
            }
        }

        public bool DeleteQuote(long? quoteId)
        {
            try
            {
                if (quoteId == null) return false;
                Utils.LogMessage($"Deleting quote #{quoteId}...");

                var deleted = Delete((long)quoteId).Result;
                if (deleted) Utils.LogMessage($"Successfully deleted quote #{quoteId}!");
                return deleted;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Deleting quote #{quoteId}: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<QuoteLineItem>> GetLineItems(long? quoteId)
        {
            try
            {
                if (quoteId == null) return null;
                Utils.LogMessage($"Getting quote line items for quote #{quoteId}...");

                var lineItems = await apiClient.GetAsync<IEnumerable<QuoteLineItem>>($"{objectUrl}/{quoteId}/QuotationLineItem");
                var s = lineItems != null && lineItems.Count() > 1 ? "s" : string.Empty;
                if (lineItems != null && lineItems.Count() > 0) Utils.LogMessage($"Successfully retrieved {lineItems.Count()} line item{s}!");
                return lineItems;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting quote line items for quote #{quoteId}: {ex.Message}");
                throw;
            }
        }

        public async Task<QuoteLineItem> AddLineItem(long? quoteId, QuoteLineItem quoteLineItem)
        {
            try
            {
                if (quoteId == null) return null;
                Utils.LogMessage($"Creating quote line item for quote #{quoteId}...");

                var lineItem = await apiClient.PostAsync(quoteLineItem, $"{objectUrl}/{quoteId}/QuotationLineItem");
                if (lineItem != null) Utils.LogMessage($"Successfully created line item #{lineItem.QUOTATION_ITEM_ID}!");
                return lineItem;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Creating quote line item for quote #{quoteId}: {ex.Message}");
                throw;
            }
        }
    }
}
