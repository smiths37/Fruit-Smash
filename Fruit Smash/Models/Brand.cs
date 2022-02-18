using System.ComponentModel.DataAnnotations;

namespace Fruit_Smash.Models
{
    public class Brand
    {
        [Required]
        public string BrandName { get; set; }
        [Required]
        public string TagLineHeading { get; set; }
        [Required]
        public string TagLineSubHeading { get; set; }
        [Required]
        public string CtaButton1Text { get; set; }
        [Required]
        public string CtaButton2Text { get; set; }
        [Required]
        public string Cta2Heading { get; set; }
        [Required]
        public string Cta2Text { get; set; }
        [Required]
        public string Cta1ButtonUrl { get; set; }
        [Required]
        public string Cta2ButtonUrl { get; set; }
        [Required]
        public string HeroImageUrl { get; set; }
        [Required]
        public string HeroImageMobileUrl { get; set; }
        [Required]
        public string HeroImageTabletUrl { get; set; }
        [Required]
        public string CanImageUrl { get; set; }
        [Required]
        public string PackImageUrl { get; set; }
    }
}
