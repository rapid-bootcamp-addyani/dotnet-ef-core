using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEfCore.DataContext
{
    [Table("tbl_absensi")]
    public class AbsensiEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_employee")]
        public int EmployeeId { get; set; }
        [Column("clock_in")]
        public DateTime AbsentStartDate { get; set; }
        [Column("clock_out")]
        public DateTime AbsentEndDate { get; set; }
        [Column("location")]
        public String Location { get; set; }
        [Column("description")]
        public String Description { get; set; }
    }
}
