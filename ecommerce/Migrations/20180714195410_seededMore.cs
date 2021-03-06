﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ecommerce.Migrations
{
    public partial class seededMore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "This hard vinyl 3-3/4” action figure will be with you through thick and thin. Maggie Squirrel is also a doctor and artist. She has devoted her life to healing the sick and doing paintings of Abraham Lincoln doing odd things like playing badminton and shopping for underpants. One of her paintings, Abraham Lincoln making a macaroni necklace for his mother, recently sold for over $5,000.", "https://cdn.shopify.com/s/files/1/1365/2497/products/maggie-squirrel-strange-friends-action-figure_1600x.jpg?v=1520535597", "Maggie - Squirrel Action Figure", 9.95m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Image", "Name", "Price", "Sku" },
                values: new object[,]
                {
                    { 5, "This sunshade will not only protect and cool your car while blocking UV rays, it will also make it appear like it’s full of a squad of sassy squirrels. At 50\" x 27 - 1 / 2\", it’s big enough for most cars. It’s too big for a mini, too small for a truck. Includes two suction cups for simple installation. Folds for easy storage. Metalized polyester laminate.", "https://cdn.shopify.com/s/files/1/1365/2497/products/car-full-of-squirrels-auto-sunshade_1600x.jpg?v=1520533891", "Squirrels throwing shade", 15.00m, "MNAG0005" },
                    { 6, "This pin is made of diecast metal and enamel and is 1-1/2” tall.", "https://cdn.shopify.com/s/files/1/1365/2497/products/squirrel-in-red-dress-strange-pin_1600x.jpg?v=1520533794", "Lady Squirrel Pin", 7.99m, "MNAG0006" },
                    { 7, "Every tree needs a squirrel in underpants. In fact, we think you'd be nuts not to have one! Made of glass, it's 4\" tall and includes string or can stand on its own", "https://cdn.shopify.com/s/files/1/1365/2497/products/handisquirrel-Box_1600x.jpg?v=1520533725", "Underpants Squirrel-nament", 6.99m, "MNAG0007" },
                    { 8, "It's a 5\" x 7\" card, with envelope, that expresses your honest emotions in a weird and measured way", "https://cdn.shopify.com/s/files/1/1365/2497/products/Squirrel_Birthday_Card_1600x.jpg?v=1520535512", "Happy Birthday, Squirrel Friend - Card", 2.99m, "MNAG0008" },
                    { 9, "These ceramic Squirrel Salt and Pepper Shakers will amuse anyone who has ever fantasized about seasoning food with the disembodied heads of tree rats. ", "https://cdn.shopify.com/s/files/1/1365/2497/products/squirrel_salt_and_pepper_shakers_1600x.jpg?v=1520534553", "Squirrel Shakers", 5.99m, "MNAG0009" },
                    { 10, "Full-sized, adult latex Squirrel Mask. Perfect for all occasions (except dog sitting).", "https://cdn.shopify.com/s/files/1/1365/2497/products/12293-SquirrelMask-Trees03-1_1600x.jpg?v=1520534463", "Squirrel Mask", 6.99m, "MNAG00010" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Ever wanted your hand to be a squirrel? Now you can with these finger puppets. Includes four paws and a squirrel head.", "https://cdn.shopify.com/s/files/1/1365/2497/products/handisquirrel-Box_1600x.jpg?v=1520533725", "Handisquirrel - Squirrel Finger Puppet", 6.99m });
        }
    }
}
