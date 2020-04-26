using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Romance" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Bibles" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Fantasy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Action" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Sci-Fi" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 6, CategoryName = "Games" });


            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 1,
                Name = "Five Feet Apart",
                Price = 18.99M,
                ShortDescription = "Rachael Lippincott",
                LongDescription =
                    "Stella Grant likes to be in control—even though her totally out of control lungs have sent her in and out of the hospital most of her life. At this point, what Stella needs to control most is keeping herself away from anyone or anything that might pass along an infection and jeopardize the possibility of a lung transplant. Six feet apart. No exceptions.",
                CategoryId = 1,
                ImageUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978153/9781534451568-l.jpg",
                inStock = true,
                isBookOfTheWeek = true,
                ImageThumbnailUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978153/9781534451568-l.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 2,
                Name = "NIGHTFALL",
                Price = 19.99M,
                ShortDescription = "Shannon Messenger",
                LongDescription =
                    "Sophie Foster is struggling. Grieving. Scrambling. But she knows one thing: she will not be defeated. The Neverseen have had their victories - but the battle is far from over. It’s time to change tactics. Make sacrifices. Reexamine everything. Maybe even time for Sophie to trust her enemies.",
                CategoryId = 3,
                ImageUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978148/9781481497404-l.jpg",
                inStock = true,
                isBookOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978148/9781481497404-l.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 3,
                Name = "THE WORD STUDY BIBLE",
                Price = 54.99M,
                ShortDescription = "Thomas Nelson",
                LongDescription =
                    "People of all ages and walks of life will enjoy the fresh style of the feature articles, which are directed at helping you approach life with the mind of Christ. You will discover that the Bible is a very practical book, just what is needed to guide you through every day. Featuring abundant sidebar articles and vibrant full-color design, the Apply the Word Study Bible is the perfect companion for everyday living.",
                CategoryId = 2,
                ImageUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978071/9780718084097-l.jpg",
                inStock = true,
                isBookOfTheWeek = true,
                ImageThumbnailUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978071/9780718084097-l.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 4,
                Name = "THE LAST JEDI",
                Price = 4.99M,
                ShortDescription = "Elizabeth Schaefer",
                LongDescription =
                    "Can Rey, Finn, General Leia, Poe Dameron, and Luke Skywalker save the galaxy from Kylo Ren and the evil First Order? The epic space saga, Star Wars: The Last Jedi, is retold in the iconic Little Golden Book format! Featuring stunning retro illustrations, this book is perfect for Star Wars--and Little Golden Book--fans of all ages!",
                CategoryId = 4,
                ImageUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978073/9780736435864-l.jpg",
                inStock = true,
                isBookOfTheWeek = true,
                ImageThumbnailUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978073/9780736435864-l.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 5,
                Name = "WATCHDOG",
                Price = 16.99M,
                ShortDescription = "Will McIntosh",
                LongDescription =
                    "Thirteen-year-old twins Vick and Tara have built an incredible machine - a loyal robotic watchdog named Daisy. But, when local crime boss Ms. Alba schemes to add Daisy to her robot army, Vick and Tara must go to great lengths to protect their prized pet. Because Daisy is more than just any robot - she’s their constant protector, and together the three make a great team.",
                CategoryId = 5,
                ImageUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978152/9781524713843-l.jpg",
                inStock = true,
                isBookOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978152/9781524713843-l.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 6,
                Name = "MINECRAFT",
                Price = 11.99M,
                ShortDescription = "Del Rey Books",
                LongDescription =
                    "This official guide will teach you how to navigate the alien terrain, battle the native mobs and find rare blocks and items. With insider info and tips from the experts at Mojang, this is the definitive guide to survival in the Nether and the End.",
                CategoryId = 6,
                ImageUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978152/9781524797232-l.jpg",
                inStock = true,
                isBookOfTheWeek = false,
                ImageThumbnailUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978152/9781524797232-l.jpg",
                AllergyInformation = ""
            });

        }

    }
}
