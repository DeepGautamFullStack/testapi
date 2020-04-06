using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestWebAPICrud.Models
{
    public class TestWebAPICrudContext : DbContext
    {
        public TestWebAPICrudContext (DbContextOptions<TestWebAPICrudContext> options)
            : base(options)
        {
        }

        public DbSet<TestWebAPICrud.Models.User> User { get; set; }
    }
}
