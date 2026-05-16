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
        // Step 1: Create a new array of doubles with the requested length.
        // Step 2: Loop from index 0 up to length - 1.
        // Step 3: For each index, calculate the multiple by multiplying number by index + 1.
        //         We use index + 1 because the first multiple of a number is number * 1, not number * 0.
        // Step 4: Store the calculated multiple in the array.
        // Step 5: Return the completed array.

        double[] multiples = new double[length];
        

        for (int index = 0; index < length; index++)
        {
            multiples[index] = number * (index + 1);
        }

        return multiples;
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
        // Step 1: Find the point where the rotated list should split.
        //         If the list has 9 items and amount is 3, the last 3 items start at index 6.
        // Step 2: Copy the last 'amount' items into a temporary list.
        // Step 3: Copy the remaining first part of the list into another temporary list.
        // Step 4: Clear the original list.
        // Step 5: Add the last items first.
        // Step 6: Add the original first items after them.
        //         This modifies the original list instead of returning a new one.

        int splitIndex = data.Count - amount;

        List<int> rightPart = data.GetRange(splitIndex, amount);
        List<int> leftPart = data.GetRange(0, splitIndex);

        data.Clear();
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}