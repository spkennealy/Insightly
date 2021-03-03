using Common.Models.Insightly;
using System.Collections.Generic;
using System.Linq;

namespace Common.Tools
{
    public static class InsightlyHelpers
    {
        public static CustomField CreateCustomField(this InsightlyCustomFieldObject obj, string fieldName, object fieldValue)
        {
            if (obj.CUSTOMFIELDS == null) obj.CUSTOMFIELDS = new List<CustomField>();
            var customField = new CustomField() { FIELD_NAME = fieldName, FIELD_VALUE = fieldValue };
            obj.CUSTOMFIELDS.Add(customField);
            return customField;
        }

        public static CustomField ExtractCustomField(this InsightlyCustomFieldObject obj, string fieldName, object fieldValue = null)
        {
            return obj?.CUSTOMFIELDS?.Where(cf => cf.FIELD_NAME == fieldName)?.FirstOrDefault() ?? CreateCustomField(obj, fieldName, fieldValue);
        }

        public static object ExtractCustomFieldValue(this InsightlyCustomFieldObject obj, string fieldName)
        {
            return obj?.CUSTOMFIELDS?.Where(cf => cf.FIELD_NAME == fieldName)?.FirstOrDefault()?.FIELD_VALUE;
        }
    }
}
