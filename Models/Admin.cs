using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace OtelSitesi.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string KullaniciAdi { get; set; } = string.Empty;

        [Required]
        public string Sifre { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Eposta { get; set; } = string.Empty;
    }
}
