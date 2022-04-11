namespace TwoDiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intArr = new int[,] { { 1, 0, 0, 2 }, { 0, 1, 0, 0 }, { 0, 0, 1, 1 }, { 0, 1, 2, 1 } };
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; ++j)
                {
                    Console.Write("\t {0}", intArr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}