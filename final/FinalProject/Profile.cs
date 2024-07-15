public class Profile
{
    private int bodyWeight;
    private int heightFeet;
    private int heightInches;
    private string gender;
    private string exerciseExperience;
    private string goal;

    public Profile(int bodyWeight, int heightFeet, int heightInches, string gender, string exerciseExperience, string goal)
    {
        this.bodyWeight = bodyWeight;
        this.heightFeet = heightFeet;
        this.heightInches = heightInches;
        this.gender = gender;
        this.exerciseExperience = exerciseExperience;
        this.goal = goal;
    }

    public int GetBodyWeight() => bodyWeight;
    public void SetBodyWeight(int value) => bodyWeight = value;

    public int GetHeightFeet() => heightFeet;
    public void SetHeightFeet(int value) => heightFeet = value;

    public int GetHeightInches() => heightInches;
    public void SetHeightInches(int value) => heightInches = value;

    public string GetGender() => gender;
    public void SetGender(string value) => gender = value;

    public string GetExerciseExperience() => exerciseExperience;
    public void SetExerciseExperience(string value) => exerciseExperience = value;

    public string GetGoal() => goal;
    public void SetGoal(string value) => goal = value;
    
    public int CalculateBMI()
    {
        int heightInInches = (heightFeet * 12) + heightInches;
        return (bodyWeight * 703) / (heightInInches * heightInInches);
    }
}
