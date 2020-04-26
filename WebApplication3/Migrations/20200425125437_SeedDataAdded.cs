using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Romance", null },
                    { 2, "Bibles", null },
                    { 3, "Fantasy", null },
                    { 4, "Action", null },
                    { 5, "Sci-Fi", null },
                    { 6, "Games", null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription", "inStock", "isBookOfTheWeek" },
                values: new object[,]
                {
                    { 1, "", 1, "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978153/9781534451568-l.jpg", "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978153/9781534451568-l.jpg", "Stella Grant likes to be in control—even though her totally out of control lungs have sent her in and out of the hospital most of her life. At this point, what Stella needs to control most is keeping herself away from anyone or anything that might pass along an infection and jeopardize the possibility of a lung transplant. Six feet apart. No exceptions.", "Five Feet Apart", 18.99m, "Rachael Lippincott", false, false },
                    { 3, "", 2, "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978071/9780718084097-l.jpg", "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978071/9780718084097-l.jpg", "People of all ages and walks of life will enjoy the fresh style of the feature articles, which are directed at helping you approach life with the mind of Christ. You will discover that the Bible is a very practical book, just what is needed to guide you through every day. Featuring abundant sidebar articles and vibrant full-color design, the Apply the Word Study Bible is the perfect companion for everyday living.", "KJV APPLY THE WORD STUDY BIBLE", 54.99m, "Thomas Nelson", false, false },
                    { 2, "", 3, "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978148/9781481497404-l.jpg", "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978148/9781481497404-l.jpg", "Sophie Foster is struggling. Grieving. Scrambling. But she knows one thing: she will not be defeated. The Neverseen have had their victories - but the battle is far from over. It’s time to change tactics. Make sacrifices. Reexamine everything. Maybe even time for Sophie to trust her enemies.", "NIGHTFALL (KEEPER OF THE LOST CITIES, BK. 6)", 19.99m, "Shannon Messenger", false, false },
                    { 4, "", 4, "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978073/9780736435864-l.jpg", "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978073/9780736435864-l.jpg", "Can Rey, Finn, General Leia, Poe Dameron, and Luke Skywalker save the galaxy from Kylo Ren and the evil First Order? The epic space saga, Star Wars: The Last Jedi, is retold in the iconic Little Golden Book format! Featuring stunning retro illustrations, this book is perfect for Star Wars--and Little Golden Book--fans of all ages!", "THE LAST JEDI (STAR WARS)", 4.99m, "Elizabeth Schaefer", false, false },
                    { 5, "", 5, "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978152/9781524713843-l.jpg", "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978152/9781524713843-l.jpg", "Thirteen-year-old twins Vick and Tara have built an incredible machine - a loyal robotic watchdog named Daisy. But, when local crime boss Ms. Alba schemes to add Daisy to her robot army, Vick and Tara must go to great lengths to protect their prized pet. Because Daisy is more than just any robot - she’s their constant protector, and together the three make a great team.", "WATCHDOG", 16.99m, "Will McIntosh", false, false },
                    { 6, "", 6, "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978152/9781524797232-l.jpg", "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978152/9781524797232-l.jpg", "This official guide will teach you how to navigate the alien terrain, battle the native mobs and find rare blocks and items. With insider info and tips from the experts at Mojang, this is the definitive guide to survival in the Nether and the End.", "MINECRAFT: GUIDE TO THE NETHER & THE END", 11.99m, "Del Rey Books", false, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);
        }
    }
}
