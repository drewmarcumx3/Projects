
public class Validator
{
    private int [] valid = { 5658845, 4520125, 7895122, 8777541,
                             8451277, 1302850, 8080152, 4562555,
                             5552012, 5050552, 7825877, 1250255,
                             1005231, 6545231, 3852085, 7576651,
                             7881200, 4581002 };
    /**
     * @param int number
     * @return found
     */
    public boolean isValid(int number)
    {
        boolean found = false; 
        int index = 0;

        while (!found && index < valid.length)
        {
            if (valid[index] == number)
                found = true;
            else
                index++;
        }

        return found;
    }
}