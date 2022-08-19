﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SRRSBakery.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Cake> Cakes { get; set; }
        public DbSet<CakeCategory> CakeCategories { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Cakes", Description = "Cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Breads", Description = "Breads" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Pancakes", Description = "Pancakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Cookies", Description = "Cookies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "CupCake", Description = "CupCake" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 6, CategoryName = "Pizza", Description = "Pizza" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 7, CategoryName = "Donuts", Description = "Donuts" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 8, CategoryName = "Chips", Description = "Chips" });

        
            modelBuilder.Entity<CakeCategory>().HasData(new CakeCategory { CakeCategoryId = 1, CakeCategoryName = "Flavor Cakes", CakeDescription = "Flavor Cakes" });
            modelBuilder.Entity<CakeCategory>().HasData(new CakeCategory { CakeCategoryId = 2, CakeCategoryName = "BirthDay Cakes", CakeDescription = "BirthDay Cakes" });
            modelBuilder.Entity<CakeCategory>().HasData(new CakeCategory { CakeCategoryId = 3, CakeCategoryName = "HeartShape Cakes", CakeDescription = "HeartShape Cakes" });
            modelBuilder.Entity<CakeCategory>().HasData(new CakeCategory { CakeCategoryId = 4, CakeCategoryName = "Premium Cakes", CakeDescription = "Premium Cakes" });

            //seed Cakes
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
               CakeId = 1,
               Name = "Round Chocolate Truffle Cake",
               Price = 549,
               ShortDescription = "The devilishly delicious taste of this cake with Cocoa fix leaves you 'High' on chocolate in every good sense.",
               LongDescription = "The heavenly taste of this Choco Truffle Cake will even leave the hardest-to-please chocolate addicts tranquil in every sense. Prepared with three layers of relishing chocolate cream filled in between the soft stacks of chocolate cake, and adorned with beautiful chocolate icing and rich glaze chocolate coating, this one is just irresistible.",
               CategoryId = 1,
               CakeCategoryId = 1,
               ImageUrl = "https://media.bakingo.com/sq-choco-truffle-cake0005choc-AA.jpg?tr=w-320,h-320,q-70",
               ImageUrlLarge = "https://media.bakingo.com/sq-choco-truffle-cake0005choc-AA.jpg",
               ImageUrlLargee = "https://media.bakingo.com/sq-choco-truffle-cake0005choc-AB.jpg",
               ImageUrlLargeee = "https://media.bakingo.com/sq-choco-truffle-cake0005choc-AD_0.jpg",
               InStock = true,
               Bestseller = true,

             });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 2,
                Name = "Heavenly Red Velvet Chocolate Cake",
                Price = 649,
                ShortDescription = "The two most relished flavours in a single cake--chocolate and red velvet to take your pleasures to next level.",
                LongDescription = "The two celebratory flavours in a single cake -red velvet cake layers entirely covered in dark chocolate cream roses sprinkled with red velvet crumbs. A slice of the cake won't be enough to celebrate the fusion of flavours; you would need a whole cake.",
                CategoryId = 1,
                CakeCategoryId = 1,
                ImageUrl = "https://media.bakingo.com/sq-red-velvet-chocolate-cake-cake1637redv-A_0.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-red-velvet-chocolate-cake-cake1637redv-A_0.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-red-velvet-chocolate-cake-cake1637redv-B_0.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-red-velvet-chocolate-cake-cake1637redv-D_0.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 3,
                Name = "Buttery Delight Butterscotch Cake",
                Price = 649,
                ShortDescription = "Butterscotch is savoured by all age groups. Bakingo presents delicious butterscotch delight is crowned with...",
                LongDescription = "Butterscotch is savoured by all age groups. Bakingo presents delicious butterscotch delight is crowned with buttercream ribbon curls toped with white chocolate. You can send butterscotch cakes online to your dear ones and bring a broad smile on their face.",
                CategoryId = 1,
                CakeCategoryId = 1,
                ImageUrl = "https://media.bakingo.com/sq-round-buttery-delight-butterscotch-cake-cake2281butt-A_1.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-round-buttery-delight-butterscotch-cake-cake2281butt-A_1.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-round-buttery-delight-butterscotch-cake-cake2281butt-B_1.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-round-buttery-delight-butterscotch-cake-cake2281butt-D_1.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 4,
                Name = "Round Pink Roses Vanilla Cake",
                Price = 649,
                ShortDescription = "So, Valentine's Day is approaching and you must be looking for something to swoon your beloved. Here's this...",
                LongDescription = "So, Valentine's Day is approaching and you must be looking for something to swoon your beloved. Here's this fluffy and moist vanilla cake topped with pink roses. You'll love this Vanilla Rose Cake for it's refreshing and subtle sweet flavors. Order now!",
                CategoryId = 1,
                CakeCategoryId = 1,
                ImageUrl = "https://media.bakingo.com/sq-round-pink-roses-vanilla-cake-rosecake2561vani-A_0.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-round-pink-roses-vanilla-cake-rosecake2561vani-A_0.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-round-pink-roses-vanilla-cake-rosecake2561vani-B_0.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-round-pink-roses-vanilla-cake-rosecake2561vani-D_0.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 5,
                Name = "Chocolate Vanilla Duet Cake",
                Price = 559,
                ShortDescription = "The best of both worlds reimagined in a cake? duet of chocolate and vanilla with chocolate garnishes on the top and red cherry. The cake will surely leave you with a sweet lingering taste.",
                LongDescription = "Your dessert of the day exquisite choco vanilla cake. Yes, you can have both at the same time. You won't know until you have a bite of it. The picture says it all! This choco vanilla cake can be a snack while whipping over a hot coffee. An ideal choice for any celebration.",
                CategoryId = 1,
                CakeCategoryId = 1,
                ImageUrl = "https://media.bakingo.com/sq-choco-vanilla-cake-2-cake893chva-A_1.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-choco-vanilla-cake-2-cake893chva-A_1.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AB.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-choco-vanilla-cake-2-cake893chva-C_1.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 6,
                Name = "Topical Mango delight",
                Price = 559,
                ShortDescription = "Taste the terrific tropic mango cake with a zesty blend of mango and mushy rich cream. Made of three rich...",
                LongDescription = "Taste the terrific tropic mango cake with a zesty blend of mango and mushy rich cream. Made of three rich cream layers and mango fillings, this cake is a tantalizing treat. The crest that is frosted with white chocolate shavings offers mango glaze which is made from fresh mango pulp. So, next time when life gives you lemons, throw it back and say I said l wanted mango!",
                CategoryId = 1,
                CakeCategoryId = 1,
                ImageUrl = "https://media.bakingo.com/sq-mango-cake0020frui-A_2.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-mango-cake0020frui-A_2.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-mango-cake0020frui-B_2.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-mango-cake0020frui-E.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 7,
                Name = "Assorted Fruit and Almond Cake",
                Price = 699,
                ShortDescription = "With farm-fresh fruits inside the cream layers and topped over a vanilla cake with almond shavings, your tastebuds will do the sweet-tango dance.",
                LongDescription = "Freshly baked Vanilla cake, Whipped cream and bountiful tropical fruits come together to create a treat that is even tastier than it looks. This combination of whipped cream and fresh fruit is a perfect start for any celebration and an enticing end to any meal.",
                CategoryId = 1,
                CakeCategoryId = 1,
                ImageUrl = "https://media.bakingo.com/sq-fresh-fruit-cake0014frui-AA.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-fresh-fruit-cake0014frui-AA.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-fresh-fruit-cake0014frui-AB.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-fresh-fruit-cake0014frui-AD.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 8,
                Name = "Glazing Red Velvet Cake",
                Price = 749,
                ShortDescription = "Celebrate your birthday and the birthday of your loved ones with this aesthetically pleasing red velvet cake....",
                LongDescription = "Celebrate your birthday and the birthday of your loved ones with this aesthetically pleasing red velvet cake. It is half red and half orange in color and the taste is just a chef's kiss. The sheer beauty and taste of this lovely cake is sure to impress just about anyone.",
                CategoryId = 1,
                CakeCategoryId = 2,
                ImageUrl = "https://media.bakingo.com/sq-dripping-with-deliciousness-red-velvet-cake-cake2297redv-A_0.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-dripping-with-deliciousness-red-velvet-cake-cake2297redv-A_0.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-dripping-with-deliciousness-red-velvet-cake-cake2297redv-B_0.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-dripping-with-deliciousness-red-velvet-cake-cake2297redv-F_0.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 9,
                Name = "Birthday Chocolate Pinata Cake",
                Price = 1399,
                ShortDescription = "Grab the most special birthday cake for celebrations of your loved one’s birthday....",
                LongDescription = "Grab the most special birthday cake for celebrations of your loved one’s birthday this year with a gorgeous chocolate pinata cake! Crack this fun filled delight to get a bite off of a dense chocolate cake topped with colourful gems, two kitkat and two Ferrero Rochers. This year crack the cake open instead of cutting it! Note: Hammer will be given with the cake.",
                CategoryId = 1,
                CakeCategoryId = 2,
                ImageUrl = "https://media.bakingo.com/sq-birthday-chocolate-overload-pinata-cake-750gm-pina2163choc-A_0.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-birthday-chocolate-overload-pinata-cake-750gm-pina2163choc-A_0.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-birthday-chocolate-overload-pinata-cake-750gm-pina2163choc-B_0.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-birthday-chocolate-overload-pinata-cake-750gm-pina2163choc-D_0.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 10,
                Name = "Happy Birthday Vanilla Cake",
                Price = 699,
                ShortDescription = "Celebrate your birthday and the birthday of your loved ones with this aesthetically pleasing cake....",
                LongDescription = "Is yours or your loved ones around the corner? Winter birthday are always fun and exciting. How about this delicious snowman snowy cake for their birthday? Baked with love and topped with an edible snowman, this birthday is sure to be a cozy one for you and your loved ones.",
                CategoryId = 1,
                CakeCategoryId = 2,
                ImageUrl = "https://media.bakingo.com/sq-round-snowman-happy-birthday-vanilla-cake-cake2407vani-A_0.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-round-snowman-happy-birthday-vanilla-cake-cake2407vani-A_0.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-round-snowman-happy-birthday-vanilla-cake-cake2407vani-B_0.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-round-snowman-happy-birthday-vanilla-cake-cake2407vani-C_0.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 11,
                Name = "Birthday Black Forest Pinata Cake",
                Price = 1449,
                ShortDescription = "End the wait, break the ball with this black forest pinata cake, the true taste of surprise and luxury....",
                LongDescription = "End the wait, break the ball with this black forest pinata cake, the true taste of surprise and luxury. It is a ball-shaped cake with a ball made of chocolate and a hammer that helps you break it loose. Next, what you see inside is a delicious black forest cake with icing, frosting and sponge, all chocolaty and mouth savouring. Make it your choice for all coming occasions.Note: Hammer will be given with the cake.",
                CategoryId = 1,
                CakeCategoryId = 2,
                ImageUrl = "https://media.bakingo.com/sq-birthday-black-forest-pinata-cake-800gm-pina2042blac-A_0.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-birthday-black-forest-pinata-cake-800gm-pina2042blac-A_0.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-birthday-black-forest-pinata-cake-800gm-pina2042blac-C_0.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-birthday-black-forest-pinata-cake-800gm-pina2042blac-D_0.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 12,
                Name = "Pineapple Gems Pinata Cake",
                Price = 1449,
                ShortDescription = "Both a joy to your sight as well as your taste buds, this pineapple flavoured scrumptious cake....",
                LongDescription = "Both a joy to your sight as well as your taste buds, this pineapple flavoured scrumptious cake is a delight that you must indulge in every celebration! Frosted with pastel shades of buttercream, drizzling white chocolate ganache, and dollops of pink whipped cream on top, this delicious cake is loaded with copious amounts of gems in the center that spills out when you cut a slice!",
                CategoryId = 1,
                CakeCategoryId = 2,
                ImageUrl = "https://media.bakingo.com/sq-pineapple-gems-pinata-cake-pina2149pine-A_0.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-pineapple-gems-pinata-cake-pina2149pine-A_0.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-pineapple-gems-pinata-cake-pina2149pine-B_0.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-pineapple-gems-pinata-cake-pina2149pine-D_0.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 13,
                Name = "Heart Black Forest Vanilla Cake",
                Price = 649,
                ShortDescription = "The chocolate and vanilla blend beautifully in texture, yet pleasantly contrast in color and flavor.",
                LongDescription = "The chocolate and vanilla blend beautifully in texture, yet pleasantly contrast in color and flavor. Watch your special ones relish with excitement when they experience the unforgettable taste of this rich and creamy three-layered cake. Beautifully finished into a heart-shape with chocolate shavings and cherries on one side and hand-crafted Red Rose on the other, is indeed, a Torrid Love Affair.",
                CategoryId = 1,
                CakeCategoryId = 3,
                ImageUrl = "https://media.bakingo.com/squ-heart-shaped-black-forest-vanilla-cake0039hbfv-A.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/squ-heart-shaped-black-forest-vanilla-cake0039hbfv-A.jpg",
                ImageUrlLargee = "https://media.bakingo.com/squ-heart-shaped-black-forest-vanilla-cake0039hbfv-B.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/squ-heart-shaped-black-forest-vanilla-cake0039hbfv-C.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 14,
                Name = "Pink Hearty Rose Strawberry Cake",
                Price = 749,
                ShortDescription = "Beautifully in texture, yet pleasantly contrast in color and flavor.",
                LongDescription = "Convey love and affection on your better half this Valentine’s Day with a lip-smacking and enticing pink hearty rose strawberry cake. This enticing pink hearty cake is decorated with red hearts on top and rose swirls on the sides. Place your order now and customise the taste, design, sizes, and more!",
                CategoryId = 1,
                CakeCategoryId = 3,
                ImageUrl = "https://media.bakingo.com/sq-pink-hearty-rose-strawberry-cake-cake2536stra-A_1.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-pink-hearty-rose-strawberry-cake-cake2536stra-A_1.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-pink-hearty-rose-strawberry-cake-cake2536stra-B_1.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-pink-hearty-rose-strawberry-cake-cake2536stra-C_1.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 15,
                Name = "Vanilla Heart Cake",
                Price = 749,
                ShortDescription = "This mouthwatering and lip-smacking cake comes with all the bells and whistles for love.....",
                LongDescription = "This mouthwatering and lip-smacking cake comes with all the bells and whistles for love. It has a full heart-shape that maintains the heart theme throughout. The heart's left side is designed with heart-shaped flowers and the other with two golden earrings with pearls.",
                CategoryId = 1,
                CakeCategoryId = 3,
                ImageUrl = "https://media.bakingo.com/sq-vanilla-heart-cake-cake1708vani-A_0.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-vanilla-heart-cake-cake1708vani-A_0.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-vanilla-heart-cake-cake1708vani-B_0.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-vanilla-heart-cake-cake1708vani-C_0.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 16,
                Name = "Pineapple Heart Shaped Pinata Cake",
                Price = 1049,
                ShortDescription = "Love is flavoursome, just like this cake a diamond-heart pinata cake in pineapple flavour.....",
                LongDescription = "Love is flavoursome, just like this cake a diamond-heart pinata cake in pineapple flavour. Inside the pinata, there is a heart-shaped sponge cake layered with whipped cream and drizzled with pineapple syrup. Break into sweet love and happiness on any celebration of yours. Note: Hammer will be given with the cake.",
                CategoryId = 1,
                CakeCategoryId = 3,
                ImageUrl = "https://media.bakingo.com/sq-pineapple-pinata-cake-450gm-pina2265pine-A_0.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-pineapple-pinata-cake-450gm-pina2265pine-A_0.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-pineapple-pinata-cake-450gm-pina2265pine-C_0.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-pineapple-pinata-cake-450gm-pina2265pine-D_0.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 17,
                Name = "Snicker Fuse Chocolate Cake",
                Price = 649,
                ShortDescription = "Snickers snickers all around! Your super healthy dessert topped with molten chocolate and chocolate chunks, you can't stop drooling over this cake.",
                LongDescription = "Award yourself with this rich chocolate cake wonderfully crammed with Cadbury Fuse and white chocolate chunks and draped lusciously with molten chocolate. This perfect work of art hides in every bite, the scrumptious flavours of heavily whipped chocolate cream and nutty bits of chocolate that is a little nutty and a lot of tasty!",
                CategoryId = 1,
                CakeCategoryId = 4,
                ImageUrl = "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AA.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AA.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AB.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AD.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 18,
                Name = "Double Trouble Fondant Cake",
                Price = 4699,
                ShortDescription = "Love is sweet and creamy, just like this cake! Spoil the love of your life with a two-tier decadent...",
                LongDescription = "Love is sweet and creamy, just like this cake! Spoil the love of your life with a two-tier decadent. Baked with lots of love, enrobed in colours of affection, and adorned with romantic hearts, the cake will infuse the moment with amorous feelings like the way you wanted.",
                CategoryId = 1,
                CakeCategoryId = 4,
                ImageUrl = "https://media.bakingo.com/sq-fondant-two-tier-cake-them1395flav-A_0.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-fondant-two-tier-cake-them1395flav-A_0.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-fondant-two-tier-cake-them1395flav-A_0.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-fondant-two-tier-cake-them1395flav-A_0.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 19,
                Name = "Round Golden Jubilee Anniversary Fondant Cake",
                Price = 5999,
                ShortDescription = "Celebrate the milestone of completing 50 years of togetherness deliciously....",
                LongDescription = "Celebrate the milestone of completing 50 years of togetherness deliciously. Send your blessings and wishes to those who matter the most to you with this ambrosial anniversary cake. It is a perfect cake if you are throwing a grand party. Order this cake and make your celebration tastier.",
                CategoryId = 1,
                CakeCategoryId = 4,
                ImageUrl = "https://media.bakingo.com/sq-round-golden-jubilee-anniversary-cake-them1386flav-A_0.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-round-golden-jubilee-anniversary-cake-them1386flav-A_0.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-round-golden-jubilee-anniversary-cake-them1386flav-A_0.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-round-golden-jubilee-anniversary-cake-them1386flav-A_0.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 20,
                Name = "3 Tier Party Celebration Cake",
                Price = 4599,
                ShortDescription = "Special Cake",
                LongDescription = "This 4 kg three-tier Cake is especially crafted with ecstasy and fervor, for you to savor its captivating taste, on all celebrations of happy times and memories. This winning cake is sure to tickle your taste buds. From how it looks to how it tastes, you indubitably are going to be utterly engaged with the very first bite. Serving: 28-30",
                CategoryId = 1,
                CakeCategoryId = 4,
                ImageUrl = "https://media.bakingo.com/sq3-tier-party-cake-for-any-celebration-A_0.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq3-tier-party-cake-for-any-celebration-A_0.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq3-tier-party-cake-for-any-celebration-A_0.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq3-tier-party-cake-for-any-celebration-A_0.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 21,
                Name = "4 Tier Anniversary Party Cake",
                Price = 10599,
                ShortDescription = "SRRS Special delicious Cake...",
                LongDescription = "Introduce a slice of heaven to your celebratory occasion and be the most amazing host of the party with this lovely 4 tiered party cake. Add spark to this vegan eggless delight with a customisable choice of the base cake flavour. Add a little slice of heaven to your party with this thick fondant-covered creamy and delicious party cake!",
                CategoryId = 1,
                CakeCategoryId = 4,
                ImageUrl = "https://media.bakingo.com/sq-4-tier-anniversary-party-cake-part1802flav_0.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-4-tier-anniversary-party-cake-part1802flav_0.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-4-tier-anniversary-party-cake-part1802flav_0.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-4-tier-anniversary-party-cake-part1802flav_0.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 22,
                Name = "3 Tier Royal Party Cake",
                Price = 5899,
                ShortDescription = "SRRS Royal delicious Cake...",
                LongDescription = "It's party time so rejoice and order this stunning fondant party cake getting it made any of your favourite flavours. This royal black and gold fondant three-tier cake is sure to make it to the highlight of the special celebratory occasion, making it a memorable one.",
                CategoryId = 1,
                CakeCategoryId = 4,
                ImageUrl = "https://media.bakingo.com/sq-3-tier-royal-party-cake-part1796flav_0.jpg?tr=w-320,h-320,q-70",
                ImageUrlLarge = "https://media.bakingo.com/sq-3-tier-royal-party-cake-part1796flav_0.jpg",
                ImageUrlLargee = "https://media.bakingo.com/sq-3-tier-royal-party-cake-part1796flav_0.jpg",
                ImageUrlLargeee = "https://media.bakingo.com/sq-3-tier-royal-party-cake-part1796flav_0.jpg",
                InStock = true,
                Bestseller = true,
            
            });
            

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 1,
                Name = "curly fries",
                Price = 30,
                ShortDescription = " curly fries tend to have a golden--orange-brown coating",
                LongDescription = "curly fries pl (normally plural, singular curly fry) (chiefly Canada, US) A kind of fries characterized by their spring-like shape, being cut from whole potatoes using a specialized spiral slice",
                CategoryId = 8,
                ImageUrl = "data:image/jpeg;base64,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",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "data:image/jpeg;base64,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",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 2,
                Name = "plantain chips",
                Price = 50,
                ShortDescription = "Baked plantain chips are chips made from green plantain",
                LongDescription =
                    "Are plantain chips healthy? Yes, plantain chips are a great healthy snack! Since they are oven-baked, they are not high in fat and calories like deep-fried plantain chips would be, and since you are making them from home, you can use a high-quality, healthy oil like olive or coconut oil to make your chips",
                CategoryId = 8,
                ImageUrl =
                "data:image/jpeg;base64,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",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl =
                    "data:image/jpeg;base64,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",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 3,
                Name = "Beetroot chips",
                Price = 100,
                ShortDescription = "healthy, guilt-free snack or can be ground into a fine powder for baking and other uses",
                LongDescription =
                   " Beets are chock full of nutrients such as fiber, Vitamin C and folates. They are also low calorie and have been proven to lower blood pressure. So yes, beets are very healthy, but if you are on a low carb diet, they don't work well as a compliant vegetable",
                CategoryId = 8,
                ImageUrl =
               "data:image/jpeg;base64,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",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl =
                   "data:image/jpeg;base64,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",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId =4 ,
                Name = "Kellogg's Pringles",
                Price =120 ,
                ShortDescription = "potato chips",
                LongDescription =
                   "P&G, the world's largest consumer products company, had decided to sell Pringles as part of a bid to exit non-core businesses. For Kellogg's, however, also the world's largest breakfast cereal maker, Pringles was a key addition to its portfolio of convenience foods.",
                CategoryId = 8,
                ImageUrl =
               "https://m.media-amazon.com/images/I/51GngLwzzkL._SX679_.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl =
                   "https://m.media-amazon.com/images/I/51GngLwzzkL._SX679_.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 5,
                Name = "Lays",
                Price =20 ,
                ShortDescription = "normal farming and chip-making process",
                LongDescription =
                   "Lay's is a brand of potato chips, as well as the name of the company that founded the chip brand in the United States. The brand has also sometimes been referred to as Frito-Lay because both Lay's and Fritos are brands sold by the Frito-Lay company, which has been a wholly owned subsidiary of PepsiCo since 1965",
                CategoryId = 8,
                ImageUrl =
               "https://m.media-amazon.com/images/I/71q0N2HhJ2L._SX679_.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl =
                   "https://m.media-amazon.com/images/I/71q0N2HhJ2L._SX679_.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId =6 ,
                Name = "chocolate frosted doughnut",
                Price = 150,
                ShortDescription = "They taste like sweet dough with frosting or icing or powdered sugar on top with sprinkles",
                LongDescription =
                   "Sift together the sugar, cocoa powder, and salt in a medium mixing bowl. Add the milk, then mix in the vanilla and corn syrup to make a smooth glaze. If the glaze is thick, add a little extra milk to loosen to a pourable consistency",
                CategoryId = 7,
                ImageUrl =
               "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ2dMtbUQ8SpZLVVb0B57DINSR8duTXQS2FdA&usqp=CAU",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl =
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ2dMtbUQ8SpZLVVb0B57DINSR8duTXQS2FdA&usqp=CAU",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 7,
                Name = "Cinnamon Twist Doughnut",
                Price =200 ,
                ShortDescription = "A heavenly twist to an old favorite",
                LongDescription =
                   "This doughnut has a unique, twisted shape that may be rectangular or circular. In New England, these beloved doughnuts tend to be of the rectangular variety. But the French Cruller is generally ring-shaped",
                CategoryId = 7,
                ImageUrl =
               "data:image/jpeg;base64,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",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl =
                   "data:image/jpeg;base64,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",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 8,
                Name = "strawberry frosted doughnut",
                Price = 180,
                ShortDescription = "Soft, cakey, and moist",
                LongDescription =
                   "Description. Soft, cakey, and moist homemade donuts are baked not fried, and topped with strawberry frosting",
                CategoryId = 7,
                ImageUrl =
               "data:image/jpeg;base64,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",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl =
                   "data:image/jpeg;base64,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",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 9,
                Name = "Jelly Doughnut",
                Price = 190,
                ShortDescription = "holiday donuts",
                LongDescription =
                   "This holiday season, we're tracking down the origins of some favorite holiday traditions. Today, we're talking Hanukkah and jelly donuts. In Hebrew, they're called sufganiyo",
                CategoryId = 7,
                ImageUrl =
               "data:image/jpeg;base64,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",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl =
                   "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAoHCBUVFRgVFRYZGRgYHBoZGRocGhoaHBgaHBwcGhoaGhocIS4lHB4rIRoaJjgmKy8xNTU1GiQ7QDs0Py40NTEBDAwMEA8QHxISHjQrJCs0NDQ0NjQ0NDQ0NDc0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NP/AABEIAKgBKwMBIgACEQEDEQH/xAAbAAABBQEBAAAAAAAAAAAAAAAFAAECAwQGB//EADsQAAEDAgQEAwcDAwQBBQAAAAEAAhEhMQMEEkEFUWFxIoGRBhMyobHR8ELB4RRS8RVigpIjBxZDcrL/xAAZAQACAwEAAAAAAAAAAAAAAAAAAgEDBAX/xAAmEQADAAICAgIDAAIDAAAAAAAAAQIDERIhMUETUQQiYaHwMkJx/9oADAMBAAIRAxEAPwD0hMpJlB0SJSTpkoxApFSKiUEoimITpEKBiMXUSO9KeakVEqARFw3TOCdJ3MoGIFRcplRcFAxWUxVjgqyoBEYTA0NLxB5VUioFBJBMVIhRKBiJTFxiNplSKiUARTFSTaTE7SB1kybeSCSCSRSQSRKYpFMUAIlNKUqMoAeUlGUpQBKU0ppTSgCUppTSmlAEpTyoSlKAOyUVJMVcYRlEqSYoAiVEqZUSlGQxTJykUDESoFTcrcHLOdQCnM2UEOlK2zMVJuG41DSdqCa38tkXy+Ra241HmRQdgtkJlJnv8n1KAWHwzENwB3P2Vw4Od3DyH8owSq/etnTImJiaxzjkp4oqf5OR+AUOCHd4/wCu/qoHgrv7m+hRjUYmINKU36qvEdUTO5kWpHmbqOKBfkZPsCu4S8TLmiBNzbrRVDhWIbFp3o7Y2Nkec51TSNrzPI0p6rM/Ec0hxaBIJvqJiBS1YhQ5Q0/kZAOOGYpsB5OBn0WbMZdzPiaR129bI8H6iHN8NI+GjqihjyI7pf1JJ0ltCPhMUPJ07mUukXT+Rk32kc0mKLZnJNIloh1yAZB1ExE7U/goViMLTDhHLkex3SmqMk2QKiVIqJQWkSmTlRKCRiolSKaCbAlQ2BApineC0w4EHqCPqmUkkZSlJRQA8pSmlKUAPKaUpTSgB5SlRlPKAO1KZOkrjnkUykooJGKiVJRKUZDFMU5VWYxQxrnOsAT9gPohkmrL4QMl1hFOZNvzotrH01EwLBvw0mki8mQI6gQvP3cWxHw5ziBP6Y8IBkBsiJE35jZaDxLWC04jmtaSQ0DctkS6/wAYFtpoq1mn0VZMFN7bO4aT4TqMEfCAKk1BmAR085SxswARp8ROoCAXGlHSQDpEiO65PK8Ta1rdTy4sJ1Elzi6HAktDyGNFr1FYrVEcLicl2Hh6/wDxBz3OdVpJMjDcQQ7UCY6wRWCnVpoz1ipML4ufa17WO8JIc6DNhIkRQixraR5SzOaY1wD3aBGqZAkAxDidq2CCYQbhgFzg7Ge0Oq7SQ0AEta6sedwICxYubcfE7CbGkObLQ5u1dRFQfST1ELWTS7JnDt9HUYrmHx6paJBAkt2mYFY25LPi5wAhxcKWb4mnxAwXQTfakXQ5rW+6aA5+EJDmkE+JxaSWtaDIbMGCL91m4k3Cw9OE0Nc5xAcD4R4hu4nUI0glrjWRbYdtLZM41vT2EcxnCHtA1S8BwDml0A1pJEVMReh6TkzvEMUmSAA3URp1CkGCZF6G1llx9LQdbSHiAGtdr07lw1UAIgCtvNVPe1ulkyA3UJOksdSWghsgE1EEUCqq342XxjXT1ssONBMhzXGAdIMw6NTXEuLTQTO6d2KQ4aWlzY8MikihMG9btikTtKzYmOH6Wh1i0tcRpdJDQQdMgTFyDWJKfFxHOa4tdDgGzDiXGY1OkUmS2RYTzVLr6LlP2ERjODW+Ml5IIAJ8REAtP9pAnvG91V/UknQ86iSRTnALS0AAAkHmJgzuhWLmpJJbYmCTMmZ8Wok367162OzBcHOLjrEUJc2g1NdJB8V3NrWN9kyyr7D4muzXmcHSaGRSDBFxMEGrSORVBUmcVlpZiCo02FXREkOJJkCKXreE0AwQQQQCCK/hV82q8FmN14ryQKrxcQN7mw5qjM50CQwguFKzE9IEU3k8r7Z8o0ky4yTufygVd5FK6LDRpcam2wRHI4mlwO3M/fYRqWfFZ4afnNWZZ0RInobdQel+8rI8j5bClyk6nDy2HiNAMHVUiPOQDUVEeSA8V4E7CDnNOpg23A5mkEfnNE+GYsAnTJBhrQ7xAmCaH8oUcY4Gt/mOVCujDVTs5fyXivrwebylK6PjfALvwR1LAKRF2gb9P8Hmg5DWjpYss5J2h0pTSoyoLSSaUxKaUAOkmlNKAO6SSSVxzhkydMgkiVEqSiUoyGKEe1D9OAYP6m/KT+yLlYeLYIfhkG0ifp+4VeRtS9DT/wAkcIMcae5nz+1T8lPCxDJgmC0aqyTBDq05inonxck3W5ljXSOdJWR+C5k35C359FgV+mbHKYR9+6ATOkSQ2RAoDaYFfWFrwc4Gy24pZxLaVNjBjxAU/UehXN4usAVBn6XCZuI9p6dCbXqm56XQvxJnTNx5dqAtUU1A3NjcQQCDINT2nmc695bqdOk0Fd4mBYNpEAQIQB2aeBPXkRsPVOzNGbGe9Of51S/J62T8S3s6Z2bcfGHHUCA0N8VAK/EaCCSFXm8257mGQ02MidQgATqJIoOkT2KDszr7in3skzOOmgAqOk2vFOfzUfJ15IWLvejoMzlzp0sIOkXkkknSAamkQOluSswsdzRBdO5i8GriHETIj+EMwM6+Ig1tsAbU+VuSvbiuFQ2vTcXinb5KHkW97I4PWmaPdanGkN2Bi1KzPaysxGySQA0GC7pNCVTki+stpEiLgx6KZkn4SI/LpeUr2Rp7HaYiALwRboZi3+Fhz+IA90nwkxNzG8V5x6Ceut2C8mG2mSaz9VQ7gjnQXGtO0bpayz4Q0pJ7bMedzDS7mB4gCZ8WkCZ5UKDu46Wa8u2NTyCHD9LXAh1OcBn/AGPJH8/w1jGE8qmq4PLtccX3jrPBe28lmpzGye7D9VbgpvbG1OujrsphjSI5LYzMsY0aoaQTWvimIHIRHzQvAzwAJtpG53+w5/dA8fNPxXO0GASXHVBAEw1tjNpI3hWa+x4w89v0jucLNNe2Aa3jda8kdLdUmQagAHnBgjuuX4YfE52GxzWkjS3UXBoAABl3xTLqUIkVNl0WTEkTMTUTEjlag+6z20q1LEqdLQbyIJgtdJPwgEAkN3DgSJEWM7SEbyuMLGjhIMAgT3Ival61C5/Dw2siJEmhABIce9bIxlnhukQZdLSTQzUmd7TErd+PWlo5eed9hcFch7TcJDJxmChPjHIk/EOk3XVYRiASJr3Mbqb2AggiQQQeoWxraM+LI8dckeYSmKIcc4Z7h4Aksd8JO3MHqPmhsqlrR2otXKpeBSlKYpIHFKSUpkAd6kkkVcc0iUxTlMUoyGKgVIqKCUIrLn2F2G8NvpMdxUfRaCq8fC1Mc0kjU1zZFxqBEjrVK1taGXR5ZmeJAZj3hLtYc1rA0tLC2rHufv4riD910mKWviW0j6/Sq47MZEYTjh4lcRroNDB8VT2IE9fNGGZ59gaHlvzA9Fz8s7N9qeuLCf8ATsYZDZ2g2/P4VzsthOiWkWqP3+aGYWZE1Fp539VaM7yPS/K3dZmmhOzdi5Zk7xPSR5rM/LNuFdg5xrrnrFj1WjDxGxFB8vLv90nZPaM2HlAYuN1twsiJkx5AKOXzO238qf8AVBsGTfsElJg2zfgZQAzzWsZZuyw4WeaImq0DiLRcivkiZ2VVyNuFl2zZXOw2jZC3cXYLkfnZVP4+2ukfl1cp0itzbYV8I2UMV3KiA43HjQAXvWK0+5WHH44+Y+lY9LpXDfgecVeyj26z4bguaDBdQ9VyuC8Obgmw90xoJiml72unpq1lUe1Ocdi4jWNOszADaySYDR1nbstvGOHnLDAw3X9yA6La9b3Pg7xqFei248bnF2P/ANkkPk34o1NY0EPBBP6qmKnlQfdEMpwV7naiSOYpXvzWPhuOWgW5HtG/pyubrr8g/UBQ7fNU5KaLVdSujVl8u1rBQAgfmyZj9JgeX4UT0Q2UIzRDXA7brO2+RVL5bC2C6A6RJJBBmIjaOdq90RyuC57aODtQB0ukCmw52NBaL8weUxNd4tWTF9x6DylEsrmnBrWtMBpdqtUTPmBSwtK2YLW/28GbND1+vk6LAa2AJkgU6Vg9rfJaGlA8TiZaQ34t5tfxCkRGkioRjL4gc0EEGRtad/39F0oua6Rzbip7Zm4rkvfYbmExIoeRBBFO49JXnTmlpLXCHNJBHIihXqUyuJ9r8noxG4os+hp+pu57j6FTa62avwsmq4v2AiU0pFNKqOoKU8qKUoJO/KZOmKuOaMVFOVEpSUMUxSKYoGQxTEpKJUDJHPe0/s5/URiYcNxWiK0DxyJ/S7k7yOxHA5nCxMJ2jEY5jps4XHMGzh1EhewIL7RYwdGEQ1zSQCHAuOq7WhkVcZG4oeyqvGn2Ssrl6POmZoiJM/t2PaeV1p/rTUU0yHVuJoBf6LTxLhzG63Na9jgA4YcSTM+AMIkwAXXNJmIgCjgYkUZNS0gOAILSAZDom481RWJls5UwgccgXG3qRNibRurf60iQIpTuZ/hBf6rTfDfQSYaTSAakdCPVQfxdgoWPm3wxfoUnw79DfIg87Pn+afIx2Uv9QLoqaxba9e4QTD47giviEf7N/VN/ruFIDWOcejQP3R8H8J+QOf1LxYm1uXLa1fNWe+J3Pblyr6oLg8dmjcB52pF9gTsrmZrNvaCzJ4jg6K+NwrUGQ0ATMhT8JDyaCrXRv6funrFiqshw7iTiGjLYbJMS8OAbQuqCZNGmwotf/tzNvDnY2Yw8INLg5uG0Oc5rZlzSXRp6yIrIop+AV5pXswZnE0iSRTr6hAM1xNzvAytTWgFeZt9UbznsVLvFjOe8jwgvaTVxDTXw6SCy7hJdSduY4jwjEy7tJ8VKxWCCQ9rokBzSCCJ5GyacUoFlddI6v2Py+VwyMR2IH47qAuHhZIkhprBuNRg7ACTOj/1BwjpwX1o57D/yAI//AC5cLg597bE+VRTnRFM5x9+PhswnumHBzS5oJBDXNIDoEgh281F1c/BMvTLOHu8QEmseRP7rs+GPIPXf/PmuLyeGNTSNjYkE2FZ3FOS6nIYsurc85qDv6Ln5UW+TsnOlsRUfP8/dDc5h6gR6R/C2YDtbAOV/T5qvEZRZr30ymemDOH5ggljqabGlvw/VFmuIpJi3IkRVBcfDhwIio/f+EUy7tQDpsN+tE00WUl5NuC7SQY2PaDQ09R5opwDFJaW1lptzB3napNEJwMGT8QFCekAE99lt4U9wdcT1N9jSamq1/j3SpfXZjzyql/Z0QJ8roPx7Ke8wnxfTqjq2SCKVdZprYojhYkmKAAgdTSPrI8uiF5ni7cNwDg50g2AFZIM94hdKqSXZgxquW15RwrXUSlbON4QbjvAiDDoAiJ278+pKwSqzuRXKUyUpSoymlAx6GmlNCUKzZzRKJTwq34jW3ICjZIimIWXE4gP0ie6yYmced4SOkTyCZIUXOABJMAfnmhHvjzWfP4xcNB3+vL01dUtZNLYJunpBTHzoDS8k6Za1jWkF7tVyK0INYBkVnkheFgz72SwaS1oDGyWa/BDYcJNpIrXakSzWZaASJJ0gDVqDmukao0xDoDARaBIIsqco8Bj2klxB1kgiSYMC9hY7iTRI8i2Qsb1svfgtxHODww6auLgP/IC5oYIgaCYEzT4Z3Cob7P5ZrHEhjw1rmsc1z3NDnN1HX4oBLiPRtoKm0lx94Y0sJEXIsAJmoBjxc420psA8z4Q4utLS4luoQI0gxyokrMMsb9MWX4HgHT/4gAxvgOt7Trc4SXvDgC8338rotg8KyxcdOCHBow2EgMc7++XOcDBaQ25H6uiwl1gXANLgTuWTTekxy6dFew6dLhOokxBEvg01NBqZEOkGwROXXki8bfsY+z+AXNOLgMDWtcJ/U5hIIDnNPisakm1qwoNyeANLMvh4bWGS8uAhrnN0kte6sgE0E12V78RxcWuIcHBpcAQGgNII0zEGtQOqhgOcwVcWt0lwIEF07CxEmk/YKHm70vH+QWN622WZXJ4Re9xwGjFY8S8NbO5oHNDZIBkmL02W7Cxn4mrEbLaBpdpaTqaHeJrAC4kh1v8AduCh7XlryHEmoMtdVpO4LhfxX6EVV+NiNLoDi0BoAJLg4gVguM2IoKXKlZehHj2yXD8MyXDEa6Xa3OcS4tFgWi7RAFzSNrK9ryT7x72+5ILdMSHNlxqDYnkDUb7LK8NJaNTYiCTM6nVdLhzIimxPUmWK1unQ6S0zasCY3pEyOdjyCj5P8f0HHf8A7/BmZmhbhvjDcHFsiTagB1CgsJIgN9QnHOFamu96NQY1+jEAAOrE06XF0iSHGNXi/VPQzg5dtMJw0O+IkQJcAQ0Da2mlDM7kxS97tLsNwDhM6iZIiaREG5rsSSFW7aXf+/wsme/1/wB/p5PxLhL2PfpYfAZJo7SA4jxFt7t8RFa7INi4bmkE2JmGkGxmwXq3GcuHDXihzyxoDfFERNTFSOkje9V5txXhr8IkOLTpJGppBmIFN4gtPOoVuO9o062uwrwxwcA4cpie1OqKZVxmVz3s5mI1NO1+gsO1T8guhZikAt1ENJBjYm0weioyzptDyzseFYwgbzdbntG3kgPCS4ib6YEzIrUeX3R1rpaDyosjXWiulqjFncLkKms7iFXgkNlu30t+eS3Yhkc0NGoEzz9FX4ZZL2gnhuEARB69/wDKvwXuaZaBvN62maikAofgYtAOhhXNdS4j6q2b09ldRvoPZvMaTQ6iHeGBAaCQHNcbTIMeXRRx3DFwwNJlzoiI0uJ1XNhevyuEN98CxrSKgkipg9HDkYvKIZfElpAJpWR8RgChEG4MSN55rqY8ivf00YKx8UvtMAe0eXd4XaSf06viJ8IMOIFwQfJwQPQ7kfRdliaMRjgCSGOkAkxBMQRs4THqhmJkRdh8j91YvHRqw50lxro5/wB07+0+iXunf2n0RV7HNuIUYRs1Kt+DsIVWNitbc+W6bM42kUv9ELfJMlNVaObsszGecaNoPmsTq3VpbyUXNj8/dI+w2UqL29fw/uryyBWk/T8hMGDn22/eijQcjPp9f2VjMEPBH6gZrvzn5eqk/D5GRzVmWEOnaInukyTuWNNafQLzGXdJDjWaGSdQoJPWk+vRVNxCPCRelT3k2PW3NF3skz+BUYmFzCwc6NSpGTAfDC2KzQ+lZ3rOysdmNTWh12/DsIoai5mtVJ2CpDKg7fhUO6J6KH49IgG1e2ql43HoOqm3MAaaUDQL0pQQNqBojkFacgOSt/06lqfdLzobcEH4mqXREmLQLW5226q045iC6QPDWsNkOMHnTny8nGTiyduTUc6Qr4EWCSBadRrApcQZ/IVTnkgHlSOYsfqtjMgpjh26OVP0HKV7MrHTWKX9Sr2Y3I8qGCOlDvdaGZBWMyA3uhc970LVQYmuE6t78wN/yeSgXiT52590Wbw5qubkGhNwuhPmlHMZqXNIraDvI5H0C8/4vkCXOilzHW32XseYwmtBXBcUewPdA6eqaHUPtlk5U10jgsDJOY4E0DobUxBJEH5fNHMPFNfhoIoQRE/pKxcYzESS0VBFQDEi4BsRIIO1Esti6mh7aSJjrHiiP9wPyWl7qdsJrs6XhWIQaWNz13XZZN+psbGC39x+clwGReJEOmk0mZgEivKvoV13CMxaTEWMz12WWlqhr/aQoWrFmcIj82W3XLnAxIMyLEcwq8wJEqupEitMGsxB87Dft6LV7yto+v8ACwYggjn+bLVgMptv+fnNIXM0mDFTQx8loDoAiBMtcIMmkzLTR1hYWHVZWNgEk0kdKb/nZTdiONJMRW9In+fVaMV6KrnZqBDIa0SXanOJPiIDWkE1mkz81A4m3JRxDDWkgggEAmfESTI5wfEOkDsk7yXRh9GK13sZxmhqFT/TN5H5K4BPpVgKqXhhvFwpWPEyyJkKDmCEzRlVtAR2GQbSn07iwFu/OEWfg8r/AJZY8bCIpPZLx0WKtmdhJNgBAO9O6g4WgNPPcdyRXqrGk05j8srWHyjtXzi/RC7JKf6cmgMA7TIHS3NVZ5ujCca+Buof8amNrAlENPMzKeG1DoIIg9QUVKaaCa00zlWcQDvOu3qrhmt4Nq78iIHmuW4pguy+O7Dc6gMsdN2EnSe9x3BUn8QeQRO8xtPYLlVLmtM6SSpbRm4h7TY7XvDTLWkNnS2JMkAg9QKzs68iNvD+N5nVGMxod4aAEOAIBBN4o61xWYQfCZqcZbOt3iaQPFUPEE2q2p5EopiMdqa9wgy79UgDxECIuSannNAr/wBePg0vHJ2WTzReASCARNlrbiGagjuEByPFWwKSRQ/my34efB6LI6SMrxvYRJE0KlhumAhzM0AQD1pegEzRXDOtBj57eso5IVwwk2TspYYcTEQh7uIj9MQbLRgcQH9w2pHNMrnfkRxWvBr0umI85VukjbzVAzQ2NUzs4Lb8lZyleyvjT9FzcU7j88laMQ8kO/1BhsRRRx8+0bWFY7IV69h8bfolxIixEz8lxfEQAXCI3my6HG4gCYqRMX/Oi4riuZc7UdiTFbd/skT5VtGmI4rs5/2iYBBpUTQgx3ix6dQs/BtYY52klgcBO2pwcQ2m8NJ8+tVnWuxXNY0Fz3Eta0RW53sKmvILs28JDcmMs0+MDUHAwDizqmY+Eu8PPSt8z+mhW9PoA4ToqDQ0B2InrawXS8GzQBA9fwrl8viU0lpaQZLdw7eRdt7InkngOEugdAaXFh5eqzXIyr0dvi00vbteOS0TInY2QvJZi7NQO0ion7LblcQGQZkeY8ln16EfRnzTYrHyWNjzet0XxFheyvfntyjkla10WzW0RY+vMU9FeCXOFRagt3lDnvid4srstjmpiSaHkB5pp8jPwGDjEaSGmAXDSDeNJcJnwgy3zBTub/HVZMmyTexJ3uYp+62sZ5kmB9b7Lp4tudsw5dJ6RLGy7mmHCPMH6KMK4YbrXNzME39bQrH5Z02H/YK3RVv7CpSUA9STlFTp6Y4UXVvVJKUC6M2NlNx6fvQLLi4Tm3HO0moRSUviv1/Ovmo0MqaA/vzHX5+qzYuZJtSfPdGX5VrjJp+/z6odjZFwFK/myV7LJqWBeK5BmZZoeYcCSx+7XG/cGkjpzAXDO1YL3YeIIc29KOE0c3m2N16HmW6AS6RH5C4/irDiGXCT127clmyqX58mqMnHr0YcLFMgiszvyupvxXvo40AEDrSnW6HvY5pobbH7qxmcLauBF7Rv1IrWqo0aJzJhXD2AgTHxcjPVaWv3B8VaExa5nqgrMy0mjqGZk15zXzWluLAA1SDet+kb2HoleMbmFm5txpMmNj627KTseZIcdh0mlybC9uSGHHk1dPhA32paLqbMfwls7GAbCok0sYn5pfiG5G/30kDUfDQV8t/JbRmSBTau/wAvRBxmANMVNbTItEBTdmnukaXxAG/KLHoo+MOQXZmzNf8AH5+6li5uYqZFJG4O/Ln6odDiQSIFjJ37flkjAaS51B1AA7oWMV3JsZmNJIEEU/ifzdRxsUkiT5DnNh6fNDTxDCEkPk2IEm/KBVJ2dcROFgYj3TcjQ2OhqY6QmWMR5oRuxsSG2gCtiZde5XK8TxXOOgOa0nmYjudhM1WrPOzz6aAxvJoJP/Yn6QhP+nPbdpCsmZh7Yj/IT8B/hmQbgiR4nu+J+5HJvIb9VvGMVyuG/FYIa8gcrj0KJMzhDA99zMAb8qbK+bTBWmLjmFMYzASWxrAFXNH6u4Hy7KvLZgP8VCIuAe0058rVWHNZx76fC3kP3O6xse5hlpPbZLTVEcls6/IZmCuiwsWgdNQvOMDijgfhPSB8kdyXGHkQMN7uw+6z1D9Dck0dozMSBRMW6hKD5XFx3AacIt/+7gI8gtOHw7Gc6X4pE00tEAdr+t0vFv0JzU+xsxl2tr+eSjlsNzrAxz+3NFcHhzRUy483Ek+ivZhiQLCb/wCKqyMWvIVmeuh8vgGKR2rO1oBm6Je7DANPxESQQRI5VtuqMuzS8AO8JpypzikER8leMoTpc0h01OqtZNT8lujwZKffbKC6NyOe0QIinom924/pKIMyrW+J5k3JNh1WZ/HcIEjU4xyFPKqfX2C2/wDitkjip2ZqL1TpKTW8ctdmhj2usZ+qcsSSQjn2uNdESEkkkEilN+ydJAGXNFjgAWhwB7CYQrM8HwngkAeUjemySSRyn5EbaBWc9kmmYM/zal0IzHsk8WI85CSSprFJCy19mHE9mscfpB7EKh3A8cD4HVmkTHqkkqqxpey1ZqHHCcxs2P8Ag37LWzhGacPhb/1Aj0SSUKP6yXns04XBM3YODRyAbHzC1s9mcd3x4pHanSwSSVk4UyqvyMn2acP2PZd73O81ry/sllmmQwJ0lasUlLzX9hDA4Pgs+FjR5LWMBo2CdJOpSFdNkH4DeQWd+TYbgJJIaQGDF4PhO/QD5fuot4DhRpcxpAsLxukkl4SaMe/sTfZnLn/42+iyZ/gGWBAYwBwuaxHKLSmSUVK0O8lD4HBcNn6BNDbmJHyRHBy7RYD0SSVTSHls1sYrG4aSSVDFrcImgk9qrS3IONSYtfxGI8q2TpLREpiXTXg0NyrGCXbbusFhznHsNtGeI9KNHnv5Jkk76XRb+NjnI90Ac5xB+J8Rps0UA8t/NZtSSSQ68Y5ldI//2Q==",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 10,
                Name = "Blueberry Doughnut",
                Price = 200,
                ShortDescription = "homemade deep fried and bakery style",
                LongDescription =
                   "Dunkin' Donuts' Blueberry Cake Donut is your standard cake donut interspersed with little blueberry-flavored bits and glazed. I picked one up while in Vermont for 99 cents. The best thing about Dunkin's Blueberry Cake Donut is that they offer one at all; none of the donut shops in my neighborhood offer them",
                CategoryId = 7,
                ImageUrl =
               "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAoHCBUVFBcVFRUYGBcaGxsdGxgbGx0gHh4hHR0iGx0dHCIbICwkGyEpIB0bJTYlKS4wMzMzHSI5PjkyPSwyMzABCwsLEA4QHRISHTIpIioyMjIyMjIyMjIyMjAyMjIyMjIyMjIyMjI0MDIyMjIyMjUyMjIyMjIyMjIzMDIyMjQyMv/AABEIAOEA4QMBIgACEQEDEQH/xAAcAAACAgMBAQAAAAAAAAAAAAAEBQMGAAIHAQj/xABHEAABAgQEAwUFBQUFBgcAAAABAhEAAyExBBJBUQUiYQYTcYGRMqGx0fBCUnLB4QcVIzOyFGKCkvEkQ1NUk9IWFzRVc8Li/8QAGgEAAgMBAQAAAAAAAAAAAAAAAAECAwUEBv/EADARAAICAQMCBAMIAwEAAAAAAAABAhEDBCExEkEFUWFxEyKhFDJSgZGxwdEVI/A0/9oADAMBAAIRAxEAPwDok2ZlUXFNPr19YISpxv8AX5/GNMZIzDqNYruJxq5JofI2vc7RXZZVlmHV942H19fXvhRgONIWlJV/DJ1Ps+vzhwgvbX4fXwgCjwCJE/X15RqmPUqhgVPthhz3suY9CkjzTX4K90ecNSE02/ID1u/lDvtFJCpCi1UMqz2oR6PHP8Ripz5USyX3UkF66EvZ9N4VbjT2LqnFBWtBAuP7RSZPtEk3ZIc0p8oo2O4viUAhUtKaVeYmj2J2GkJVqWskrbyL++HRbixSyOoo6Mr9oEiuQLWpnACWrW7s0Br7cTTXukpGzknzt4RTsNJAs0EKWBSJUbGHw6KXzbstUrtpNf8AlhvxM++hjbi3aBGJlgKQqXMQoLQoMoEg1SbEPWrRUEzlO2Xwr6xKJwfYwukufhuBrZFi4rikf2kELGUyHvqc8seFMp8ouSsRWrVUW8y49RX1jmTAs7HWoBhzgeLLpLKFKGUgFKqnKCoJII6UO97wNGZqfD5YV1R3X1ReBMSUjY+sQT2vsRb4e8GECeNE5UKlzEksxpR+VycrAVvaI53H0WKpqafdNR/kiNGfY9XM2t9V93o8CzMQPj6fX1SFK+JygSkzlBnFUn09W9OsRKxUlgn+0M4BqBrXVY0hNMdh0ybU01oafX14R53zW/KFxKDbEJYu3K3R3zsfKNgHIHeoUHsHBr+HNWhhUwtDDDJUtTC3TWLlgcOiTLK1slgSomwArCfs/KSpQCWZNTY+FqG4iuftc48UiXgpamKx3kxvuuQhPgSFE/hG8TgiE3ZX+2/7QJmIUqVhjllCmbVXXwjny1EqBWSSdSYNn4dJFGoHceGvygTDYbPVRMWUQCEqDR5h5feKdqOzDWIJ8rLYnweCuETiAoClb7PBQDn+xy/uL/zp+UZAudWx+vOMgA+gVJim9uEhIQQGJO3SLik/X+vlFO7cKco89vnFUi2IT2ewqZmGQFC4V/UR+cNMHKmSjlU6pf2TXl6eBpCfsVO/glOqFkepCxSLYnY/X0wgBmq1hixHy8Y0Eyv19P1jZSPeP0+XpESE12/P6+UMQUpIUkpOoIPo36xw/iMlYK0zFLWoKbmUXBCiD4a0teO3SknMD4+uscb7QTknEzjRjNWxe38Quw8HgY0Kkykg8qWcMXq9XDUpYekFIlbvGsoOX6+6C5kxuViHf9D9ViSN/SYeiKXd8kKw1Grt8PWNzhlMCPtb0u/5j3GCMNgVLSpeV0JYqOgcsPE9Ih43jUFBzoSBuhKU1P2iwqWrU3eJnbmydCtcLn3Ip0lSSAQxahLm9LxAUKqDo/NVn6HwjWTxxEwnOKHUQykYtCqJUC2n6QipZLqXYDw+IIU1WtvpeHac4SJiaMQX0Buz7wnnYfKwLKSX8TRm+HlF57IYZC5K0lKStykKUnNldPKWOldNoKFmyOEHOW6B04tU0oIISQGXTcty7NvW4pA/EFKKsxFGYVoD1dPNXSkJMNxFKMQqWqpQWWxcDIsFQcXYgiH/ABBSjKfIQulAXY7jeoForaowc8IqTceOxHiJObO6Q5Uo30cnaB8PJzqcoowAqNqNy7NDdUiYpgEskvY71aJcEhQSP4Zf8SdPPy8oi7KAfDcNZ6I5bXcPzV9YnmSlOzIPKSXdrgGC5cxWZf8ADNSl+ZNOUdfg8RrWcxeWochq6dxsfpoEJjPsXJbvVb5AN6ZgSepNY5R2ymiZxDFTJjkJmd2mtEhACPiCfMx1rsdN/mp2yH1zfKOP9qFd1xLGIUP96pQuaTGmCg6Ki6JWACQFJVLRQkXuN391xAeDQUuk6UofEfkYb4fFEgqRLJYVISwHy0EIsBKVMmKJUQ6ja5L6RJCJMeAlLu5rSsQ4FwoJ+83j9Vh7ieAJXLUsK506EsWdiam9qRXJczIb2vAwHn9kxH3F+v6x7Cr95dT6mPYWwH0fmYeX1tFF7XzXUA+8XWcr0iido15pgAFookWxNux03LOWhuWYn3pt7iYv8s0p6ekc3wc3upiFj7Jr4G49CY6LLP16wIJBGTf0+vONgj698Yhz9ecSZYsEQ4yemXLXMLAJSVE9AHjhOJmFeZZd1F8tHJUsU2p4/KOu9ulkYKcBdaco/wAUcjmpokNU5TatVAfGkRY0ZgySwtTaC8XTKDeldOoG1h6wHhUlgl2NR86GDcWFMk0s3R4mj0mB3uWTAzhKwYyNmWtSVcpskClaH2hzDdr2ovaVAWX0Gm5LMT74smDUVS+7cjK+Wr3vfU/ACKnxfFKzlK0tloCNR84kVamoY5KS3bb/AKQokJNq6eVWY/GDMLNL3IMRBaQHzPR/CpDfW8SYCSpRcDX4xGLM/SZJqVXsWsqBl1DJDNQv7rRJKxExIUJa1ICmByqYsDQgio8tCRrEcsFKTzB2IAa501gjhksrXLGV8xAKSfzHWGjXilLG1JbBM3gYkTULUkuoBdS75lOpy9ybiLqogLWnKvlQS+RTW0IDE9BCbjmL7zEIQQORYTTYlPvix4jiUqq+8RkUkgLzpykmwBdiekRkY+tj0xhslab2BUzOUHKvlFeRRJo1AA6vJ4hkqASn2qlR9lR+0XdhSr3g4YpA7tJWnNlFHDmjOA+8Qy8QgsxFCXAI3d/O/nEGjgsgTMTmWK3S3Kr7u7MdYimz0ueb7DWO9HpTWCzNBKuYVUGqPuj/AFiHErDnfLuN4KA87LYjLiiHopCUnxuPe484q37YOE93iJeLA5ZqQhZ2Wkcr9Sj+gw/4Uh5ilDREv+l4tXE+HS8dhVyJoosMSLpUKpUnqCx90TT3ItHz0viisuRBZwxL3o3waIMAhaag0d/n+UTcd4LOwM5UicljdKx7K0vRaTtuNLRmBmOkdKfL4xOyIzMyYQpISpVLba11+niuqwUzKpZBoa+J+EWKWpzmJarlRcua33oWjzEz0oYgODW9qdesDdgVOMh1ml7H1jIQHdsZiqUim4sZpilaD66R05fcIuJY8Wf5xEcThV0JlnoQn8xFfSWdZyTEqJLC1emvh1jo/B8SJktCxqGI6ih+HwgnF9msLNDpSEHRSCw9LRDwjhK8OJiFEFJVmSoUdwxBGhoNT4wdNB1WNkDWJIGTOWPsBvxf/mPe+WbJDfi/RodiEXbk/wCzFH3hM90qYRHLkL5Lj7L2rzJ/NjHVu0cuZMSAJThIWoqccp7tQSwapc3FmEVE8ITl5lnmIDHVqsd3bWE0NFUystWUuHcNW9YLnELS2oDkdGtD3H8NBlZkvmRUbNqOn6QmlKYsRXbaHFm5o8vVGu6B8POKD6eUS4iXLmhzdrN561EezZZcqADXH0zCBs7eNYsNXphliBTODJBegH15Rth+Gpl1D2tpvBKpxapuWDX83j1CFKNySBbWtoRyrDDq4NzNJUNA1mr198O+DFKVhaq5QMuwJsW+0AHeu0V3iq0oMtImc+bMtLWqQlLuQKAHzO0NEYhJSBL5ybNck0FOrQyMMyyOWLihnw6WpeIzUyoUJi1F/vC7bkn0O0XyepOZTtVCopuEwEuXLV3gzTEsqhLu4okjyDxPxXHYeSsmYS60ke0oqVo1C5HjSK2/IyNZl+0ZagrS2Vdy0ywhpdrD4dREKcjB8p5ljQ0CyG9KNFMR2ilAAGVMNgolbZjqWBIS52iVHaCUwHdqZyR/EUDzEm42feFZR9ky+Ra1S5YMwAJ9oEhg3sJD2+mgDiSEPQJokaClS3hr6QNhOK4VZUVKKC7pCiQGygEEglJ5sxrv0jbHKlF1ylhaSACQrMKlVAXOUhrQPgrljlD7yaDuAy/aO6JfwJ+NfOH8sFJcXhN2TUFJU1WRLBPUKmJP9Leg0iw93DoqsE4vwrD42WZU9AWNNFJP3kquk+Ecs4z+y7EyCpWFUJ8u+RTJmD/6r93hHTuIryhxeOd8R/aVisPiFy0olzJaGBC3CidWUk9WsbQ0+wqECOzuMfL/AGaaKfcLPvtBiOwWOnqAMvukAAOsh93YRZML+1oKHPhMpF8s1x75YjoPCOICfJlzgkpC0hQBuH+PjDEcs/8AKaZ/xfcPnGR1/MI9gAqczgM41LKP4vnA+I4BMAfI/wCEg+6Lq0RrSITQ7KBLmzJReWpYIIdPm1QqlLxaOEcbEw93MASvT7qvDY9IZT8MhYZaQrxHwNxFb45wsS0GZLCmSeYVJGyg1WiNUO0xrjsMpHMhSgj7ux6PpeBU94B/MUTrQFuldBBXAsd30spXVSaK6g2MR9xlUUE2Pq/6GBjQKpcwDMqYyRVTpS3UWff0gdWElLSlYCiFLcMVBnq7PRvdHvFpfeqThwWCkuo+YCQWL0qb7QdLwKkoQErYAgMwZmI8X84aJScen1/gWYjhgUhYSogkMOYgBz0tCTivZ3O5lvnS7Vqd6nXWsW2dgHSvNMOXWg330iBXDFOr+Ip66J2hhjyyxu4s5bOxCpRCZqHSQCFNQi4oYmVNlqYggWpan6ResT2fMzImYoqcJzAhBDtzNRt4R4vsLKy55cxaakNQhwcpuNwafGGa2n8SivvbPzRXV4UFmJB8t3e0EHIkF8pLVrXZywv0hhO7FrSFJE9LJLVDu6QaseUuTTZjrAKODtyqmZtSAGatNTsfSC0dP23Bzf0EXEOHIUk5FKUt7nZ6O1dYO4VJXLAmq5VIUCLUB5XILhypQvp1hhPwGQJAVQnYM7FqPmtmq7b6Mnx83PMMtBJAIc0vqA3o/wBCN3sjP6/izaxKk+fYnn8YmrURLUqp5lFtC/LSnlAvdiqlLKlN7TufKDZWGAToBTo25gaapyALB+Zr6UY0hpUaWHBGCqK3+prhlhQAqRSpbxguWhr+vvgRGFDuAXqH/wBY3UoksR9CgeHR0Q07S+bkPSjaCMGyDTle4sDs7fGAsOtvlB+Hl5xQVF/efyJ8oGhZcMGqkX7sTKAkmgBdQKRVv4iyHeoJCgWNnpFmjnXZbiBlzWJLKSxT95rf4hVjsSNo6HLWFAKBcEODuDCPOavTvDOu3YB4hhCsUjknbPsZPM0zpSCsKqoJuCNa6FtNY7YYA4gh0kNoYTVbnOnex86pwyZUyWMWhYlkFRQkjMpjRJaqAS9b0Nri7Sv2rzKJlYaWiWkAJSSXADD7JAAbpTrA3bvgRUkTspzo5VAVGVyQd6E6b9IoUtAetW0Fz4n5w07Bqmdg/wDNmX/yyv8AqJ+UZHNeTdH+QxkMD6XjVSQYx4x4CIi4pNxEg94l5soe0kAZgNxu300bcK41Jm+zMT1SaEPoQYdlYim9rOzctT4iW8ucmpUix3zJBr4iu7wqGO8Pw+XKmiZLUQF8pRQitQ2zN1ifiXKtKtwR6f6xS+E46aZkiWvN/MSQ4Acfepdw8XjiYrL8T8Ij2JcMSsRNSrUk38m+AiRGKmZUnKkjMGqXqGrC/tHie7lrW+VkqOa7Ml3YVNrCK7ie1apclOQMu4zVDDUsTf52hoFFydIua8VN7tTBANHLlhXqNoWL7VykrU82S1bTH9yQdY52vjE3Ep/iTCz+w5CT4izfKN0YUGpAPlb63h0aGn0EciuTf5HRcDxtMwpMuZKVypYd4M1v943sK3AerxJj588SXKUEuomrUzEhmFaMHjnP7vSfs+sTYZMyWCJc1aUfcBOX0Li/SHR0S8I7xl+qLXj8ZNdbSxerlq5aZWFQ2WuhzbVRLmTHAyhh1tubeF2sYxXH1qDTUB9FJoPME0r1iJGNSpamSp2S5dLMHKWq7uVekVy2M/Lp54XU0Q8UnrCQSkAPSv8AdVo2hbXUwmwEoJqrxJLXt+ZhjxnGZkIGUh1ihZwWUNHFidYiQkpQKgCgJPX84lHg0dDj+Ry83+xriVqUrILDTfWN5ODaXmUQh3YEh/JugeIZGHJUz5zmIYe7W9tdYk44DKdJFUCozVexe/x0MT5Nb4kUrW1L6dwXEcRly+Ul1XrfzGkeyOJy10bz28dfSK3hJzhSspJJL/FvCNO95SwI8/rX0hIyF4lJyprbt5lwnScjqSdnfQfLrEmDmMoODeodnbTpC/hGJzoyNoLnrEgxIKsoNK1ofhaDg7YZuppPv/JdMbhEpAnSiSkLIKiHrQgg7OfX33Hs7xFM2UG9pFFD4HwMU7s9iCrDT5JB9gqBIOo6eEN+xSxmUfvpc9SkgPAzj1eLqxSvmL2foXAktGqkvG7RopWkRZioFXw+Wp3APRor3/hThqZmUYdBmKJdPM4FTmyhXKmjAszxakmEPGuzffTDPlTlyJ+RUvvEgKBSagKSrY6hjB7Eo03u6JP3Vgv+Rl/9BP8A2x5CD/wnxX/3Y/8ATP8A3R7BuWdMPMu6ZvRvSNFYqrVs71ba7N5QnxPFx3feISV25HALkgEEksGd/KkKpPEeYqIUiXUpClqc5mPMlQdLEUFmPiIkc5ZZmLavXcfnCnH8TOUpFfcYQY3jAzXc+Jtowt5+MJZk2bNWlLlyaS0VBe2Y6+m0A6LT2ZUmdihQq7oZs+gJ5QkH7T1PlFm4svnSNgff/pEXZvhIwsnm9tXMs9dAPC0QYud7S1dT6aRGTGuSq9tcYnujLuSCFDopJSQWqKGKHhuHrmBSiSkKod26Pahh7icR3kwrVZ/jb3x4sOGcN57w4razXx6RLpT57/mLe7CRlluzMC22sSJMxN3PL9fXWDsNLd8v116Qp4pxOXKWUkhakkv7VNOjvEjWnkxYIb7BWGnKUHYj6uIMkTYVYHHS5zgKyVfpT01hlMBD1zUFWZntU3gJ4M0JxSTv1COIYIh0qBCmBIPX4wtwqwhZCrEBqE2d7Q94ElC5oTNzFKuVxoTb4N6QFxXh5lqUEnMEKLKs+UsaaQONqiGfHDMnhf3krT7WKuOTk/w2uFAsxqGd/reJcSp0MHLl328ffEHEAFgDMk3uRdqetY2wCwuWAa15qt1iEeDh0L/1td0xn2d/nywySMwoRqaP138ok7aYR585ISWOUuzXSklvfCrDzChToehcEFj0IMMVYnPVRJJ1UXf1rFh3Sw9Ur81TOd4hK5JIBcExpLWSwekW/ifDUqBN2BIBtC/B8PHKopDEOzv8IWxlS0XTN1weYaQoy7MkAuzOSLXgjCKVmqKmrBm8aUtB2GlmWFJKs2Y0pYEe4Rrw/DKBUWYadWu/SkJl8MElOMi58HxwRh1IKglQNEqBfKoafGkNexaOcnZKviExU5a2CkhIdWpBcDYbR0DsjhMssrP2mA8Br5kn0ge5PXJYsMn+IfKMQLMTrEQLiLPOo8RBCIGQYJRAgkbRkZGRIiULE9n5ksnu1ApcHKoPUWPiN4VY7h2IJNAXuX91up9Y6eqdLo6hVmfra8Ye7FeX3QhnM+Hdlpy9AkGpP6mLvwTs/LwwzFivVR0hkvGJFgT8IWYha5iuaiAbCz/nCslTCsViM9B7Pxiu9qp/d4dW6iEjzqfcDD4JivdsZbyAWstPwI/OIvcu06XxEnxZRjlCDZzv03OmkYJj6V3v4xmJQAE+dAL0ufSIpRJPjYRaj1emgt5MZz8KuXITNKgBMfKKvTUlmHq9Yp2KkpWtS1gVt8zF27S4hK0oQkgITLTlbUkOX+tIomNmgOFDRnrWtLWgfGxm+IRnPGpVu237LsQzwJY5FcrsRv1h1geJTFICNOXmAejsabxWsRiUmgckFyq2t26w44UgKLpWxFS2oLW2ND6wI4NPkkk0WGWtSDc0NCdwXpFl4wszMPKnqYFSVJUQLkOUk7OyvWKqZZSam/2To1HpfT1izFY/dyc5rnOR60BIc7M5HpAbnVahKt7r1piLCyAe7OarKDbsQKxBjsKZczvEJJSfbAFv73h9axaeBcJQqXLKkO/eHMKWUgh9enqNYYzuDy1FgACFDwIYkhrPS8V1Tsw8md4dTNrdW/0KOwUkEB9iNNvKIVy1AVHkf0iy8Z7NLQDMkcwZ1ynr+KWd+hvp1QpWEqCFOhQHsrSQql3zfGJpmrp9Spr5X+XdA6nKWNtj10reNWLBqBmt5QTNAejG1oiKyGBFybfOkFnS21vJG8iVaC0SwGKjdspfpGuFUH66UcjwAhweFKy51pyJDEJNFF3ALaChiLYsueONdTdL/uxnAeGrxExmZIYqNKDXzNo6bKlBKQlIYAAAdBC3s7JCZCRlCS6goAapUQ51Jo/iTDWJHnNbq3qJ7bRXBqRA82CYGxJhM40QyzBJmBKSo2FYDlqiPiE2gS/U/lCQ2Q/veZ91HvjyBcwjIYqGeUA8tKn1NTT6vGyBoLfX6wDhcQJiwE6ln8Br8fKHicKBqYgtyctgPu43MphBaZbR4pESoi2L1CsJe1qXwywz1T5MX/JvOLIuXAWOkIUky1OQsEMNqB/JxXSFRZimoyUn2Zyme2WorToQS28A4dbEhmUNPGLBxfhi5MxKFEEF8qvvfqNR18IVzMGLpdtehD21iaZ6XTydqUXsN1yZasKjL/MSSFBqlKi4J2YlhFXxvD3dx7qfpDFEwggBz8AOsTzT4eH5RI6Xju03at8+pTjwRS3ynLqHsW0hh2clgIzkMoEuGrdgIboWXYxIJYL6bjeA5/8AHRU1JcdyGUg1vX6MNcasGXLSlxlSxBNMyrsNA4eBUNc0A6Qz4DwdeLmA+yhFVLLkEj2Us4fR20etRCOjNKGJKcuEXTB8ISlSAFLbKoZc1HGQUA3qS8SfuhPsmZMPMGLpd2LGiWpceAfWJ5UubmHOjNzgnIWukktn6AX1jZaJmYELQBmS/Kb1sXoDQN1iJ46TbbbIZ/C6FpswEC7p315aN0jTG9n5cwtMUVJryqTLUBS4zJLHWCphmgqcoVQEAJL+0Ke1fSN1Ga55pb10UzN47wCTadplfPYXDEvzjM1AsgJ1YMz7V2j2X2MkJQGJUcxqolQoS1CaQ9Bmjuw6FUS5rWlSG3jxKphA5UgV3fMFN/lJcvdiITLvtOZqnJ17kWG4YmWpRlhKA7EBIryg0P2anzrAPaCUvKrOvMGTlAADF1Xu+m0Nf4zLJEsnNQZiwGVOuV3dzbWFPaJa8rKSBRGYgvcmzgOQc1KabwnwV9Tb3HfCqSz+Jfmcxc+Zcto7QbAfCC6Hd+ZWjXUSR5Fx5QdEys1MCY60GmAOKFkwnwNcgCZjQPPmMCanwvHiVPXe0YowkSAf3in/AIc3/J+sZBGWMgC/QsmCwaZYoBm1IHu3aC41SsGNoklRBs0UI1zClY0xSSRTQ1G8aylB2LPp4EwASlMRKREifq3oI9IgArnaHDiZLKAHUKilixZqhyW30r1pk7CLlIExSeQs6hYE/e28bR0PiJKWIBUygcouaWEAIQruykysyVZQQcuVQV9llKFTaouRCR26bWSwvbdeRzzESAohQFaOQdjRhaI+5U5uT402hjxvszMlBU2SpUuWDWWsvlc5QxDuCSL21Ma4bs3xFw6ACrUrG2oDkekSPQY9XglHq6l+e24IUqAfKRbw9dY1lJD81Nz+d4ejsxiynN3pFjRIIIP3OYP5teGeA7NISjPMlzJywVcqjLAoSASAQDYUJMIg/FMMFzb9Ct8N4JOxf8sNL/4iwwPRIufK2pi98KkrkpRLloTlSgCqjopWY+zUkl9LRNhcYQ6BLUWCajKw5QAL9HYCxEBfvJaVEGWq3SvMa3p+sJsxNXrZ6mk9orhf2EnETUr9lLAqbmqXApUefl0gTHcWXLBUuWKKTQL6sKtoSD5Qu4pxNQUnkUl1hiWaqVPYl6BvMRXONdogxQxvY+0SD40Aa/jEbOaGNzdIseO7W5UqVlylmckFjcWuWrCXE/tAmKJMtEtIY0XnLvo6aRVVZpheYW6bDzggS0MzBtmhpeZsafw+NXLdj7D9v5yO7eVLypAASnMWagqVbQ9wXb2WUgTUEFy5HjQN4Ud9IpSMgFL6RsAk0o2tIdF/+Lw1TT97OoYHi8uaVd0lSgtTlYysGSEgkZswBCQxZvOBO0WKUUKzIKAAhszOS6nbISLZbtFCwGIVLVmQ6FJLAg6aePWLHjuMGfLc+3yJp7NCrmr7JJU1aWiMjM1OgliXVHdfVe5cuzp/2dBu7l/EnesNBCbsokjCSgr2gmtQa3uKHyhw8TM09hXx5TSx1P5Q0JhaZiZkxeYOhACQGdyqpp5CExoSpXGFcNJvCkKcy1ZTtcel0wPheGTM4CxyipLuD0ERolYIx2MZFpboI8iXSKwTEzSjmGl/CCcNiUrS6YGm8wPWFEviSJalCWFTSCAoJDJSRQupTJJFXAJI2hkSymAsQkgggUf/AFESoxKVZeYOoOA9SKPTVnEQie6CxrUeYLH4QAZKlulAVLCWPsJIZNwCCwYgV5WZzU6lgn5/of0gWVMSoh8pUl2I0s7ai4jchIUpdHIAdg7DR7m5gAExc4AhVw4PLV6PTeE2B4rJEuXKTlSQqUWcVqkqIyvzZixBIq52eTjfEQhJUhXMHKQCHJSDTzPK+jxXpnaSXLShOUd4haF5yzX52IBd05hZ6g6Qi+GNy4TLpOxCFhaFOxSfskWN3ZhVqnx0jafxJGZJqz1dKg1HsRWKWO3csqUmZKdCwUqyrBoQ1QQDWHkrthhVrScxHUgH+kk+6GJ4Z/hf6DI8SQZSFOebKRylgCqgJAYMKeUeyeJS2UHWVOonlVqXAs1AUhunQxpPx6O4BMxKmCMxTUVID0sl3rp5RqniMrKWUlIzLuRUhRzEV1LmIlYHL4wgEgJULfYNWAclhTQV26QsxPEUmaKKoFUKVCzHat9NjtG4xiAslS0tlGoGUDMC9d3v0gXGYyV3iDmTUMC4q5DAbm8RJ0Lu0vE0mWnK6TmzOQQWAUGAUAQSSLjQxUcNJc99NNXpufDfX4w243M76adEgkBtk095c+cAY4OpjUJAYCzmvyiyKNrQaVOm+TJs/MQSm1gOu+9I8SFKtYFiPD4aROEg1SliAH1GzlrB29Y3VN7vMokHUpZyWar2bRobNGb6KS28zZCE1vXXTakepAHWAcR2iTQMlhYVfz39ImwWORMABPNs3nC3JLUQff6j7g+ISg51JzIIIUlnUk0DtoH1N6xJipSkLKxkKFEhSRbdlaP1GriK4pYTMIBIYe5/ztD/AIGlM0BBzHMcpILAOOUVBsxJ8bwFLmt5Pjh+x0DsnKSjCykJLhIYfk/VmhzFQ7FzlIVMkKuNOoLH3N6RbiYDzeqxfCyuK47ezBuIYjIgnXSB+CSgZRJ+2on05R8IWdosYHyjT4wBgONLlgJoUimxiK3ZS9kW7+zl3BqNTf3XicmA+HY3vUZgC1oLiREyMjIyABPh8LnSlisISSAHACh9klgHDVA61cxvxeYJEiZMSgLUhBUEl2J6sDTUwHiMcrDlE2ZMSZSyEFyqhUwlkOLuCFVHtPpXbGnOVKIFgC2oSSU+8kwDOOcT4xisUy5mZXd52KEZQhJqapp8st4e4btLPnYSXLmTVSwqYqWuamkxSEywtrE5iM3MBoIvszh6VS1IUkALSUnzDfAxRuCcA7pU9E3mTLnIIUsmwQSJgsPtJ6UO0LgknZauCLlSJSUAkqAWoUKllJVmBCQ/tJQCWYuLA0gXinHpktRzMM6EkJBJyFyLkt7ITygAAklzA2MwicOleIQpaGSpgTR1EkliXZSiEt1GzxWpRUqqvaJGbWlgBsB+UCVl2HH1yJMTiVzLlkkuT73PziFchISVKPhYxLPCwyUgfitYv8IUiWc3KaUSB1NbaC9TD4NyFYq2DEd391j4RMqUkJKks+jbwMmSu+UqqRazRsmYUFiG6GJGg8UckNnybcNxcxIOcljQtfz0UOhiz8J7QImju1pSFOWUAMqtW/umK+iYkirt0Fa9NYHGEMtRUmod72L3Gm0JqzFzaCmki0YQpK1N0fxb4M0ZiUjvEBgzKbxdP6esJuGJzEjKCgbjWgptYv5QWqQnvbCqK0Gpau7j4RV3M2cJQbjJboQYSY6i+gHvvG01WZZb10s3lWIe4yTFyyegV4UB6aGCloq5o9R5hotXBvaRu17D3gclKcPNmvz8qBb7QJrSxLekU/ic7mIBYMW3MXHh80DCThYgpWfZdSQ4o9RlKVEtVnjnfGcZ3k5aPZGYgFwbdRTzB2hvg5tXm6epJ7t/SkSYyWjuyGAI1oS/jr46wPw3EFKgRo0BTkLsok1q967wbgJTkX8g/jSIxRy6ZSi9y2TFEpJYGjjxaHnZCb/FAJYqS3izco2FPdCGbypAsT9NDjson/aEOfZSok/4T84aNdx/1Sb8i24WaE8RYD2kgKO5yk/kIdcW4h3aaXit8PWVY3OHLAOTcMgkvt7QEC9rOLBCVrJonTc6CITdGLrY1KPsit8Z4+s4lMtJBaqyQ7P8hXzEMsJjwshJCXJbMio8xcRV+yyJcyYV4hjnc1JAfQEi2pZ60i2cD4XLmYsS5dZYVmNSWAYkAvUPTzhVRxOnydNwsoIQlKbAAA79fO8Sx5HsTKzIyMjIAKxieEZzLVO5sq092EcyWT7IU59ps5Kg1TSrPJh0Ly86ChQJDOS4BoXJculjWt4cHIpIJQ4Cs6Xy33SRQFydXvpBE1AesA7FCUFqWgbiGGdJcXS3oXFRDwyAKiBcYgEP1+MDBcnL+2OKW0uSC6UnvCKuR7KQok1L5z/l2gDCIJoaG8Ne0MkCcQb9drhmAoHhSTkqCB4mloceDY02n6UpkmHxBW+ZAoosH+7TzN4ixa0y15h45aNe9I2bPmCmZ6F3cCzHV4RcbWWIe7+kFHZnm4RUquq/UbI4+mgIrq2/hBqZ0uaGofiPlFaw+GSpIGY0Yhmq1fl6RLhphlrSEghyRUuDv5BwPKEtznwa+U5KMlXlQ2mgyyWBIG1ejlzeH3BUpmypiBKKllJLkgAAOcxc1Ngw84VT0BSSNoK7O4pUrES1A0qkgPzOLGj3b0iR35Opwck/VAUsKlzUpUGc5SH0VQFwdyC4g9Ej+KxKqC+ZTvVheooaGIeNYcibZnCVBwxY1BYEgepgvFcJnjESUy15grPnUoJcJSoOwo5rEJrujg8RhGXRNd0/TgV8bwSkTBMBJBYvrQAEe5/WI1AlOYEMKgtVtX98WjH8MUyRnUoOXcIoACrRIeoTZj74SrwKpJykn8jV3f690KLI6LOmulvdHuA4oZSQEoSS5Kir7Y5co6WUP8Ris4nhBmLMxmeYTlD0BsHN298O1kEkszaF6lzZ/CMlzy2Xq7NYke+LLO6ekw5ZKS5FOI4aTMDNlKanUEfpE8iQJY5Q53UPrxg1ZfWISHfpSv11gOhYIp2RpSpRdVWt0h5gpQlMuYkqSpIKcpGUvoTuDQiFqEUBYjodoOlyioEgMzndIfVvgHq0JseRxhC26XcsXCJ4RLmrbKtahTQAjNR6m9+kULthjjMmpkJNAQpZ+A/PzEPeKcREgFJJOSVLJehKik3GhJ08IqHC8JNnFcxKFTFqdSmFhp08BFfc8vlyfEm5ef7dhhg0ig0HhHVewmAySlTGbOWT+FPzL+kcz4JgDMmIls5URvd8rEaNrHccLITLQmWn2UpCR4ANAluUze1EkexkZEys1rGRtGQABTsMlEkolywQn2EaV1sdyXPXxiWVLUlASalqm9T4ABnezROZfNmc2Znpd3az9Y1MsAlVXNKqLV6Es/lABrKqkMG6GI56HSR0jZZUFHKklg7NdzYElnp8KiN8wLtWrQAcr46CZkw0dC1BV7e0DW5ykQkxSgpOUDMSxtYb+MXDj2DKps0o7wpUCSSlWVCkEJYKPKxBDAfdO8VZbJqpyxGltNPWCJv6PKnjS8uR32SmSBKmCapKVaKIcgZdAKkA12tFH7Q51FSrvmUVH7VakH3tDNSspoSUVq2t26iBeIo7xDAsfPXyppE7Ls2KMoylFvft7FWRjFSyU3H5dPKGGAzzFgmpNCemphbO4bMSoJLkmwuCemkXHhWDyJDhlNX9IjRmaTFJ5La4DJa2cxPwokzAUgkpVmbdi7DrSBZ68oIGuv5Ug7g+ICFAqAIYgukE+KQaPDR6CCfQ6W9Bs0nET3sFLSA5skMDtQfnFoGEWVj+JLysopVlsXA1VQnMbaP5pezfBxiSsqJSEpbMm7k5mrvFlR2SlZSkqUXyl2APK9mDanrWIvcwPEcnzrH+EVKw8wqAMyUEpV7QUSVOkghvshi9zUCPMfgBMQxWhRBSOVRBqQ9jYByeghqOx0h1VUyk5WpSoNNXpq8ayexWHSrMCt2UGzFmUkpOuxMKjg66aaKjiuCt/LIUU6Zg3uoYUTsHMT7SFddvhHQpHYTDIUlSVTHSQRzq0L1rbpDFPZ2WPtKPixbweDc0cPiTgqaOVS8MAKFqOx+njwgA1+MdVX2blHU+VPhA2I7IyFXd2AernxILwbnUvFoJcMpWG4VNmIzcsuWLqWWJ/CCH8yG8YM4rOly5SZaGALAl8xKmdTkCpqPSjWixz+ykoICc1EvlcEs5c/as5JrvFR45w9MlC1mYoISCcqQgAmoBzZc4VVqKF4TM3Uayed77LyKNx/GHEYuaBRGdvJFD73HpD/guOXIBCEBYU1C4qKCz0iu8MkiqiACagCwGg/SHmAmHNZ6Fzs3h5Qm/IoUdqZeewXDyZkycqrPXTMupbZg9P7wi+CF/AcD3MhCSGU2ZQ/vKqR5UHlDGJJUiuTtnhjBGRjQyJ7GRrGQASRhjIyAAfF+wfFP9QiTUxkZABU+Nf+oR4J/pmRSsZ7avGPYyCJq6DiQrx9kf4oGOkexkNGpD7rJpftJ/xQZLvGRkMrxckU32UxIi0ZGQGpiOg9gP5Uz8Q+EWyMjIieT8R/8ATL3MjYRkZAcRkZGRkAGGNYyMgGCY72T4GOYdvv8A06vxJ/qjIyIvkmipYT2PrpDrgvty/wD5Ef1iMjIiTO16mNoyMiwoPDHsZGQAZGRkZAB//9k=",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl =
                   "data:image/jpeg;base64,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",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 11,
                Name = "Jam-filled-pikelets",
                Price = 100,
                ShortDescription = "Mini Australian Pancakes",
                LongDescription =
                   "These fluffy mini Australian pancakes are made with pockets that can be filled with custard or jam. Pikelets are usually enjoyed with butter and honey or jam as a snack or are served with afternoon tea",
                CategoryId = 3,
                ImageUrl = "https://d2rdhxfof4qmbb.cloudfront.net/wp-content/uploads/20190227160336/jam-filled-pikelets.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://d2rdhxfof4qmbb.cloudfront.net/wp-content/uploads/20190227160336/jam-filled-pikelets.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 12,
                Name = "Kaiserschmarrn",
                Price = 150,
                ShortDescription = "The Emperor's omellete",
                LongDescription =
                   "Kaiserschmarrn literally means “the emperor’s sweet omelette,” and is named for the Kaiser Franz Joseph I of Austria. As the pancake mix cooks, it is turned and cut with a fork, which is why it doesn’t have the shape of traditional types of pancakes. It is usually served with sugar, berries, jam, or apples.",
                CategoryId = 3,
                ImageUrl = "https://d2rdhxfof4qmbb.cloudfront.net/wp-content/uploads/20190227160958/Kaiserschmarrn.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://d2rdhxfof4qmbb.cloudfront.net/wp-content/uploads/20190227160958/Kaiserschmarrn.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 13,
                Name = "Boquette",
                Price = 200,
                ShortDescription = "Made up of buckwheat",
                LongDescription =
                   "Belgium may be more famous for its waffles (which some may argue are essentially the same, though they actually use different batter), don’t miss the delicious boûkéte (or bouquette). Its texture resembles the French crepe, and it is usually made with buckwheat flour and pan-fried in lard. Boûkètes may be embellished with raisins and garnished with a local brown sugar known as cassonade or with sirop de Liège",
                CategoryId = 3,
                ImageUrl = "https://d2rdhxfof4qmbb.cloudfront.net/wp-content/uploads/20190227162217/Boquette.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://d2rdhxfof4qmbb.cloudfront.net/wp-content/uploads/20190227162217/Boquette.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 14,
                Name = "Brazilian-Tapioca",
                Price = 250,
                ShortDescription = "They are made of Tapioca Flour",
                LongDescription =
                   "Tapiocas are also similar to crepes, though the Brazilian pancakes are often slightly thicker. They are made with tapioca flour that is cooked on ungreased girdles. They can be eaten either plain or with a range of sweet and savoury toppings, which include butter and shredded coconut",
                CategoryId = 3,
                ImageUrl = "https://d2rdhxfof4qmbb.cloudfront.net/wp-content/uploads/20190227163300/Brazilian-Tapioca.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://d2rdhxfof4qmbb.cloudfront.net/wp-content/uploads/20190227163300/Brazilian-Tapioca.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 15,
                Name = "Cong-you-bing-2",
                Price = 300,
                ShortDescription = "Made up of Wheat",
                LongDescription =
                   "Bing are savoury Chinese pancakes that are usually made with wheat. The consistency varies across regions from thick and chewy to paper-thin. They are often eaten as a snack, and can be filled with ground meat, or fried with scallions. One of the most popular variations is the cong you bing, or the flaky scallion pancakes. These types of pancakes are often served with soy sauce to dip it in.",
                CategoryId = 3,
                ImageUrl = "https://d2rdhxfof4qmbb.cloudfront.net/wp-content/uploads/20190228181951/cong-you-bing-2.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://d2rdhxfof4qmbb.cloudfront.net/wp-content/uploads/20190228181951/cong-you-bing-2.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 16,
                Name = "Arepas",
                Price = 350,
                ShortDescription = "Made of corn Flour",
                LongDescription =
                   "Traditionally found across Colombia and Venezuela, arepas are a staple of South American cooking much like the tortilla is in Central America. Often said to be a cross between a flatbread and a pancake, they are made with corn flour (or masa) and are often split in half and filled with meat, beans, cheese, and more. While the Colombian arepas are larger and flatter than the thick Venezuelan ones, they are both cooked on a girdle.",
                CategoryId = 3,
                ImageUrl = "https://d2rdhxfof4qmbb.cloudfront.net/wp-content/uploads/20190227170318/Arepas.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://d2rdhxfof4qmbb.cloudfront.net/wp-content/uploads/20190227170318/Arepas.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 17,
                Name = "choclate Chip Cookies",
                Price = 100,
                ShortDescription = "Fan Favorite",
                LongDescription =
                   "Chocolate chip cookies are the perennial classic and longtime fan favorite. They can be soft and chewy or crispy and crunchy depending on how you make them and the ingredients you use. Either way, they’re completely delicious.",
                CategoryId = 4,
                ImageUrl = "https://ediblebloglive.wpengine.com/wp-content/uploads/2020/03/Chocolate-Chip-Cookies-min.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://ediblebloglive.wpengine.com/wp-content/uploads/2020/03/Chocolate-Chip-Cookies-min.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 18,
                Name = "Shortbread Cookies",
                Price = 150,
                ShortDescription = "Made With Large Amount of butter",
                LongDescription =
                   "Shortbread cookies are made with a large amount of butter or shortening, which lends them the name “short.” Due to their low amount of flour and sugar, they have a classic crumbly and tender texture.",
                CategoryId = 4,
                ImageUrl = "https://ediblebloglive.wpengine.com/wp-content/uploads/2020/03/Shortbread-Cookies-min.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://ediblebloglive.wpengine.com/wp-content/uploads/2020/03/Shortbread-Cookies-min.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 19,
                Name = "Macaron Cookies",
                Price = 200,
                ShortDescription = "Made with almond meal ,egg whites and Powdered suger with cream ganches in the middle",
                LongDescription =
                   "Macarons are meringue-based cookies made with almond meal, egg whites, and powdered sugar with a creme ganache in the middle. The cookie shell features a delicate outer crust that houses a chewy meringue texture inside.",
                CategoryId = 4,
                ImageUrl = "https://ediblebloglive.wpengine.com/wp-content/uploads/2020/03/Macaron-Cookies-min.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://ediblebloglive.wpengine.com/wp-content/uploads/2020/03/Macaron-Cookies-min.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 20,
                Name = "Sugar Cookies",
                Price = 250,
                ShortDescription = "It is very tasty",
                LongDescription =
                  "Made with basic ingredients, such as sugar, flour, butter, and vanilla, sugar cookies are easy to make and insanely popular. They’re typically made by rolling out the dough and cutting into shapes before decorating with icing, sprinkles, or colored sugar",
                CategoryId = 4,
                ImageUrl = "https://ediblebloglive.wpengine.com/wp-content/uploads/2020/03/Sugar-Cookies-min.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://ediblebloglive.wpengine.com/wp-content/uploads/2020/03/Sugar-Cookies-min.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 21,
                Name = "Oatmeal Raisin Cookies",
                Price = 300,
                ShortDescription = "Made with oats",
                LongDescription =
                 "Oatmeal raisin is a type of drop cookie. as its name suggests, it’s made with oats, and contains raisins and brown sugar. They can be crispy and crunchy or chewy, depending on the ingredients you use and how long you bake them",
                CategoryId = 4,
                ImageUrl = "https://ediblebloglive.wpengine.com/wp-content/uploads/2020/03/Oatmeal-Raisin-Cookies-min.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://ediblebloglive.wpengine.com/wp-content/uploads/2020/03/Oatmeal-Raisin-Cookies-min.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 22,
                Name = "Gingerbread Cookies",
                Price = 350,
                ShortDescription = "Ultimate Holiday Cookie",
                LongDescription =
                 "Gingerbread cookies are the ultimate holiday cookie. They’re made with spices galore, including cinnamon, ginger, nutmeg, and molasses, and are made by rolling out the dough and cutting into shapes",
                CategoryId = 4,
                ImageUrl = "https://ediblebloglive.wpengine.com/wp-content/uploads/2020/03/Gingerbread-Cookies-min.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://ediblebloglive.wpengine.com/wp-content/uploads/2020/03/Gingerbread-Cookies-min.jpg",
                AllergyInformation = ""
            });
            
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 23,
                Name = "Chocolate Glaze Cupcake",
                Price = 50,
                ShortDescription = "This cup cake is the ultimate chocolaty heaven for the people who are M.O.C(Mad Over Chocolate).",
                LongDescription = "This cup cake is the ultimate chocolaty heaven for the people who are M.O.C(Mad Over Chocolate).",
                CategoryId = 5,
                ImageUrl = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcStNRVh_1BX98oVqeynwIJTjemhBgXZsufdEi9liD45goyI1IP56J_t-bDT9m4S3TgEZ5ADTUsZ3ck1OuQZWir5AlmMfsc67w&usqp=CAE",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcStNRVh_1BX98oVqeynwIJTjemhBgXZsufdEi9liD45goyI1IP56J_t-bDT9m4S3TgEZ5ADTUsZ3ck1OuQZWir5AlmMfsc67w&usqp=CAE",
                AllergyInformation = ""

            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 24,
                Name = "Choco Chip Cupcake",
                Price = 30,
                ShortDescription = "This cup cake is the ultimate chocolaty heaven for the people who are M.O.C ( Mad Over Chocolate).",
                LongDescription = "If you wish for the taste of pure chocolaty delicacy, this cake could be an idea deal for you. Coming with chocolate base and swirls of chocolate cream and sprinkled chocolate chips, this cake makes you chocolate dream comes true",
                CategoryId = 5,
                ImageUrl = "https://cdn.dotpe.in/longtail/item_thumbnails/7700711/F1cmZEzB.webp",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://cdn.dotpe.in/longtail/item_thumbnails/7700711/F1cmZEzB.webp",
                AllergyInformation = ""

            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 25,
                Name = "Choco Vanilla Cupcake",
                Price = 50,
                ShortDescription = "This cup cake is the ultimate chocolaty heaven for the people who are M.O.C(Mad Over Chocolate).",
                LongDescription = "Coming with chocolate cup cake base, whipped vanilla cream, chocolate sauce and the sprinkles of edible sugar candies, this set of 6 cup cake can easily hold a permanent space in anyone's heart.",
                CategoryId = 5,
                ImageUrl = "https://cdn.dotpe.in/longtail/store-items/7700711/NpGi6441.jpeg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://cdn.dotpe.in/longtail/store-items/7700711/NpGi6441.jpeg",
                AllergyInformation = ""

            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 26,
                Name = "Choco Coffee Cupcake",
                Price = 150,
                ShortDescription = "Wake up fresh and experience the coffee rush in your veins as you take a bite of these cupcakes.",
                LongDescription = "Coming with chocolate cup cake base, whipped vanilla cream, chocolate sauce and the sprinkles of edible sugar candies, this set of 6 cup cake can easily hold a permanent space in anyone's heart.",
                CategoryId = 5,
                ImageUrl = "https://cdn.dotpe.in/longtail/item_thumbnails/7700711/V4c4CuHE.webp",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://cdn.dotpe.in/longtail/item_thumbnails/7700711/V4c4CuHE.webp",
                AllergyInformation = ""

            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 27,
                Name = "Choco Swirl Frosting CupCakes",
                Price = 60,
                ShortDescription = "Wake up fresh and experience the choco rush in your veins as you take a bite of these cupcakes.",
                LongDescription = "This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.",
                CategoryId = 5,
                ImageUrl = "https://cdn.dotpe.in/longtail/store-items/7700711/B2fmWTdg.jpeg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://cdn.dotpe.in/longtail/store-items/7700711/B2fmWTdg.jpeg",
                AllergyInformation = ""

            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 28,
                Name = "Treat Strawberry Cupcake",
                Price = 30,
                ShortDescription = "Your old fashioned belgian Strawberry cupcakes. Totally mouth melting and droolworthy. ",
                LongDescription = "Strawberries are one of my all-time favorite fruits, and I love strawberry flavors in a moist and fluffy cake more than anything else. Like my strawberry pound cake, I can’t think of a better Spring and Summer time dessert that features one of the best fruits known to man than these Strawberry Cupcakes with Strawberry Buttercream.",
                CategoryId = 5,
                ImageUrl = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcRNSKt0-JcNRZIGPuLJ2bFTikGfo-ahpzh8262Xii7qIVY6T57Q8DiZv17_j2nJYEh8m49oVonJ4RD6DeCORKikQULRaxR0m7PV7Pu8-OVYx2mTZNP2bCMkJg&usqp=CAE",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcRNSKt0-JcNRZIGPuLJ2bFTikGfo-ahpzh8262Xii7qIVY6T57Q8DiZv17_j2nJYEh8m49oVonJ4RD6DeCORKikQULRaxR0m7PV7Pu8-OVYx2mTZNP2bCMkJg&usqp=CAE",
                AllergyInformation = ""

            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 29,
                Name = "Fresh Strawberry Cupcake",
                Price = 50,
                ShortDescription = "Your old fashioned belgian Strawberry cupcakes. Totally mouth melting and droolworthy. ",
                LongDescription = "Strawberries are one of my all-time favorite fruits, and I love strawberry flavors in a moist and fluffy cake more than anything else. Like my strawberry pound cake, I can’t think of a better Spring and Summer time dessert that features one of the best fruits known to man than these Strawberry Cupcakes with Strawberry Buttercream.",
                CategoryId = 5,
                ImageUrl = "https://greedyeats.com/wp-content/uploads/2019/07/Best-strawberry-cupcake-recipe-with-strawberry-frosting.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://greedyeats.com/wp-content/uploads/2019/07/Best-strawberry-cupcake-recipe-with-strawberry-frosting.jpg",
                AllergyInformation = ""

            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 30,
                Name = "Double Creme Strawberry Cupcake",
                Price = 120,
                ShortDescription = "Your old fashioned belgian Strawberry cupcakes. Totally mouth melting and droolworthy. ",
                LongDescription = "Bursting with cups of real and fresh strawberries for the best strawberry flavor! These aren't sad vanilla cupcakes with bits of baked strawberries. And we don't need any strawberry essence.",
                CategoryId = 5,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSbjXOellK20PeVXGdNuOYgYpQ4cKSsZjIdmA&usqp=CAU",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSbjXOellK20PeVXGdNuOYgYpQ4cKSsZjIdmA&usqp=CAU",
                AllergyInformation = ""
            });


            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 31,
                Name = "Strawberry Chocolate Cupcakes",
                Price = 40,
                ShortDescription = "Your old fashioned belgian Strawberry cupcakes. Totally mouth melting and droolworthy. ",
                LongDescription = "Bursting with cups of real and fresh strawberries for the best strawberry flavor! These aren't sad vanilla cupcakes with bits of baked strawberries. And we don't need any strawberry essence.",
                CategoryId = 5,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTO76IJauKeSXJ9aJMlJMQXzUmAxPXvZszw7A&usqp=CAU",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTO76IJauKeSXJ9aJMlJMQXzUmAxPXvZszw7A&usqp=CAU",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 32,
                Name = "Strawberry Lemonade Cupcakes",
                Price = 55,
                ShortDescription = "Your old fashioned belgian Strawberry cupcakes. Totally mouth melting and droolworthy.",
                LongDescription = "Strawberries are one of my all-time favorite fruits, and I love strawberry flavors in a moist and fluffy cake more than anything else. Like my strawberry pound cake, I can’t think of a better Spring and Summer time dessert that features one of the best fruits known to man than these Strawberry Cupcakes with Strawberry Buttercream.",
                CategoryId = 5,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFeoGUdWbFPdMOQtwqKBvUX3OI19Zkng5GEA&usqp=CAU",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFeoGUdWbFPdMOQtwqKBvUX3OI19Zkng5GEA&usqp=CAU",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 33,
                Name = "Apple Spice Cupcakes",
                Price = 58,
                ShortDescription = "They’re the indisputable champion if you’re looking for a festive and fun fall cupcake!",
                LongDescription = "One bite is all it will take to convince even the most die-hard summer spirit that the flavors of fall reign supreme! They’re soft and cakey, remind me of apple pie, and taste extra special with the caramel frosting on top.",
                CategoryId = 5,
                ImageUrl = "https://sallysbakingaddiction.com/wp-content/uploads/2012/09/apple-spice-cupcakes-salted-caramel-frosting.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://sallysbakingaddiction.com/wp-content/uploads/2012/09/apple-spice-cupcakes-salted-caramel-frosting.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 34,
                Name = "Apple Snickerdoodle Cupcake",
                Price = 40,
                ShortDescription = "Cupcakes are topped with more apple flavor in the frosting",
                LongDescription = "Amazing thing (although admittedly not as cool 😉 ) are these cupcakes. I’m not craving sweets at this point, but these cupcakes are ones that I wanted to keep all to myself. It’s fall in a cupcake and I’m loving them!",
                CategoryId = 5,
                ImageUrl = "https://www.lifeloveandsugar.com/wp-content/uploads/2017/09/Apple-Snickerdoodle-Cupcakes5.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://www.lifeloveandsugar.com/wp-content/uploads/2017/09/Apple-Snickerdoodle-Cupcakes5.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 35,
                Name = "Sweet Apple Cinnamon",
                Price = 45,
                ShortDescription = "They’re the indisputable champion if you’re looking for a festive and fun fall cupcake!",
                LongDescription = "Amazing thing are these cupcakes. I’m not craving sweets at this point, but these cupcakes are ones that I wanted to keep all to myself. It’s fall in a cupcake and I’m loving them!",
                CategoryId = 5,
                ImageUrl = "http://www.blueberryvegan.com/wp-content/uploads/2017/10/Vegan-Apple-Cinnamon-Cupcakes.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "http://www.blueberryvegan.com/wp-content/uploads/2017/10/Vegan-Apple-Cinnamon-Cupcakes.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 36,
                Name = "Caramel Apple Cupcakes",
                Price = 50,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence",
                LongDescription = "If one wishes for something better than Chocolate Truffle should be their next stop. Surprise that Chocolate lover in your group with this tasty batch of 4 Chocolate Truffle Cupcakes and make them smile from ear to ear",
                CategoryId = 5,
                ImageUrl = "https://greedyeats.com/wp-content/uploads/2020/09/Caramel-Apple-Cupcakes.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://greedyeats.com/wp-content/uploads/2020/09/Caramel-Apple-Cupcakes.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 37,
                Name = "Cinnamon Apple CupCakes",
                Price = 80,
                ShortDescription = "If one wishes for something better than Chocolate Truffle should be their next stop. Surprise that Chocolate lover in your group with this tasty batch of 4 Chocolate Truffle Cupcakes and make them smile from ear to ear",
                LongDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                CategoryId = 5,
                ImageUrl = "https://assets.epicurious.com/photos/59b1c289ca17873531543f0d/master/pass/cinnamon-apple-cupcakes-recipe-090617.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://assets.epicurious.com/photos/59b1c289ca17873531543f0d/master/pass/cinnamon-apple-cupcakes-recipe-090617.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 38,
                Name = "Blackberry Lavender Cupcake",
                Price = 100,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                LongDescription = "If one wishes for something better than Chocolate Truffle should be their next stop. Surprise that Chocolate lover in your group with this tasty batch of 4 Chocolate Truffle Cupcakes and make them smile from ear to ear",
                CategoryId = 5,
                ImageUrl = "https://www.thelittleepicurean.com/wp-content/uploads/2011/08/IMG_5582-1.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://www.thelittleepicurean.com/wp-content/uploads/2011/08/IMG_5582-1.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 39,
                Name = "Lemon Blackberry CupCake",
                Price = 120,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                LongDescription = "If one wishes for something better than Chocolate Truffle should be their next stop. Surprise that Chocolate lover in your group with this tasty batch of 4 Chocolate Truffle Cupcakes and make them smile from ear to ear",
                CategoryId = 5,
                ImageUrl = "https://i0.wp.com/ahealthylifeforme.com/wp-content/uploads/2015/05/Lemon-Blackberry-Cupcakes-Recipe-4.jpg?ssl=1",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://i0.wp.com/ahealthylifeforme.com/wp-content/uploads/2015/05/Lemon-Blackberry-Cupcakes-Recipe-4.jpg?ssl=1",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 40,
                Name = "Blackberry Chocolate cheese",
                Price = 350,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                LongDescription = "If one wishes for something better than Chocolate Truffle should be their next stop. Surprise that Chocolate lover in your group with this tasty batch of 4 Chocolate Truffle Cupcakes and make them smile from ear to ear.If one wishes for something better than Chocolate Truffle should be their next stop.Surprise that Chocolate lover in your group with this tasty batch of 4 Chocolate Truffle Cupcakes and make them smile from ear to ear. ",
                CategoryId = 5,
                ImageUrl = "https://www.dessertfortwo.com/wp-content/uploads/2010/06/blackberry-cupcakes-16.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://www.dessertfortwo.com/wp-content/uploads/2010/06/blackberry-cupcakes-16.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 41,
                Name = "Blackberry Lime Cupcakes",
                Price = 220,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                LongDescription = "If one wishes for something better than Chocolate Truffle should be their next stop. Surprise that Chocolate lover in your group with this tasty batch of 4 Chocolate Truffle Cupcakes and make them smile from ear to ear",
                CategoryId = 5,
                ImageUrl = "https://cookienameddesire.com/wp-content/uploads/2015/07/blackberry-swirl-cupcakes-lime-frosting.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://cookienameddesire.com/wp-content/uploads/2015/07/blackberry-swirl-cupcakes-lime-frosting.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 42,
                Name = "Chocolate Stuffed Blackberry Cupcake",
                Price = 120,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                LongDescription = "If you wish for the taste of pure chocolaty delicacy, this cake could be an idea deal for you. Coming with chocolate base and swirls of chocolate cream and sprinkled chocolate chips, this cake makes you chocolate dream comes true.If you wish for the taste of pure chocolaty delicacy, this cake could be an idea deal for you. Coming with chocolate base and swirls of chocolate cream and sprinkled chocolate chips, this cake makes you chocolate dream comes true.",
                CategoryId = 5,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtezNgG-1pJ2Kts4hGESeqCWOGwqDx6nsYuQ&usqp=CAU",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtezNgG-1pJ2Kts4hGESeqCWOGwqDx6nsYuQ&usqp=CAU",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 43,
                Name = "Coconut ButterCream Cupcake",
                Price = 60,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                LongDescription = "This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.",
                CategoryId = 5,
                ImageUrl = "https://www.cookingclassy.com/wp-content/uploads/2017/03/coconut-cupcakes-66.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://www.cookingclassy.com/wp-content/uploads/2017/03/coconut-cupcakes-66.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 44,
                Name = "Coconut SnowBalls Cupcake",
                Price = 50,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                LongDescription = "This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.",
                CategoryId = 5,
                ImageUrl = "https://preppykitchen.com/wp-content/uploads/2022/04/Coconut-Cupcakes-Recipe-Card.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://preppykitchen.com/wp-content/uploads/2022/04/Coconut-Cupcakes-Recipe-Card.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 45,
                Name = "Chocolate Coconut Cupcake",
                Price = 70,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                LongDescription = "If you wish for the taste of pure chocolaty delicacy, this cake could be an idea deal for you. Coming with chocolate base and swirls of chocolate cream and sprinkled chocolate chips, this cake makes you chocolate dream comes true.If you wish for the taste of pure chocolaty delicacy, this cake could be an idea deal for you. Coming with chocolate base and swirls of chocolate cream and sprinkled chocolate chips, this cake makes you chocolate dream comes true.",
                CategoryId = 5,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTD3UfJTRX5aHobIJOiMBy1cM9vSw-YLsdxzA&usqp=CAU",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTD3UfJTRX5aHobIJOiMBy1cM9vSw-YLsdxzA&usqp=CAU",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 46,
                Name = "Blueberry Coconut Cupcake",
                Price = 80,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                LongDescription = "This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.",
                CategoryId = 5,
                ImageUrl = "https://www.lifeloveandsugar.com/wp-content/uploads/2022/06/Blueberry-Coconut-Cupcakes3.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://www.lifeloveandsugar.com/wp-content/uploads/2022/06/Blueberry-Coconut-Cupcakes3.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 47,
                Name = "Coconut CreamCupcakes",
                Price = 90,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                LongDescription = "If you wish for the taste of pure chocolaty delicacy, this cake could be an idea deal for you. Coming with chocolate base and swirls of chocolate cream and sprinkled chocolate chips, this cake makes you chocolate dream comes true.If you wish for the taste of pure chocolaty delicacy, this cake could be an idea deal for you. Coming with chocolate base and swirls of chocolate cream and sprinkled chocolate chips, this cake makes you chocolate dream comes true.",
                CategoryId = 5,
                ImageUrl = "https://thescranline.com/wp-content/uploads/2021/03/Coconut-Cream-Cupcakes-500x500.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://thescranline.com/wp-content/uploads/2021/03/Coconut-Cream-Cupcakes-500x500.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 48,
                Name = "Creamsicle Cupcake",
                Price = 40,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                LongDescription = "This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.",
                CategoryId = 5,
                ImageUrl = "https://www.nithaskitchen.com/wp-content/uploads/2020/12/orange_cream9_L.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://www.nithaskitchen.com/wp-content/uploads/2020/12/orange_cream9_L.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 49,
                Name = "Eggless Orange Cupcake",
                Price = 450,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                LongDescription = "If you wish for the taste of pure chocolaty delicacy, this cake could be an idea deal for you. Coming with chocolate base and swirls of chocolate cream and sprinkled chocolate chips, this cake makes you chocolate dream comes true",
                CategoryId = 5,
                ImageUrl = "https://www.ruchiskitchen.com/wp-content/uploads/2016/05/Eggless-orange-cupcakes-4-1.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://www.ruchiskitchen.com/wp-content/uploads/2016/05/Eggless-orange-cupcakes-4-1.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 50,
                Name = "Creamy Dreamy Orange",
                Price = 60,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                LongDescription = "This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.",
                CategoryId = 5,
                ImageUrl = "https://foodlets.com/wp-content/uploads/2020/06/orange-cream-cupcakes-horz.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://foodlets.com/wp-content/uploads/2020/06/orange-cream-cupcakes-horz.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 51,
                Name = "Fresh Squeezed Cupcake",
                Price = 70,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                LongDescription = "This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.",
                CategoryId = 5,
                ImageUrl = "https://sallysbakingaddiction.com/wp-content/uploads/2016/08/fresh-squeezed-mimosa-cupcakes-2.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://sallysbakingaddiction.com/wp-content/uploads/2016/08/fresh-squeezed-mimosa-cupcakes-2.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 52,
                Name = "Creamy Butterscotch Orange",
                Price = 80,
                ShortDescription = "Bursting with cups of real and fresh apple for the best apple flavor! These aren't sad vanilla cupcakes with bits of baked apples. And we don't need any apple essence.",
                LongDescription = "This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.This set of chocolate cupcakes, which has been topped up with a rich, luscious chocolate swirl and milk chocolate curl is sure to brighten up anyone's day with its look and taste.",
                CategoryId = 5,
                ImageUrl = "https://sallysbakingaddiction.com/wp-content/uploads/2013/11/Butterscotch-Filled-Brown-Sugar-Cupcakes-by-sallysbakingaddiction.com_.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://sallysbakingaddiction.com/wp-content/uploads/2013/11/Butterscotch-Filled-Brown-Sugar-Cupcakes-by-sallysbakingaddiction.com_.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 53,
                Name = "Margherita Pizza",
                Price = 400,
                ShortDescription = "Lip smashing pizza is here!",
                LongDescription = "Flavorful Margherita Pizza only includes a few simple and tasty ingredients, like perfectly melty mozzarella cheese and fresh basil. My easy version includes a homemade whole wheat pizza dough and scratch-made tomato sauce, but can also be made using store bought staples and your choice of toppings. Try this Italian-inspired Margherita recipe for your next pizza party or weekend movie night!",
                CategoryId = 6,
                ImageUrl = "https://www.vegrecipesofindia.com/wp-content/uploads/2020/12/margherita-pizza-recipe-1.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://www.vegrecipesofindia.com/wp-content/uploads/2020/12/margherita-pizza-recipe-1.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 54,
                Name = "Peppy Paneer Pizza",
                Price = 450,
                ShortDescription = "Dominos Peppy Paneer pizza – Chunky paneer with crisp capsicum and spicy red pepper – quite a mouthful!",
                LongDescription = "Chunky paneer with crisp capsicum and spicy red pepper – quite a mouthful! Check out this mouth-watering overload of paneer, crisp capsicum, and spicy red pepper. Regular Pizza starting @ Rs 450/ only. Grab your Delightful combination of thin crust, capsicum, and paneer. A pizza that goes ballistic on veggies! The flavorful trio of juicy paneer, crisp capsicum with spicy red paprika.",
                CategoryId = 6,
                ImageUrl = "https://i0.wp.com/www.dominosoffer.co.in/wp-content/uploads/2021/03/Dominos-peppy-paneer-pizza.jpg?fit=800%2C450&ssl=1",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://i0.wp.com/www.dominosoffer.co.in/wp-content/uploads/2021/03/Dominos-peppy-paneer-pizza.jpg?fit=800%2C450&ssl=1",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 55,
                Name = "Cheese Burst Pizza",
                Price = 300,
                ShortDescription = "Cheese burst bread pizza",
                LongDescription = "Cheese burst bread pizza|Cheese bread pizza|Bread pizza on tawa:cheesy, easy and delicious cheese burst bread pizza. perfect instant snacks for movie night or whenever you feel lazy and crave for pizza.",
                CategoryId = 6,
                ImageUrl = "https://i.pinimg.com/736x/a4/20/2d/a4202d486dfcfedccde2838c1a11f13f.jpg",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://i.pinimg.com/736x/a4/20/2d/a4202d486dfcfedccde2838c1a11f13f.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 56,
                Name = "Corn Pizza",
                Price = 550,
                ShortDescription = "Corn will make your stomach crave again.",
                LongDescription = "I never would have thought about putting corn on a pizza, but now I can't think about anything but. The corn are juicy bursts of summer and combine with the cheese to make a truly great pie.",
                CategoryId = 6,
                ImageUrl = "https://static.wixstatic.com/media/c1db4b_a6ed9358b3ec4c6ab8522b9b2c57ec64~mv2.jpg/v1/fill/w_3000,h_2250,al_c,q_85/c1db4b_a6ed9358b3ec4c6ab8522b9b2c57ec64~mv2.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://static.wixstatic.com/media/c1db4b_a6ed9358b3ec4c6ab8522b9b2c57ec64~mv2.jpg/v1/fill/w_3000,h_2250,al_c,q_85/c1db4b_a6ed9358b3ec4c6ab8522b9b2c57ec64~mv2.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 57,
                Name = "Cheese Pasta Pizza",
                Price = 380,
                ShortDescription = "A pizza loaded with a spicy combination of Harissa sauce, Peri Peri chicken chunks and delicious pasta.",
                LongDescription = "New Combination of pasta on the top of pizza,i never would have thought about putting pasta on a pizza, but now I can't think about anything but. The pasta are juicy bursts of summer and combine with the cheese to make a truly great pie.",
                CategoryId = 6,
                ImageUrl = "https://images.dominos.co.in/CreamyTomatoPPVG.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://images.dominos.co.in/CreamyTomatoPPVG.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 58,
                Name = "Chicken HeavyWeight Pizza",
                Price = 570,
                ShortDescription = "Chicken Pepperoni, Sliced Chicken Meatballs, Minced Chicken Chunks BBQ Chicken and Chicken Ham with Loads of Cheese.",
                LongDescription = "Pizza with full of protiens is here, Chicken Pepperoni, Sliced Chicken Meatballs, Minced Chicken Chunks BBQ Chicken and Chicken Ham with Loads of Cheese.",
                CategoryId = 6,
                ImageUrl = "https://5.imimg.com/data5/RI/MN/MY-17758356/imperial-recipe-pizza-non-veg-chicken-heavyweight-i10-500x500.png",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://5.imimg.com/data5/RI/MN/MY-17758356/imperial-recipe-pizza-non-veg-chicken-heavyweight-i10-500x500.png",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 59,
                Name = "Texas BBQ",
                Price = 550,
                ShortDescription = "Bell pepper, BBQ sauce, bacon, and cheddar make this pizza Texas-style. A premade crust makes preparation easy.",
                LongDescription = "You’ll find pre-made pizza crusts in the refrigerated section of most supermarkets, which makes this an easy recipe for casual entertaining.Nutritional information may change when substituting your chicken product. If you choose to substitute frozen chicken for this recipe, it's best to thaw before cooking.",
                CategoryId = 6,
                ImageUrl = "https://www.goldnplump.com/sites/default/files/Texas%20BBQ%20Chicken%20Pizza_web.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://www.goldnplump.com/sites/default/files/Texas%20BBQ%20Chicken%20Pizza_web.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 60,
                Name = "Mexican Passion",
                Price = 590,
                ShortDescription = "Mexican Passion Pizza with cheese, baby corn, Mexican chicken, jalapeno.",
                LongDescription = "You’ll find pre-made pizza crusts in the refrigerated section of most supermarkets, which makes this an easy recipe for casual entertaining.Nutritional information may change when substituting your chicken product. If you choose to substitute frozen chicken for this recipe, it's best to thaw before cooking.",
                CategoryId = 6,
                ImageUrl = "https://www.gortsa.com/cache/large/product/18880/6SRxqpa2uoY4ch3LWnobpT69u4Z2ULuA2hhepH9s.jpeg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://www.gortsa.com/cache/large/product/18880/6SRxqpa2uoY4ch3LWnobpT69u4Z2ULuA2hhepH9s.jpeg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 61,
                Name = "Meateor",
                Price = 600,
                ShortDescription = "Meateor Pizza with cheese, onion, chicken sausage, herbed chicken, Mexican chicken, BBQ chicken.",
                LongDescription = "They were in a foul mood as they said they were having to do everything to prepare for Christmas. Which we felt wasn’t fair as we had put up the Xmas trees and put the chocolates on (minus the half we had scoffed of course). No, we were just in the way and a Christmas miracle happened when they threw some money at us and told us to get out and have a pizza, now we are not so slow on the uptake sometimes and had departed the house even before the wives voice had finished echoing in the hallway.",
                CategoryId = 6,
                ImageUrl = "https://www.gortsa.com/cache/large/product/18888/ArdOIgkDuZ7pXF5MQ9kPg9K46vSQBAQhZAWct929.jpeg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://www.gortsa.com/cache/large/product/18888/ArdOIgkDuZ7pXF5MQ9kPg9K46vSQBAQhZAWct929.jpeg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 62,
                Name = "American Hottest Pizza",
                Price = 650,
                ShortDescription = "American Hottest Pizza with lamb pepperoni, red paprika, jalapenos, mozzarella.",
                LongDescription = "The Pizza Lads were cold, very cold and not just from the frosty stares the missuses were casting at us. They were in a foul mood as they said they were having to do everything to prepare for Christmas. Which we felt wasn’t fair as we had put up the Xmas trees and put the chocolates on (minus the half we had scoffed of course). No, we were just in the way and a Christmas miracle happened when they threw some money at us and told us to get out and have a pizza, now we are not so slow on the uptake sometimes and had departed the house even before the wives voice had finished echoing in the hallway.",
                CategoryId = 6,
                ImageUrl = "https://www.thepizzalads.com/wp-content/uploads/2019/01/american-hot-pizza-review-american-hot-pizza-from-pizza-express.jpg",
                InStock = true,
                Bestsell = false,
                ImageThumbnailUrl = "https://www.thepizzalads.com/wp-content/uploads/2019/01/american-hot-pizza-review-american-hot-pizza-from-pizza-express.jpg",
                AllergyInformation = ""
            });
            //seed Bread
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 63,
                Name = "Milk Bread",
                Price = 50,
                ShortDescription = "Special Bread",
                LongDescription = "Milk Bread, also known as special bread among everyone is our signature baked bread with a little sweetness.",
                CategoryId = 2,
                ImageUrl = "https://cdn.shopify.com/s/files/1/0617/4533/2395/products/BREAD-1.jpg?v=1650475358&width=360",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0617/4533/2395/products/BREAD-2.jpg?v=1650475476&width=600",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 64,
                Name = "Plain Bread",
                Price = 40,
                ShortDescription = "Fresh Bread",
                LongDescription = "It is a traditional style of loaf made chiefly in Scotland and Ireland.It has a dark, well-fired crust on the top and bottom of the bread.",
                CategoryId = 2,
                ImageUrl = "https://cdn.shopify.com/s/files/1/0617/4533/2395/products/BREAD-2.jpg?v=1650475476",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0617/4533/2395/products/BREAD-2.jpg?v=1650475476&width=600",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 65,
                Name = "Wheat Bread",
                Price = 50,
                ShortDescription = "Whole wheat bread",
                LongDescription = "wholemeal bread is a type of bread made using flour that is partly or entirely milled from whole or almost-whole wheat grains, see whole-wheat flour and whole grain.",
                CategoryId = 2,
                ImageUrl = "https://cdn.shopify.com/s/files/1/0617/4533/2395/products/BREAD-4.jpg?v=1650475492",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0617/4533/2395/products/BREAD-4.jpg?v=1650475492",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 66,
                Name = "SRRS Special Bread",
                Price = 100,
                ShortDescription = "Special Milk Bread",
                LongDescription = "It is a type of bread made using flour that is partly or entirely milled from whole or almost-whole wheat grains, see whole-wheat flour and whole grain.",
                CategoryId = 2,
                ImageUrl = "https://cdn.shopify.com/s/files/1/0617/4533/2395/products/BREAD-5.jpg?v=1650475544",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0617/4533/2395/products/BREAD-5.jpg?v=1650475544&width=600",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 67,
                Name = "Triangle Sandwich Bread",
                Price = 150,
                ShortDescription = "Speacial Sandwich Bread",
                LongDescription = "It is a type of bread made using flour that is partly or entirely milled from whole or almost-whole wheat grains, see whole-wheat flour and whole grain.",
                CategoryId = 2,
                ImageUrl = "https://cdn.shopify.com/s/files/1/0617/4533/2395/products/BREAD-7.jpg?v=1650475583&width=360",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0617/4533/2395/products/BREAD-7.jpg?v=1650475583&width=600",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 68,
                Name = "Rasin Bun - Special Bun",
                Price = 40,
                ShortDescription = "Speacial Bun",
                LongDescription = "It is a Special,Fresh Bun,sweet made from a dough of flour, milk, yeast and small amounts of sugar and/or butter. Sweet bun dough is distinguished from bread dough by being enriched with sugar, butter and sometimes egg. Common sweet varieties contain small fruit or nuts, topped with icing or caramel, and filled with jam or cream.",
                CategoryId = 2,
                ImageUrl = "https://cdn.shopify.com/s/files/1/0617/4533/2395/products/BUN-2.jpg?v=1650624615&width=360",
                InStock = true,
                Bestsell = true,
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0617/4533/2395/products/BUN-2.jpg?v=1650624615&width=600",
                AllergyInformation = ""
            });


        }
    }

}

