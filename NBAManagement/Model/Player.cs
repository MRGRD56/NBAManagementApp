using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAManagement.Model
{
    /// <summary>
    /// Представляет класс игрока.
    /// </summary>
    public class Player
    {
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string LastName { get; set; }

        [Required, MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        public Gender Gender { get; set; }

        private decimal height;
        [Required]
        public decimal Height
        {
            get => height;
            set => height = Math.Round(value, 2);
        }

        private decimal weight;
        [Required]
        public decimal Weight
        {
            get => weight;
            set => weight = Math.Round(value, 2);
        }

        [Required, MaxLength(10)]
        public string ShirtNumber { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        public virtual Country Country { get; set; }

        [Required]
        public virtual Team Team { get; set; }
    }

    /// <summary>
    /// Представляет пол игрока
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// Мужской пол
        /// </summary>
        M,
        /// <summary>
        /// Женский пол
        /// </summary>
        F
    }
}
