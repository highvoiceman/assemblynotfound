using DependentLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dependent1 = new DependentClass1();
            dependent1.DoSomething();
        }
    }
}
