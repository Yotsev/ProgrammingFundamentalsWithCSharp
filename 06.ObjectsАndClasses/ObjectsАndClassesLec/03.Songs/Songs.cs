﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Songs
{
    class Songs
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();
            
            for (int i = 0; i < numberOfLines; i++)
            {
                string[] data = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries);

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();
           
            if (typeList == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

            //// collection filter

            //List<Song> filtered = songs.Where(s => s.TypeList == typeList).ToList();

            //foreach (var song in filtered)
            //{
            //    Console.WriteLine(song.Name);
            //}
        }
    }

    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
