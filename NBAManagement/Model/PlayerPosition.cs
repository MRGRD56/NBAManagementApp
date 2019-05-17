using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAManagement.Model
{
    public class PlayerPosition
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public virtual Player Player { get; set; }
    }
}
