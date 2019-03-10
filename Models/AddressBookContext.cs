using Microsoft.EntityFrameworkCore;
using addressBook.Models;

namespace addressBook.Models
{
    public class AddressBookContext : DbContext
    {

        public AddressBookContext(DbContextOptions<AddressBookContext> options)
            : base(options)
        {
        }

        //public DbSet<Disp> Disps { get; set; }

        public DbSet<Contact> Contacts { get; set; }



    }
}