namespace SortingTechniques
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SearchTheWordFromWordList d = new SearchTheWordFromWordList();
            d.List();
            Console.WriteLine("\nEnter word do you want to search : ");
            string Word = Console.ReadLine();
            d.Searching(Word);

        }
    }
}



