﻿using Microsoft.AspNetCore.Mvc;

namespace Seatly1.Controllers
{
    public class OrganizerRouteController : Controller
    {
        // 活動方主頁
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OrganizerLogin()
        {
            return View();
        }
        public IActionResult OrganizerRegister()
        {
            return View();
        }

        // GET: 活動方忘記密碼頁面
        public ActionResult OrganizerForgetPwd()
        {
            return View();
        }

        public IActionResult OrganizerInfo()
        {
            return View();
        }
        public IActionResult NotificationRecord()
        {
            return View();
        }
        public IActionResult ActivityCreate()
        {
            return View();
        }
        public IActionResult ActivityEdit()
        {
            return View();
        }
    }
}
