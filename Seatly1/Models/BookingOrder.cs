﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Seatly1.Models;

public partial class BookingOrder
{
    [Key]
    public int OrderId { get; set; }

    public int? ActivityId { get; set; }

    public string? ActivityName { get; set; }

    public int? WaitingNumber { get; set; }

    public string? UserName { get; set; }

    public DateTime? DateTime { get; set; }

    public string? Status { get; set; }

    public string? ActivityBarcode { get; set; }

    public bool? Checked { get; set; }
}
