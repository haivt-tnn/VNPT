using System.ComponentModel.DataAnnotations;

namespace KhachSan.Models
{
    public class ContactModel
    {
        [Display(Name = "Tên của bạn")]
        [Required(ErrorMessage = "Tên không được trống")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        [Required(ErrorMessage = "Mail không được trống")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email không đúng")]
        public string Email { get; set; }

        [Display(Name = "Chủ đề")]
        [Required(ErrorMessage = "Chủ đề không được trống")]
        public string Subject { get; set; }

        [Display(Name = "Nội dung")]
        [Required(ErrorMessage = "Yêu cầu không được trống")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}