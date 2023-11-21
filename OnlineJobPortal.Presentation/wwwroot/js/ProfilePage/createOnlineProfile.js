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
  const positionContainer = $(".position-container");
  const skillContainer = $(".skill-container");
  const workExperienceContainer = $(".work-experience-container");
  const updateResumeForm = $("#update-resume-form")[0];
  const btnSaveProject = $(".btn-save-project");
  const educationContainer = $(".education-container");
  const addExperienceProjectForm = $("#add-experience-project-form")[0];
  const projectContainer = $(".project-container");
  const foreignContainer = $(".language-container");
  const switchJobSearchMode = $("#Resume_JobSearchMode");
  const embebViewCVDemo = $("#view-cv-demo");

  $("#upload-cv").change(function (e) {
    let file = e.target.files[0];
    let formData = new FormData();
    formData.append("cv", file);
    $.ajax({
      type: "patch",
      dataType: "json",
      url: "/Profile/UploadCV",
      data: formData,
      processData: false,
      contentType: false,
      success: function (res) {
        embebViewCVDemo.attr("src","." + res);
        toastr.success("Đã cập nhật CV thành công");
      },
      error: function (err) {
        console.log(err);
      },
    });
  });

  switchJobSearchMode.change(function () {
    let isChecked = $(this).prop("checked");
    data = {
      resumeId: RESUME_ID,
      searching: isChecked,
    };
    if (isChecked) {
      toastr.success("Đã bật chế độ tìm việc cho hồ sơ");
    } else {
      toastr.warning("Đã tắt chế độ tìm việc cho hồ sơ");
    }
    $.ajax({
      type: "patch",
      dataType: "json",
      url: "/Profile/ChangeJobSearchMode",
      data: data,
    });
  });

  var btnSave = $(".btn-save");
  var btnCancel = $(".btn-cancel");

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
      case "vị trí ứng tuyển":
        let position = $("#position-field").val();
        let yearOfExperiences = $("#year-of-experiences-field").val();
        data = {
          id: RESUME_ID,
          position: position,
          yearOfExperiences: yearOfExperiences
        };
        break;
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
        if (!updateResumeForm.checkValidity()) {
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
        if (data.startDate > data.endDate) {
          toastr.warning("Ngày kết thúc phải sau ngày bắt đầu");
          return;
        }
        break;
      case "học vấn":
        if (!updateResumeForm.checkValidity()) {
          toastr.warning("Vui lòng nhập đầy đủ các trường bắt buộc");
          return;
        }
        data = {
          resumeId: RESUME_ID,
          university: $("#education-university-field").val(),
          major: $("#education-major-field").val(),
          startDate: $("#education-start-date-field").val(),
          completionDate: $("#education-completion-date-field").val(),
          gPA: $("#education-gpa-field").val(),
        };
        break;
      case "dự án":
        if (!updateResumeForm.checkValidity()) {
          toastr.warning("Vui lòng nhập đầy đủ các trường bắt buộc");
          return;
        }
        data = {
          resumeId: RESUME_ID,
          title: $("#project-title-field").val(),
          position: $("#project-position-field").val(),
          linkGit: $("#project-link-git-field").val(),
          description: $(".ck-content").text(),
          startDate: $("#project-start-date-field").val(),
          endDate: $("#project-end-date-field").val(),
        };
        if (data.startDate > data.endDate) {
          toastr.warning("Ngày kết thúc phải sau ngày bắt đầu");
          return;
        }
        break;
      case "ngoại ngữ":
        if (!updateResumeForm.checkValidity()) {
          toastr.warning("Vui lòng nhập đầy đủ các trường bắt buộc");
          return;
        }
        data = {
          resumeId: RESUME_ID,
          languageName: $("#foreign-language-name-field").val(),
          degree: $("#foreign-language-degree-field").val(),
        };
        break;
      default:
        break;
    }
    updateSection(targetSection, data);
  });

  btnSaveProject.click(function (event) {
    let experienceId = $(this).data("experience-id");
    let container = $(".experience-project-container");
    container.filter('[data-experience-project-id="${experienceId}}"]');
    event.preventDefault();
    let data = {
      experienceId: experienceId,
      title: $("#experience-project-name-field").val(),
      position: $("#experience-project-position-field").val(),
      startDate: $("#experience-project-start-date-field").val(),
      endDate: $("#experience-project-end-date-field").val(),
    };
    if (!addExperienceProjectForm.checkValidity()) {
      toastr.warning("Vui lòng điền đầy đủ các trường bắt buộc");
      return;
    } else if (data.startDate > data.endDate) {
      toastr.warning("Ngày kết thúc phải sau ngày bắt đầu");
      return;
    }

    $.ajax({
      type: "POST",
      dataType: "json",
      url: "/Profile/AddExperienceProject",
      data: data,
      success: function (res) {
        renderExperienceProject(container, res);
        toastr.success("Thêm dự án thành công");
        btnCancel.trigger("click");
        $("#add-experience-project-form input").val("");
      },
      error: function (err) {
        console.log("error");
        btnCancel.trigger("click");
      },
    });
  });

  function renderExperienceProject(container, data) {
    experienceProjectHtml = `
    <div class="py-1 px-2 mb-1 fw-bold w-100" style="background-color: #f5f5f5;">
      <p class="d-flex justify-content-between align-items-baseline mb-2">
        <span class="">Dự án</span>
        <a role="button" class="btn-sm btn-outline-danger rounded-pill btn-delete-experience-project"
          title="Xóa dự án" data-project-id="${data.id}">
          <i class="fa-solid fa-xmark"></i>
        </a>
      </p>
      <div class="d-flex w-100 justify-content-between">
        <span class="text-dark">${data.title}</span>
        <span>${formatDate(data.startDate)} -
            ${formatDate(data.endDate)}</span>
      </div>
    </div>`;
    container.append(experienceProjectHtml);
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
      case "vị trí ứng tuyển":
        modalBodyHtml = `
        <div class="d-flex flex-column gap-3">
          <div>
              <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Vị trí công việc<span class="text-danger fw-light ms-1">(*)</span></label>
              <input class="form-control" type="text" id="position-field" required autocomplete="off">
          </div>
          <div>
              <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Số năm kinh nghiệm<span class="text-danger fw-light ms-1">(*)</span></label>
              <input class="form-control" type="text" id="year-of-experiences-field" required autocomplete="off">
          </div>
        </div>`;
        break;
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
              <input class="form-control" type="text" id="experience-position-field" required autocomplete="off">
          </div>
          <div>
              <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Tên công ty<span class="text-danger fw-light ms-1">(*)</span></label>
              <input class="form-control" type="text" id="experience-company-name-field" required autocomplete="off">
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
            <input class="form-control" type="text" id="education-university-field" required autocomplete="off">
        </div>
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Chuyên ngành</label>
            <input class="form-control" type="text" id="education-major-field" required autocomplete="off">
        </div>
        <div class="d-flex gap-3">
            <div class="flex-grow-1">
                <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Ngày bắt đầu</label>
                <input class="form-control" type="date" id="education-start-date-field" required>
            </div>
            <div class="flex-grow-1">
                <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Ngày kết thúc</label>
                <input class="form-control" type="date" id="education-completion-date-field" required>
            </div>
        </div>
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Điểm trung bình(GPA)</label>
            <input class="form-control" type="number" step="0.01" min="1" id="education-gpa-field" required>
        </div>
        <span class="text-danger me-auto" style="font-weight: 300; font-size: 0.8rem;">(*) Bắt buộc</span>
    </div>`;
        break;
      case "dự án":
        modalBodyHtml = `<div class="d-flex flex-column gap-3">
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Tên dự án<span class="text-danger fw-light ms-1">(*)</span></label>
            <input class="form-control" type="text" id="project-title-field" required autocomplete="off">
        </div>
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Vị trí đảm nhận<span class="text-danger fw-light ms-1">(*)</span></label>
            <input class="form-control" type="text" id="project-position-field" required autocomplete="off">
        </div>
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Link git</label>
            <input class="form-control" type="text" id="project-link-git-field" autocomplete="off">
        </div>
        <div class="d-flex gap-3">
            <div class="flex-grow-1">
                <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Thời gian bắt đầu<span class="text-danger fw-light ms-1">(*)</span></label>
                <input class="form-control" type="date" id="project-start-date-field" required>
            </div>
            <div class="flex-grow-1">
                <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Thời gian kết thúc<span class="text-danger fw-light ms-1">(*)</span></label>
                <input class="form-control" type="date" id="project-end-date-field" required>
            </div>
        </div>
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Mô tả</label>
            <textarea class="form-control text-editor" id="project-description-field"></textarea>
        </div>
        <span class="text-danger me-auto" style="font-weight: 300; font-size: 0.8rem;">(*) Bắt buộc</span>
    </div>`;
        break;
      case "ngoại ngữ":
        modalBodyHtml = `<div class="d-flex flex-column gap-3">
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Ngôn ngữ<span class="text-danger fw-light ms-1">(*)</span></label>
            <input class="form-control" type="text" id="foreign-language-name-field" required autocomplete="off">
        </div>
        <div>
            <label class="text-dark" style="font-size: 0.9rem; font-weight: 600;">Trình độ<span class="text-danger fw-light ms-1">(*)</span></label>
            <input class="form-control" type="text" id="foreign-language-degree-field" required autocomplete="off">
        </div>
        <span class="text-danger me-auto" style="font-weight: 300; font-size: 0.8rem;">(*) Bắt buộc</span>
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

  function renderPositionContainerContent(data) {
    positionContainer.find("p").text(data.position + " - " + data.yearOfExperiences);
    $('#section-info-position').text(data.position);
    $('#section-info-year-of-experiences').text(data.yearOfExperiences);
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

  function formatDate(date) {
    date = new Date(date).toISOString().slice(0, 7);
    date = date.split("-");
    date = date.reverse();
    return date.join("/");
  }

  function renderExperienceContainerContent(data) {
    var experienceSkillList = [];
    if (data.experienceSkills != null && data.experienceSkills.length > 0) {
      experienceSkillList = data.experienceSkills.map((es) => {
        return `<span class="py-1 px-2 bg-white border">${es.skill.skillName}</span>`;
      });
    }
    var experienceContainerHtml =
      `
      <div class="d-flex flex-lg-row flex-column gap-3 my-3 px-2 pt-2 pb-4 border-bottom" style="font-size: 0.9rem;">
        <div class="text-nowrap">${formatDate(data.startDate)} - ${formatDate(
        data.endDate
      )}</div>
        <div class="flex-grow-1">
          <p class="mb-1">
            <span class="text-danger fw-bold">${data.position}</span> tại
            <span class="fw-bold">${data.companyName}</span>
          </p>
          <p class="mb-1">${data.description}</p>
          <p class="fw-bold mb-1">Kỹ năng</p>
          <p class="d-flex flex-wrap gap-3">` +
      experienceSkillList.join("") +
      `</p>` +
      `<div class="d-flex flex-wrap gap-3 my-3 experience-project-container" data-experience-project-id="${data.id}"></div>
          <div class="d-flex">
            <a role="button"
                class="btn btn-sm btn-outline-dark rounded-3 btn-add-project"
                data-bs-toggle="modal" data-bs-target="#experience-project-modal" data-experience-id="${data.id}">
                <i class="fa-solid fa-circle-plus me-2"></i>Thêm dự án
            </a>
          </div>
        </div>
        <div class="ms-auto align-self-center">
          <button class="btn btn-delete-experience" data-bs-toggle="tooltip" data-bs-placement="top"
                  title="Xóa" data-experience-id="${data.id}">
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
      case "vị trí ứng tuyển":
        callAjaxToUpdateSections(
          "/Profile/UpdatePosition",
          data,
          renderPositionContainerContent
        );
        break;
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
        callAjaxToUpdateSections(
          "/Profile/AddEducation",
          data,
          renderEducationContainerContent
        );
        break;
      case "dự án":
        callAjaxToUpdateSections(
          "/Profile/AddProject",
          data,
          renderProjectContainerContent
        );
        break;
      case "ngoại ngữ":
        callAjaxToUpdateSections(
          "/Profile/AddForeignLanguage",
          data,
          renderForeignLanguageContainerContent
        );
        break;
    }
  }

  function renderForeignLanguageContainerContent(data) {
    let foreignLanguageHtml = `
    <div class="d-flex gap-3 my-3 p-2" style="background-color: #f5f5f5;">
      <span class="py-1 px-2 fw-bold"
            style="font-size: 0.9rem;">${data.languageName}</span>
      <span class="py-1 px-2" style="font-size: 0.9rem;">${data.degree}</span>
      <div class="ms-auto align-self-center">
          <button class="btn btn-delete-foreign-language" data-bs-toggle="tooltip" data-bs-placement="top" data-foreign-language-id="${data.id}"
                  title="Xóa">
              <i class="fa-regular fa-trash-can"></i>
          </button>
      </div>
    </div>`;
    foreignContainer.append(foreignLanguageHtml);
  }

  function renderProjectContainerContent(data) {
    let projectHtml = `
    <div class="d-flex gap-3 my-3 p-2" style="font-size: 0.9rem;">
        <div class="text-nowrap">
            ${formatDate(data.startDate)} - ${formatDate(data.endDate)}
        </div>
        <div class="flex-grow-1">
            <p class="mb-1 fw-bold">${data.title}</p>
            <p class="mb-1 fw-bold text-danger">${data.position}</p>
            <p class="mb-1">${data.description}</p>
            <p class="mb-1 fw-light fst-italic">${data.linkGit}</p>
        </div>
        <div class="ms-auto align-self-center">
            <button class="btn btn-delete-project" data-bs-toggle="tooltip" data-bs-placement="top"
                    title="Xóa" data-project-id="${data.id}">
                <i class="fa-regular fa-trash-can"></i>
            </button>
        </div>
    </div>`;
    projectContainer.append(projectHtml);
  }

  function renderEducationContainerContent(data) {
    let educationHtml = `
    <div class="d-flex gap-3 my-3 p-2" style="font-size: 0.9rem;">
      <div class="text-nowrap">
        ${formatDate(data.startDate)} - ${formatDate(data.completionDate)}
      </div>
      <div class="flex-grow-1">
        <p class="mb-1 fw-bold">${data.university}</p>
        <p class="mb-1">${data.major}</p>
        <p class="mb-1" style="font-size: .8rem; font-style: italic;">
          GPA ${data.gpa}
        </p>
      </div>
      <div class="ms-auto align-self-center">
        <button
          class="btn btn-delete-education"
          data-bs-toggle="tooltip"
          data-bs-placement="top"
          title="Xóa"
          data-education-id="${data.id}"
        >
          <i class="fa-regular fa-trash-can"></i>
        </button>
      </div>
    </div>`;
    educationContainer.append(educationHtml);
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

function callAjaxToDeleteResources(id, url) {
  $.ajax({
    type: "Delete",
    url: url,
    data: { id: id },
    success: function (res) {
      if (res.success) toastr.success("Xóa thành công");
      else toastr.error("Xóa thất bại");
    },
    error: function (err) {
      console.log("Không thể kết nối tới server");
    },
  });
}

function hideTooltip() {
  $(".tooltip").remove();
}

$(document).on("click", ".btn-delete-experience", function (e) {
  e.preventDefault();
  var btnDeleteExperience = $(this);
  var container = btnDeleteExperience.closest(".d-flex");
  let id = btnDeleteExperience.data("experience-id");
  container.remove();
  hideTooltip();
  callAjaxToDeleteResources(id, "/Profile/DeleteExperience");
});

$(document).on("click", ".btn-add-project", function (e) {
  var experienceId = $(this).data("experience-id");
  var btnSaveProject = $(".btn-save-project");
  btnSaveProject.data("experience-id", experienceId);
});

$(document).on("click", ".btn-delete-experience-project", function () {
  let btnDeleteExperienceProject = $(this);
  var projectId = $(this).data("project-id");
  let container = btnDeleteExperienceProject.closest("div");
  let id = btnDeleteExperienceProject.data("experience-id");
  hideTooltip();
  container.remove();
  callAjaxToDeleteResources(projectId, "/Profile/DeleteExperienceProject");
});

$(document).on("click", ".btn-delete-project", function (e) {
  e.preventDefault();
  let btnDeleteProject = $(this);
  let container = btnDeleteProject.closest(".d-flex");
  let projectId = btnDeleteProject.data("project-id");
  hideTooltip();
  container.remove();
  callAjaxToDeleteResources(projectId, "/Profile/DeleteProject");
});

$(document).on("click", ".btn-delete-education", function (e) {
  e.preventDefault();
  let btnDeleteEducation = $(this);
  let container = btnDeleteEducation.closest(".d-flex");
  let educationId = btnDeleteEducation.data("education-id");
  hideTooltip();
  container.remove();
  callAjaxToDeleteResources(educationId, "/Profile/DeleteEducation");
});

$(document).on("click", ".btn-delete-foreign-language", function (e) {
  e.preventDefault();
  let btnDeleteForeignLanguage = $(this);
  let container = btnDeleteForeignLanguage.closest(".d-flex");
  let foreignLanguageId = btnDeleteForeignLanguage.data("foreign-language-id");
  hideTooltip();
  container.remove();
  callAjaxToDeleteResources(
    foreignLanguageId,
    "/Profile/DeleteForeignLanguage"
  );
});
