using BasketLeague2.Utils.Models;

namespace BasketLeague2.Utils.Utils;

public static class PlayerUtils
{
    public static void PlayerRoulette(this Player player)
    {
        Random rng = new();

        player.InsideScoring += rng.Next(-1, 2);
        player.OutsideScoring += rng.Next(-1, 2);
        player.Athleticism += rng.Next(-1, 2);
        player.Playmaking += rng.Next(-1, 2);
        player.Rebounding += rng.Next(-1, 2);
        player.Defending += rng.Next(-1, 2);

        player.Overall = player.CalculateOverall();
    }
}

public static class RandomNameGenerator
{
    private static readonly string[] FirstNames =
    {
        "Aiden", "Amelia", "Aria", "Ava", "Caden", "Charlotte", "David", "Elijah", "Emily", "Grace", "Grayson",
        "Harper", "Isabella", "Jackson", "John", "Landon", "Liam", "Lily", "Lucas", "Mateo", "Mia", "Nicole", "Noah",
        "Olivia", "Sophia", "Sophie", "Zoe", "Benjamin", "Emma", "Ethan", "Hannah", "James", "Jayden", "Leah", "Logan",
        "Madison", "Mason", "Natalie", "Nathan", "Owen", "Riley", "Samuel", "Scarlett", "Sebastian", "Stella",
        "Victoria", "William", "Xavier", "Zachary", "Zara"
    };

    private static readonly string[] LastNames =
    {
        "Anderson", "Baker", "Barnes", "Brown", "Carter", "Clark", "Davis", "Edwards", "Evans", "Fisher", "Garcia",
        "Gonzalez", "Green", "Harris", "Hernandez", "Hill", "Jackson", "Johnson", "Jones", "King", "Lee", "Lewis",
        "Martin", "Martinez", "Miller", "Moore", "Nelson", "Nguyen", "Parker", "Perez", "Phillips", "Robinson",
        "Rodriguez", "Sanchez", "Scott", "Smith", "Stewart", "Taylor", "Thomas", "Thompson", "Turner", "Walker",
        "White", "Williams", "Wilson", "Wright", "Young", "Zimmerman", "Collins", "Murphy"
    };

    private static readonly string[] Nicknames =
    {
        "Ace", "Al", "Ben", "Buddy", "Cami", "Cass", "Charlie", "Dave", "Duke", "Elle", "Ellie", "Em", "Finn", "Gigi",
        "Izzy", "Jack", "Jake", "Jo", "Johnny", "Jules", "Kat", "Katie", "Leo", "Liv", "Lulu", "Max", "Mick", "Mimi",
        "Nate", "Nicky", "Pip", "Red", "Ricky", "Rocky", "Sam", "Sunny", "Teddy", "Tommy", "Tony", "Tori", "Vicky",
        "Wes", "Zane", "Zoe", "Zeke", "Jess", "Frankie", "Bobby", "Jamie", "Jay"
    };

    public static string GenerateName()
    {
        Random random = new();
        var firstNameIndex = random.Next(FirstNames.Length);
        var lastNameIndex = random.Next(LastNames.Length);
        var firstName = FirstNames[firstNameIndex];
        var lastName = LastNames[lastNameIndex];
        return firstName + " " + lastName;
    }

    public static string GenerateNickname()
    {
        Random random = new();
        var nicknameIndex = random.Next(Nicknames.Length);
        var nickname = Nicknames[nicknameIndex];
        return nickname;
    }
}