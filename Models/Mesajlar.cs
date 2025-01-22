using System;
using System.ComponentModel.DataAnnotations;

namespace OtelSitesi.Models
{
    public class Mesajlar
    {
        [Key] // Birincil anahtar
        public int Id { get; set; }

        [Required] // Zorunlu alan
        public string AdSoyad { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Eposta { get; set; } = string.Empty;

        [Required]
        public string Mesaj { get; set; } = string.Empty;

        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
    }
}