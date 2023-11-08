namespace Challenge2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the stock prices separated by commas (e.g., 100,180,260,310,40,535,695):");
            string input = Console.ReadLine();
            int[] prices = Array.ConvertAll(input.Split(','), int.Parse);
            string result = MaxProfit(prices);
            Console.WriteLine(result);
        }

        public static string MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
            {
                return "-1";
            }

            int minPrice = prices[0];
            int maxProfit = 0;
            int buyDay = 0;
            int sellDay = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                    buyDay = i;
                }
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                    sellDay = i;
                }
            }

            if (maxProfit == 0)
            {
                return "-1";
            }
            else
            {
                return $"Buy on day {buyDay + 1} at price {minPrice}\nSell on day {sellDay + 1} at price {prices[sellDay]}\nMax profit: {maxProfit}";
            }
        }
    }
}