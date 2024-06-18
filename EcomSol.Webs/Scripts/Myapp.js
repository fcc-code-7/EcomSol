$(document).ready(function () {
    $("#Create").click(function () {
        $.ajax({
            url: '/Product/Create',
            type: 'GET'
        })
            .done(function (response) {
                $("#action-container").html(response)
            })
            .fail(function (err) {
                console.log(err);
            })
    });


    $("#Submit").click(function () {
        var name = $("#Name").val();
        var desc = $("#Desc").val();
        var price = $("#Price").val();
        var obj = {
            Name: name,
            Description: desc,
            Price: price
        }
        $.ajax({
            url: '/Product/Create',
            type: 'POST',
            data:obj
        })
            .done(function (response) {
                $("#table-container").html(response)
                $('#Form')[0].reset();

            })
            .fail(function (err) {
                console.log(err);
            })
    });

    //EDIT
    $(".editForm").click(function () {
        var id = $(this).attr('data-id');
        console.log(id);
        var obj = {
            Id: id
        }
        $.ajax({
            url: '/Product/Edit',
            type: 'GET',
            data: obj
        })
            .done(function (response) {
                $("#action-container").html(response)
            })
            .fail(function (err) {
                console.log(err);
            })
    });

    //POSTEDIT
    $("#SubmitEdit").click(function () {
        var id = $(".getId").attr('id')
        var name = $("#Name").val();
        var desc = $("#Desc").val();
        var price = $("#Price").val();
        var obj = {
            Id:id,
            Name: name,
            Description: desc,
            Price: price
        }
        $.ajax({
            url: '/Product/Edit',
            type: 'POST',
            data: obj
        })
            .done(function (response) {
                $("#table-container").html(response)
                $('#EditForm')[0].reset();

            })
            .fail(function (err) {
                console.log(err);
            })
    });

    //DELETE
    $(".delForm").click(function () {
       
        $('#deleteModal').modal('show');
   
        // Use event delegation for dynamically added elements
        $("#yesbtn").click(function () {
            var id = $(".delForm").attr('data-id');
            var obj = { Id: id };
            $.ajax({
                url: '/Product/DeleteConfirmed',
                type: 'POST',
                data: obj
            })
                .done(function (response) {
                    $("#table-container").html(response);
                    $('#deleteModal').modal('hide');
                })
                .fail(function (err) {
                    console.log(err);
                });
        });

        // No button is handled by the modal dismiss button (data-dismiss="modal")
    });
});