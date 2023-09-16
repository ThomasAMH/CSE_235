internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Thomas Montoya";
        string location = "Hungary";
        DateTime today = DateTime.Now;
        DateTime christmas = new(2023, 12, 25);

        Console.WriteLine($"I am {name} from {location}");
        Console.WriteLine($"The current date: {today:mm/dd/yyyy}");
        Console.WriteLine($"The number of days until Christmas: {christmas - today:dd}");


        double width, height, woodLength, glassArea;
        string widthString, heightString;

        Console.WriteLine("Enter the width in feet");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        Console.WriteLine("Enter the height in feet");
        heightString = Console.ReadLine();
        height= double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25;

        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " + woodLength + "feet");
        Console.WriteLine("The area of the glass is " + glassArea + " square meters");

        /*Pause after execution*/

        Console.ReadKey();

    }
}