using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiShopOnline.Models
{
    public class Course:BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Title { get; set; }
        public int Creadits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}