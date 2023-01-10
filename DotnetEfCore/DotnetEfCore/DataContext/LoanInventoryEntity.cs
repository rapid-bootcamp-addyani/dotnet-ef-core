using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEfCore.DataContext
{
    [Table("tbl_loan_inventory")]
    public class LoanInventoryEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name_user")]
        public String NameUser { get; set; }
        [Column("name_admin")]
        public String NameAdmin { get; set; }
        [Column("detail")]
        public String Detail { get; set; }
        [Column("status")]
        public Boolean Status { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
    }
}
