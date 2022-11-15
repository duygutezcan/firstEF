using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace firstEF.Data
{
    public class Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]   //otomatik artmasın diye
        public int Id { get; set; }
        public bool Deleted { get; set; }
    }
}
