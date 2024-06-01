using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>(4);
        Video video1 = new Video();
        video1._title = "C programming";
        video1._author = "John Apple";
        video1._length = 234000;
        video1._comments.Add(new Comment("Jarom", "Sounds great"));
        video1._comments.Add(new Comment("Amayrani", "It is boring"));
        video1._comments.Add(new Comment("Moroni", "Too cool"));

        Video video2 = new Video();
        video2._title = "Web development course";
        video2._author = "Seiko Hinata";
        video2._length = 413222;
        video2._comments.Add(new Comment("Tom", "It is a japanese Video"));
        video2._comments.Add(new Comment("Bryan", "It's awesome"));
        video2._comments.Add(new Comment("Kevin", "When do you get out the second part?"));

        Video video3 = new Video();
        video3._title = "OpenGL course";
        video3._author = "Hans Zimmer";
        video3._length = 22500;
        video3._comments.Add(new Comment("Jimmy", "Too complex"));
        video3._comments.Add(new Comment("Zayemi", "it doesn't work"));
        video3._comments.Add(new Comment("Sam", "It is cool, I could draw a triangle"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}