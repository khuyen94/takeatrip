function registerPagingEventHandlers(containerId, callback) {
    var searchText = $("#" + containerId + " .search-text").val();
    var orderBy = $("#" + containerId).find(".hdn-order-by").val();
    var isOrderAscending = $("#" + containerId).find(".hdn-is-order-ascending").val();

    $("#" + containerId + " .pagination li:not(.active) a.page-index").on('click', function (e) {
        e.preventDefault();
        var pageIndex = $(this).data('index');

        if (typeof callback == 'function') {
            callback(pageIndex, searchText, orderBy, isOrderAscending);
        }
    });

    $("#" + containerId + " .pagination li.active a.page-index").on('click', function (e) {
        e.preventDefault();
    });

    $("#" + containerId + " .pagination a.previous-page").on('click', function (e) {
        e.preventDefault();
        var currentIndex = $("#" + containerId + " ul.pagination").find("li.active").find("a").data("index");
        if (currentIndex > 0) {
            var pageIndex = currentIndex - 1;

            if (typeof callback == 'function') {
                callback(pageIndex, searchText, orderBy, isOrderAscending);
            }
        }

        return false;
    });

    $("#" + containerId + " .pagination a.next-page").on('click', function (e) {
        e.preventDefault();
        var numberPage = $("#" + containerId + " ul.pagination").data("number-page");
        var currentIndex = $("#" + containerId + " ul.pagination").find("li.active").find("a").data("index");
        if ((currentIndex + 1) < numberPage) {
            var pageIndex = currentIndex + 1;

            if (typeof callback == 'function') {
                callback(pageIndex, searchText, orderBy, isOrderAscending);
            }
        }

        return false;
    });

    $("#" + containerId + " .pagination a.first-page").on('click', function (e) {
        e.preventDefault();
        var currentIndex = $("#" + containerId + " ul.pagination").find("li.active").find("a").data("index");
        if (currentIndex > 0) {
            var pageIndex = 0;

            if (typeof callback == 'function') {
                callback(pageIndex, searchText, orderBy, isOrderAscending);
            }
        }

        return false;
    });

    $("#" + containerId + " .pagination a.last-page").on('click', function (e) {
        e.preventDefault();
        var numberPage = $("#" + containerId + " ul.pagination").data("number-page");
        var currentIndex = $("#" + containerId + " ul.pagination").find("li.active").find("a").data("index");
        if ((currentIndex + 1) < numberPage) {
            var pageIndex = numberPage - 1;

            if (typeof callback == 'function') {
                callback(pageIndex, searchText, orderBy, isOrderAscending);
            }
        }

        return false;
    });
}


function registerSortingEventHandlers(containerId, callback) {
    $("#" + containerId + " th.column-order").on('click', function () {
        var searchText = $("#" + containerId + " .search-text").val();
        var currentIndex = $("#" + containerId + " ul.pagination").find("li.active").find("a").data("index");
        var orderBy = $(this).data("order-by");
        var childElement = $(this).find('i.fa');

        if (childElement.hasClass("fa-sort") || childElement.hasClass("fa-sort-desc")) {
            if (typeof callback == 'function') {
                callback(currentIndex, searchText, orderBy, "True");
            }
        } else {
            if (typeof callback == 'function') {
                callback(currentIndex, searchText, orderBy);
            }
        }
    });
}