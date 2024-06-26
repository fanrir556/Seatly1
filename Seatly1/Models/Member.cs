﻿using System;
using System.Collections.Generic;

namespace Seatly1.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public string? MemberAccount { get; set; }

    public string? MemberPassword { get; set; }

    public string? MemberNickname { get; set; }

    public string? MemberName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? Permission { get; set; }

    public int? Points { get; set; }

    public int? Age { get; set; }

    public DateOnly? Birthday { get; set; }

    public string? Sex { get; set; }

    public bool? Validation { get; set; }
}
