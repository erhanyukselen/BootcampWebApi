using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampWebApi.Entities
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] //It provides automatic progression of id.
        public int Id //Read and write Property
        {
            get; set;
        }
        [Required, StringLength(50)] //Allows up to 50 characters to be entered
        public string Name //Read and write Property
        {
            get; set;
        }
        [Required]
        public int BootcampId //Read and write Property
        {
            get; set;
        }

        public bool Status //Status for pass or fail
        {
            get; set;
        }
    }
}
