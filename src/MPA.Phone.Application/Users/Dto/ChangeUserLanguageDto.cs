using System.ComponentModel.DataAnnotations;

namespace MPA.Phone.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}