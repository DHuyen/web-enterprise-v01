using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace WebEnterprise_mssql.Api.Models
{
    public class Categories
    {
        [KeyAttribute]
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Posts> Posts { get; set; }
    }
}