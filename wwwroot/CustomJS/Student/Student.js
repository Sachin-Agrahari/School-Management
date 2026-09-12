$(document).ready(function () {
    GetEmployeeData();
})

function GetEmployeeData() {
    $.ajax({
        url: "/Students/GetStudentData",
        type: "GET",
        dataType: "JSON",
        data: {},
        succes: function (res) {
            alert(res);
        }
    })
}