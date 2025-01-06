namespace InterfaceAndPolymorphism
{
    public class SmsNotificationChannel : INotinficationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");

        }
    }
}
