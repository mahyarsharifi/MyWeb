using System.ComponentModel.DataAnnotations;

namespace MyWeb.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        [MinLength(2, ErrorMessage = "حداقل طول نام 2 کاراکتر است")]
        [MaxLength(100, ErrorMessage = "حداقل طول نام 100 کاراکتر است")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        [EmailAddress(ErrorMessage = "مقدار وارد شده ایمیل صحیح نمی باشد")]
        public string Email { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        public string Message { get; set; }
    }
}
