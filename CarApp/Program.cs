namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bilmærke?");
            string brand = Console.ReadLine();
            Console.WriteLine("Bilmodel?");
            string model = Console.ReadLine();
            Console.WriteLine("Årgang?");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gearkasse? (A eller M)");
            
            char transM = Console.ReadLine()[0];

            Console.WriteLine("\n\nMærke: "+brand);
            Console.WriteLine("Bilmodel: "+model);
            Console.WriteLine("Årgang: "+year);
            Console.WriteLine("Gearkasse: "+transM);

            Console.WriteLine("\nBilen er en "+brand+" "+model+" fra "+year+" med "+transM+" gearkasse");

            Console.ReadLine(); /* Wait for user input to exit program */
        }
    }
}
