using System.Collections.Generic;

namespace Models.Insightly.Interfaces
{
    public interface IInsightlyCustomFieldObject
    {
        List<CustomField> CUSTOMFIELDS { get; set; }
    }
}
