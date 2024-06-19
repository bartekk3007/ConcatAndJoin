namespace ConcatAndJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] strArray = { "abecadlo", "banan", "cebula", "dynia", "ekran", "flet" };

            string numString = string.Concat(numArray);
            Console.WriteLine(numString);

            string strString = string.Join(", ", strArray);
            Console.WriteLine(strString);
        }
    }
}
