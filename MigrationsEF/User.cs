using System;
using System.Collections.Generic;

namespace MigrationsEF
{
    public partial class User
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Passport { get; set; }
    }
}
