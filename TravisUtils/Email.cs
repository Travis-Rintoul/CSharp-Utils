using System.Net.Mail;

namespace TravisUtils
{

    public class Email
    {
        public static SmtpClient Smtp { get; set; }
        
        private string _To { get; set; }
        public string To
        {
            get { return _To; }
            set { _To = value; }
        }
        
        private string _From { get; set; }
        public string From
        {
            get { return _From; }
            set { _From = value; }
        }
        
        private string _Subject { get; set; }
        public string Subject
        {
            get { return _Subject; }
            set { _Subject = value; }
        }
        
        private string _Body { get; set; }
        public string Body
        {
            get { return _Body; }
            set { _Body = value; }
        }

        public void Send()
        {
            Smtp.Send(From, To, Subject, Body);
        }
    }
}

