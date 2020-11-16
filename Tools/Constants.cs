namespace Tools
{
    public static class Constants
    {
        // API OPTIONS
        public const int TOP_500 = 500;

        // LAMBDA INPUT OPTIONS
        public const string CREATED = "Created";
        public const string UPDATED = "Updated";
        public const string EDIT = "EDIT";

        // STANDARD OBJECTS
        public const string TASKS = "Tasks";
        public const string LEAD = "Lead";
        public const string LEADS = "Leads";
        public const string CONTACT = "Contact";
        public const string CONTACTS = "Contacts";
        public const string ORGANISATION = "Organisation";
        public const string ORGANISATIONS = "Organisations";
        public const string OPPORTUNITY = "Opportunity";
        public const string OPPORTUNITIES = "Opportunities";
        public const string PROJECT = "Project";
        public const string PROJECTS = "Projects";
        public const string EVENT = "Event";
        public const string EVENTS = "Events";
        public const string PIPELINES = "Pipelines";

        // SHARED FIELDS
        public const string DATE_CREATED_UTC = "DATE_CREATED_UTC";
        public const string DATE_UPDATED_UTC = "DATE_UPDATED_UTC";
        public const string TAGS = "TAGS";
        public const string OWNER_USER_ID = "OWNER_USER_ID";
        public const string CREATED_USER_ID = "CREATED_USER_ID";
        public const string RESPONSIBLE_USER_ID = "RESPONSIBLE_USER_ID";

        // LEAD FIELDS
        public const string LEAD_EMAIL = "EMAIL";

        // CONTACT FIELDS
        public const string CONTACT_FIRST_NAME = "FIRST_NAME";
        public const string CONTACT_LAST_NAME = "LAST_NAME";
        public const string CONTACT_EMAIL_ADDRESS = "EMAIL_ADDRESS";
        public const string CONTACT_PHONE = "PHONE";
        public const string CONTACT_PHONE_HOME = "PHONE_HOME";
        public const string CONTACT_PHONE_MOBILE = "PHONE_MOBILE";
        public const string CONTACT_PHONE_OTHER = "PHONE_OTHER";
        public const string CONTACT_TITLE = "TITLE";
        public const string CONTACT_ASSISTANT_NAME = "ASSISTANT_NAME";
        public const string CONTACT_PHONE_ASSISTANT = "PHONE_ASSISTANT";
        public const string CONTACT_DATE_OF_BIRTH = "DATE_OF_BIRTH";
        public const string CONTACT_BACKGROUND = "BACKGROUND";
        public const string CONTACT_SOCIAL_FACEBOOK = "SOCIAL_FACEBOOK";
        public const string CONTACT_SOCIAL_LINKEDIN = "SOCIAL_LINKEDIN";
        public const string CONTACT_SOCIAL_TWITTER = "SOCIAL_TWITTER";
        public const string CONTACT_ADDRESS_MAIL_STREET = "ADDRESS_MAIL_STREET";
        public const string CONTACT_ADDRESS_MAIL_CITY = "ADDRESS_MAIL_CITY";
        public const string CONTACT_ADDRESS_MAIL_STATE = "ADDRESS_MAIL_STATE";
        public const string CONTACT_ADDRESS_MAIL_POSTCODE = "ADDRESS_MAIL_POSTCODE";
        public const string CONTACT_ADDRESS_MAIL_COUNTRY = "ADDRESS_MAIL_COUNTRY";
        public const string CONTACT_ADDRESS_OTHER_STREET = "ADDRESS_OTHER_STREET";
        public const string CONTACT_ADDRESS_OTHER_CITY = "ADDRESS_OTHER_CITY";
        public const string CONTACT_ADDRESS_OTHER_STATE = "ADDRESS_OTHER_STATE";
        public const string CONTACT_ADDRESS_OTHER_POSTCODE = "ADDRESS_OTHER_POSTCODE";
        public const string CONTACT_ADDRESS_OTHER_COUNTRY = "ADDRESS_OTHER_COUNTRY";

        // ORGANIZATION FIELDS
        public const string ORGANISATION_ID = "ORGANISATION_ID";
        public const string ORGANISATION_NAME = "ORGANISATION_NAME";
        public const string ORG_EMAIL = "ORGANISATION_FIELD_21";
        public const string ORGANISATION_FIELD = "ORGANISATION_FIELD";
        public const string ORGANISATION_PHONE = "PHONE";
        public const string ORGANISATION_PHONE_FAX = "PHONE_FAX";
        public const string ORGANISATION_ADDRESS_BILLING_STREET = "ADDRESS_BILLING_STREET";
        public const string ORGANISATION_ADDRESS_BILLING_CITY = "ADDRESS_BILLING_CITY";
        public const string ORGANISATION_ADDRESS_BILLING_STATE = "ADDRESS_BILLING_STATE";
        public const string ORGANISATION_ADDRESS_BILLING_POSTCODE = "ADDRESS_BILLING_POSTCODE";
        public const string ORGANISATION_ADDRESS_BILLING_COUNTRY = "ADDRESS_BILLING_COUNTRY";
        public const string ORGANISATION_ADDRESS_SHIP_STREET = "ADDRESS_SHIP_STREET";
        public const string ORGANISATION_ADDRESS_SHIP_CITY = "ADDRESS_SHIP_CITY";
        public const string ORGANISATION_ADDRESS_SHIP_STATE = "ADDRESS_SHIP_STATE";
        public const string ORGANISATION_ADDRESS_SHIP_POSTCODE = "ADDRESS_SHIP_POSTCODE";
        public const string ORGANISATION_ADDRESS_SHIP_COUNTRY = "ADDRESS_SHIP_COUNTRY";
        public const string ORGANISATION_BACKGROUND = "BACKGROUND";
        public const string ORGANISATION_EMAIL_DOMAIN = "EMAIL_DOMAIN";
        public const string ORGANISATION_WEBSITE = "WEBSITE";
        public const string ORGANISATION_SOCIAL_FACEBOOK = "SOCIAL_FACEBOOK";
        public const string ORGANISATION_SOCIAL_LINKEDIN = "SOCIAL_LINKEDIN";
        public const string ORGANISATION_SOCIAL_TWITTER = "SOCIAL_TWITTER";

        // OPPORTUNITY FIELDS
        public const string OPPORTUNITY_ID = "OPPORTUNITY_ID";
        public const string OPPORTUNITY_NAME = "OPPORTUNITY_NAME";
        public const string OPPORTUNITY_DETAILS = "OPPORTUNITY_DETAILS";
        public const string PROBABILITY = "PROBABILITY";
        public const string OPEN = "OPEN";
        public const string WON = "WON";
        public const string LOST = "LOST";
        public const string SUSPENDED = "SUSPENDED";
        public const string ABANDONED = "ABANDONED";

        // PROJECT FIELDS
        public const string PROJECT_NAME = "PROJECT_NAME";
        public const string PROJECT_DETAILS = "PROJECT_DETAILS";
        public const string PROJECT_STATUS = "STATUS";
        public const string PROJECT_NOT_STARTED = "NOT STARTED";
        public const string PROJECT_IN_PROGRESS = "IN PROGRESS";
        public const string PROJECT_DEFERRED = "DEFERRED";
        public const string PROJECT_CANCELLED = "CANCELLED";
        public const string PROJECT_COMPLETED = "COMPLETED";

        // PRODUCT FIELDS
        public const string PRODUCT_SKU = "PRODUCT_SKU";
        public const string PRODUCT_ID = "PRODUCT_ID";
        public const string PRODUCT_FAMILY = "PRODUCT_FAMILY";

        // EVENT FIELDS
        public const string EVENT_TITLE = "TITLE";
        public const string EVENT_DETAILS = "DETAILS";
        public const string EVENT_ALL_DAY = "ALL_DAY";
        public const string EVENT_START_DATE = "START_DATE_UTC";
        public const string EVENT_END_DATE = "END_DATE_UTC";

        // QUOTE FIELDS
        public const string QUOTE_DRAFT = "Draft";

        // TASK FIELDS
        public const int HIGH_PRIORITY = 3;
        public const int MEDIUM_PRIORITY = 2;
        public const int LOW_PRIORITY = 1;

        // USER FIELDS
        public const string PROFILE_ID = "PROFILE_ID";

        // LINK FIELDS
        public const string ORGANIZATION = "Organization";
        public const string TASK = "Task";

        // CUSTOM OBJECT FIELDS
        public const string RECORD_NAME = "RECORD_NAME";
    }
}
