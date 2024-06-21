﻿var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/api/landmark',
            method: "GET"
        },
        "columns": [
            { data: 'id' },
            { data: 'name' },
            {
                data: 'description',
                "render": function (data) {
                    return data.length > 20 ? data.substr(0, 20) + '...' : data;
                }
            },
            { data: 'openTime' },
            { data: 'closeTime' },
            {
                data: 'latitude',
                "render": function (data) {
                    return data.toFixed(2); // Display latitude with 2 decimal places
                }
            },
            {
                data: 'longitude',
                "render": function (data) {
                    return data.toFixed(2); // Display longitude with 2 decimal places
                }
            },
            { data: 'egyptianTicketPrice' },
            { data: 'egyptianStudentTicketPrice' },
            { data: 'foreignTicketPrice' },
            { data: 'foreignStudentTicketPrice' },
            {
                data: 'images',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                      <img src="${data[0].url}" alt="Image" style="width: 200px; height: 150px;">
                    </div>`
                }
            },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/Landmark/edit?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>               
                     <a onClick=Delete('/api/landmark?id=${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                    </div>`
                }
            }
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
            Swal.fire({
                title: "Deleted!",
                text: "Your file has been deleted.",
                icon: "success"
            });
        }
    })
}