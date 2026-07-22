using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# Basics for Beginners", "Vanessa Awo", 725);
        video1.AddComment(new Comment("Chidi", "This really helped me understand classes!"));
        video1.AddComment(new Comment("Amaka", "Great pacing, thanks."));
        video1.AddComment(new Comment("Tobi", "Can you do one on inheritance next?"));

        Video video2 = new Video("Building a Portfolio Website", "Vanessa Awo", 940);
        video2.AddComment(new Comment("Ifeoma", "Loved the design tips."));
        video2.AddComment(new Comment("Bayo", "What tools did you use?"));
        video2.AddComment(new Comment("Grace", "Subscribed!"));
        video2.AddComment(new Comment("Emeka", "Very clear explanation."));

        Video video3 = new Video("Nigeria Travel Vlog", "Vanessa Awo", 1200);
        video3.AddComment(new Comment("Kunle", "Abuja looks beautiful!"));
        video3.AddComment(new Comment("Ngozi", "Adding this to my bucket list."));
        video3.AddComment(new Comment("Femi", "Great cinematography."));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}