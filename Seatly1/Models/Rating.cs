﻿using System;
using System.Collections.Generic;

namespace Seatly1.Models;

public partial class Rating
{
    public int RatingId { get; set; }

    public string? MemberAccount { get; set; }

    public string? RestaurantAccount { get; set; }

    public DateTime? CommentTime { get; set; }

    public int? TimelinessScore { get; set; }

    public int? TasteScore { get; set; }

    public int? ServiceScore { get; set; }

    public int? EnvironmentScore { get; set; }
}
