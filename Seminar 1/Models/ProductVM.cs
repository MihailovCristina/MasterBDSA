using Microsoft.SqlServer.Server;
using ProiectMaster.Models.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Seminar_1.Models
{
    public class ProductVM
    {
        public ProductVM()
        {
            Name = string.Empty;
            Author = string.Empty;
            Format = string.Empty;
            Description = string.Empty;
        }

        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MaxLength(2000)]
        public string Author { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MaxLength(2000)]
        public string Format { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MaxLength(2000)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string? ImagePath { get; set; }

        [AllowedExtensions(".jpg", ".png", ".jpeg")]
        [MaxFileSize(3 * 1024 * 1024)]
        public IFormFile? ProducImage { get; set; }

        public static Product VMProdToProd(ProductVM vm)
        {
            var prod = new Product();

            prod.Name = vm.Name;
            prod.Author = vm.Author;
            prod.Format = vm.Format;
            prod.Description = vm.Description;
            prod.Price = vm.Price;
            prod.IsAvailable = vm.IsAvailable;
            prod.ImagePath = vm.ImagePath;


            return prod;
        }

        public ProductVM ProdToProdVM(Product? prod)
        {
            if (prod == null)
                return new ProductVM();

            var vm = new ProductVM();

            vm.Id = prod.Id;
            vm.Name = prod.Name;
            vm.Author = prod.Author;
            vm.Format = prod.Format;
            vm.Description = prod.Description;
            vm.Price = prod.Price;
            vm.IsAvailable = prod.IsAvailable;
            vm.ImagePath = prod.ImagePath;


            return vm;
        }

    }
}
