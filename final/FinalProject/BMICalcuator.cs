public class BMICalculator
{
    private List<Profile> profiles;

    public BMICalculator(List<Profile> profiles)
    {
        this.profiles = profiles;
    }

    public void CalculateBMI()
    {
        if (profiles.Count == 0)
        {
            Console.WriteLine("No profiles available. Please create a profile first.");
            return;
        }

        Console.Write("Enter profile index to calculate BMI: ");
        int index = Convert.ToInt32(Console.ReadLine());

        if (index < 0 || index >= profiles.Count)
        {
            Console.WriteLine("Invalid profile index.");
            return;
        }

        Profile profile = profiles[index];
        int bmi = profile.CalculateBMI();
        Console.WriteLine($"The BMI for the selected profile is: {bmi}");
    }
}
