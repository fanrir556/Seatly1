﻿var strPointsTitle = sessionStorage.getItem('strPointsTitle') || "";
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
        strPointsTitle = "pointsShop";
        sessionStorage.setItem('strPointsTitle', strPointsTitle);
    });
    $("#pointsHistory").on("click", function () {
        strPointsTitle = "pointsHistory";
        sessionStorage.setItem('strPointsTitle', strPointsTitle);
    });
    $("#coupon").on("click", function () {
        strPointsTitle = "coupon";
        sessionStorage.setItem('strPointsTitle', strPointsTitle);
    });
})