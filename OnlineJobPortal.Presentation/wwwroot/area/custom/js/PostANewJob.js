﻿$(document).ready(function () {

  $.ajax({
    type: "get",
    dataType: "json",
    cache: false,
    url: "/Employer/JobPost/IsValidCompanyInfo",
    success: function (res) {
      if(!res){
        $('.overlay').show();
      }
    },
    error: function (err) {
      console.error(err);
    }
  });  

  // Khởi tạo location selection
  var localpicker = new LocalPicker({
    province: "ls_province",
    district: "ls_district",
    ward: "ls_ward",
  });

  $(".ls_province").change(function () {
    var provinceText = $(this).find("option:selected").text();
    $("input[name='ProvinceName']").val(provinceText);
  });

  $(".ls_district").change(function () {
    var districtText = $(this).find("option:selected").text();
    $("input[name='DistrictName']").val(districtText);

    var provinceText = $(".ls_province").find("option:selected").text();

    var address = districtText + ", Tỉnh " + provinceText;
    if (provinceText === "Hồ Chí Minh") {
      address = districtText + ", TP. " + provinceText;
    }
    $("input[name='Address']").val(address);
  });

  // Chọn tất cả các step
  var steps_title = $(".step-title");
  var steps = $(".step");

  // Sử dụng sự kiện click cho mỗi step
  steps_title.click(function () {
    // Loại bỏ class active-step từ tất cả các step
    steps.removeClass("active-step");

    // Thêm class active-step vào step mà bạn vừa nhấn
    $(this).children(".step").addClass("active-step");
  });

  $("form").on("submit", function () {
    var methodSelector = $("#methodSelector");
    var salary = null;

    if (methodSelector.val() == 1) {
      var minSalary = $("#minSalary").val();
      var maxSalary = $("#maxSalary").val();
      salary =
        minSalary && maxSalary
          ? minSalary + " - " + maxSalary
          : null;
    } else if (methodSelector.val() == 2) {
      var about = $(".about-method input").val();
      salary = about ? about: null;
    } else if (methodSelector.val() == 3) {
      salary = "Thỏa thuận";
    }
    
    $("#Salary").val(salary);
  });
});

const editors = document.querySelectorAll(".text-editor");
editors.forEach((el) => {
  ClassicEditor.create(el).catch((error) => {
    console.error(error);
  });
});

// Add active for tabs
function hiddenTabs() {
  var tabs = $(".postJob-tabs");
  tabs.removeClass("active-tab");
}

function showBasicInfomationTab() {
  hiddenTabs();
  $("#basicInfomationTab").addClass("active-tab");
  var steps = $(".step");
  steps.removeClass("active-step");
  $("#step-menu-item-basicInfomation .step").addClass("active-step");
  scrollOnTop();
}

function showJobDescriptionTab() {
  hiddenTabs();
  $("#jobDescriptionTab").addClass("active-tab");
  var steps = $(".step");
  steps.removeClass("active-step");
  $("#step-menu-item-jobDescription .step").addClass("active-step");
  scrollOnTop();
}

function showBenefitTab() {
  hiddenTabs();
  $("#benefitTab").addClass("active-tab");
  var steps = $(".step");
  steps.removeClass("active-step");
  $("#step-menu-item-benefits .step").addClass("active-step");
  scrollOnTop();
}

function scrollOnTop() {
  document.body.scrollTop = 0;
  document.documentElement.scrollTop = 0;
}

$("#methodSelector").on("change", function () {
  var inputs = $(".range-method input, .about-method input");
  inputs.each(function () {
    $(this).val("");
  });

  //Ẩn hiện thông tin của các hình thức thanh toán lương
  var selectedValue = $(this).val();
  if (selectedValue == "1") {
    $(".about-method").css("display", "none");
    $(".range-method").css("display", "block");
    $(".period").css("display", "block");
  } else if (selectedValue == "2") {
    $(".range-method").css("display", "none");
    $(".period").css("display", "block");
    $(".about-method").css("display", "block");
  } else {
    $(".range-method").css("display", "none");
    $(".period").css("display", "none");
    $(".about-method").css("display", "none");
  }
});

$(document).ready(function () {
  $("#skillSelector").on("change", function () {
    var container = $("#skillList").empty();

    $("#skillSelector option:selected").each(function (i) {
      container.append(
        '<input type="hidden" name="Skills[' + i + '].SkillId" value="' +
          this.value +
          '" />'
      );
    });
  });
});

