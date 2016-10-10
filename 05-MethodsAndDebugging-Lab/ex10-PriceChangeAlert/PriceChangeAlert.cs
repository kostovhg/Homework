using System;

class PriceChangeAlert
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        double thresholdValue = double.Parse(Console.ReadLine());

        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < N - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = Percent(lastPrice, currentPrice);
            bool isSignificantDifference = thresholdCheck(difference, thresholdValue);
            string message = resultMsg(currentPrice, lastPrice, difference, isSignificantDifference);
            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    private static string resultMsg(double currentPrice, double lastPrice, double difference, bool overThreshold)
    {
        string to = "";
        if (difference == 0)
        {
            to = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!overThreshold)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
        }
        else if (overThreshold && (difference > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
        }
        else if (overThreshold && (difference < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
        return to;
    }

    private static bool thresholdCheck(double granica, double isDiff)
    {
        if (Math.Abs(granica) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double Percent(double initialPrice, double currentPrice)
    {
        double result = (currentPrice - initialPrice) / initialPrice;
        return result;
    }
}