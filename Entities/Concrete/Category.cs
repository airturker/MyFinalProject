using Entities.Abstract; //implement ettik - işaret ettik
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //çıplak class kalmasın
    public class Category: IEntity //implement ettik - işaret ettik
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
