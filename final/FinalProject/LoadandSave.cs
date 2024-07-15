using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public class Saver
{
    public void SaveProfiles(List<Profile> profiles)
    {
        string json = JsonConvert.SerializeObject(profiles, Formatting.Indented);
        File.WriteAllText("profiles.json", json);
        Console.WriteLine("Profiles saved successfully.");
    }
}
