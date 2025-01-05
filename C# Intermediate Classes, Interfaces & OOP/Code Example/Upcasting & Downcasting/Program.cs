namespace Upcasting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shap text = new Text();
            //Shap shap = text;
            text.Width = 200;
            text.Width = 100;
            Console.WriteLine(text.Width);


        }
    }
}
