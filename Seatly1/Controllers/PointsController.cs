﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Seatly1.Models;

namespace Seatly1.Controllers
{
    public class PointsController : Controller
    {
        SeatlyContext _context;

        public PointsController(SeatlyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //GET: /Points/pointsShopTitle
        public IActionResult pointsShopTitle()
        {
            return PartialView("_pointsShopTitlePartial");
        }

        public IActionResult pointsHistoryTitle()
        {
            return PartialView("_pointsHistoryTitlePartial");
        }

        public IActionResult couponTitle()
        {
            return PartialView("_couponTitlePartial");
        }

        public async Task<IActionResult> pointsShopContentHead()
        {
            return PartialView("_pointsShopContentHeadPartial", await _context.PointStores.ToListAsync());
        }

        public async Task<IActionResult> pointsShopContentBody(string? cate)
        {
            if (cate == "all")
            {
                return PartialView("_pointsShopContentBodyPartial", await _context.PointStores.ToListAsync());
            }
            else
            {
                return PartialView("_pointsShopContentBodyPartial", await _context.PointStores.Where(s => s.Category == cate).ToListAsync());
            }
        }

        public IActionResult pointsHistoryContent()
        {
            return PartialView("_pointsHistoryContentPartial");
        }

        public IActionResult couponContent()
        {
            return PartialView("_couponContentPartial");
        }
    }
}
