const TOASTR_PLUGIN_URL = "../../area/assets/plugins/toastr/toastr.min.js";
const RESUME_ID = $("#Resume_Id").val();

var tooltipTriggerList = [].slice.call(
  document.querySelectorAll('[data-bs-toggle="tooltip"]')
);
var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
  return new bootstrap.Tooltip(tooltipTriggerEl);
});

$(document).ready(function () {
  const btnShowModal = $(".btn-show-modal");
  const modalTitle = $(".modal-title");
  const experienceModalBody = $("#staticBackdrop .modal-body");
  const summaryContainer = $(".summary-container");
  const skillContainer = $(".skill-container");
  const workExperienceContainer = $(".work-experience-container");
  const updateResumeForm = $("#update-resume-form")[0];
  const btnSaveProject = $(".btn-save-project");
  const btnAddProject = $(".btn-add-project");
  const addExperienceProjectForm = $("#add-experience-project-form")[0];

  var btnSave = $(".btn-save");
  var btnCancel = $(".btn-cancel");
  var btnDeleteExperience = $(".btn-delete-experience");

  btnShowModal.click(function () {
    var title = $(this).find("i").data("info-area");
    renderModalContent(title);
  });

  async function getAllSkills() {
    var skills = [];
    await $.ajax({
      type: "GET",
      dataType: "json",
      url: "/Resume/GetAllSkill",
      success: function (res) {
        skills = res;
      },
      error: function (err) {
        console.error(err);
      },
    });
    return skills;
  }

  btnSave.click(function (event) {
    event.preventDefault();
    var targetSection = $(this).data("target-section");
    var data;
    switch (targetSection.toLowerCase()) {
      case "tóm tắt":
        let careerGoal = $(".ck-content").text();
        data = {
          id: RESUME_ID,
          careerGoal: careerGoal,
        };
        break;
      case "kỹ năng":
        data = {
          id: RESUME_ID,
          skillList: $(".chosen-select").val(),
        };
        break;
      case "kinh nghiệm làm việc":
        if (!updateResumeForm.checkValidity()){
          toastr.warning("Vui lòng nhập đầy đủ các trường bắt buộc");
          return;
        }
        data = {
          resumeId: RESUME_ID,
          position: $("#experience-position-field").val(),
          companyName: $("#experience-company-name-field").val(),
          startDate: $("#experience-start-date-field").val(),
          endDate: $("#experience-end-date-field").val(),
          skills: $("#experience-skills-list-field").val(),
          description: $(".ck-content").text(),
        };
        if(data.startDate > data.endDate) {
          toastr.warning("Ngày kết thúc phải sau ngày bắt đầu");
          return;
        }
        break;
    }
    updateSection(targetSection, data);
  });

  btnDeleteExperience.click(function(event) {
    event.preventDefault();
    $(this).closest('.d-flex').remove();
    let id = $(this).data("experience-id");
    callAjaxToDeleteResources(id, "/Profile/DeleteExperience");
  });

  btnAddProject.click(function(){
    let experienceId = $(this).data("experience-id");
    btnSaveProject.data("experience-id", experienceId);
  });

  btnSaveProject.click(function(event){
    event.preventDefault();
    let experienceId = $(this).data("experience-id");
    let data = {
      experienceId: experienceId,
      title: $('#experience-project-name-field').val(),
      position: $('#experience-project-position-field').val(),
      startDate: $('#experience-project-start-date-field').val(),
      endDate: $('#experience-project-end-date-field').val()
    };
    if(!addExperienceProjectForm.checkValidity()) {
      toastr.warning('Vui lòng điền đầy đủ các trường bắt buộc');
    }
    console.log(data);
    $.ajax({
      type: 'POST',
      dataType: 'json',
      url: '/Profile/AddExperienceProject',
      data: data,
      success: function(res){

      },
      error: function(err){

      }
    });
  });

  function callAjaxToDeleteResources(id, url){
    $.ajax({
      type: "Delete",
      url: url,
      data: {id: id},
      success: function(res){
        if(res.success)
          toastr.success("Xóa thành công");
        else
          toastr.error("Xóa thất bại");
      },
      error: function(err){
        console.log("Không thể kết nối tới server");
      }
    });
  }

  async function renderModalContent(title) {
    var skillList = await getAllSkills();
    var options;
    if (skillList.length > 0) {
      options = skillList.map(
        (skill) => `<option value="${skill.id}">${skill.skillName}</option>`
      );
    }
    var optionElements = options.join("");
    modalTitle.html(title);
    btnSave.data("target-section", title);

    var modalBodyHtml = "";
    switch (title.toLowerCase()) {
      case "tóm tắt":
        modalBodyHtml = `
            <textarea class="form-control text-editor"></textarea>`;
        break;
      case "kỹ năng":
        modalBodyHtml =
          `<select class="chosen-select" data-placeholder="Vd: C#, ASP.NET,..." multiple>` +
          optionElements +
          `</select>`;
        break;
      case "kinh nghiệm làm việc":
        modalBodyHtml =
          `<div class="d-flex flex-column gap-3">
          <div>
              <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Vị trí công việc<span class="text-danger fw-light ms-1">(*)</span></label>
              <input class="form-control" type="text" id="experience-position-field" required>
          </div>
          <div>
              <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Tên công ty<span class="text-danger fw-light ms-1">(*)</span></label>
              <input class="form-control" type="text" id="experience-company-name-field" required>
          </div>
          <div class="d-flex gap-3">
              <div class="flex-grow-1">
                  <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Ngày bắt đầu<span class="text-danger fw-light ms-1">(*)</span></label>
                  <input class="form-control" type="date" id="experience-start-date-field" required>
              </div>
              <div class="flex-grow-1">
                  <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Ngày kết thúc<span class="text-danger fw-light ms-1">(*)</span></label>
                  <input class="form-control" type="date" id="experience-end-date-field" required>
              </div>
          </div>
          <div>
              <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Kỹ năng tích lũy<span class="text-danger fw-light ms-1">(*)</span></label>
              <select class="chosen-select" data-placeholder="Vd: C#, ASP.NET,..." multiple id="experience-skills-list-field">
              ` +
          optionElements +
          `</select>
          </div>
          <div>
              <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Mô tả</label>
              <textarea class="form-control text-editor" id="experience-description-field"></textarea>
          </div>
          <span class="text-danger me-auto" style="font-weight: 300; font-size: 0.8rem;">(*) Bắt buộc</span>

      </div>`;
        break;
      case "học vấn":
        modalBodyHtml = `
        <div class="d-flex flex-column gap-3">
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Tên trường</label>
            <input class="form-control" type="text">
        </div>
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Chuyên ngành</label>
            <input class="form-control" type="text">
        </div>
        <div class="d-flex gap-3">
            <div class="flex-grow-1">
                <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Ngày bắt đầu</label>
                <input class="form-control" type="date">
            </div>
            <div class="flex-grow-1">
                <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Ngày kết thúc</label>
                <input class="form-control" type="date">
            </div>
        </div>
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Điêm trung bình(GPA)</label>
            <input class="form-control" type="number" step="0.01" min="1">
        </div>
    </div>`;
        break;
      case "dự án":
        modalBodyHtml = `<div class="d-flex flex-column gap-3">
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Tên dự án</label>
            <input class="form-control" type="text">
        </div>
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Vị trí đảm nhận</label>
            <input class="form-control" type="text">
        </div>
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Công nghệ sử dụng</label>
            <input class="form-control" type="text">
        </div>
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Link git</label>
            <input class="form-control" type="text">
        </div>
        <div class="d-flex gap-3">
            <div class="flex-grow-1">
                <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Thời gian bắt đầu</label>
                <input class="form-control" type="date">
            </div>
            <div class="flex-grow-1">
                <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Thời gian kết thúc</label>
                <input class="form-control" type="date">
            </div>
        </div>
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Mô tả</label>
            <textarea class="form-control text-editor"></textarea>
        </div>
    </div>`;
        break;
      case "ngoại ngữ":
        modalBodyHtml = `<div class="d-flex flex-column gap-3">
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Ngôn ngữ</label>
            <input class="form-control" type="text">
        </div>
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Trình độ</label>
            <input class="form-control" type="text">
        </div>
    </div>`;
        break;
      default:
        break;
    }
    experienceModalBody.html(modalBodyHtml);

    const editors = $(".text-editor");
    editors.each((index, el) => {
      ClassicEditor.create(el).catch((error) => {
        console.error(error);
      });
    });

    $(".chosen-select").chosen({
      allow_single_deselect: true,
      width: "100%",
      no_results_text: "Không tìm thấy kết quả :",
    });
  }

  function renderSummaryContainerContent(data) {
    summaryContainer.find("p").text(data);
  }

  function renderSkillContainerContent(data) {
    if (data != null && data.length > 0) {
      var skillListHtml = [];
      for (let i = 0; i < data.length; i++) {
        skillListHtml.push(
          `<span class="py-1 px-2 bg-white border" style="font-size: 0.9rem;">${data[i].skillName}</span>`
        );
      }
      skillContainer.find("p").html(skillListHtml.join(""));
    } else {
      skillContainer.find("p").html("Không có kỹ năng nào.");
    }
  }

  function renderExperienceContainerContent(data) {
    var experienceSkillList = [];
    if (data.experienceSkills != null && data.experienceSkills.length > 0) {
      experienceSkillList = data.experienceSkills.map((es) => {
        return `<span class="py-1 px-2 bg-white border">${es.skill.skillName}</span>`;
      });
    }
    var experienceContainerHtml =
      `<div class="d-flex gap-3 my-3 px-2 pt-2 pb-4 border-bottom" style="font-size: 0.9rem;">
      <div class="text-nowrap">${data.startDate} - ${data.endDate}</div>
      <div class="flex-grow-1">
        <p class="mb-1">
          <span class="text-danger fw-bold">${data.position}</span> tại
          <span class="fw-bold">${data.companyName}</span>
        </p>
        <p class="mb-1">${data.description}</p>
        <p class="fw-bold mb-1">Kỹ năng</p>
        <p class="d-flex gap-3">` +
      experienceSkillList.join("") +
      `</p>
        <div class="d-flex flex-column flex-wrap gap-3 experience-project-container"></div>
        <div class="d-flex">
          <a role="button" class="btn btn-sm btn-outline-dark rounded-3 btn-add-project"
            data-bs-toggle="modal"
            data-bs-target="#experience-project-modal"
            data-experience-id="${data.id}">
            <i class="fa-solid fa-circle-plus me-2"></i>Thêm dự án
          </a>
        </div>
      </div>
      <div class="ms-auto align-self-center">
        <button class="btn btn-delete-experience" data-bs-toggle="tooltip" data-bs-placement="top" title="Xóa" data-experience-id="${data.id}">
          <i class="fa-regular fa-trash-can"></i>
        </button>
      </div>
    </div>`;
    workExperienceContainer.append(experienceContainerHtml);
  }

  function callAjaxToUpdateSections(url, data, callback) {
    $.ajax({
      type: "POST",
      dataType: "json",
      url: url,
      data: data,
      success: function (res) {
        $.getScript(TOASTR_PLUGIN_URL, function () {
          toastr.success("Cập nhật thông tin thành công!");
        });
        callback(res);
        btnCancel.trigger("click");
      },
      error: function (err) {
        console.error(err);
      },
    });
  }

  function updateSection(target, data) {
    switch (target.toLowerCase()) {
      case "tóm tắt":
        callAjaxToUpdateSections(
          "/Profile/UpdateSummary",
          data,
          renderSummaryContainerContent
        );
        break;
      case "kỹ năng":
        callAjaxToUpdateSections(
          "/Profile/UpdateSkills",
          data,
          renderSkillContainerContent
        );
        break;
      case "kinh nghiệm làm việc":
        callAjaxToUpdateSections(
          "/Profile/AddExperience",
          data,
          renderExperienceContainerContent
        );
        break;
      case "học vấn":
        return "UpdateEducations";
      case "dự án":
        return "UpdateProjects";
      case "ngoại ngữ":
        return "UpdateForeignLanguages";
    }
  }

  //Tải ảnh lên tag img khi input thay đổi
  $("#avatar_image-file").change(function (e) {
    var avatarImg = $("#avatar_image");

    if (e.target.files.length > 0) {
      var file = e.target.files[0];
      var reader = new FileReader();

      reader.onload = function (event) {
        avatarImg.attr("src", event.target.result);
      };

      reader.readAsDataURL(file);
    } else {
      avatarImg.attr("src", "");
    }
  });
});
