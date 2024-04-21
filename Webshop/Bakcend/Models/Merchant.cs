using System;
using System.Collections.Generic;

namespace Bakcend.Models;

public partial class Merchant
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }

    public int QuantityId { get; set; }

    public virtual Quantity Quantity { get; set; } = null!;

    public virtual ICollection<User> User { get; set; } = new List<User>();
}
