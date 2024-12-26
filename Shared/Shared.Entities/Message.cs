using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Study_2024_11.Shared.Entities;

//[Table("main_messages")]
public class Message
{
    [Key]
    public int UniqId { get; set; }
    public string Title { get; set; }

    //[Column("message_body")]
    public string Body { get; set; }

    //[ForeignKey(nameof(Producer))]
    public int AuthorId { get; set; }
    public User Producer { get; set; }

    //[NotMapped]
    //public int Count { get; set; }
}
