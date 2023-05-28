using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.data
{

    [Table("interested")]
    public class interested
    {

        public int id { get; set; }
        [Required]
        public string name { get; set; }

    }
}
