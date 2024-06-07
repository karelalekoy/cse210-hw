using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        Video v1 = new Video("LUXURY BOAT Rebuild In Minutes START TO FINISH", "BeBeau Builds", 654);
        Comment v1c1 = new Comment("durh_m", "Your dad is absolutely correct when saying “they’ll never ask how long it took, only who built it”. What a gangster, congratulations on a beautiful boat!.");
        Comment v1c2 = new Comment("FWM123", "Took a 300 dollar boat and turned it into a timeless masterpiece good job fellas");
        Comment v1c3 = new Comment("beauar1", "Looks like an awesome boat.  I love the retro feel it has");
        v1.ListComment(v1c1);
        v1.ListComment(v1c2);
        v1.ListComment(v1c3);
        videoList.Add(v1);
        Video v2 = new Video("Santiago Motorizado - Festival Marvin Gateway (Completo)", "Guido B.", 1152);
        Comment v2c1 = new Comment("MarielSz", "Podría escuchar esta versión de Jazmin Chino en loop todo el día.");
        Comment v2c2 = new Comment("tomaskuruc8864", "Este hombre tiene el don de mejorar canciones");
        Comment v2c3 = new Comment("Juanialberto", "Un tema mejor que el otro. Que gran interprete sos Santiago.");
        v2.ListComment(v2c1);
        v2.ListComment(v2c2);
        v2.ListComment(v2c3);
        videoList.Add(v2);
        Video v3 = new Video("We Built An Off Grid SHIPPING CONTAINER HOME (start to finish)", "Life Uncontained", 1860);
        Comment v3c1 = new Comment("mr0al277", "To all those who watched the video, we didn't just witness a house being built from nothing, we witnessed the birth and growth of a beautiful family ");
        Comment v3c2 = new Comment("The_Riddler21", "Imagine your kids when they are  old letting there kids watch this journey 50 years from now");
        Comment v3c3 = new Comment("nicholasfrigiola9261", "Watching the house get built was really cool but watching a family get started was the best part.");
        v3.ListComment(v3c1);
        v3.ListComment(v3c2);
        v3.ListComment(v3c3);
        videoList.Add(v3);
        foreach (Video video in videoList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }

}