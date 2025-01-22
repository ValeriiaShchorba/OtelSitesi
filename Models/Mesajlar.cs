using System;
using System.ComponentModel.DataAnnotations;

namespace OtelSitesi.Models
{
    public class Mesajlar
    {
        [Key] 
        public int Id { get; set; }

        [Required] 
        public string AdSoyad { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Eposta { get; set; } = string.Empty;

        [Required]
        public string Mesaj { get; set; } = string.Empty;

        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
    }
}