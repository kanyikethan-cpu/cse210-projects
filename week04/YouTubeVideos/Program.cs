using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Video video1=new Video("Conceptualizing Escapulation","Kanyike Jonathan",180);

        Comment comment1=new Comment("Hellen","Great video");
        video1.AddComment(comment1);
        Comment comment2=new Comment("Liz","Nice content");
        video1.AddComment(comment2);
        Comment comment3=new Comment("Luke","I wish to see you!!");
        video1.AddComment(comment3);
        Comment comment4=new Comment("John","I like you alot");
        video1.AddComment(comment4);

        Video video2=new Video("Understanding programming", "Kizito Reagan",360);
        
        Comment comment5=new Comment("Joel","Awesome");
        video2.AddComment(comment5);
        Comment comment6=new Comment("Emmanuel","Godd content");
        video2.AddComment(comment6);
        Comment comment7=new Comment("Prosper","Fantastic");
        video2.AddComment(comment7);
        Comment comment8=new Comment("Prudence","Worthy it");
        video2.AddComment(comment8);

        Video video3=new Video("C# Concepts","Reagan",720);

        Comment comment9=new Comment("Brian","Nice content");
        video3.AddComment(comment9);
        Comment comment10=new Comment("Happy","I have learnt alot");
        video3.AddComment(comment10);
        Comment comment11=new Comment("Tonny","Appreciated");
        video3.AddComment(comment11);
        Comment comment12=new Comment("Lukanda","Excellent");
        video3.AddComment(comment12);

        Video video4=new Video("Programming","Grace",1020);

        Comment comment13=new Comment("Loda","Great ideas");
        video4.AddComment(comment13);
        Comment comment14=new Comment("Albert","Wow");
        video4.AddComment(comment14);
        Comment comment15=new Comment("Francis","Indeed that was nice");
        video4.AddComment(comment15);
        Comment comment16=new Comment("Reachel","Very good content");
        video4.AddComment(comment16);

        List<Video>videos=new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Video Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length of video: {video._length}");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine();

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"Person commenting: {comment._name}");
                Console.WriteLine($"Comment: {comment._text}");
            }

            Console.WriteLine();
        }


    

        

    }
}