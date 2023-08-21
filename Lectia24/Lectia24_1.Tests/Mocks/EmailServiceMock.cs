namespace Lectia24_1.Tests.Mocks
{
    // Mock-ul serviciului de e-mail
    public class EmailServiceMock : IEmailService
    {
        public bool SendEmailCalled { get; private set; }
        public string LastRecipient { get; private set; }
        public string LastSubject { get; private set; }
        public string LastBody { get; private set; }

        public void SendEmail(string to, string subject, string body)
        {
            SendEmailCalled = true;
            LastRecipient = to;
            LastSubject = subject;
            LastBody = body;
        }
    }
}