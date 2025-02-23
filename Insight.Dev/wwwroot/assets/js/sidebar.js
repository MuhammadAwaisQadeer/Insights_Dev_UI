document.addEventListener("DOMContentLoaded", function () {
    // Initialize sidebar toggling
    $(".sidebar-toggle").click(function () {
        $(".sidebar").toggleClass("collapsed");
    });

    // Highlight active menu items
    $(".nav-item").each(function () {
        if (window.location.href.includes($(this).attr("href"))) {
            $(this).addClass("active");
        }
    });
});
