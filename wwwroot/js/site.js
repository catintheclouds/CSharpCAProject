// Please see documentation at  
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    //alert("Use alerts to check if JS file is even being used")
    //This is to make search bar auto-clear when blank
});

    $("#searchBar").keyup(function (event) {
        var input = $("#searchBar").val();
        var tCount = $("#tCount").val();
        var number = $("#number").val();
        if (event.keyCode == 8 && input.length <= 0 && number != tCount) {
            $("#searchForm").submit();
        }
    })
    function sortinghat() {
        var e = document.getElementById("sorterId");
        var sortValue = e.options[e.selectedIndex].value;
        //alert(sortValue);
        $("#searchBar").val(sortValue);
        $("#searchForm").submit();
    }

//document.getElementById("sorterId").setAttribute("onchange", "sortinghat()");
//Why doesnt addeventlistener work?
