using System;
using System.Collections.Generic;
using Common.Tools;
using Models.Insightly;

namespace Services.Insightly
{
    public class ContactService : CrudService<Contact>
    {
        public ContactService(string apiKey) : base(apiKey, "Contacts")
        {
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            try
            {
                Utils.LogMessage($"Getting all contacts...");

                var contacts = GetAll().Result;
                var s = contacts != null && contacts.Count() > 1 ? "s" : string.Empty;
                if (contacts != null && contacts.Count() > 0) Utils.LogMessage($"Successfully found {contacts.Count()} contact{s}!");
                return contacts;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting all contacts: {ex.Message}");
                throw;
            }
        }

        public Contact GetContact(long? contactId)
        {
            try
            {
                if (contactId == null) return null;
                Utils.LogMessage($"Getting contact #{contactId}...");

                var contact = Get((long)contactId)?.Result;
                if (contact != null) Utils.LogMessage($"Successfully retrieved contact, {contact.FIRST_NAME} {contact.LAST_NAME}!");
                return contact;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting contact #{contactId}: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<Contact> SearchContactsByFieldValue(string fieldName, object fieldValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fieldName) || fieldValue == null) return null;
                Utils.LogMessage($"Searching for contacts with {fieldValue} in {fieldName}...");

                var contacts = Search(fieldName, fieldValue)?.Result;
                var s = contacts != null && contacts.Count() > 1 ? "s" : string.Empty;
                if (contacts != null && contacts.Count() > 0) Utils.LogMessage($"Successfully found {contacts.Count()} matching contact{s}!");
                return contacts?.Count() > 0 ? contacts : null;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Searching for contacts with {fieldValue} in {fieldName}: {ex.Message}");
                return null;
            }
        }

        public Contact CreateContact(Contact contact)
        {
            try
            {
                if (contact == null) return null;
                Utils.LogMessage($"Creating contact {contact?.FIRST_NAME} {contact?.LAST_NAME}...");

                contact = Create(contact)?.Result;
                if (contact != null) Utils.LogMessage($"Successfully created contact #{contact.CONTACT_ID}!");
                return contact;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Creating contact {contact?.FIRST_NAME} {contact?.LAST_NAME}: {ex.Message}");
                throw;
            }
        }

        public Contact UpdateContact(Contact contact)
        {
            try
            {
                if (contact == null) return null;
                Utils.LogMessage($"Updating contact {contact?.FIRST_NAME} {contact?.LAST_NAME}...");

                contact = Update(contact)?.Result;
                if (contact != null) Utils.LogMessage($"Successfully updated contact #{contact.CONTACT_ID}!");
                return contact;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Updating contact {contact?.FIRST_NAME} {contact?.LAST_NAME}: {ex.Message}");
                throw;
            }
        }

        public bool DeleteContact(long? contactId)
        {
            try
            {
                if (contactId == null) return false;
                Utils.LogMessage($"Deleting contact #{contactId}...");

                var deleted = Delete((long)contactId).Result;
                if (deleted) Utils.LogMessage($"Successfully deleted contact #{contactId}!");
                return deleted;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Deleting contact #{contactId}: {ex.Message}");
                throw;
            }
        }

        public static Contact CopyContact(Contact contact)
        {
            return new Contact() { CONTACT_ID = contact.CONTACT_ID, CUSTOMFIELDS = new List<CustomField>() };
        }
    }
}
