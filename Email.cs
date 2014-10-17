using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PackageTracker {
    class Email {
        private readonly string EmailFrom = ConfigurationManager.AppSettings["EmailFrom"];
        private readonly string EmailSubject = ConfigurationManager.AppSettings["EmailSubject"];
        private readonly string SmtpServer = ConfigurationManager.AppSettings["SmtpServer"];

        public static string GenerateBody(Package Parcel, Account Person) {
            string Date = DateTime.Now.ToString("MM/dd/yyyy");
            string Time = DateTime.Now.ToString("hh:mm");
            
            var Body = new StringBuilder();

            Body.Append("==================================================").AppendLine();
            Body.Append("     SVC Mailroom INBOUND PARCEL NOTIFICATION     ").AppendLine();
            Body.Append("==================================================").AppendLine();
            Body.Append("  Parcel Inbound on " + Date + " at " + Time).AppendLine();
            Body.Append("---------------- Inbound Details -----------------").AppendLine();
            Body.Append("            Name: " + Person.Firstname + " " + Person.Lastname).AppendLine();
            Body.Append(" Tracking Number: " + Parcel.UPC).AppendLine();
            Body.Append("Shipping Carrier: " + Parcel.Carrier).AppendLine();
            Body.Append("          Sender: " + Parcel.Sender).AppendLine();
            Body.Append("==================================================").AppendLine();
            Body.Append("Please wait one hour for processing").AppendLine();
            Body.Append("before picking up package!").AppendLine();

            return Body.ToString();
        }

        public void SendEmail(Package Parcel, Account Person) {
            var Email = new MailMessage();

            Email.To.Add(Person.Email);
            Email.From = new MailAddress(EmailFrom);
            Email.Body = GenerateBody(Parcel, Person);
            Email.Subject = EmailSubject;

            SmtpClient smtp = new SmtpClient(SmtpServer);
            smtp.Send(Email);
        }
    }
}
