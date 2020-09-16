using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiShopOnline.Models
{
    public class Student:BaseEntity
    {
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollMentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}