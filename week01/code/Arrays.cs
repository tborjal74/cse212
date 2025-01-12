using System.Diagnostics;
using System.Globalization;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {

        // Step 1. Create an array to hold the numbers
        double [] result = new double[length];
        // Step 2. Create a for loop that will display the multiples given the length and number.
        for(int i = 0; i < length; i++ ){
            result [i] = number * (i + 1);
        }
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Step 3. Return the result 
        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1. Set condition for the list, data and amount of rotation.
        if(data == null || data.Count == 0 || amount <= 0)
        return;
        
        // Step 2. Make sure that the amount of rotation is within the length of the amount
        int count = data.Count;
        amount %= count; 

        // Step 3. Split the list into two parts
        List<int> lastPart = data.GetRange(count - amount, amount);
        List<int> firstPart = data.GetRange(0, count - amount);

        // Step 4. Reconstruct the list after clearing
        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(firstPart);

        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
