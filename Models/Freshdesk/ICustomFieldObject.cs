using System.Collections.Generic;

namespace Models.Freshdesk
{
    public interface ICustomFieldObject
    {
        long? ID { get; set; }

        Dictionary<string, object> CUSTOM_FIELDS { get; set; }
    }
}
