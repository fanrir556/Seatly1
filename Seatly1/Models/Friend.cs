﻿using System;
using System.Collections.Generic;

namespace Seatly1.Models;

public partial class Friend
{
    public int FlowId { get; set; }

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public string? FriendUserId { get; set; }

    public string? FriendUserName { get; set; }

    public bool? Checked { get; set; }
}
