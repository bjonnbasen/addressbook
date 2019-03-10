using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace addressBook.Models

{
    [Table("addressbook")]
    public class AddressBook
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Phone")]
        public int Phone { get; set; }

        [Column("city")]
        public string city { get; set; }

    }
}