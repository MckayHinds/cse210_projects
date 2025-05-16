class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        var video1 = new Video("C# Basics", "CodeWizard", 240);
        video1.AddComment(new Comment("Alice", "Thanks! Super clear."));
        video1.AddComment(new Comment("Bob", "I love this channel."));
        video1.AddComment(new Comment("Sam", "Could you do one on LINQ?"));
        videos.Add(video1);

        var video2 = new Video("Unity 101", "GameDevTV", 360);
        video2.AddComment(new Comment("Tina", "This helped a ton."));
        video2.AddComment(new Comment("Max", "Cool examples."));
        videos.Add(video2);

        var video3 = new Video("Intro to Python", "PyMaster", 180);
        video3.AddComment(new Comment("Luke", "Great for beginners!"));
        video3.AddComment(new Comment("Mia", "Short and sweet."));
        video3.AddComment(new Comment("Dan", "Very useful."));
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.Display();
        }
    }
}
