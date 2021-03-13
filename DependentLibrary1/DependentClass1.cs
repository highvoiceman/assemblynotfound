using MissingLibrary1;


namespace DependentLibrary1
{
    public class DependentClass1
    {
        public void DoSomething()
        {
            var missing1 = new MissingClass1();
            missing1.DoSomething();
        }
    }
}
