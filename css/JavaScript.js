		//< !--JavaScript xử lý-- >//
$(function () {
	var websiteName = $("span[value='website']").text();
	var chkFirstLogin = $("input[value='chkFirstLogin']");
	var chkCreateSub = $("input[value='chkCreateSub']");
	var chkFirstLoginSub = $("input[value='chkFirstLoginSub']");

	chkCreateSub.prop("disabled", true);
	chkFirstLoginSub.prop("disabled", true);

	///////////// Xử lý sự kiện //////////////////
	if (websiteName === "VIVA88") {
		$("#MaxBetNumberGame").prop("disabled", false);
		$("#MaxBetNumberGame").attr("required", "required");
	} else {
		$("#MaxBetNumberGame").removeAttr();
		$("#MaxBetNumberGame").prop("disabled", true);
	}
	if (websiteName === "3IN1") {
		$(".checkboxWebsite3IN1").show();
	} else {
		$(".checkboxWebsite3IN1").hide();
	}

	$("input[value='checkboxWebsite']").change(function () {
		if ($(this).is(":checked")) {
			$("select[value='checkboxWebsite']").prop("disabled", true);
		} else {
			$("select[value='checkboxWebsite']").prop("disabled", false);
		}
	});
	//$("#DropDownListWed").change(function () {
	//	const DropDownListWed = $("#DropDownListWed option:selected").text();
	//	if (DropDownListWed === "VIVA88") {
	//		$("#MaxBetNumberGame").prop("disabled", false);
	//	} else {
	//		$("#MaxBetNumberGame").prop("disabled", true);
	//	}
	//	if (DropDownListWed === "3IN1") {
	//		$(".checkboxWebsite3IN1").show();
	//	} else {
	//		$(".checkboxWebsite3IN1").hide();
	//	}
	//});
	chkFirstLogin.change(function () {
		if ($(this).is(":checked")) {
			chkCreateSub.prop("disabled", false);
		} else {
			chkCreateSub.prop("disabled", true);
			chkCreateSub.prop("checked", false);
			chkFirstLoginSub.prop("disabled", true);
			chkFirstLoginSub.prop("checked", false);
		}
	});
	chkCreateSub.change(function () {
		if ($(this).is(":checked")) {
			chkFirstLoginSub.prop("disabled", false);
		} else {
			chkFirstLoginSub.prop("disabled", true);
			chkFirstLoginSub.prop("checked", false);
		}
	});
});