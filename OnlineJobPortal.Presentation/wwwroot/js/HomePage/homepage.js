$(document).ready(function () {
    $("#exp-selector, #local-selector, #salary-selector").chosen({
        enable_search: true,
        no_results_text: "Your Custom Title"
    });

    $.ajax({
        method: 'GET',
        url: '/JobPost/GetJobWithPagination',
        data: { currentItems: 0 },
        dataType: 'JSON',
        success: function (response) {
            if (response.items.length != 0) {
                var loop = response.items;
                for (let i = 0; i < loop.length; i++) {
                    CreateJobPost(loop[i]);
                }
            }
        },
        error: function () {
            console.log('Không thể kết nối đến máy chủ.');
        }
    });

});

function CreateJobPost(item) {
    var htmlRaw = `
        <div class="job-item p-4 mb-4">
            <div class="row g-4">
                <div class="col-sm-12 col-md-8 d-flex align-items-center">
                    <img class="flex-shrink-0 img-fluid border rounded-3" src="${item.logoUrl}" alt=""
                        style="width: 90px; height: 90px;">
                    <div class="text-start ps-4">
                        <a href="/JobPost/JobDetail/${item.id}" target="_blank"><h5 class="mb-2">${item.title}</h5></a>
                        <div class="p-0 mb-2 ">
                            <a href="/Company/CompanyDetail/${item.companyId}"
                                target="_blank" class="text-uppercase text-muted">${item.companyName}</a>
                        </div>
                        <div
                            class="d-flex flex-wrap gap-3 mb-2 text-capitalize text-primary skills-wrapper">
                            ${item.skills.map(skill => `<span>${skill}</span>`).join('')}
                        </div>
                        <span class="text-truncate me-3">
                            <i class="fa fa-map-marker-alt text-primary me-2"></i>${item.province}
                        </span>
                        <span class="text-truncate me-3">
                            <i class="far fa-clock text-primary me-2"></i>Full Time
                        </span>
                        <span class="text-truncate me-0">
                            <i class="far fa-money-bill-alt text-primary me-2"></i>${item.salary}
                        </span>
                    </div>
                </div>
                <div
                    class="col-sm-12 col-md-4 d-flex flex-column align-items-start align-items-md-end justify-content-center">
                    <div class="d-flex mb-3">
                        <a class="btn btn-light btn-square me-3" href="">
                            <i class="far fa-heart text-primary"></i>
                        </a>
                        <a class="btn btn-primary" href="">Ứng tuyển</a>
                    </div>
                    <span class="text-truncate">
                        <i class="far fa-calendar-alt text-primary me-2"></i>Hạn cuối: ${item.expiredDate}
                    </span>
                </div>
            </div>
        </div>
    `;

    var jobList = $('.tab-content #tab-1 .job-list')
    jobList.append(htmlRaw);
}
