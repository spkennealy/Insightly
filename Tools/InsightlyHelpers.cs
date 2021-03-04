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

        public static Project SetProjectCustomFieldValue(this Project project, string fieldName, object value)
        {
            if (project == null || fieldName == null) return project;
            var field = ExtractCustomField(project, fieldName, value);
            field.FIELD_VALUE = value;
            return project;
        }

        public static Link BuildLink(string objName, long? objId, string linkObjName, long? linkObjId)
        {
            if (objId == null || linkObjId == null) return null;
            Utils.LogMessage($"Building link...");

            return new Link()
            {
                OBJECT_NAME = objName,
                OBJECT_ID = objId,
                LINK_OBJECT_NAME = linkObjName,
                LINK_OBJECT_ID = linkObjId
            };
        }
    }
}
