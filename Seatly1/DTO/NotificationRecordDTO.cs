﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Seatly1.DTO
{
    public class NotificationRecordDTO
    {
        public int ActivityId { get; set; }

        public int? OrganizerId { get; set; }

        public byte[]? ActivityPhoto { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public int? Capacity { get; set; }

        public string? ActivityName { get; set; }

        public string? ActivityMethod { get; set; }

        public string? DescriptionN { get; set; }

        public bool? IsRecurring { get; set; }

        public string? RecurringTime { get; set; }

        public string? HashTag1 { get; set; }

        public string? HashTag2 { get; set; }

        public string? HashTag3 { get; set; }

        public string? HashTag4 { get; set; }

        public string? HashTag5 { get; set; }
    }
}
