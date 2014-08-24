using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace YiMianWeb.Models
{
    public class ProblemContext : DbContext
    {
        public ProblemContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<ProblemEntity> Problems { get; set; }
    }
    [Table("Problem")]
    public class ProblemEntity
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProblemId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Creator { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ChangeTime { get; set; }
        public byte ProblemType { get; set; }
    }

    [Table("ProblemExt")]
    public class ProblemExtEntity
    {
        [Key]
        public int ProblemID { get; set; }
        public int Attempted { get; set; }
        public int LikeCount { get; set; }
        public int FavoriteCount { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ChangeTime { get; set; }
    }


}