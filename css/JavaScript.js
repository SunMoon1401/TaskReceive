$("#IsChecked").click(function () {
    if ($("#IsChecked").is(":checked")) {
        $("#DropDownListUser").prop("disabled", true);
    }
    else {
        $("#DropDownListUser").removeAttr("disabled");
    }
})
//$("#IsCheckedMaxBet").click(function () {
//    if ($("#IsChecked").is(":checked")) {
//        $("#MaxBetNumBerGame").prop("enable", true);
//    }
//    else {
//        $("#MaxBetNumBerGame").removeAttr("disabled");
//    }
//})