class Program
{
    static void Main()
    {
        var total = 0;
        var searchIndex = 0;
        var searchString = "SIAPA";

        Console.WriteLine("Input:");
        var str = Console.ReadLine();
        var index = str.IndexOf(searchString[0]);

        while (index != -1)
        {
            var sb = new System.Text.StringBuilder(str);
            sb.Remove(index, 1);
            str = sb.ToString();

            if (searchIndex == searchString.Length - 1)
            {
                searchIndex = 0;
                total++;
            }
            else
            {
                searchIndex++;
            }

            index = str.IndexOf(searchString[searchIndex]);
        }
        Console.WriteLine("Jumlah Kata yang Dihasilkan:");
        Console.WriteLine(total);
    }
}