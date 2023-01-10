using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEfCore.DataContext
{
    [Table("tbl_inventory")]
    public class InventoryEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("inventory_name")]
        public String Name { get; set; }
        [Column("specification")]
        public String Specification { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("onloan")]
        public int OnLoan { get; set; }
        [Column("ready")]
        public int Ready { get; set; }
    }
}
