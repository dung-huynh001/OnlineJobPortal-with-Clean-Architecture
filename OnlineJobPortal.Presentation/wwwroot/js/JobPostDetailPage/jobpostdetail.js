$(document).ready(function () {
    const btnChangeSection = $(".btn-change-section");
    const btnShowCollapse = $(".btn-show-collapse");
    const workExperienceContainer = $(".work-experience-container");
    const experienceProjectContainer = $(".experience-container");
    const candidateSkillContainer = $(".candidate-skill-container");
    const projectContainer = $(".project-container");
    const educationContainer = $(".education-container");
    const certificateContainer = $(".certificate-container");
    const coverLetter = $(".cover-letter");


    btnChangeSection.click(function (e) {
        e.preventDefault();
        $(".btn-change-section").each(function () {
            $(this).removeClass("active");
        })
        $(this).addClass("active");
    });


    btnShowCollapse.click(function (e) {
        e.preventDefault();
        $(".btn-show-collapse").each(function () {
            $(this).removeClass("active");
        })
        $(".collapse").removeClass("show");
        $(this).addClass("active");
    });



    $(document).on("click", ".btn-view-profile", function () {
        let btnViewProfile = $(this);
        let candidateId = btnViewProfile.data("candidate-id");
        let applyId = btnViewProfile.data("apply-id");
        $("#modal-candidate-name").text("");
        $("#modal-candidate-position").text("");
        $("#modal-candidate-create-at").text("");
        $("#modal-cv-url").attr("href", "");
        $("#modal-avatar-url").attr("src", "../../img/default_user.png");
        callAjaxToMarkViewedProfile(applyId);
        if ($('.status').find('span').text().toLowerCase() == "pending") {
            let statusHtml = `<span class="px-2 py-1 bg-info text-white rounded-2" >VIEWED</span>`
            $(".status").html(statusHtml);
        }
        callAjaxToLoadProfile(applyId);
    });

    $(document).on("click", ".btn-approval", function () {
        let btnApproval = $(this);
        let profileItem = btnApproval.closest(".profile-item");
        let applyId = btnApproval.data("apply-id");
        let jobPostId = btnApproval.data("job-post-id");
        $("#btn-send-notification").data("apply-id", applyId);
        $("#btn-send-notification").data("job-post-id", jobPostId);
        let statusHtml = `<span class="px-2 py-1 bg-success text-white rounded-2" >PASSED</span>`
        profileItem.find(".status").html(statusHtml);
    });

    $(document).on("click", "#btn-send-notification", function () {
        let btnSendNotification = $(this);
        let applyId = btnSendNotification.data("apply-id");
        
        if(!$("#appointment-form")[0].checkValidity()) {
            toastr.warning("Vui lòng nhập thông tin lịch hẹn trước khi duyệt");
            return;
        }
        callAjaxToApprovalProfile(applyId);
    });

    $(document).on("click", "#btn-close-appointment-modal", function() {
        $("input").val("");
        $("textarea").val("");
    });
    
    $(document).on("click", ".btn-reject-profile", function () {
        let btnViewProfile = $(this);
        let profileItem = btnViewProfile.closest(".profile-item");
        let applyId = btnViewProfile.data("apply-id");
        callAjaxToRejectProfile(applyId);
        let statusHtml = `<span class="px-2 py-1 bg-secondary text-white rounded-2" >REJECTED</span>`
        profileItem.find(".status").html(statusHtml);
    });



    function callAjaxToApprovalProfile(applyId) {
        $.ajax({
            type: "patch",
            dataType: "json",
            data: { applyId: applyId },
            url: "/Employer/JobPost/ApprovalCandidate",
            success: function (res) {
                if (res) {
                    toastr.success("Duyệt hồ sơ thành công");
                }
            },
            error: function (err) {
                console.log(err);
            }
        });
    }

    function callAjaxToMarkViewedProfile(applyId) {
        $.ajax({
            type: "patch",
            dataType: "json",
            data: { applyId: applyId },
            url: "/Employer/JobPost/MarkViewedProfile",
            success: function (res) {
                if (!res) { console.log(res) }
            },
            error: function (err) {
                console.log(err);
            }
        });
    }

    function callAjaxToRejectProfile(applyId) {
        $.ajax({
            type: "patch",
            dataType: "json",
            data: { applyId: applyId },
            url: "/Employer/JobPost/RejectCandidate",
            success: function (res) {
                if (res) {
                    toastr.warning("Đã từ chối hồ sơ");
                }
            },
            error: function (err) {
                console.log(err);
            }
        });
    }

    function callAjaxToLoadProfile(applyId) {
        $.ajax({
            type: "get",
            dataType: "json",
            data: { applyId: applyId },
            url: "/Employer/JobPost/LoadProfile",
            caches: false,
            success: function (res) {
                let avatarUrl = "../." + res.avatarUrl;
                let cvUrl = "../." + res.cvUrl;
                $("#modal-candidate-name").text(res.fullName);
                $("#modal-candidate-position").text(res.position);
                $("#modal-candidate-create-at").text(formatDate(res.createAt));
                $("#modal-cv-url").attr("href", cvUrl);
                $("#modal-avatar-url").attr("src", avatarUrl);
                coverLetter.text(res.coverLetter);
                candidateSkillContainer.html(renderSkills(res.skills));
                workExperienceContainer.html(renderExperiences(res.experiences));
                certificateContainer.html(renderCertificates(res.foreignLanguages));
                educationContainer.html(renderEducations(res.educations));
                projectContainer.html(renderProjects(res.projects));
                console.log(res);
            },
            error: function (err) {
                console.log(err);
            }
        });
    }

    function renderSkills(data) {
        let skillsHtml = ``;
        for (var i = 0; i < data.length; i++) {
            skillsHtml += `<span class="py-1 px-2 bg-white border" style="font-size: 0.9rem;">${data[i]}</span>`;
        }
        return skillsHtml;     
    }

    function renderExperiences(data) {
        console.log(data);
        let experienceHtml = ``;
        for (let i = 0; i < data.length; i++) {
            experienceHtml += `
            <div class="d-flex flex-lg-row flex-column gap-3 px-2 border-bottom"
                style="font-size: 0.9rem;">
                <div class="text-nowrap align-self-start">10/2023 - 11/2023</div>
                <div class="flex-grow-1">
                    <p class="mb-1">
                        <span class="text-danger fw-bold">${data[i].position}</span> tại <span
                            class="fw-bold">${data[i].companyName}</span>
                    </p>
                    <p class="mb-1">${data[i].description}</p>
                    <p class="fw-bold mb-1">Kỹ năng</p>
                    <p class="d-flex flex-wrap gap-3 candidate-skill-container">
                        ${renderSkills(data[i].skills)}
                    </p>
                    <div class="d-flex flex-wrap gap-3 my-3 experience-project-container"
                        data-experience-project-id="">
                        <div class="py-1 px-2 mb-1 fw-bold w-100" style="background-color: #f5f5f5;">
                            <p class="d-flex justify-content-between align-items-baseline mb-2">
                                <span class="">Dự án</span>
                            </p>
                            ${renderExperienceProject(data[i].projects)}
                        </div>
                    </div>
                </div>
            </div>`;
        }
        return experienceHtml;
    }

    function renderExperienceProject(data) {
        let experienceProjectHtml = ``;
        for(let i = 0; i < data.length; i++) {
            experienceProjectHtml += `
            <div class="d-flex w-100 justify-content-between">
                <p class="text-dark">${data[i].title}</p>
                <span>${formatDate(data[i].startDate)} - ${formatDate(data[i].endDate)}</span>
            </div>`;
        }
        return experienceProjectHtml;
    }

    function renderProjects(data) {
        let projectHtml = ``;
        for (let i = 0; i < data.length; i++) {
            projectHtml += `
            <div class="d-flex gap-3 p-2" style="font-size: 0.9rem;">
                <div class="text-nowrap">${formatDate(data[i].startDate)} - ${formatDate(data[i].endDate)}</div>
                <div class="flex-grow-1">
                    <p class="mb-1 fw-bold">${data[i].title}</p>
                    <p class="mb-1 fw-bold text-danger">${data[i].position}</p>
                    <p class="mb-1">"${data[i].description}"</p>
                    <p class="mb-1 fw-light fst-italic">${data[i].linkGit}</p>
                </div>
            </div>`;
        }
        return projectHtml;
    }

    function renderEducations(data) {
        let educationHtml = ``;
        for (let i = 0; i < data.length; i++) {
            educationHtml += `
            <div class="d-flex gap-3 p-2" style="font-size: 0.9rem;">
                <div class="text-nowrap">${formatDate(data[i].startDate)} - ${formatDate(data[i].completionDate)}</div>
                <div class="flex-grow-1">
                    <p class="mb-1 fw-bold">${data[i].university}</p>
                    <p class="mb-1">${data[i].major}</p>
                    <p class="mb-1" style="font-size: .8rem; font-style: italic;">GPA ${data[i].gpa}</p>
                </div>
            </div>`
        }
        return educationHtml;
    }

    function renderCertificates(data) {
        let certificatesHtml = ``;
        for (let i = 0; i < data.length; i++) {
            certificatesHtml += `
            <div class="d-flex gap-3 py-2" style="background-color: #f5f5f5;">
                <span class="py-1 px-2 fw-bold" style="font-size: 0.9rem;">${data[i].languageName}</span>
                <span class="py-1 px-2" style="font-size: 0.9rem;">${data[i].degree}</span>
            </div>`
        }
        return certificatesHtml;
    }

    function formatDate(date) {
        let result = date.slice(0, 10).split("-").reverse();
        return result.join("/");
    }

});