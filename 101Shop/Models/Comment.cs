using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public virtual Cake Cake { get; set; }
        public int CakeId { get; set; }
        public virtual User User { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

    }
}
