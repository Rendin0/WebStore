using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Название обязательно")]
        [StringLength(100, ErrorMessage = "Максимум 100 символов")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Описание")]
        [StringLength(500, ErrorMessage = "Максимум 100 символов")]
        public string? Description { get; set; }

        [Display(Name = "Цена")]
        [Required(ErrorMessage = "Цена обязательна")]
        [Range(0.01, 100000, ErrorMessage = "Цена должна быть в диапазоне от 0.01 до 100000")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Изображение")]
        public string? ImageUrl { get; set; } = "/images/placeholder.jpg";

        [Display(Name = "Кол-во на складе")]
        [Range(0, 1000, ErrorMessage = "Кол-во должно быть от 0 до 1000")]
        public int StockQuantity { get; set; } = 0;

        [Display(Name = "Категория ID")]
        public int CategoryId { get; set; }

        [Display(Name = "Категория")]
        public Category? Category { get; set; }

        [Display(Name = "Дата добавления")]
        public DateTime CreateDate { get; set; } = DateTime.Now;

    }
}
