using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yagisotomasyonu.Entities
{
    class Yagis
    {
        [Key]
        public int YagisId { get; set; }

        public int IlId { get; set; }
        public int Yil { get; set; }
        public string Ay { get; set; }
        public double Miktar { get; set; }

        [ForeignKey("IlId")]
        public Il Il { get; set; }
    }
}
