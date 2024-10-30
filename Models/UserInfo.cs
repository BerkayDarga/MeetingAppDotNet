using System.ComponentModel.DataAnnotations;

namespace MeetingAppDotNet.Models
{
    public class UserInfo
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Ad alanı zorunlu")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Telefon alanı zorunlu")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Email alanı zorunlu")]
        [EmailAddress]   // email formatında girilmesi zorunlu hale getirdik

        public string? Email { get; set; }
        [Required(ErrorMessage = "katılım durumunuzu giriniz")]
        public bool? WillAttend { get; set; }
    }

}