using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampWebApi.Entities
{
    public class Bootcamp
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] //id'nin otomatik ilerlemesini sağlar.
        public int Id
        {
            get; set;
        }
        [Required, StringLength(50)]
        public string Name
        {
            get; set;
        }
        [Required]
        public DateTime Date
        {
            get; set;
        }
    }
}
