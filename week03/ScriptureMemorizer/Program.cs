using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        SafeClear();
        Console.WriteLine("Welcome to the Scripture Memorizer!");
List<Scripture> scriptures = new List<Scripture>
{
    new Scripture(new Reference("John", 3, 16),
        "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),

    new Scripture(new Reference("Proverbs", 3, 5, 6),
        "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."),

    new Scripture(new Reference("Mosiah", 2, 17),
        "When ye are in the service of your fellow beings ye are only in the service of your God."),

    new Scripture(new Reference("2 Nephi", 2, 25),
        "Adam fell that men might be; and men are, that they might have joy."),

    new Scripture(new Reference("Alma", 37, 6),
        "By small and simple things are great things brought to pass; and small means in many instances doth confound the wise."),

    new Scripture(new Reference("Ether", 12, 27),
        "And if men come unto me I will show unto them their weakness."),

    new Scripture(new Reference("D&C", 10, 5),
        "Pray always, that you may come off conqueror; yea, that you may conquer Satan, and that you may escape the hands of the servants of Satan that do uphold his work."),

    new Scripture(new Reference("Romans", 8, 28),
        "And we know that all things work together for good to them that love God, to them who are the called according to his purpose."),

    new Scripture(new Reference("Philippians", 4, 13),
        "I can do all things through Christ which strengtheneth me."),

    new Scripture(new Reference("Matthew", 11, 28, 30),
        "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.")
};
        var rand = new Random();
        while (true)
        {
            Scripture scripture = scriptures[rand.Next(scriptures.Count)];
            while (!scripture.AllWordsHidden())
            {
                SafeClear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    return;
                scripture.HideRandomWords(3);
            }
            SafeClear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nWell done! Scripture completely hidden.\nPress Enter for a new one or type 'quit' to exit.");
            if (Console.ReadLine().ToLower() == "quit")
                return;
        }
    }
    static void SafeClear()
    {
        try { Console.Clear(); }
        catch (IOException) {}
    }
}