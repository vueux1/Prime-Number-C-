namespace Asal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool control = false; 
            for(int i = 500; i <= 600; i++) 
            {
                for(int j = 2; j < i; j++)
                {
                    if ((i % j == 0)) { control = true; break; }
                }
                // display numbers side by side
                if (control == false) { Console.Write(i + ", "); }
                control = false;
            }
            
            Console.ReadKey();
        }
    }
}