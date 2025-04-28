using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace mvp_refresher.Models
{
    public class PetModel
    {
        //Fields
        private int id;
        private string name;
        private string type;
        private string color;

        //Properties - Validation
        [DisplayName("Ped ID")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Ped Name")]
        [Required(ErrorMessage = "Pet name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get => name; set => name = value; }

        [DisplayName("Ped Type")]
        [Required(ErrorMessage = "Pet type is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Type must be between 3 and 50 characters.")]
        public string Type { get => type; set => type = value; }

        [DisplayName("Ped Color")]
        [Required(ErrorMessage = "Pet color is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Color must be between 3 and 50 characters.")]
        public string Color { get => color; set => color = value; }
    }
}
