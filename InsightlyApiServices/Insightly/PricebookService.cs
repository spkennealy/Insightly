using System.Collections.Generic;
using System.Threading.Tasks;
using Models.Insightly;

namespace Services.Insightly
{
    public class PricebookService : CrudService<Pricebook>
    {
        public PricebookService(string apiKey) : base(apiKey, "Pricebook")
        {
        }

        public async Task<IEnumerable<PricebookEntry>> GetPricebookEntries(long pricebookId)
        {
            return await GetByUrlAsync<IEnumerable<PricebookEntry>>($"{pricebookId}/PricebookEntry");
        }
    }
}
