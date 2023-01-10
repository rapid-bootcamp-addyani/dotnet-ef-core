using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEfCore.DataContext
{
    [Table("tbl_employee")]
    public class EmployeeEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("employee_name")]
        public String Name { get; set; }
        [Column("email")]
        public String Email { get; set; }
        [Column("address")]
        public String Address { get; set; }
        [Column("phone")]
        public long Phone { get; set; }
        [Column("position")]
        public String Position { get; set; }
    }
}
