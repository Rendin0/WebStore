using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Навзание")]
        [Required(ErrorMessage = "Название категории обязательно")]
        [StringLength(50, ErrorMessage = "Длина названия до 50 символов")]
        public string Name { get; set; } = string.Empty;

        public List<Product> Products { get; set; } = [];
    }
}
