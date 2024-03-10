using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace VENIC.API.WEB.Models.Third
{
    public class RequestThirdModelAPI
    {
        [Required]
        public long Id { get; set; }
        [MaxLength(100)]
        public string? FirstName { get; set; }
        [MaxLength(100)]
        public string? SecondName { get; set; }
        [MaxLength(100)]
        public string? FirstSurName { get; set; }
        [MaxLength(100)]
        public string? SecondSurName { get; set; }
        [MaxLength(300)]
        public string? ComercialName { get; set; }
        [Required]
        public int DocumentTypeId { get; set; }
        [MaxLength(13)]
        public string? DocumentNumber { get; set; }
        [Required]
        public int ThirdTypeId { get; set; }
        public int GenderId { get; set; }
        public DateTime? BirthDay { get; set; }
        public DateTime? LegalDate { get; set; }
        public bool Active { get; set; }
    }
}