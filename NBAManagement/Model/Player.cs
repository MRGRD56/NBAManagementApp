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

        /// <summary>
        /// Фамилия
        /// </summary>
        [Required, MaxLength(30)]
        public string LastName { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [Required, MaxLength(30)]
        public string FirstName { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        [Required]
        public Gender Gender { get; set; }

        private decimal height;
        /// <summary>
        /// Рост
        /// </summary>
        [Required]
        public decimal Height
        {
            get => height;
            set => height = Math.Round(value, 2);
        }

        private decimal weight;
        /// <summary>
        /// Вес
        /// </summary>
        [Required]
        public decimal Weight
        {
            get => weight;
            set => weight = Math.Round(value, 2);
        }

        /// <summary>
        /// ShirtNumber
        /// </summary>
        [Required, MaxLength(10)]
        public string ShirtNumber { get; set; }

        /// <summary>
        /// Электронная почта
        /// </summary>
        [MaxLength(50)]
        public string Email { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        [Required]
        public virtual Country Country { get; set; }

        /// <summary>
        /// Команда
        /// </summary>
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
