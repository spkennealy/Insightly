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

        public static string GetStandardFieldLabel(string fieldName)
        {
            switch (fieldName)
            {
                case "ACTUAL_CLOSE_DATE":
                    return "Actual Close Date";
                case "BID_AMOUNT":
                    return "Bid";
                case "BID_CURRENCY":
                    return "Bid Currency";
                case "BID_DURATION":
                    return "Bid Duration";
                case "BID_TYPE":
                    return "Bid Type";
                case "CATEGORY_ID":
                    return "Category ID";
                case "OPPORTUNITY_STATE":
                    return "Current State";
                case "LAST_ACTIVITY_DATE_UTC":
                    return "Date of Last Activity UTC";
                case "NEXT_ACTIVITY_DATE_UTC":
                    return "Date of Next Activity UTC";
                case "OPPORTUNITY_DETAILS":
                    return "Description";
                case "FORECAST_CLOSE_DATE":
                    return "Forecast Close Date UTC";
                case "DATE_CREATED_UTC":
                    return "Opportunity Created";
                case "OPPORTUNITY_NAME":
                    return "Opportunity Name";
                case "ORGANISATION_ID":
                    return "Organization ID";
                case "PIPELINE_ID":
                    return "Pipeline ID";
                case "PROBABILITY":
                    return "Probability Of Winning";
                case "OPPORTUNITY_ID":
                    return "Record ID";
                case "STAGE_ID":
                    return "Stage ID";
                case "RESPONSIBLE_USER_ID":
                    return "User Responsible ID";
                default:
                    return fieldName;
            }
        }

        public static string ExtractIdFromUrl(this string url)
        {
            var splitUrl = url.Split('/');
            return splitUrl[splitUrl.Length - 1];
        }
        
        public static double? SumNumericCustomFieldOnMultipleRecords(this IEnumerable<InsightlyCustomFieldObject> insightlyObjects, string fieldName)
        {
            if (insightlyObjects == null || insightlyObjects.Count() == 0 || string.IsNullOrWhiteSpace(fieldName)) return null;
            double? sum = 0;

            foreach (var record in insightlyObjects)
            {
                double fieldAmount = double.TryParse(record.ExtractCustomFieldValue(fieldName)?.ToString(), out double amt) ? amt : 0;
                sum += fieldAmount;
            }

            return sum;
        }
    }
}
