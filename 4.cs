class Program
{
    static void Main()
    {
        var rubyCount = 5;
        var topazCount = 3;
        var permataCount = 1;
        
        var rubyPrice = 1000000;
        var topazPrice = 1250000;
        var permataPrice = 3000000;

        var rubyCountPair = rubyCount / 2;
        var topazCountPair = topazCount / 2;
        var permataCountPair = permataCount / 2;

        var maxProfit = rubyCountPair * rubyPrice + topazCountPair * topazPrice + permataCountPair * permataPrice;
        
        Console.WriteLine(maxProfit);
    }
}