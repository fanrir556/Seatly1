﻿using System;
using System.Collections.Generic;

namespace Seatly1.Models;

public partial class RestaurantTime
{
    public int Id { get; set; }

    public int? RestaurantId { get; set; }

    public int? Weekday { get; set; }

    public TimeOnly? OpeningTime { get; set; }

    public TimeOnly? ClosingTime { get; set; }

    public TimeOnly? LastAdmission { get; set; }
}