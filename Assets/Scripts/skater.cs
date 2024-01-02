using System;

[Serializable]
public class Skater
{
    // Basic skater attributes
    public string name;
    public int age;

    // Resources
    public float money;
    public int freeHours;

    // Skills and stats
    public int skatingSkill;
    public int strength;
    public int agility;

    // Constructor to initialize the skater
    public Skater(string name, int age)
    {
        this.name = name;
        this.age = age;
        money = 0;
        freeHours = 24; // Assuming a start with a full day's free hours

        // Initialize skills and stats
        skatingSkill = 0;
        strength = 0;
        agility = 0;
    }

    // Method to simulate training, which increases skills
    public void Train(string skillType, int hours)
    {
        if (freeHours < hours)
        {
            Console.WriteLine("Not enough free hours to train");
            return;
        }

        freeHours -= hours;

        switch (skillType)
        {
            case "Skating":
                skatingSkill += hours; // Simple formula for skill increase
                break;
            case "Strength":
                strength += hours;
                break;
            case "Agility":
                agility += hours;
                break;
            default:
                Console.WriteLine("Unknown skill type");
                break;
        }
    }

    // Add other methods for activities like working out, sleeping, earning money, etc.
}