public class ProfileManager
{
    private List<Profile> profiles;

    public ProfileManager(List<Profile> profiles)
    {
        this.profiles = profiles;
    }

    public void CreateProfile()
    {
        Console.Write("Enter body weight (pounds): ");
        int bodyWeight = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter height (feet): ");
        int heightFeet = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter height (inches): ");
        int heightInches = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter gender (male/female): ");
        string gender = Console.ReadLine();

        Console.Write("Enter exercise experience (beginner/intermediate/advanced): ");
        string exerciseExperience = Console.ReadLine();

        Console.Write("Enter goal (lose/gain weight): ");
        string goal = Console.ReadLine();

        Profile profile = new Profile(bodyWeight, heightFeet, heightInches, gender, exerciseExperience, goal);
        profiles.Add(profile);

        Console.WriteLine("Profile created successfully.");
    }
}
