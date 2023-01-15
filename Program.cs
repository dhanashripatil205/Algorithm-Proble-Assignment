namespace SortingTechniques
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String str = "CAT";
            int n = str.Length;
            Console.Write("\nAll possible strings are : ");
            PermutationOfStringUsingIterativeMethod.usingIterativeMethod(str, 0, n - 1);
        }
    }
}



