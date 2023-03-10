using System.ComponentModel.DataAnnotations;

namespace HuynhDucPhat_1811062779_BigSchool.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}