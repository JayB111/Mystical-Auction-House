using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartingPrice = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CurrentPrice = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    AuctionEndTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsSold = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AuctionEndTime", "CurrentPrice", "Description", "ImageFileName", "IsSold", "Name", "StartingPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9748), 0m, "A beautifully ornate box said to contain all the evils of the world. Opening it released sorrow... and hope.", "pandoras box.jpg", false, "Pandora's Box", 500m },
                    { 2, new DateTime(2025, 5, 4, 12, 52, 7, 478, DateTimeKind.Utc).AddTicks(9763), 0m, "Ancient dice used to divine fate. Roll carefully... each face reveals a destiny.", "Oracle's Dice.jpg", false, "Oracle's Dice", 300m },
                    { 3, new DateTime(2025, 5, 4, 12, 49, 7, 478, DateTimeKind.Utc).AddTicks(9766), 0m, "Forged in the fires of the underworld and marked by Hades himself. A toll for the river Styx.", "Hades' Coin.jpg", false, "Hades' Coin", 250m },
                    { 4, new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9769), 0m, "A silver thread spun by unknown gods. Said to lead lost souls through forgotten paths.", "Thread of tyron.jpg", false, "The Thread of Tyron", 800m },
                    { 5, new DateTime(2025, 5, 4, 12, 53, 7, 478, DateTimeKind.Utc).AddTicks(9772), 0m, "A cursed mirror that once reflected the gaze of Medusa. Some say it still can.", "Medusa's Mirror.jpg", false, "Medusa’s Mirror", 600m },
                    { 6, new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9806), 0m, "A replica, yes... but still crackling with static. Handle with reverence.", "Zeus lightningbolt.jpg", false, "Zeus' Lightning Bolt", 1000m },
                    { 7, new DateTime(2025, 5, 4, 12, 48, 7, 478, DateTimeKind.Utc).AddTicks(9809), 0m, "Brushing with this comb is said to make even the stars blush. Love lingers in every tooth.", "Aphrodite's Comb.jpg", false, "Aphrodite’s Comb", 450m },
                    { 8, new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9812), 0m, "Worn by Hades himself. With it, one vanishes from mortal and divine sight alike.", "helm-of-darkness.jpg", false, "Helm of Darkness", 1200m },
                    { 9, new DateTime(2025, 5, 4, 12, 51, 7, 478, DateTimeKind.Utc).AddTicks(9816), 0m, "The forbidden nectar of the gods. They say a sip adds a century to your life.", "Ambrosia.jpg", false, "Ambrosia", 1000m },
                    { 10, new DateTime(2025, 5, 4, 12, 54, 7, 478, DateTimeKind.Utc).AddTicks(9819), 0m, "Winged and enchanted, made for swift travel between worlds and whispering winds.", "hermes-sandals.jpg", false, "Hermes’ Sandals", 700m },
                    { 11, new DateTime(2025, 5, 4, 12, 53, 7, 478, DateTimeKind.Utc).AddTicks(9822), 0m, "A forged replica of Mjölnir. Still surprisingly heavy. Lifting it may reveal your worth.", "Thors Hammer.jpg", false, "Thor’s Hammer", 950m },
                    { 12, new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9828), 0m, "Woven from the golden ram, its glow is said to grant fortune, or madness.", "The Golden Fleece.jpg", false, "Golden Fleece", 1100m },
                    { 13, new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9831), 0m, "Plucked from the trench’s darkest depths. Some say it whispers tides in ancient tongues.", "Poseidon's shell.jpg", false, "Poseidon’s Shell", 500m },
                    { 14, new DateTime(2025, 5, 4, 12, 51, 7, 478, DateTimeKind.Utc).AddTicks(9834), 0m, "It shakes the sea. A weapon of command, control, and crashing waves.", "poseidons-trident.jpg", false, "Poseidon's Trident", 1300m },
                    { 15, new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9837), 0m, "An ancient spinning spindle, said to be cursed. One touch and the world falls quiet.", "spinning spindle.jpg", false, "The Spindle of Destiny", 400m },
                    { 16, new DateTime(2025, 5, 4, 12, 54, 7, 478, DateTimeKind.Utc).AddTicks(9902), 0m, "Perfect and red... a single bite seals your fate. Still fresh after centuries.", "Poison apple.jpg", false, "Poison Apple of Death", 380m },
                    { 17, new DateTime(2025, 5, 4, 12, 49, 7, 478, DateTimeKind.Utc).AddTicks(9906), 0m, "Glass-crafted destiny. If it fits, your path changes forever.", "Cinderella's slipper.jpg", false, "Cinderella’s Slipper", 620m },
                    { 18, new DateTime(2025, 5, 4, 12, 49, 7, 478, DateTimeKind.Utc).AddTicks(9914), 0m, "Forged in the fires of Mount Doom. Grants invisibility — and a growing obsession.", "the-one-ring.jpg", false, "The One Ring", 1500m },
                    { 19, new DateTime(2025, 5, 4, 12, 52, 7, 478, DateTimeKind.Utc).AddTicks(9923), 0m, "Captured in a magical vessel or locked within a chest, this kiss breaks the darkest curses.", "true-loves-kiss.jpg", false, "True Love’s Kiss", 900m },
                    { 20, new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9931), 0m, "Inscribed with cosmic secrets in glowing green script. The alchemical key to 'as above, so below.'", "emerald-tablet.jpg", false, "The Emerald Tablet", 1250m },
                    { 21, new DateTime(2025, 5, 4, 12, 51, 7, 478, DateTimeKind.Utc).AddTicks(9947), 0m, "Forged in shadow and insight, this elusive deck reveals more than mere futures—it reveals veiled truths. Only the brave may draw from it.", "Tarot of the Veiled Realms.jpg", false, "Tarot of the Veiled Realms", 900m },
                    { 22, new DateTime(2025, 5, 4, 12, 53, 7, 478, DateTimeKind.Utc).AddTicks(9960), 0m, "This violet-hued spirit board pulses with ancient presence. It speaks not only to the dead, but to forgotten echoes of magic itself.", "Enchanted Ouija Board.jpg", false, "The Enchanted Ouija Board", 850m },
                    { 23, new DateTime(2025, 5, 4, 12, 56, 7, 478, DateTimeKind.Utc).AddTicks(9967), 0m, "A cursed hourglass that counts a hidden hour no one sees. Time rewinds for those who dare flip it.", "The Thirteenth Hour Sandglass.jpg", false, "The Thirteenth Hour Sandglass", 950m },
                    { 24, new DateTime(2025, 5, 4, 12, 53, 7, 478, DateTimeKind.Utc).AddTicks(9971), 0m, "Glows only in total darkness. Believed to guide lost spirits home.", "The Lantern of the Deep Moon.jpg", false, "The Lantern of the Deep Moon", 780m },
                    { 25, new DateTime(2025, 5, 4, 12, 54, 7, 478, DateTimeKind.Utc).AddTicks(9973), 0m, "Carved from the last living tree in a cursed forest, this wand pulses with ancient magic. Its touch is strangely warm.", "The Wand of the Hollow Grove.jpg", false, "The Wand of the Hollow Grove", 750m },
                    { 26, new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9975), 0m, "A celestial map that charts constellations no longer in the sky. Some say they never were.", "The Atlas of Lost Stars.jpg", false, "The Atlas of Lost Stars", 940m },
                    { 27, new DateTime(2025, 5, 4, 12, 51, 7, 478, DateTimeKind.Utc).AddTicks(9978), 0m, "Said to be woven by death herself. Whoever wears it sees beyond the veil of life.", "The Widow’s Veil.jpg", false, "The Widow’s Veil", 890m },
                    { 28, new DateTime(2025, 5, 4, 12, 54, 7, 478, DateTimeKind.Utc).AddTicks(9980), 0m, "Flip it and hear the name of a place not on any map.", "The Coin of Forgotten Realms.jpg", false, "The Coin of Forgotten Realms", 880m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
