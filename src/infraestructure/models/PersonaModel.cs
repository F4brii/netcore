using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace infraestructure.models{
    [Table("persona", Schema = "public")]
    public class PersonaModel{
        [Key]
        [Column("id", TypeName = "int")]
        public int Id { get; set; }
        [Column("dni", TypeName = "varchar")]
        public string dni { get; set; }
        [Column("nombres", TypeName = "varchar")]
        public string nombres { get; set; }
        [Column("email", TypeName = "varchar")]
        public string email { get; set; }
    }
}