﻿<script src="../../Scripts/jquery-1.7.1.js" type="text/javascript"></script>
    <script src="../../Scripts/jquery-1.7.1.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            //Dropdownlist Selectedchange event
            $("#Country").change(function () {
                $("#State").empty();
                $.ajax({
                    type: 'POST',
                    url: '@Url.Action("GetStates")', // we are calling json method

                    dataType: 'json',

                    data: { id: $("#Country").val() },
                    // here we are get value of selected country and passing same value
                    as inputto json method GetStates.
 
                        success: function (states) {
            // states contains the JSON formatted list
            // of states passed from the controller

            $.each(states, function (i, state) {
                $("#State").append('<option value="' + state.Value + '">' +
                    state.Text + '</option>');
                // here we are adding option for States

            });
        },
                error: function (ex) {
            alert('Failed to retrieve states.' + ex);
        }
            });
            return false;
        })
    });
    </script>
    <script type="text/javascript">
        $(document).ready(function () {
            //Dropdownlist Selectedchange event
            $("#State").change(function () {
                $("#city").empty();
                $.ajax({
                    type: 'POST',
                    url: '@Url.Action("GetCity")',
                    dataType: 'json',
                    data: { id: $("#State").val() },
                    success: function (citys) {
                        // states contains the JSON formatted list
                        // of states passed from the controller
                        $.each(citys, function (i, city) {
                            $("#city").append('<option value="'
                                + city.Value + '">'
                                + city.Text + '</option>');
                        });
                    },
                    error: function (ex) {
                        alert('Failed to retrieve states.' + ex);
                    }
                });
                return false;
            })
        });
</script> 