using System.Threading.Tasks;
using Models.Insightly.CustomFieldDetails;

namespace Services.Insightly
{
    public class CustomFieldService : BaseService<CustomFieldDetail>
    {
        public CustomFieldService(string apiKey, string baseObj) : base(apiKey, $"CustomFields/{baseObj}")
        {
        }

        public async Task<CustomFieldDetail> SearchByFieldName(string field)
        {
            return await GetByUrlAsync<CustomFieldDetail>($"Search?fieldName={field}");
        }
    }
}
