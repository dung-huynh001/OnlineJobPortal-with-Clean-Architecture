$(document).ready(function () {
    // Khởi tạo location selection
    var localpicker = new LocalPicker({
        province: "ls_province",
        district: "ls_district",
        ward: "ls_ward",
    });

    spinner.show();
    $.ajax({
        type: "GET",
        dataType: "JSON",
        url: "/JobPost/GetJobWithPagination",
        cache: false,
        data: { currentItems: 0, sortBy: "new" },
        success: function (response) {
            if (response.items.length != 0) {
                jobList.empty();
                var loop = response.items;
                for (let i = 0; i < loop.length; i++) {
                    CreateJobPost(loop[i]);
                }
                if (loop.length == response.totalCount) {
                    $("#btn-seeMore").hide();
                }
            }
            spinner.hide();
        },
        error: function () {
            console.log("Không thể kết nối đến máy chủ.");
            spinner.hide();
        },
    });

    $.ajax({
        type: "GET",
        dataType: "json",
        url: "/JobType/GetJobTypeWithPagination",
        cache: false,
        data: { currentItems: 0 },
        success: function (response) {
            if (response.items.length != 0) {
                jobTypeList.empty();
                for (let i = 0; i < response.items.length; i++) {
                    CreateJobType(response.items[i]);
                }
            }
            if (response.items.length == response.totalCount) {
                $(".btn-see-more").hidden();
            }
            spinner.hide();
        },
        error: function (error) {
            renderEmptyImg(jobTypeList);
            spinner.hide();
        },
    });
});

function CreateJobPost(item) {
    var htmlRaw = `
          <div class="job-item p-4 mb-4">
              <div class="row g-4">
                  <div class="col-sm-12 col-md-8 d-flex align-items-center">
                      <img class="flex-shrink-0 img-fluid border rounded-3" src="${"." + item.logoUrl
        }" alt=""
                          style="width: 90px; height: 90px;">
                      <div class="text-start ps-4">
                          <a href="/JobPost/JobDetail/${item.id
        }" target="_blank"><h5 class="mb-2">${item.title
        }</h5></a>
                          <div class="p-0 mb-2 ">
                              <a href="/Company/CompanyDetail/${item.companyId}"
                                  target="_blank" class="text-uppercase text-muted">${item.companyName
        }</a>
                          </div>
                          <div
                              class="d-flex flex-wrap gap-3 mb-2 text-capitalize text-primary skills-wrapper">
                              ${item.skills
            .map((skill) => `<span>${skill}</span>`)
            .join("")}
                          </div>
                          <span class="text-truncate me-3">
                              <i class="fa fa-map-marker-alt text-primary me-2"></i>${item.province
        }
                          </span>
                          <span class="text-truncate me-3">
                              <i class="far fa-clock text-primary me-2"></i>${item.employmentType
        }
                          </span>
                          <span class="text-truncate me-0">
                              <i class="far fa-money-bill-alt text-primary me-2"></i>${item.salary
        }
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
                          <i class="far fa-calendar-alt text-primary me-2"></i>Hạn cuối: ${item.expiredDate
        }
                      </span>
                  </div>
              </div>
          </div>
      `;
    jobList.append(htmlRaw);
}

function CreateJobType(item) {
    var renderJobTypeHtml = `
          <div class="col-lg-3 col-sm-6 wow fadeInUp job-type-item" data-wow-delay="0.1s">
              <a class="cat-item rounded p-4" href="">
                  <i class="fa fa-3x ${item.jobTypeIcon} text-primary mb-4"></i>
                  <h6 class="mb-3">${item.jobTypeName}</h6>
                  <p class="mb-0">${item.totalJobPost} Vị trí</p>
              </a>
          </div>
      `;

    jobTypeList.append(renderJobTypeHtml);
}

$(".btn-see-more").click(function (e) {
    spinner.show();

    var jobTypeItems = $(".job-type-item").length;
    $.ajax({
        type: "GET",
        dataType: "json",
        url: "/JobType/GetJobTypeWithPagination",
        cache: false,
        data: { currentItems: jobTypeItems },
        success: function (response) {
            if (response.items.length != 0) {
                for (let i = 0; i < response.items.length; i++) {
                    CreateJobType(response.items[i]);
                }
                if (response.items.length + jobTypeItems == response.totalCount) {
                    $(".btn-see-more").hide();
                }
            }
            spinner.hide();
        },
        error: function (error) {
            renderEmptyImg(jobTypeList);
            spinner.hide();
        },
    });
});

function renderEmptyImg(box) {
    var noResultFound = `
          <div class="d-flex justify-content-center align-items-center">
              <img src="../img/no-result-found.jpg" alt="" style="width: 350px; "/>
          </div>    
          `;
    box.append(noResultFound);
}

const jobList = $(".tab-content #tab-1 .job-list");
const spinner = $(".spinner");
const jobTypeList = $(".job-type-list");

//Lọc theo điều kiện
var keyword;
var level;
var provinceName;
var salary;

$("#search-job").on("change", function () {
    keyword = $("#search-job").val();
});

$("#exp-selector").on("change", function () {
    level = $("#exp-selector option:selected").text();
});

$(".ls_province").on("change", function () {
    provinceId = $(".ls_province option:selected").text();
});

$("#salary-selector").on("change", function () {
    salary = $("#salary-selector option:selected").text();
});

function filterJobPosts(currentItems, sortBy) {
    var filter = {
        currentItems: currentItems,
        sortBy: sortBy,
        keyword: keyword,
        level: level,
        provinceName: provinceName,
        salary: salary
    };
    spinner.show();
    $.ajax({
        type: "GET",
        url: "/JobPost/GetJobWithPagination",
        dataType: "JSON",
        cache: false,
        data: filter,
        success: function (response) {
            if (response.items.length != 0) {
                var loop = response.items;
                for (let i = 0; i < loop.length; i++) {
                    CreateJobPost(loop[i]);
                }
                if (response.totalCount == currentItems) {
                    $("#btn-seeMore").hide();
                }
            } else {
                renderEmptyImg(jobList);
            }
            spinner.hide();
        },
        error: function (error) {
            console.log("Không thể kết nối đến máy chủ.");
            spinner.hide();
        },
    });
}





$(document).on("click", ".filter-btn", function () {
    jobList.empty();
    var sortBy = $(this).data("sort");
    filterJobPosts(0, sortBy);
});

const btnFilter = $(".filter-btn");

$("#btn-seeMore").click(function () {
    btnFilter.each(function (index, btn) {
        if ($(btn).hasClass("active")) {
            var sortBy = $(btn).data("sort");
            var jobItems = $(".job-item").length;
            filterJobPosts(jobItems, sortBy);
        }
    });
});

$("#btn-find").on("click", function () {
    jobList.empty();
    btnFilter.each(function (index, btn) {
        if ($(btn).hasClass("active")) {
            var sortBy = $(btn).data("sort");
            var jobItems = $(".job-item").length;
            filterJobPosts(jobItems, sortBy);
        }
    });
    filterJobPosts(0, sortBy);
});
