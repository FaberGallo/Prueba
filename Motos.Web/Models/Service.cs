namespace Motos.Web.Models
{

    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    public class Service
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Price { get; set; }
        [DisplayName("Is Active")]
        public bool IsActive { get; set; }
        [DisplayName("Is Starred")]
        public bool IsStarred { get; set; }
        public Category Category { get; set; }
        public ICollection<ServiceImage> ServicImages { get; set; }
        [DisplayName("Service Images Number")]
        public int ServicImagesNumber => ServicImages == null ? 0 : ServicImages.Count;
        //TO DO: Pendiente cambiar los paths por los de Azure
        [Display(Name = "Image")]
        public string ImageFullPath => ServicImages == null || ServicImages.Count == 0
        ? $"https://localhost:50001/images/noimage.png"
        : ServicImages.FirstOrDefault().ImageFullPath;
    }
}