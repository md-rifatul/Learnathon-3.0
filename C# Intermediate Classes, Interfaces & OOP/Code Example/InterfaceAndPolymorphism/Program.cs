namespace InterfaceAndPolymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.Encode(new Video());
        }
    }
}
