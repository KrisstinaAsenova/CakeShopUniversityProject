using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace _101Shop.Models
{
    [Table("AspNetUsers")]
    public class User : IdentityUser
    {
        public List<Comment> Comments { get; set; }
    }
}
