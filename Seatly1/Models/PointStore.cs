﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Seatly1.Models;

public partial class PointStore
{
    [Display(Name = "優惠券編號")]
    [DisplayName("優惠券編號")]
    public int ProductId { get; set; }

    [Display(Name = "優惠券圖片")]
    [DisplayName("優惠券圖片")]
    public string ProductImage { get; set; }

    [Display(Name = "優惠券名稱")]
    [DisplayName("優惠券名稱")]
    public string ProductName { get; set; }

    [Display(Name = "優惠券價格")]
    [DisplayName("優惠券價格")]
    public int? ProductPrice { get; set; }

    [Display(Name = "優惠券類別")]
    [DisplayName("優惠券類別")]
    public string Category { get; set; }

    [Display(Name = "優惠券描述")]
    [DisplayName("優惠券描述")]
    public string ProductDescription { get; set; }
}
