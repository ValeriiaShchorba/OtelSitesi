using System;
using System.ComponentModel.DataAnnotations;



namespace OtelSitesi.Models
{
    public class Rezervasyonlar
    {

        [Key] 
        public int Id { get; set; }

        [Required]
        public string AdSoyad { get; set; } = string.Empty;

        [Required]
        [EmailAddress] 
        public string Eposta { get; set; } = string.Empty;

        [Required]
        public string Telefon { get; set; } = string.Empty;

        [Required]
        public string OdaTuru { get; set; } = string.Empty;

        [Required]
        public DateTime GirisTarihi { get; set; }

        [Required]
        public DateTime CikisTarihi { get; set; }

        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
    }
}
