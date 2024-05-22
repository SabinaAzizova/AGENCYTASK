using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgencyWeb.Models
{
    public class Portofolio
    {
        public int Id { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string WebPosition { get; set; }
       
        public string? ImgUrl { get; set; }
        [NotMapped]
        public IFormFile? ImgFile { get; set; }

    }
}
