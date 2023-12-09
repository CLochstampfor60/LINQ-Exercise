namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myList = new String[] { "The Witcher 3", "Overwatch 2", "Magic the Gathering Online", "Lorcana", "Remnant I", "Legend of Zelda", "Pokemon: Gold & Silver" };

            var orderByLengthDescending = myList.OrderByDescending(x => x.Length);

            foreach (var item in orderByLengthDescending)
            {
                Console.WriteLine(item);
            }
            /*   Console.WriteLine();*/
        }
    }
}
