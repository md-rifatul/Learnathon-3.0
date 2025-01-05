namespace Method_Overriding

{
    public class ClassB:ClassA
    {
        public override void Display()
        {
            Console.WriteLine("This is class B");
            base.Display();
        }
    }
}
