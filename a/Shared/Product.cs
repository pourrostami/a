using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a.Shared
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }=string.Empty;

        public string Description { get; set; }=string.Empty;
        public string ImageUrl { get; set; }=string.Empty;
        public int Price { get; set; }


        #region
        public int CategoryId { get; set;}
        public Category? Category { get; set; }

        #endregion
    }
}
