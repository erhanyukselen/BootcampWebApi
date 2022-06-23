using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampWebApi.Entities
{
    public class Bootcamp
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] //It provides automatic progression of id.
        public int Id //Read and write Property
        {
            get; set;
        }
        [Required, StringLength(50)] //Allows up to 50 characters to be entered
        public string Name //Read and write property
        {
            get; set;
        }
        [Required]
        public DateTime Date //Bootcamp date property
        {
            get; set;
        }
    }
}
