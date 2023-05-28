using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.data
{
    [Table("users")]
    public class user
    {

        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        public string phone { get; set; }
        public string email { get; set; }

    }
}
