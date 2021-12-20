// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function getDob(idNumber) {
    var year = idNumber.substring(0, 2);
    var month = idNumber.substring(2, 4);
    var day = idNumber.substring(4, 6);

    var cutoff = (new Date()).getFullYear() - 2000;

    var dob = (year > cutoff ? '19' : '20') + year + '-' + month + '-' + day;
    document.getElementById("birth-date").value = dob;
}

function getClientReport() {
    window.open('/Home/Report', '_blank');
}


function disableIDBox(box) {
    var idNumber = document.getElementById("id-number")
    if (box.checked) {
        idNumber.disabled = true;
        idNumber.required = false;

    } else {
        idNumber.disabled = false;
    }
}
