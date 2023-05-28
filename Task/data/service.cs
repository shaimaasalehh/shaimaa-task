using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.data
{
    [Table("services")]
    public class service
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }

    }
}
