﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Seatly1.Models;

public partial class NotificationRecord
{
    public int ActivityId { get; set; }

    public int? OrganizerId { get; set; }

    public byte[] ActivityPhoto { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public int? Capacity { get; set; }

    public string ActivityName { get; set; }

    public string DescriptionN { get; set; }

    public bool? IsRecurring { get; set; }

    public string RecurringTime { get; set; }

    public string HashTag { get; set; }

    public string ActivityMethod { get; set; }
}