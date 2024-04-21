using System;
using System.Collections.Generic;

namespace Bakcend.Models;

public partial class Quantity
{
    public int Id { get; set; }

    public int Extant { get; set; }

    public int Sold { get; set; }

    public int Revenue { get; set; }

    public virtual ICollection<Merchant> Merchants { get; set; } = new List<Merchant>();
}
