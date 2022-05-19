using System;
using System.Threading.Tasks;
using Motos.Web.Models;
namespace Motos.Web.Helpers

{
    public class ConverterHelper : IConverterHelper
    {
        public Category ToCategory(CategoryViewModel model, Guid imageId, bool isNew)
        {
            return new Category
            {
                Id = isNew ? 0 : model.Id,
                ImageId = imageId,
                Name = model.Name
            };
        }

        public CategoryViewModel ToCategoryViewModel(Category category)
        {
            return new CategoryViewModel
            {
                Id = category.Id,
                ImageId = category.ImageId,
                Name = category.Name
            };
        }

        public Task<Service> ToServiceAsync(ServiceViewModel model, bool isNew)
        {
            throw new NotImplementedException();
        }

        public ServiceViewModel ToServiceViewModel(Service service)
        {
            throw new NotImplementedException();
        }

        public User ToUser(UserViewModel model, Guid imageId, bool isNew)
        {
            throw new NotImplementedException();
        }

        public UserViewModel ToUserViewModel(User user)
        {
            throw new NotImplementedException();
        }

       
    }

}
