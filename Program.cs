namespace SortingTechniques
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String s = "ABC";
            String answer = "";

            Console.Write("\nAll possible strings are : ");
            PermutationOfStringUsingRecursiveMethod.RecursiveApproach(s, answer);

        }
    }
}



