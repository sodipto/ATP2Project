/// <reference path="jquery-3.3.1.intellisense.js" />
var apiRoot = "http://localhost:14728/api";
var serverRoot = "http://localhost:8874";
var model;

function populateDepartmentTable(){
    $.ajax({
        type: "GET",
        url: apiRoot + "/departments",
        success: function (data) {
            model = data;
            $("#pageContainer").load(serverRoot + "/Views/Department/Index.html");
        }
    });
}

$("body").on("click", "#department", function () {
    populateDepartmentTable();
});

$("body").on("click", "#dept-list", function () {
    populateDepartmentTable();
});

$("body").on("click", "#dept-create", function () {
    $("#pageContainer").load(serverRoot + "/Views/Department/Create.html");
});

$("body").on("click", "#dept-edit", function () {
    var id = $(this).parent().parent().attr('id');
    $.ajax({
        type: "GET",
        url: apiRoot + "/departments/"+id,
        success: function (data) {
            model = data;
            $("#pageContainer").load(serverRoot + "/Views/Department/Edit.html");
        }
    });
});

$("body").on("click", "#dept-delete", function () {
    var id = $(this).parent().parent().attr('id');
    $.ajax({
        type: "GET",
        url: apiRoot + "/departments/"+id,
        success: function (data) {
            model = data;
            $("#pageContainer").load(serverRoot + "/Views/Department/Delete.html");
        }
    });
});

$("body").on("click", "#dept-detail", function (event) {
    var id = $(this).parent().parent().attr('id');
    //console.log(id);
    $.ajax({
        type: "GET",
        url: apiRoot + "/departments/" + id,
        success: function (data) {
            model = data;
            $("#pageContainer").load(serverRoot + "/Views/Department/Detail.html");
        }
    });
});