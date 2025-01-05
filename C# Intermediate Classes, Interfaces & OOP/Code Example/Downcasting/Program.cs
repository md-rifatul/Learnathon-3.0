namespace Downcasting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shap shap = new Text(); //upcasting
            Text text = (Text)shap;  //downcasting
            shap.Draw();  //upcasting
            text.Temp(); //downcasting

        }
    }
}
