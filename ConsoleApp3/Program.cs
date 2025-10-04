namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int size = ReadSize();
            RenderBoard(size);
        
        }

        static int Readsize()
        {
            int n;
            while (true)
            {
                 Console.WriteLine("Hur stort schackbräde vill du ha? (3-50)");
}                string input = Console.ReadLine();
                if (int.TryParse(input, out n) && n >= 3 && n <= 50)
                {
                    return n;
                }
                Console.WriteLine("Ogiltig inmatning. Ange ett heltal mellan 3 och 50.");
        }
        }
    }  
