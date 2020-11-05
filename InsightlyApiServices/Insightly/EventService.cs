using System;
using System.Collections.Generic;
using System.Linq;
using Common.Tools;
using Models.Insightly;

namespace Services.Insightly
{
    public class EventService : CrudService<Event>
    {
        public EventService(string apiKey) : base(apiKey, "Events")
        {
        }

        public IEnumerable<Event> GetAllEvents()
        {
            try
            {
                Utils.LogMessage($"Getting all events...");

                var events = GetAll().Result;
                var s = events != null && events.Count() > 1 ? "s" : string.Empty;
                if (events != null && events.Count() > 0) Utils.LogMessage($"Successfully found {events.Count()} event{s}!");
                return events;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting all events: {ex.Message}");
                throw;
            }
        }

        public Event GetEvent(long? insightlyEventId)
        {
            try
            {
                if (insightlyEventId == null) return null;
                Utils.LogMessage($"Getting event #{insightlyEventId}...");

                var insightlyEvent = Get((long)insightlyEventId).Result;
                if (insightlyEvent != null) Utils.LogMessage($"Successfully retrieved event, {insightlyEvent.TITLE}!");
                return insightlyEvent;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting event #{insightlyEventId}: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<Event> SearchEventsByFieldValue(string fieldName, object fieldValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fieldName) || fieldValue == null) return null;
                Utils.LogMessage($"Searching for events with {fieldValue} in {fieldName}...");

                var events = Search(fieldName, fieldValue).Result;
                var s = events != null && events.Count() > 1 ? "s" : string.Empty;
                if (events != null && events.Count() > 0) Utils.LogMessage($"Successfully found {events.Count()} event{s} with {fieldValue} in {fieldName}!");
                return events;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Searching for events with {fieldValue} in {fieldName}: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<Event> SearchEventsUpdatedAfterDate(object date)
        {
            try
            {
                if (date == null) return null;
                Utils.LogMessage($"Searching for events updated after {date}...");

                var events = SearchUpdatedAfterDate(date).Result;
                var s = events != null && events.Count() > 1 ? "s" : string.Empty;
                if (events != null && events.Count() > 0) Utils.LogMessage($"Successfully found {events.Count()} event{s} updated after {date}!");
                return events;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Searching for events updated after {date}: {ex.Message}");
                throw;
            }
        }

        public Event CreateEvent(Event insightlyEvent)
        {
            try
            {
                if (insightlyEvent == null) return null;
                Utils.LogMessage($"Creating event {insightlyEvent?.TITLE}...");

                insightlyEvent = Create(insightlyEvent)?.Result;
                if (insightlyEvent != null) Utils.LogMessage($"Successfully created event #{insightlyEvent.EVENT_ID}!");
                return insightlyEvent;
            }
            catch (Exception ex)
            {
                Utils.LogMessage($"Error creating event {insightlyEvent?.TITLE}: {ex.Message}");
                throw;
            }
        }

        public Event UpdateEvent(Event insightlyEvent)
        {
            try
            {
                if (insightlyEvent == null) return null;
                Utils.LogMessage($"Updating the event #{insightlyEvent.EVENT_ID}...");

                insightlyEvent = Update(insightlyEvent).Result;
                if (insightlyEvent != null) Utils.LogMessage($"Successfully updated event #{insightlyEvent.TITLE}!");
                return insightlyEvent;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Updating the event #{insightlyEvent?.EVENT_ID}: {ex.Message}");
                throw;
            }
        }

        public bool DeleteEvent(long? insightlyEventId)
        {
            try
            {
                if (insightlyEventId == null) return false;
                Utils.LogMessage($"Deleting event #{insightlyEventId}...");

                var deleted = Delete((long)insightlyEventId).Result;
                if (deleted) Utils.LogMessage($"Successfully deleted event #{insightlyEventId}!");
                return deleted;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Deleting event #{insightlyEventId}: {ex.Message}");
                throw;
            }
        }

        public static Event CopyEvent(Event insightlyEvent)
        {
            return new Event() { EVENT_ID = insightlyEvent.EVENT_ID, CUSTOMFIELDS = new List<CustomField>() };
        }
    }
}
