namespace RegexPractice;
using System.Text.RegularExpressions;

/// <summary>
/// Prompts the user to enter a regular expression or press ENTER to use the default regular expression.
/// Then the program prompts the user to enter an input to compare it to the regex.
/// The programs compares the input and regular expression and returns either true or false.
/// </summary>
public class RegexChecker
{
    public static bool RegexCheckerRun() {
        string? regex, inputToMatch;
        string defaultRegex = "^[a-z]";

        // Query
        System.Console.Write("The default regular expression checks for at least one digit.\nEnter a regular expression (or press ENTER to use the default): ");
        regex = System.Console.ReadLine();

        if (regex is null) 
            throw new Exception("Null value");

        System.Console.Write("Enter the input to match: ");
        inputToMatch = System.Console.ReadLine();

        if (inputToMatch is null)
            throw new Exception("inputToMatch is null");

        // If the regex is empty, then use default regex.
        if (regex == "")
            regex = defaultRegex;
        
        return Regex.IsMatch(inputToMatch, regex);
    }
}
