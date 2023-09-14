using System.ComponentModel.DataAnnotations;

namespace OnionShop.DataLayer.DTOs.Contacts
{
    public class AnswerTicketDTO
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Text { get; set; }
    }

  
}
