﻿using Microsoft.EntityFrameworkCore;
using MusicCollection.Entities;
using System.Security.Cryptography;

namespace MusicCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicCollectionDBContext context = new MusicCollectionDBContext();
            //var average = context.Tracks.Include(t => t.Albums).Where(a => a.Name=="Comeback");

            //var album=context.Albums.Find(4);
            //context.Entry(album).Collection(t => t.Tracks).Load();
            //Console.Write("Name of tracks :: ");
            //foreach (var track in album.Tracks) 
            //{
            //    Console.Write($"{track.Name} ");
            //}

            //N2
            //var res = (from a in context.Albums
            //          join ar in context.Artists on a.ArtistId equals ar.Id
            //          where ar.Name.Contains("Danulo")
            //          orderby a.Rating
            //          select a).Take(3);
            //foreach (var artist in res) 
            //{
            //    Console.WriteLine(artist.Name);
            //}
            //N3
            //var res = (from a in context.Tracks
            //               //join ar in context.Artists on a.ArtistId equals ar.Id
            //           where a.Name.Contains("Lo")
            //           select a).Take(2);
            //foreach (var track in res)
            //{
            //    Console.WriteLine("Tracks where name contains :: "+track.Name);
            //}
            //
            //var res2 = (from a in context.Tracks
            //               //join ar in context.Artists on a.ArtistId equals ar.Id
            //           where a.Text.Contains("Poland")
            //           select a).Take(2);
            //foreach (var track in res2)
            //{
            //    Console.WriteLine("Tracks were text contains :: "+track.Name);
            //}
        }
    }
}
