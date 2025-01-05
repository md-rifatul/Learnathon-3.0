namespace Downcasting
{
    public class Text : Shap
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public override void Draw()
        {
            Console.WriteLine("hello");
        }
        public void Temp()
        {
            Console.WriteLine("hi");
        }

    }
}
