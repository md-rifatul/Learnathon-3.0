namespace InterfaceAndPolymorphism
{
    public class MailNotificationChannel : INotinficationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail...");
        }
    }
}
