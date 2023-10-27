

$(document).ready(function () {

  //Remove active nav-links
  var navLinks = $(".nav-link");
  navLinks.removeClass("active");
  //Add active for Post a new Job
  var PostANewJobItem = navLinks.eq(2);
  PostANewJobItem.addClass("active");


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

  $('form').on('submit', function(){
    var methodSelector = $('#methodSelector');
    var period = $('#periodSelector option:selected').text();

    var salary = null;
    if(methodSelector.val() == 1) {
        var minSalary = $('#minSalary').val();
        var maxSalary = $('#maxSalary').val();
        if(minSalary === '' || maxSalary === '') {
          salary = null;
        }
        else{
          salary = minSalary + ' - ' + maxSalary + + ' ' + period;
        }
    }else if(methodSelector.val() == 2) {
        var about = $('.about-method input').val();
        if(about === ''){
          salary = null;
        }
        else{
          salary = about  + ' ' + period;
        }
    }else if(methodSelector.val() == 3){
        salary = 'Thỏa thuận';
    }else{
      salary = null;
    }

    $('#Salary').val(salary);
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
    var container = $("#skillList");

    container.empty();

    var skills = $("#skillSelector option:selected")
      .toArray()
      .map((item) => {
        return { value: item.value, text: item.text };
      });

    var rawHtml = "";
    for (var i = 0; i < skills.length; i++) {
      rawHtml +=
        '<input type="hidden" name="Skills[' +
        i +
        '].Id" value="' +
        skills[i].value +
        '" />' +
        '<input type="hidden" name="Skills[' +
        i +
        '].SkillName" value="' +
        skills[i].text +
        '" />';
      console.log(skills[i]);
    }

    container.append(rawHtml);
  });
});
