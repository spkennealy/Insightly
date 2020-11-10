using System;
using System.Collections.Generic;
using System.Linq;
using Common.Tools;
using Models.Insightly;
using CommonConstants = Tools.Constants;

namespace Services.Insightly
{
    public class OrganizationService : CrudService<Organization>
    {
        public OrganizationService(string apiKey) : base(apiKey, "Organisations")
        {
        }

        public IEnumerable<Organization> GetAllOrgs()
        {
            try
            {
                Utils.LogMessage($"Getting all orgs...");

                var orgs = GetAll().Result;
                if (orgs != null && orgs.Count() > 0) Utils.LogMessage($"Successfully found {orgs.Count()} orgs!");
                return orgs;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting all orgs: {ex.Message}");
                throw;
            }
        }

        public Organization GetOrg(long? orgId)
        {
            try
            {
                if (orgId == null) return null;
                Utils.LogMessage($"Getting the org #{orgId}...");

                var org = Get((long)orgId).Result;
                if (org != null) Utils.LogMessage($"Successfully found org #{orgId}: {org.ORGANISATION_NAME}");
                return org;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting the org #{orgId}: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<Organization> SearchOrgsByFieldValue(string fieldName, object fieldValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fieldName) || fieldValue == null) return null;
                Utils.LogMessage($"Searching for orgs with {fieldValue} in {fieldName}...");

                var orgs = Search(fieldName, fieldValue).Result;
                if (orgs != null && orgs.Count() > 0) Utils.LogMessage($"Successfully found {orgs.Count()} orgs!");
                return orgs;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Searching for orgs with {fieldValue} in {fieldName}: {ex.Message}");
                throw;
            }
        }

        public Organization SearchOrgsByFieldValueExactMatch(string fieldName, object fieldValue)
        {
            var orgs = SearchOrgsByFieldValue(fieldName, fieldValue);

            Organization org = null;
            if (fieldName.Contains("__c") || fieldName.Contains(CommonConstants.ORGANISATION_FIELD))
            {
                org = orgs?.Where(o => Utils.ExtractCustomFieldValue(o, fieldName)?.ToString()?.ToLower() == fieldValue?.ToString()?.ToLower())?.FirstOrDefault();
            }
            else
            {
                org = orgs?.Where(o => typeof(Organization)?.GetProperty(fieldName)?.GetValue(o)?.ToString()?.ToLower() == fieldValue?.ToString()?.ToLower())?.FirstOrDefault();
            }

            if (org != null) Utils.LogMessage($"Extracted first matching org #{org?.ORGANISATION_ID}");
            return org;
        }

        public IEnumerable<Organization> SearchOrgsUpdatedAfterDate(object date)
        {
            try
            {
                if (date == null) return null;
                Utils.LogMessage($"Searching for orgs updated after {date}...");

                var orgs = SearchUpdatedAfterDate(date).Result;
                var s = orgs != null && orgs.Count() > 1 ? "s" : string.Empty;
                if (orgs != null && orgs.Count() > 0) Utils.LogMessage($"Successfully found {orgs.Count()} org{s} updated after {date}!");
                return orgs;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Searching for orgs updated after {date}: {ex.Message}");
                throw;
            }
        }

        public Organization CreateOrg(Organization org)
        {
            try
            {
                if (org == null) return null;
                Utils.LogMessage($"Creating org, {org?.ORGANISATION_NAME}...");

                org = Create(org).Result;
                if (org != null) Utils.LogMessage($"Successfully created org #{org.ORGANISATION_ID}!");
                return org;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Creating org #{org?.ORGANISATION_NAME}: {ex.Message}");
                throw;
            }
        }

        public Organization UpdateOrg(Organization org)
        {
            try
            {
                if (org == null) return null;
                Utils.LogMessage($"Updating org #{org.ORGANISATION_ID}...");

                org = Update(org).Result;
                if (org != null) Utils.LogMessage($"Successfully updated org, {org.ORGANISATION_NAME}!");
                return org;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Updating org #{org?.ORGANISATION_ID}: {ex.Message}");
                throw;
            }
        }

        public bool DeleteOrg(long? orgId)
        {
            try
            {
                if (orgId == null) return false;
                Utils.LogMessage($"Deleting org #{orgId}...");

                var deleted = Delete((long)orgId).Result;
                if (deleted) Utils.LogMessage($"Successfully deleted org #{orgId}!");
                return deleted;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Deleting org #{orgId}: {ex.Message}");
                throw;
            }
        }

        public static Organization CopyOrg(Organization org)
        {
            return new Organization() { ORGANISATION_ID = org.ORGANISATION_ID, CUSTOMFIELDS = new List<CustomField>() };
        }
    }
}
