using System.ComponentModel.DataAnnotations;

namespace yzn.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}