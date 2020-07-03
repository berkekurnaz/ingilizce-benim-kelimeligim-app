using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngilizceKelimeApp.Models
{
    public class Word : BaseEntity
    {
        public string Title { get; set; }
        public string Mean { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
