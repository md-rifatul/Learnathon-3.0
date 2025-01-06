namespace InterfaceAndPolymorphism
{
    public class MailService
    {
        public void Send(MailService mail)
        {
            Console.WriteLine("Sending email...");
        }
    }
}
