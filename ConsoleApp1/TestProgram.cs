namespace MyTestProject
{
    public class TestProgram
    {
        public static int RandomInt()
        {
            Random rnd = new Random();
            int value = rnd.Next();
            return value;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RandomInt());
            Console.WriteLine(RandomInt());
            Console.WriteLine(RandomInt());
        }
    }
}
