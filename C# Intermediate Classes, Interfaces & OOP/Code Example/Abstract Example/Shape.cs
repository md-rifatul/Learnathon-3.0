namespace Abstract_Example
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Hight { get; set; }
        public abstract void Draw();
        public void Copy()
        {
            Console.WriteLine("This is copy method");
        }
    }
}
