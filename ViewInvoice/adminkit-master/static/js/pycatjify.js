$(function () {
    $('languageddl').select(function () {
        var data = {}  // object to hold the user input data
        // store user data in a data["pycatj_data"] 
        if ($('#yaml_switch').prop("checked")) {
            data["pycatj_data"] = $('#in_form').val()  // in case of YAML data - store it as a string
        } else {
            data["pycatj_data"] = JSON.parse($('#in_form').val())  // in case of JSON data - store it as an object
        }

        // todo: add root input element
        // data["root"] = "POST"
        console.log(data)
        var body = JSON.stringify(data)
        $.ajax({
            url: "http://localhost:5000/api/Language",
            contentType: "application/json",
            data: body,
            dataType: "json",
            type: 'POST',
            success: function (response) {
                $('#out_form').val(response.data)
            }
        });
    });
});

$(function () {
    $('currencyddl').select(function () {
        var data = {}  // object to hold the user input data
        // store user data in a data["pycatj_data"] 
        if ($('#yaml_switch').prop("checked")) {
            data["pycatj_data"] = $('#in_form').val()  // in case of YAML data - store it as a string
        } else {
            data["pycatj_data"] = JSON.parse($('#in_form').val())  // in case of JSON data - store it as an object
        }

        // todo: add root input element
        // data["root"] = "POST"
        console.log(data)
        var body = JSON.stringify(data)
        $.ajax({
            url: "http://localhost:5000/api/Language",
            contentType: "application/json",
            data: body,
            dataType: "json",
            type: 'POST',
            success: function (response) {
                $('#out_form').val(response.data)
            }
        });
    });
});

$(function () {
    $('AddressText').select(function () {
        var data = {}  // object to hold the user input data
        // store user data in a data["pycatj_data"] 
        if ($('#yaml_switch').prop("checked")) {
            data["pycatj_data"] = $('#in_form').val()  // in case of YAML data - store it as a string
        } else {
            data["pycatj_data"] = JSON.parse($('#in_form').val())  // in case of JSON data - store it as an object
        }

        // todo: add root input element
        // data["root"] = "POST"
        console.log(data)
        var body = JSON.stringify(data)
        $.ajax({
            url: "http://localhost:5000/api/Receiver",
            contentType: "application/json",
            data: body,
            dataType: "json",
            type: 'POST',
            success: function (response) {
                $('#out_form').val(response.data)
            }
        });
    });
});