using System;

namespace MyConsoleApp

{
    public class Activity3
    {
        public string VoterEligibiltyChecker(int age, string citizen)
        {
            // TODO: Implement logic to check if user is eligible to vote.
            // - The program should:
            // - Check if the person is 18 years or older **and** a Filipino citizen.
            // - Return "You are eligible to vote." if both conditions are met.
            // - Otherwise, return "You are not eligible to vote."

            if (age >= 18 && citizen == "yes")
            {
                return "You are eligible to vote.";
            }
            else
            {
                return "You are not eligible to vote";
            }
        }
    }
}