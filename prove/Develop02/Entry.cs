using System;
class Entry 
{
   public string date = "";
   public string prompt = "";
   public string userInput = "";

        public Entry(string date, string prompt, string userInput) {
        this.date = date;
        this.prompt = prompt;
        this.userInput = userInput;
    }
    public void Display() {
        Console.WriteLine($"{this.prompt} [{date}]\n{this.userInput}\n");
    }
}