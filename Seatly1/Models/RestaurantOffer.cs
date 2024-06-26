﻿using System;
using System.Collections.Generic;

namespace Seatly1.Models;

public partial class RestaurantOffer
{
    public int Id { get; set; }

    public int? RestaurantId { get; set; }

    public string? Photo { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }
}
