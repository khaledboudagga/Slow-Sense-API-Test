using System;
using System.Collections.Generic;

namespace Slow_Sense
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
