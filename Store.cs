namespace knightmoves;
public class Store
{
    // Add your code here
    public static string PriceCheck(double price)
    {
        if(price == 1.50)
        {
            return "match";
        } else
        {
            return "";
        }
    }

    public static string GuessNumber(int guess)
    {
        if(guess == 25)
        {
            return "";
        } else
        {
            return "not it";
        }
    }
}
