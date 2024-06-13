namespace basicC_
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;
            Console.CursorVisible = false;
            int x = 5;
            int y = 5;
            while (true)
            {
                ConsoleKeyInfo k = Console.ReadKey(true);

                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write(" ");
                if (k.Key == ConsoleKey.LeftArrow && x > 0)
                {
                    x--;
                }
                else if (k.Key == ConsoleKey.RightArrow && x <= Console.WindowWidth)
                {
                    x++;
                }
                else if (k.Key == ConsoleKey.UpArrow && y > 0)
                {
                    y--;
                }
                else if (k.Key == ConsoleKey.DownArrow && y <= Console.WindowHeight)
                {
                    y++;
                }
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.WriteLine((char)1);
            }
            Thread.Sleep(15);
        }
    }
}
 
