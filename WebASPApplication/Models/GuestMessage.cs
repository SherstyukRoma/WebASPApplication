using System.ComponentModel.DataAnnotations;
namespace WebASPApplication.Models
{
    // Сущность описывающая Пользовательское сообщение
    public class GuestMessage
    {
        public int Id { get; set; }

        
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Пожалуйста, заполните валидный Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Пожалуйста, заполните Fio")]
        public string Fio {  get; set; }

        
        [Required(ErrorMessage = "Пожалуйста, заполните Phone")]
        public string Phone { get; set; }

        
        [Required(ErrorMessage = "Пожалуйста, заполните Subject")]
        public string Subject { get; set; }


        [Required(ErrorMessage = "Пожалуйста, заполните Message")]
        public string Message { get; set; }
    }
}
