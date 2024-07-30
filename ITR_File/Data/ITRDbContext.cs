using DocumentFormat.OpenXml.Spreadsheet;
using ITR_File.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Cryptography.X509Certificates;

namespace ITR_File.Data
{
    public class ITRDbContext :DbContext
    {
        public ITRDbContext(DbContextOptions<ITRDbContext> options) : base(options)
        {
        }
            public DbSet<Models.UserInfo> User { get; set; }
            public DbSet<FormDetails> Formdetail { get; set; }

            public DbSet<Receipt> receipts { get; set; }


        
    }
}
