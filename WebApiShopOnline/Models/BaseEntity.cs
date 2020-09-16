using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiShopOnline.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}