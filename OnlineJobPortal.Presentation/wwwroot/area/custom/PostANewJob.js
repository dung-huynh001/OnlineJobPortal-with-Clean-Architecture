const editors = document.querySelectorAll('.text-editor');
editors.forEach((el) => {
    ClassicEditor
        .create(el)
        .catch(error => {
            console.error(error);
        });
});

$(document).ready(function () {
    // Chọn tất cả các step
    var steps_title = $('.step-title');
    var steps = $('.step');

    // Sử dụng sự kiện click cho mỗi step
    steps_title.click(function () {
        // Loại bỏ class active-step từ tất cả các step
        steps.removeClass('active-step');

        // Thêm class active-step vào step mà bạn vừa nhấn
        $(this).children(".step").addClass('active-step');
    });

    //Remove active nav-links
    var navLinks = $('.nav-link');
    navLinks.removeClass('active');

    //Add active for Post a new Job
    var PostANewJobItem = navLinks.eq(2);
    PostANewJobItem.addClass('active');


});

// Add active for tabs
function hiddenTabs() {
    var tabs = $('.postJob-tabs');
    tabs.removeClass('active-tab');
}



function showBasicInfomationTab() {
    hiddenTabs();
    $('#basicInfomationTab').addClass('active-tab');
    var steps = $('.step');
    steps.removeClass('active-step');
    $('#step-menu-item-basicInfomation .step').addClass('active-step');
    crollOnTop();
}

function showJobDescriptionTab() {
    hiddenTabs();
    $('#jobDescriptionTab').addClass('active-tab');
    var steps = $('.step');
    steps.removeClass('active-step');
    $('#step-menu-item-jobDescription .step').addClass('active-step');
    crollOnTop();
}

function showBenefitTab() {
    hiddenTabs();
    $('#benefitTab').addClass('active-tab');
    var steps = $('.step');
    steps.removeClass('active-step');
    $('#step-menu-item-benefits .step').addClass('active-step');
    crollOnTop();
}

function crollOnTop() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}


$('#methodSelector').on('change', function () {
    var selectedValue = $(this).val();
    console.log(selectedValue)
    if (selectedValue == "0") {
        $('.about-method').css('display', 'none');
        $('.range-method').css('display', 'block');
    } else if (selectedValue == "1") {
        $('.range-method').css('display', 'none');
        $('.about-method').css('display', 'block');
    } else {
        $('.range-method').css('display', 'none');
        $('.about-method').css('display', 'none');
    }
});