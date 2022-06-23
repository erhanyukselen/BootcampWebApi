using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampWebApi.Entities
{
    public class User
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
        public int BootcampId
        {
            get; set;
        }

        public bool Status
        {
            get; set;
        }
    }
}
