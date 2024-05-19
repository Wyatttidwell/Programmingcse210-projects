namespace PGen
{
    public class PromptClass
    {
        public string Promptmethod()
        {
        List<string> prompts = new List<string>()
        {
            "If you could travel anywhere in the world right now, where would you go?",
            "What's the most interesting book you've read recently?",
            "What's your favorite thing about the city you live in?",
            "If you could have dinner with any historical figure, who would it be?",
            "What made you smile today?",
            "Describe a challenge you overcame recently.",
            "Write about a goal you're working towards.",
            "Reflect on a meaningful conversation you had.",
            "What's something new you learned today?",
            "Write about a place you'd like to visit.",
            "Describe a favorite childhood memory.",
            "What are you grateful for right now?",
            "Reflect on a mistake you made and what you learned from it.",
            "Write about a book or article you read recently.",
            "Describe a moment when you felt proud of yourself.",
            "What's a hobby you enjoy and why?",
            "Write about a time you felt inspired.",
            "Reflect on a friendship that's important to you.",
            "What's something you'd like to improve about yourself?",
            "Describe a favorite food and why you love it.",
            "Write about a movie or TV show you watched recently.",
            "Reflect on a time when you felt stressed and how you managed it.",
            "What's a dream you've had recently?",
            "Describe a song that holds special meaning to you.",
            "Write about a skill you'd like to learn.",
            "Reflect on a moment of kindness you experienced.",
            "What's a quote that resonates with you?",
            "Describe a memorable travel experience.",
            "Write about a fear you've overcome.",
            "Reflect on a time you felt inspired by nature.",
            "What's a cultural tradition you cherish?",
            "Describe a mentor or role model in your life.",
            "Write about a personal achievement you're proud of.",
            "Reflect on a time when you felt grateful for someone's support.",
            "What's a goal you have for the future?",
            "Describe a favorite memory from your childhood home.",
            "Write about a place in nature that brings you peace.",
            "Reflect on a time you took a risk and it paid off.",
            "What's a topic you'd like to learn more about?",
            "Describe a favorite family tradition.",
            "Write about a moment of unexpected joy.",
            "Reflect on a time you felt motivated to make a positive change.",
            "What's a skill you'd like to teach others?",
            "Describe a favorite holiday celebration.",
            "Write about a time you felt proud of someone else.",
            "Reflect on a favorite quote or saying from a loved one.",
            "What's a small act of kindness you can do today?",
            "Describe a place where you feel completely at peace.",
            "Write about a time you helped someone in need.",
            "Reflect on a lesson you learned from a difficult experience.",
            "What's a cause you feel passionate about?",
            "Describe a favorite childhood game or activity.",
            "Write about a time you felt inspired by someone's resilience.",
            "Reflect on a personal mantra or motto that guides you.",
        };

        Random random = new Random();
        int index = random.Next(prompts.Count);
        Console.WriteLine("Conversation Prompt:");


         return prompts[index];
        }
    }
}
