using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp_refresher.Models
{
    public class PetModel
    {
        //Fields
        private int id;
        private string name;
        private string type;
        private string color;

        //Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Color { get => color; set => color = value; }
    }
}
