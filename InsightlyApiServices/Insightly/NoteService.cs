using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Tools;
using Models.Insightly;

namespace Services.Insightly
{

    public class NoteService : BaseService<Note>
    {
        public NoteService(string apiKey, string baseObj) : base(apiKey, baseObj)
        {
        }

        public IEnumerable<Note> GetNotes(long? leadId)
        {
            try
            {
                if (leadId == null) return null;
                Utils.LogMessage($"Getting lead notes...");

                var leadNotes = GetRecordNotes((long)leadId).Result;
                if (leadNotes != null || leadNotes.Count() > 0) Utils.LogMessage($"Successfully retrieved {leadNotes.Count()} notes for lead #{leadId}!");
                return leadNotes;
            }
            catch (Exception ex)
            {
                Utils.LogMessage($"Error getting lead #{leadId} notes: {ex.Message}.");
                throw;
            }
        }

        public Note AddNote(long? baseObjId, Note note)
        {
            try
            {
                if (baseObjId == null || note == null) return null;
                Utils.LogMessage($"Adding note to {objectUrl}...");

                note = Create((long)baseObjId, note).Result;
                if (note != null) Utils.LogMessage($"Successfully created note #{note} for {objectUrl} #{baseObjId}!");
                return note;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Adding note to {objectUrl} #{baseObjId}: {ex.Message}.");
                throw;
            }
        }

        private async Task<IEnumerable<Note>> GetRecordNotes(long id)
        {
            return await apiClient.GetAsync<IEnumerable<Note>>($"{objectUrl}/{id}/Notes");
        }

        private async Task<Note> Create(long id, Note note)
        {
            return await apiClient.PostAsync(note, $"{objectUrl}/{id}/Notes");
        }
    }
}
