using System.ComponentModel.DataAnnotations;

namespace VENIC.API.WEB.Models.Authority
{
    public class RequestAuthorityAPI
    {
        [Required, MaxLength(20)]
        public string? Name {  get; set; }
        [Required, MaxLength(100), MinLength(3)]
        public string? Password {  get; set; }
    }
}
