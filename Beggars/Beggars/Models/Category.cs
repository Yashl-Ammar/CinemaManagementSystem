using System.ComponentModel.DataAnnotations;

namespace Beggars.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public List<Product> products { get; set; }

    }
}
