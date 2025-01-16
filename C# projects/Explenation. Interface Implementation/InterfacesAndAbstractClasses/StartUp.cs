namespace InterfacesAndAbstractClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Woman woman = new Woman();
            Kid kid = new Kid();

            man.Run();
            woman.Run();
            kid.Run();
        }
    }
}
