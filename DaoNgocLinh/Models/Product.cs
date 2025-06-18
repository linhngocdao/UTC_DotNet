using System.ComponentModel.DataAnnotations;

namespace DaoNgocLinh.Models
{
    public class Product
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string Image { get; set; }
        public bool Available { get; set; }
        public int CategoryId { get; set; }
        public string? Description { get; set; }
    }
}
