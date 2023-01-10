using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEfCore.DataContext
{
    [Table("tbl_mailbox")]
    public class MailboxEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("username")]
        public String Username { get; set; }
        [Column("to_recipients")]
        public String ToRecipients { get; set; }
        [Column("cc_recipients")]
        public String CCRecipients { get; set; }
        [Column("subject")]
        public String Subject { get; set; }
        [Column("body")]
        public String Body { get; set; }
        [Column("attachment")]
        public String Attachment { get; set; }
        [Column("scheduled")]
        public DateTime Scheduled { get; set; }
        [Column("status")]
        public Boolean StatusDone { get; set; }
    }
}
