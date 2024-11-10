jQuery(document).ready(function ($) {
    document.getElementById("searchIcon").addEventListener("click", function () {
        var searchForm = document.getElementById("searchForm");
        var searchButton = document.getElementById("searchButton");

        if (searchForm.classList.contains("hidden")) {
            searchForm.classList.remove("hidden");
            searchButton.classList.remove("hidden");
        } else {
            searchForm.classList.add("hidden");
            searchButton.classList.add("hidden");
        }
    });
});