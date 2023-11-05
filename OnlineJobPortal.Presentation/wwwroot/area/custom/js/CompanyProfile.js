//Khởi tạo chosen select
$(document).ready(function () {
  $(".chosen-select").chosen({
    allow_single_deselect: true,
    width: "100%",
    no_results_text: "Không tìm thấy kết quả :",
  });
  // Khởi tạo ckeditor
  const editors = document.querySelectorAll(".text-editor");
  editors.forEach((el) => {
    ClassicEditor.create(el).catch((error) => {
      console.error(error);
    });
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
});
$("#CompanyLogo").change(function (e) {
  var img = $("#logoCompanyImg");

  if (e.target.files.length > 0) {
    var file = e.target.files[0];
    var reader = new FileReader();

    reader.onload = function (event) {
      img.attr("src", event.target.result);
    };

    reader.readAsDataURL(file);
  } else {
    img.attr("src", "");
  }
});
