using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace yagisotomasyonu.Entities
{
    class Il
    {
        [Key]
        public int IlId { get; set; }

        [Required]
        public string IlAdi { get; set; }

        public ICollection<Yagis> Yagislar { get; set; }
    }
}
