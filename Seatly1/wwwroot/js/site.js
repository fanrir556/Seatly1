﻿var strPoints = sessionStorage.getItem('strPoints') || "";
$(function () {
    /*點數專區導覽列hover開始*/
    var timer;
    $("#pointsNav, #pointsDropdown").on("mouseenter", function () {
        clearTimeout(timer);
        $("#pointsNav").addClass("show");
        $("#pointsNav").attr("aria-expanded", "true");
        $("#pointsDropdown").addClass("show");
        $("#pointsDropdown").attr("data-bs-popper", "none");
    });

    $("#pointsNav, #pointsDropdown").on("mouseleave", function () {
        timer = setTimeout(function () {
            $("#pointsNav").removeClass("show");
            $("#pointsNav").attr("aria-expanded", "false");
            $("#pointsDropdown").removeClass("show");
            $("#pointsDropdown").attr("data-bs-popper", "");
        }, 100); // 這裡可以調整延遲的時間
    });
    /*點數專區導覽列hover結束*/

    $("#pointsShop").on("click", function () {
        strPoints = "pointsShop";
        sessionStorage.setItem('strPoints', strPoints);
    });
    $("#pointsHistory").on("click", function () {
        strPoints = "pointsHistory";
        sessionStorage.setItem('strPoints', strPoints);
    });
    $("#coupon").on("click", function () {
        strPoints = "coupon";
        sessionStorage.setItem('strPoints', strPoints);
    });
})