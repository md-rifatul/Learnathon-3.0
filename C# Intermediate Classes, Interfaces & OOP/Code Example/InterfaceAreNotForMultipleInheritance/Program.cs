using System.Drawing;

namespace InterfaceAreNotForMultipleInheritance
{
    public class Text : UiControl, IDropable, IDraggable
    {
        public void Drag()
        {
            Console.WriteLine("Drag Method");
        }

        public void Drop()
        {
            Console.WriteLine("Drop Method");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
