using System.ComponentModel.DataAnnotations;

namespace ABP.DY.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}