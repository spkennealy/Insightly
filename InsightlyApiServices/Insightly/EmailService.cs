using System;
namespace Services.Insightly
{
    public class EmailService //: BaseService<Email>
    {
        public EmailService(string apiKey) : base(apiKey, "Emails")
        {
        }
    }
}
