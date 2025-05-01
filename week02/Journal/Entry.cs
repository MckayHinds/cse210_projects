public class Entry
{
    public string Date { get; }
    public string Prompt { get; }
    public string Response { get; }
    public int MoodRating { get; }

    public Entry(string date, string prompt, string response, int moodRating)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        MoodRating = moodRating;
    }

    public string GetDisplayText()
    {
        return $"{Date} - {Prompt}\nResponse: {Response}\nMood Rating: {MoodRating}/10\n";
    }

    public string ToFileFormat()
    {
        return $"{Date}|{Prompt}|{Response}|{MoodRating}";
    }

    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');
        string date = parts[0];
        string prompt = parts[1];
        string response = parts[2];
        int moodRating = int.Parse(parts[3]);

        return new Entry(date, prompt, response, moodRating);
    }
}
