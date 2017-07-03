using SpodIgly.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SpodIgly.DAL
{
    public class StoreInitializer : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            SeedStoreData(context);

            base.Seed(context);
        }

        private void SeedStoreData(StoreContext context)
        {
            var genres = new List<Genre>{
                new Genre() {Name="Rock", Description="Lorem ipsum", IconFilename="rock.png"},
                new Genre() {Name="Metal", Description="Lorem ipsum", IconFilename="rock.png"},
                new Genre() {Name="Jazz", Description="Lorem ipsum", IconFilename="rock.png"},
                new Genre() {Name="Hip Hop", Description="Lorem ipsum", IconFilename="rock.png"},
                new Genre() {Name="R&B", Description="Lorem ipsum", IconFilename="rock.png"},
                new Genre() {Name="Pop", Description="Lorem ipsum", IconFilename="rock.png"},
                new Genre() {Name="Reggae", Description="Lorem ipsum", IconFilename="rock.png"},
                new Genre() {Name="Alternative", Description="Lorem ipsum", IconFilename="rock.png"},
                new Genre() {Name="Electronic", Description="Lorem ipsum", IconFilename="rock.png"},
                new Genre() {Name="Classical", Description="Lorem ipsum", IconFilename="rock.png"},
                new Genre() {Name="Inne", Description="Lorem ipsum", IconFilename="rock.png"},
                new Genre() {Name="Promocje", Description="Lorem ipsum", IconFilename="rock.png"} 
            };

            genres.ForEach(g => context.Genres.Add(g));
            context.SaveChanges();

            var albums = new List<Album>{
                new Album() {AlbumTitle="YOLO", ArtistName="Jolero", CoverFileName="1.png", Price = 50, GenreId = 1},  
                new Album() {AlbumTitle="Hasztag", ArtistName="szesnasty", CoverFileName="2.png", Price = 50, GenreId = 2},
                new Album() {AlbumTitle="7 grzechow", ArtistName="sobota", CoverFileName="3.png", Price = 50, GenreId = 5},
                new Album() {AlbumTitle="3 korony", ArtistName="wini", CoverFileName="4.png", Price = 50, GenreId = 6},
                new Album() {AlbumTitle="Siema", ArtistName="Janusz", CoverFileName="5.png", Price = 50, GenreId = 8},
                new Album() {AlbumTitle="YOLO MOTO NARA", ArtistName="Jolero", CoverFileName="6.png", Price = 50, GenreId = 1},
            };

            albums.ForEach(a => context.Albums.Add(a));
            context.SaveChanges();
        }

    }
}