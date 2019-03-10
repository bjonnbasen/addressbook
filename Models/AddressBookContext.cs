using addressBook.Services;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;






namespace addressBook.Models
{
    public class AddressBookContext : DbContext
    {

        public AddressBookContext(DbContextOptions<AddressBookContext> options, MsiAccessTokenProvider tokenProvider)
            : base(options)
        {
            var connection = Database.GetDbConnection() as SqlConnection;
            connection.AccessToken = tokenProvider.getAccessToken();
        }


        //public DbSet<Disp> Disps { get; set; }

        public DbSet<AddressBook> AddressBooks { get; set; }



    }
}