using Microsoft.EntityFrameworkCore;
using AuctionAPI.Models;

namespace AuctionAPI.Data
{
    public class AuctionDbContext : DbContext
    {
        public AuctionDbContext(DbContextOptions<AuctionDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Pandora's Box", Description = "A beautifully ornate box said to contain all the evils of the world. Opening it released sorrow... and hope.", StartingPrice = 500, ImageFileName = "pandoras box.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(5) },
                new Product { Id = 2, Name = "Oracle's Dice", Description = "Ancient dice used to divine fate. Roll carefully... each face reveals a destiny.", StartingPrice = 300, ImageFileName = "Oracle's Dice.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(7) },
                new Product { Id = 3, Name = "Hades' Coin", Description = "Forged in the fires of the underworld and marked by Hades himself. A toll for the river Styx.", StartingPrice = 250, ImageFileName = "Hades' Coin.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(4) },
                new Product { Id = 4, Name = "The Thread of Tyron", Description = "A silver thread spun by unknown gods. Said to lead lost souls through forgotten paths.", StartingPrice = 800, ImageFileName = "Thread of tyron.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(5) },
                new Product { Id = 5, Name = "Medusa’s Mirror", Description = "A cursed mirror that once reflected the gaze of Medusa. Some say it still can.", StartingPrice = 600, ImageFileName = "Medusa's Mirror.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(8) },
                new Product { Id = 6, Name = "Zeus' Lightning Bolt", Description = "A replica, yes... but still crackling with static. Handle with reverence.", StartingPrice = 1000, ImageFileName = "Zeus lightningbolt.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(5) },
                new Product { Id = 7, Name = "Aphrodite’s Comb", Description = "Brushing with this comb is said to make even the stars blush. Love lingers in every tooth.", StartingPrice = 450, ImageFileName = "Aphrodite's Comb.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(3) },
                new Product { Id = 8, Name = "Helm of Darkness", Description = "Worn by Hades himself. With it, one vanishes from mortal and divine sight alike.", StartingPrice = 1200, ImageFileName = "helm-of-darkness.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(5) },
                new Product { Id = 9, Name = "Ambrosia", Description = "The forbidden nectar of the gods. They say a sip adds a century to your life.", StartingPrice = 1000, ImageFileName = "Ambrosia.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(6) },
                new Product { Id = 10, Name = "Hermes’ Sandals", Description = "Winged and enchanted, made for swift travel between worlds and whispering winds.", StartingPrice = 700, ImageFileName = "hermes-sandals.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(9) },
                new Product { Id = 11, Name = "Thor’s Hammer", Description = "A forged replica of Mjölnir. Still surprisingly heavy. Lifting it may reveal your worth.", StartingPrice = 950, ImageFileName = "Thors Hammer.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(8) },
                new Product { Id = 12, Name = "Golden Fleece", Description = "Woven from the golden ram, its glow is said to grant fortune, or madness.", StartingPrice = 1100, ImageFileName = "The Golden Fleece.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(5) },
                new Product { Id = 13, Name = "Poseidon’s Shell", Description = "Plucked from the trench’s darkest depths. Some say it whispers tides in ancient tongues.", StartingPrice = 500, ImageFileName = "Poseidon's shell.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(5) },
                new Product { Id = 14, Name = "Poseidon's Trident", Description = "It shakes the sea. A weapon of command, control, and crashing waves.", StartingPrice = 1300, ImageFileName = "poseidons-trident.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(6) },
                new Product { Id = 15, Name = "The Spindle of Destiny", Description = "An ancient spinning spindle, said to be cursed. One touch and the world falls quiet.", StartingPrice = 400, ImageFileName = "spinning spindle.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(5) },
                new Product { Id = 16, Name = "Poison Apple of Death", Description = "Perfect and red... a single bite seals your fate. Still fresh after centuries.", StartingPrice = 380, ImageFileName = "Poison apple.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(9) },
                new Product { Id = 17, Name = "Cinderella’s Slipper", Description = "Glass-crafted destiny. If it fits, your path changes forever.", StartingPrice = 620, ImageFileName = "Cinderella's slipper.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(4) },
                new Product 
{ 
    Id = 18, 
    Name = "The One Ring", 
    Description = "Forged in the fires of Mount Doom. Grants invisibility — and a growing obsession.", 
    StartingPrice = 1500, 
    ImageFileName = "the-one-ring.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(4) 
},

new Product 
{ 
    Id = 19, 
    Name = "True Love’s Kiss", 
    Description = "Captured in a magical vessel or locked within a chest, this kiss breaks the darkest curses.", 
    StartingPrice = 900, 
    ImageFileName = "true-loves-kiss.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(7) 
},

new Product 
{ 
    Id = 20, 
    Name = "The Emerald Tablet", 
    Description = "Inscribed with cosmic secrets in glowing green script. The alchemical key to 'as above, so below.'", 
    StartingPrice = 1250, 
    ImageFileName = "emerald-tablet.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(5) 
},

new Product {
    Id = 21,
    Name = "Tarot of the Veiled Realms",
    Description = "Forged in shadow and insight, this elusive deck reveals more than mere futures—it reveals veiled truths. Only the brave may draw from it.",
    StartingPrice = 900,
    ImageFileName = "Tarot of the Veiled Realms.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(6)
},

new Product {
    Id = 22,
    Name = "The Enchanted Ouija Board",
    Description = "This violet-hued spirit board pulses with ancient presence. It speaks not only to the dead, but to forgotten echoes of magic itself.",
    StartingPrice = 850,
    ImageFileName = "Enchanted Ouija Board.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(8)
},

new Product {
    Id = 23,
    Name = "The Thirteenth Hour Sandglass",
    Description = "A cursed hourglass that counts a hidden hour no one sees. Time rewinds for those who dare flip it.",
    StartingPrice = 950,
    ImageFileName = "The Thirteenth Hour Sandglass.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(11)
},
new Product {
    Id = 24,
    Name = "The Lantern of the Deep Moon",
    Description = "Glows only in total darkness. Believed to guide lost spirits home.",
    StartingPrice = 780,
    ImageFileName = "The Lantern of the Deep Moon.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(8)
},
new Product {
    Id = 25,
    Name = "The Wand of the Hollow Grove",
    Description = "Carved from the last living tree in a cursed forest, this wand pulses with ancient magic. Its touch is strangely warm.",
    StartingPrice = 750,
    ImageFileName = "The Wand of the Hollow Grove.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(9)
},
new Product {
    Id = 26,
    Name = "The Atlas of Lost Stars",
    Description = "A celestial map that charts constellations no longer in the sky. Some say they never were.",
    StartingPrice = 940,
    ImageFileName = "The Atlas of Lost Stars.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(5)
},
new Product {
    Id = 27,
    Name = "The Widow’s Veil",
    Description = "Said to be woven by death herself. Whoever wears it sees beyond the veil of life.",
    StartingPrice = 890,
    ImageFileName = "The Widow’s Veil.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(6)
},

new Product {
    Id = 28,
    Name = "The Coin of Forgotten Realms",
    Description = "Flip it and hear the name of a place not on any map.",
    StartingPrice = 880,
    ImageFileName = "The Coin of Forgotten Realms.jpg",AuctionEndTime = DateTime.UtcNow.AddMinutes(9)
}



            );
        }
    }
}
