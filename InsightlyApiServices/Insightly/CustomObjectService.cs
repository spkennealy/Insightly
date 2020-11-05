using System;
using System.Collections.Generic;
using System.Linq;
using Common.Tools;
using Models.Insightly;

namespace Services.Insightly
{
    public class CustomObjectService : CrudService<CustomObject>
    {
        private string ObjectName => ExtractObjectName(objectUrl);

        public CustomObjectService(string apiKey, string customObjName) : base(apiKey, customObjName)
        {
        }

        public IEnumerable<CustomObject> GetAllRecords()
        {
            try
            {
                Utils.LogMessage($"Getting all records for {ObjectName}...");

                var records = GetAll().Result;
                if (records != null && records.Count() > 0) Utils.LogMessage($"Successfully found {records.Count()} {ObjectName}!");
                return records;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting all records for {ObjectName}: {ex.Message}");
                throw;
            }
        }

        public CustomObject GetRecord(long? recordId)
        {
            try
            {
                if (recordId == null) return null;
                Utils.LogMessage($"Getting the {ObjectName} #{recordId}...");

                var record = Get((long)recordId).Result;
                if (record != null) Utils.LogMessage($"Successfully found {ObjectName} #{recordId}: {record.RECORD_NAME}");
                return record;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting the {ObjectName} #{recordId}: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<CustomObject> SearchRecordsByFieldValue(string fieldName, object fieldValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fieldName) || fieldValue == null) return null;
                Utils.LogMessage($"Searching for {ObjectName} with {fieldValue} in {fieldName}...");

                var records = Search(fieldName, fieldValue).Result;
                if (records != null && records.Count() > 0) Utils.LogMessage($"Successfully found {records.Count()} {ObjectName}!");
                return records;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Searching for {ObjectName} with {fieldValue} in {fieldName}: {ex.Message}");
                throw;
            }
        }

        public CustomObject CreateRecord(CustomObject record)
        {
            try
            {
                if (record == null) return null;
                Utils.LogMessage($"Creating {ObjectName}, {record?.RECORD_NAME}...");

                record = Create(record).Result;
                if (record != null) Utils.LogMessage($"Successfully created {ObjectName}, {record.RECORD_ID}!");
                return record;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Creating {ObjectName} #{record?.RECORD_NAME}: {ex.Message}");
                throw;
            }
        }

        public CustomObject UpdateRecord(CustomObject record)
        {
            try
            {
                if (record == null) return null;
                Utils.LogMessage($"Updating {ObjectName} #{record?.RECORD_ID}...");

                record = Update(record).Result;
                if (record != null) Utils.LogMessage($"Successfully updated {ObjectName}, {record.RECORD_NAME}!");
                return record;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Updating {ObjectName} #{record?.RECORD_ID}: {ex.Message}");
                throw;
            }
        }

        public bool DeleteRecord(long? recordId)
        {
            try
            {
                if (recordId == null) return false;
                Utils.LogMessage($"Deleting {ObjectName} #{recordId}...");

                var deleted = Delete((long)recordId).Result;
                if (deleted) Utils.LogMessage($"Successfully deleted {ObjectName} #{recordId}!");
                return deleted;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Deleting {ObjectName} #{recordId}: {ex.Message}");
                throw;
            }
        }

        private string ExtractObjectName(string objectUrl)
        {
            return string.Join(" ", objectUrl?.Substring(0, objectUrl.Length - 3)?.Split('_'));
        }
    }
}
