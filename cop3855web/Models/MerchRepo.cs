using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cop3855web.Models
{
    public class MerchRepo : IProductRepo
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product 
            { 
                Name = "Body Shots World Tour Signed Poster Winter/Spring 2019", 
                ProductID = 1, 
                Price = 20, 
                Category = "Posters", 
                Description = "High quality poster featuring list of all of the shows performed during Bert Kreischer's Body Shots tour", 
                ImageLink = "~/images/body-shots-world-tour-signed-poster.jpg"
            },
            new Product 
            { 
                Name = "Live From Cleveland Machine Tshirt ", 
                ProductID = 2, 
                Price = 30, 
                Category = "Clothing", 
                Description = "Premium tshirt featuring The Machine himself, Bert Kreischer, that is imbued with the spirit of America's #1 Party Animal", 
                ImageLink = "~/images/live-from-cleveland-machine-shirt.jpg"
            },
            new Product 
            { 
                Name = "Berty Boy World Tour Tshirt - Blue", 
                ProductID = 3, 
                Price = 35, 
                Category = "Clothing", 
                Description = "This high quality tshirt commemorates Bert Kreischer's Berty Boy World Tour and grants the wearer the ability to mispronounce almost every 3 syllable or greater word", 
                ImageLink = "~/images/berty-boy-world-tour-tee-blue.png"},
            new Product 
            { 
                Name = "Mystic Rick Glasses Men's Black Tee", 
                ProductID = 4, 
                Price = 35, 
                Category = "Clothing", 
                Description = "Do you think professional wrestling is basically a soap opera for men? Then this is the tshirt for you. What better way to avoid conversations with people that are professional wrestling fans than by wearing a shirt with a fake professional wrestler on it!", 
                ImageLink = "~/images/mystic-rick-glasses-mens-black-tee.jpg"
            },
            new Product 
            { 
                Name = "Do the Yelp! Tee", 
                ProductID = 5, 
                Price = 35, 
                Category = "Clothing", 
                Description = "Upon hearing about Tom's willingness to commit unspeakable acts to protect his kids, was your response \"Do the Yelp\"? If so this is the shirt for you", 
                ImageLink = "~/images/do-the-yelp-mens-black-tee.webp"
            },
            new Product 
            { 
                Name = "2 Bears Tshirt", 
                ProductID = 6, 
                Price = 30, 
                Category = "Clothing", 
                Description = "This tshirt is for true 2 Bears 1 Cave superfans, we're talking about people that know all about Bert's pool \"showers\" and all about Top Dog's Vietnam flashbacks", 
                ImageLink = "~/images/2-bears-tshirt.png"
            },
            new Product
            {
                Name = "Truth Seeker Unisex Black Tee",
                ProductID = 7,
                Price = 30,
                Category = "Clothing",
                Description = "This tshirt is only for #TeamTom members - anyone that condones stolen valor and believes that Christina P. found the keys? Take a hike",
                ImageLink = "~/images/truth-seeker-tee.jpg"
            },
            new Product
            {
                Name = "Thicc Boi Nation Men's Sleeveless Charcoal Tee",
                ProductID = 8,
                Price = 33,
                Category = "Clothing",
                Description = "This tshirt is perfect for members of Thicc Boi Nation and has the sleeves already cut off since you were going to do that anyways, weren't you?",
                ImageLink = "~/images/thicc-boi-nation-mens-sleeveless-charcoal-tee.jpg"
            },
            new Product
            {
                Name = "Thicc Boi Nation Men's Black Hoodie",
                ProductID = 9,
                Price = 45,
                Category = "Clothing",
                Description = "This soft, premium black hoodie is perfect to keep you warm in the cold or hide just how thicc you've become, only so others don't feel inadequate in their lack of thiccness of course",
                ImageLink = "~/images/thicc-boi-nation-mens-black-hoodie.jpg"
            },
            new Product
            {
                Name = "Hot Summer Nights Poster - Signed",
                ProductID = 10,
                Price = 20,
                Category = "Posters",
                Description = "This vibrant poster features all of the tour dates from Bert Kreischer's Hot Summer Nights Tour and comes signed by Bert (guaranteed COVID-19 Free)  ",
                ImageLink = "~/images/hot-summer-nights-poster-signed.jpeg"
            },
            new Product
            {
                Name = "Bikes 2019 Women's Tee",
                ProductID = 11,
                Price = 25,
                Category = "Clothing",
                Description = "This premium tshirt features the iconic quote from the uncensored episode of Scared Straight and lets your friends know that if they pass someone on a bike while driving with you, they should prepare to be deaf",
                ImageLink = "~/images/bikes-2019-womens-tee.webp"
            },
            new Product
            {
                Name = "Sick or Thicc Men's Black Tee",
                ProductID = 12,
                Price = 35,
                Category = "Clothing",
                Description = "Stay home if you sick, come over if you thicc.",
                ImageLink = "~/images/sick-or-thicc-mens-black-tee.jpg"
            },
            new Product
            {
                Name = "Street Name Tee",
                ProductID = 13,
                Price = 30,
                Category = "Clothing",
                Description = "This shirt features the iconic Isla Kreischer with her classic foot-in-mouth-moment quote",
                ImageLink = "~/images/street-name-tee.png"
            }
        };
    }
}
