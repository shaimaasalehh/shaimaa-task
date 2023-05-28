using System.ComponentModel.DataAnnotations;

namespace Task.Models
{
    public class userDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please fill Username!")]
        public string name { get; set; }


        public string phone { get; set; }
       
        public string email { get; set; }

    }
}
