namespace knightmoves;
public class Store
{
    // Add your code here
    public string PriceCheck(double price)
    {
        if(price == 1.50)
        {
            return "match";
        } else
        {
            return "";
        }
    }

    public string GuessNumber(int guess)
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
