public static class UniqueLetters {
    public static void Run() {
        var test1 = "abcdefghjiklmnopqrstuvwxyz"; // Expect True because all letters unique
        Console.WriteLine(AreUniqueLetters(test1));

        var test2 = "abcdefghjiklanopqrstuvwxyz"; // Expect False because 'a' is repeated
        Console.WriteLine(AreUniqueLetters(test2));

        var test3 = "";
        Console.WriteLine(AreUniqueLetters(test3)); // Expect True because its an empty string
    }

    /// <summary>Determine if there are any duplicate letters in the text provided</summary>
    /// <param name="text">Text to check for duplicate letters</param>
    /// <returns>true if all letters are unique, otherwise false</returns>
    private static bool AreUniqueLetters(string text) {
        // TODO Problem 1 - Replace the O(n^2) algorithm to use sets and O(n) efficiency
        var seen = new HashSet<char>();
        foreach (char letter in text)
    {
        if (seen.Contains(letter))
            return false;

        seen.Add(letter);
    }

        return true;
    }
}


///How can unique letter method be written with O(n) performance using a set?
/// You can write it with O(n) performance by using a set to keep track of the 
/// letters you have already seen. As you go through each character once, check 
/// if it is in the set. If it is, the letter is not unique. If it is not, add 
/// it to the set and continue. Since set lookups and insertions are O(1) on 
/// average, the whole algorithm runs in O(n).
