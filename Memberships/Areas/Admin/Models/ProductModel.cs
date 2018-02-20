using Memberships.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Memberships.Areas.Admin.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Title { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }

        [DisplayName("Image Url")]
        [MaxLength(1024)]
        public string ImageUrl { get; set; }

        public int ProductLinkTextId { get; set; }

        public int ProductTypeId { get; set; }

        public ICollection<ProductLinkText> ProductLinkTexts { get; set; }

        public ICollection<ProductType> ProductTypes { get; set; }

        public string ProductType
        {
            get
            {
                return ProductTypes == null || 
                    ProductTypes.Count.Equals(0) ?
                    String.Empty : ProductTypes.First(
                        pt => pt.Id.Equals(ProductTypeId)).Title;
            }
        }

        public string ProductLinkText
        {
            get
            {
                return ProductLinkText == null || 
                    ProductLinkText.Count.Equals(0) ?
                    String.Empty : ProductLinkText.First(
                        pt => pt.Id.Equals(ProductLinkTextId)).Title;
            }
        }

    }
}