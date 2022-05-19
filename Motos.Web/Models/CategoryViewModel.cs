namespace Motos.Web.Models
{

    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;
    public class CategoryViewModel : Category
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }

}