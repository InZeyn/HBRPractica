using System;
using System.ComponentModel.DataAnnotations;

namespace HBRPractica.ViewModels
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

    }
}
