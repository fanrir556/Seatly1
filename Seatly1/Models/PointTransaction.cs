﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Seatly1.Models;

public partial class PointTransaction
{
    [Display(Name = "交易編號")]
    [DisplayName("交易編號")]
    public int Id { get; set; }

    [Display(Name = "優惠券編號")]
    [DisplayName("優惠券編號")]
    public int? ProductId { get; set; }

    [Display(Name = "會員編號")]
    [DisplayName("會員編號")]
    public string MemberId { get; set; }

    [Display(Name = "交易時間")]
    [DisplayName("交易時間")]
    public DateTime? TransactionDate { get; set; }

    [Display(Name = "優惠券狀態")]
    [DisplayName("優惠券狀態")]
    public bool? Active { get; set; }
}
