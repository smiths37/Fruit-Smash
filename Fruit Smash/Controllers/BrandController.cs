using Microsoft.AspNetCore.Mvc;
using Fruit_Smash.Models;

namespace Fruit_Smash.Controllers
{
    public class BrandController : Controller
    { 
        public IActionResult Index()
        {
            //Replicating an instance of the brand class, to mimic getting data from a CMS
            //It looks like you are using Episerver - I have experience using Ektron, which Episerver bought/acquired, before they became Optimizely
            //I'm going off my knowledge of Ektron - you could create "smartforms" and assign ids to each field
            //Then you'd get that data using Ektron's user controls, deserialize the JSON, and finally assign those fields' values to an instance of a class
            //This is what I'm trying to mimic here - the text values would be whatever value you could get from the smartform/cms object data
            Brand fruitSmash = new Brand();
            fruitSmash.BrandName = "Fruit Smash";
            fruitSmash.CanImageUrl = "/images/cans.png";
            fruitSmash.PackImageUrl = "/images/pack.jpg";
            fruitSmash.HeroImageUrl = "/images/hero.jpg";
            fruitSmash.HeroImageMobileUrl = "/images/hero-mobile.webp";         //I got this and the tablet image from the fruit smash website, since I couldn't make the main hero image line up well on mobile or tablet
            fruitSmash.HeroImageTabletUrl = "/images/hero-tablet.png";
            fruitSmash.TagLineHeading = "Say Bye";
            fruitSmash.TagLineSubHeading = "To Basic Selterzing";
            fruitSmash.CtaButton1Text = "Find near you";
            fruitSmash.Cta1ButtonUrl = "https://www.fruitsmashseltzer.com/#find";
            fruitSmash.CtaButton2Text = "Learn More";
            fruitSmash.Cta2ButtonUrl = "https://www.fruitsmashseltzer.com/";
            fruitSmash.Cta2Heading = "Super Hard Variety Pack";
            fruitSmash.Cta2Text = ViewBag.HtmlStr = "Introducing <strong>The New</strong> Fruit Smash Super Hard Seltzer. A boozy seltzer made with real juice for a bolder taste that packs a punch.";

            return View(fruitSmash);
        }
    }
}
