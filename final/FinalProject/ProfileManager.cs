using Newtonsoft.Json;
using System;
using System.IO;

public class ProfileManager
{
    private UserProfile currentProfile;

    public void CreateProfile()
    {
        Console.WriteLine("Enter Profile Details:");
        // Collect and set details for Profile
        currentProfile = new UserProfile
        {
            Index = 1, // Placeholder index
            Name = "John Doe", // Placeholder name
            Weight = 180, // Placeholder weight
            Height = 1.75, // Placeholder height
            ExerciseExperienceLevel = "Beginner",
            WeightGoal = 170
        };
        Console.WriteLine("Profile created successfully.");
    }

    public void CalculateBMI()
    {
        if (currentProfile != null)
        {
            double bmi = currentProfile.Weight / (currentProfile.Height * currentProfile.Height);
            currentProfile.BMI = bmi;
            Console.WriteLine($"Your BMI is: {bmi}");
        }
        else
        {
            Console.WriteLine("No profile found.");
        }
    }

    public void ProvideFeedback()
    {
        if (currentProfile != null)
        {
            // Collect and set feedback for the profile
            currentProfile.ProgressPercentage = 75; // Placeholder progress
            Console.WriteLine($"Profile progress updated to: {currentProfile.ProgressPercentage}%");
        }
        else
        {
            Console.WriteLine("No profile found.");
        }
    }

    public void SaveProfile()
    {
        if (currentProfile != null)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new ProfileConverter() }
            };

            string json = JsonConvert.SerializeObject(currentProfile, settings);
            File.WriteAllText("profile.json", json);
            Console.WriteLine("Profile saved successfully.");
        }
        else
        {
            Console.WriteLine("No profile to save.");
        }
    }

    public void LoadProfile()
    {
        JsonDeserializer deserializer = new JsonDeserializer("profile.json");
        currentProfile = deserializer.Deserialize<UserProfile>();
        Console.WriteLine("Profile loaded successfully.");
    }
}
