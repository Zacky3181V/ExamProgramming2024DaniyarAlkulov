using Utilities;
namespace UtilitiesTest
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringUtilities.LongWordsCount("Hello World a"));
            Console.WriteLine(StringUtilities.SpinalCase("tHe lOrD oF ThE RinGs"));
            Console.WriteLine(StringUtilities.ToPascalCase("tHe lOrD oF tHE rinGs"));
        }
    }
}