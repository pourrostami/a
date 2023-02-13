using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a.Shared
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public int Status { get; set; } = 1;

        #region Relation
        public List<Product> Products { get; set; }
        #endregion

    }
}
