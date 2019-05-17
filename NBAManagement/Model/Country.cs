using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAManagement.Model
{
    /// <summary>
    /// Представляет класс страны.
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Код страны.
        /// </summary>
        [Key, MinLength(3), MaxLength(3)]
        public string Code { get; set; }

        /// <summary>
        /// Название страны.
        /// </summary>
        [Required, MaxLength(50)]
        public string Name { get; set; }
    }
}
