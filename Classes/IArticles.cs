using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce
{
    public interface IArticles
    {
        public List<Article> GetList();
    }
}