using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Tools;
using Models.Insightly;

namespace Services.Insightly
{
    public class LinkService : BaseService<Link>
    {
        public LinkService(string apiKey, string baseObj) : base(apiKey, baseObj)
        {
        }

        private async Task<IEnumerable<Link>> Get(long id)
        {
            return await apiClient.GetAsync<IEnumerable<Link>>($"{objectUrl}/{id}/Links");
        }

        private async Task<Link> Create(long id, Link link)
        {
            return await apiClient.PostAsync(link, $"{objectUrl}/{id}/Links");
        }

        private async Task<bool> Delete(long id, long? linkId)
        {
            return await apiClient.DeleteAsync<Link>($"{objectUrl}/{id}/Links/{linkId}");
        }

        public IEnumerable<Link> GetLinks(long? id)
        {
            try
            {
                if (id == null) return null;
                Utils.LogMessage($"Getting links for {objectUrl.Substring(0, objectUrl.Length - 1)} #{id}...");

                var links = Get((long)id)?.Result;
                var s = links != null && links.Count() > 1 ? "s" : string.Empty;
                if (links != null && links.Count() > 0) Utils.LogMessage($"Successfully retrieved {links.Count()} link{s}!");
                return links;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting links for {objectUrl.Substring(0, objectUrl.Length - 1)} #{id}: {ex.Message}");
                throw;
            }
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

        public Link CreateLink(Link link)
        {
            try
            {
                if (link == null || link?.OBJECT_ID == null) return null;
                Utils.LogMessage($"Creating link between {link.OBJECT_NAME} #{link.OBJECT_ID} and {link.LINK_OBJECT_NAME} #{link.LINK_OBJECT_ID}...");

                link = Create((long)link.OBJECT_ID, link).Result;
                if (link != null) Utils.LogMessage($"Successfully created link #{link.LINK_ID}");
                return link;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Creating link between {link.OBJECT_NAME} #{link.OBJECT_ID} and {link.LINK_OBJECT_NAME} #{link.LINK_OBJECT_ID}: {ex.Message}");
                throw;
            }
        }

        public bool DeleteLink(long? baseObjId, long? linkId)
        {
            try
            {
                if (baseObjId == null || linkId == null) return false;
                Utils.LogMessage($"Deleting {objectUrl.Substring(0, objectUrl.Length - 1)} link #{linkId}...");

                var deleted = Delete((long)baseObjId, (long)linkId).Result;
                if (deleted) Utils.LogMessage($"Successfully deleted link #{linkId}!");
                return deleted;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Deleting {objectUrl.Substring(0, objectUrl.Length - 1)} link #{linkId}: {ex.Message}");
                throw;
            }
        }
    }
}
