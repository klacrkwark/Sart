using System;

class Sart {
    static void Main() {
        Console.WriteLine("Welcome to the Search and Rescue Tracker (SART)!");
        Console.WriteLine("Please enter the number of search and rescue teams: ");
        int numTeams = int.Parse(Console.ReadLine());

        // Create an array to store the team information
        string[,] teams = new string[numTeams, 3];

        // Get information for each team
        for (int i = 0; i < numTeams; i++) {
            Console.WriteLine($"Enter information for team {i+1}:");
            Console.Write("Team name: ");
            teams[i, 0] = Console.ReadLine();
            Console.Write("Number of team members: ");
            teams[i, 1] = Console.ReadLine();
            Console.Write("Last known location: ");
            teams[i, 2] = Console.ReadLine();
            Console.WriteLine();
        }

        // Print out the team information
        Console.WriteLine("Search and Rescue Teams:");
        for (int i = 0; i < numTeams; i++) {
            Console.WriteLine($"Team {i+1}: {teams[i, 0]} - {teams[i, 1]} members - Last known location: {teams[i, 2]}");
        }
    }
}
