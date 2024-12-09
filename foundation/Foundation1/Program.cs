using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to take care of your dog", "PetsLovers01", 240);
        video1.AddComment(new Comment("Pedro21", "I really like this video! I love dogs."));
        video1.AddComment(new Comment("Patricia001flowers", "This video helped me to understand how to take care of my dog properly. Thank you very much!"));
        video1.AddComment(new Comment("Dogz2", "Very helpful, love this video."));

        Video video2 = new Video("How to repair a computer", "BestRepairHD", 300);
        video2.AddComment(new Comment("Martin09", "Thank you. This video saved me and I repaired my PC successfully."));
        video2.AddComment(new Comment("Kenny877", "Good information. Excellent!!"));
        video2.AddComment(new Comment("Maria5", "This tutorial was amazing. Thanks a lot!"));

        Video video3 = new Video("How to draw", "PicassoWasHere", 180);
        video3.AddComment(new Comment("Wally43", "I managed to draw a nice city thanks to this tutorial! Recommended."));
        video3.AddComment(new Comment("Lion9", "The art style and the way this video explains everything about how to draw is perfect."));
        video3.AddComment(new Comment("Lillys05", "Absolutely loved this video! Nice tutorial."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
