namespace _04_Songs
{
    using System;
    using System.Collections.Generic;

    public class Songs
    {

        public class Song
        {
            public string TypeList  { get; set; }

            public string SongName { get; set; }
            
            public string Time { get; set; }

        }

        public static void Main()
        {
            var numberOfSongs = int.Parse(Console.ReadLine());
            var songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                var songInput = Console.ReadLine().Split("_");

                var type = songInput[0];
                var name = songInput[1];
                var time = songInput[2];

                var newSong = new Song();

                newSong.TypeList = type;
                newSong.SongName = name;
                newSong.Time = time;

                songs.Add(newSong);

            }
            var song = Console.ReadLine();

            if (song == "all")
            {
                foreach (var list in songs)
                {
                    Console.WriteLine(list.SongName);
                }
            }
            else
            {
                foreach (var item in songs)
                {
                    if (item.TypeList == song)
                    {
                        Console.WriteLine(item.SongName);
                    }
                }
            }

        }
    }
}
