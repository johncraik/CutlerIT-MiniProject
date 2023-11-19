// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function AddNewNote() {
    var title = document.getElementById('title').value;
    var noteTxt = document.getElementById('note').value;
    var date = document.getElementById('date').value;

    //alert(title + " " + noteTxt + " " + date);

    DotNet.invokeMethodAsync('CutlerITMiniProject', 'AddNote', title, noteTxt, date);
}