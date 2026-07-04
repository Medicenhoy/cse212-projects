using System;
using System.Collections.Generic;

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
        // TODO Problem 1 Start
        
        // Plan:
        // First I need to create an empty array of doubles with the size of 'length' to hold the answers.
        // Then I'll use a for loop that runs 'length' times.
        // Inside the loop, I'll multiply the starting 'number' by (i + 1) to get the multiples,
        // because the loop starts at 0 and I don't want to multiply by zero.
        // Save each result in the array and return it at the end.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result; 
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
        // TODO Problem 2 Start
        
        // Plan:
        // Rotating right basically means taking a chunk from the end of the list and moving it to the front.
        // I need to figure out where to cut the list first, which is the total count minus the 'amount'.
        // I'll grab that end piece using GetRange and save it in a temporary list.
        // Then I have to delete that piece from the end of the original list so it's not duplicated.
        // Finally, I'll just insert that saved piece at index 0 (the beginning) using InsertRange.
        
        int splitIndex = data.Count - amount;
        
        List<int> slice = data.GetRange(splitIndex, amount);
        
        data.RemoveRange(splitIndex, amount);
        
        data.InsertRange(0, slice);
    }
}