using System;

class ClassifiedMailFilter
{
    // List of keywords that might indicate classified information
    static string[] classifiedKeywords = { "top secret", "classified", "confidential", "restricted" };

    static void Main()
    {
        // Sample incoming email text (replace this with actual email text)
        string emailText = "Please find attached the confidential document containing top secret information.";

        // Check if email contains any classified keywords
        bool isClassified = IsClassifiedEmail(emailText);

        if (isClassified)
        {
            // Replace sensitive text with *****
            string censoredText = CensorSensitiveText(emailText);
            Console.WriteLine("Potential classified email detected:");
            Console.WriteLine(censoredText);
        }
        else
        {
            Console.WriteLine("No potential classified email detected.");
        }
    }

    static bool IsClassifiedEmail(string text)
    {
        foreach (string keyword in classifiedKeywords)
        {
            if (text.ToLower().Contains(keyword))
            {
                return true;
            }
        }
        return false;
    }

    static string CensorSensitiveText(string text)
    {
        foreach (string keyword in classifiedKeywords)
        {
            // Replace sensitive text with *****
            text = text.Replace(keyword, new string('*', keyword.Length));
        }
        return text;
    }
}
