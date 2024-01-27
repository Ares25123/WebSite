using System;
using System.Collections.Generic;

namespace Web2.Models
{
    public partial class User
    {
        public User()
        {
            Meals = new HashSet<Meal>();
            Categories = new HashSet<Category>();
            Products = new HashSet<Product>();
        }

        public int UserId { get; set; }
        public string Surname { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int CreatedBy { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Sex { get; set; } = null!;

        public virtual ICollection<Meal> Meals { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
