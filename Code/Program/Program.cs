namespace RegexPractice;

class Program {
    public static void Main() {
        bool loopContinue = true;
        string? input;

        // Explains what the program does to the user.
        System.Console.WriteLine("The default regular expression checks for at least one digit.");
        
        while (loopContinue == true) {
            try {
                System.Console.WriteLine(RegexChecker.RegexCheckerRun());
            } catch (Exception e) {
                System.Console.WriteLine(e.Message);
            }

            // Prompt user to exit or continue loop.
            System.Console.Write("Press ENTER to end or any key to try again: ");
            input = System.Console.ReadLine();
            if (input == "")
                break;
            else
                input = "";
        }

        System.Console.Write("END OF PROGRAM");
    }
}