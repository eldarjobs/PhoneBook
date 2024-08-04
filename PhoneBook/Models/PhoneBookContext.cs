using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class PhoneBookContext : DbContext
    {

        DbSet<Person> People { get; set; }
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.,1401;database=PhoneBook2;uid=sa;pwd=Pro247!!;Encrypt=True;TrustServerCertificate=true;\r\n");
        }
    }
}
