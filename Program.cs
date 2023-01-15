namespace SortingTechniques
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //String str = "DOG";
            //int n = str.Length;
            //Console.Write("\nAll possible strings are : ");
            //PermutationOfStringUsingIterativeMethod.usingIterativeMethod(str, 0, n - 1);
            String s = "ABC";
            String answer = "";

            Console.Write("\nAll possible strings are : ");
            PermutationOfStringUsingRecursiveApproach.RecursiveApproach(s, answer);



        }

    }

}



