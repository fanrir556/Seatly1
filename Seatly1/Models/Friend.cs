﻿using System;
using System.Collections.Generic;

namespace Seatly1.Models;

public partial class Friend
{
    public int FlowId { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public string? FriendUserName { get; set; }
}