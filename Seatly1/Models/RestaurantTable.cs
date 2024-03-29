﻿using System;
using System.Collections.Generic;

namespace Seatly1.Models;

public partial class RestaurantTable
{
    public int TableId { get; set; }

    public int? RestaurantId { get; set; }

    public string? TableName { get; set; }

    public int? Capacity { get; set; }

    public string? Status { get; set; }

    public string? PartitionName { get; set; }
}