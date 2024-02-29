namespace exersize_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many even number?");
            int maxNumber = int.Parse(Console.ReadLine());
            int loopCounter;
            // print even unumbers up to requested max
            for (loopCounter = 0; loopCounter < maxNumber; loopCounter += 2)
            {
                Console.WriteLine(loopCounter);
                   
            }
        }
    }
}