$(document).ready(function () {
  const jobPostList = $(".job-post-list");
  const jobTypeList = $(".job-type-list");
  const pagingPartialContainer = $(".paging-partial-container");
  const btnMore = $(".btn-see-more");
  const btnFind = $("#btn-find");
  const totalJob = $(".total-job");

  var sortBy = "";

  fetchData(0, sortBy);
  fetchJobTypes(0);

  $(".filter-btn").click(function () {
    jobPostList.empty();
    sortBy = $(this).data("sort");
    fetchData(0, sortBy);
  });

  btnMore.click(function () {
    var currentJobTypes = $(".job-type-item").length;
    fetchJobTypes(currentJobTypes);
  });

  // Khởi tạo filter
  var keyword = "";
  var level = "";
  var provinceName = "";
  var salary = "";

  $("#search-job").on("change", function () {
    keyword = $(this).val();
  });

  $("#exp-selector").on("change", function () {
    level = $(this).find("option:selected").text();
  });

  $(".ls_province").on("change", function () {
    provinceName = $(this).find("option:selected").text();
  });

  $("#salary-selector").on("change", function () {
    salary = $(this).val();
  });

  btnFind.click(function () {
    fetchData(0, sortBy);
  });

  $("input, select").on("change", function () {
    btnFind.trigger("click");
  });

  function fetchJobTypes(currentJobTypes) {
    renderSpinner(jobTypeList);
    $.ajax({
      type: "GET",
      dataType: "json",
      url: "/JobType/GetJobTypeWithPagination",
      cache: false,
      data: { currentItems: currentJobTypes },
      success: function (res) {
        if (res.items != null && res.items.length > 0) {
          for (let i = 0; i < res.items.length; i++) {
            renderJobType(res.items[i], jobTypeList);
          }
          if (currentJobTypes + res.items.length >= res.totalCount) {
            btnMore.hide();
          } else {
            btnMore.show();
          }
        } else {
          if (currentJobTypes) {
            renderEmptyPage(jobTypeList);
            btnMore.hide();
          }
        }
        removeSpinner(jobTypeList);
      },
      error: function (err) {
        console.log("Không thể kết nối tới Server " + err.message);
        removeSpinner(jobTypeList);
        if (currentJobTypes == 0) {
          renderEmptyPage(jobTypeList);
          btnMore.hide();
        }
      },
    });
  }

  function fetchData(pageNumber, sortBy) {
    jobPostList.empty();
    renderSpinner(jobPostList);
    var filter = {
      pageNumber: pageNumber,
      sortBy: sortBy,
      keyword: keyword,
      level: level,
      provinceName: provinceName,
      salary: salary,
    };
    $.ajax({
      type: "get",
      dataType: "json",
      url: "/JobPost/GetJobWithPagination",
      cache: false,
      data: filter,
      success: function (res) {
        totalJob.text(res.totalCount);
        if (res.items != null && res.items.length > 0) {
          for (let i = 0; i < res.items.length; i++) {
            renderJobPost(res.items[i], jobPostList);
          }
          renderPagingPartial(
            res.pageNumber,
            res.totalPages,
            pagingPartialContainer
          );
        } else {
          renderEmptyPage(jobPostList);
        }
        removeSpinner(jobPostList);
      },
      error: function (err) {
        console.log("Không thể kết nối tới Server" + err.Message);
        removeSpinner(jobPostList);
        renderEmptyPage(jobPostList);
      },
    });
  }

  function renderJobPost(jobPost, container) {
    var jobPostHtml = `
            <div class="job-item p-4 mb-4">
                <div class="row g-4">
                    <div class="col-sm-12 col-md-8 d-flex align-items-center">
                        <img class="flex-shrink-0 img-fluid border rounded-3" src="${
                          "." + jobPost.logoUrl
                        }" alt=""
                            style="width: 90px; height: 90px;">
                        <div class="text-start ps-4">
                            <a href="/JobPost/JobDetail/${
                              jobPost.id
                            }" target="_blank"><h5 class="mb-2">${
      jobPost.title
    }</h5></a>
                            <div class="p-0 mb-2 ">
                                <a href="/Company/CompanyDetail/${
                                  jobPost.companyId
                                }"
                                    target="_blank" class="text-uppercase text-muted">${
                                      jobPost.companyName
                                    }</a>
                            </div>
                            <div
                                class="d-flex flex-wrap gap-3 mb-2 text-capitalize text-primary skills-wrapper">
                                ${jobPost.skills
                                  .map((skill) => `<span>${skill}</span>`)
                                  .join("")}
                            </div>
                            <span class="text-truncate me-3">
                                <i class="fa fa-map-marker-alt text-primary me-2"></i>${
                                  jobPost.province
                                }
                            </span>
                            <span class="text-truncate me-3">
                                <i class="far fa-clock text-primary me-2"></i>${
                                  jobPost.employmentType
                                }
                            </span>
                            <span class="text-truncate me-0">
                                <i class="far fa-money-bill-alt text-primary me-2"></i>${
                                  jobPost.salary
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
                            <i class="far fa-calendar-alt text-primary me-2"></i>Hạn cuối: ${
                              jobPost.expiredDate
                            }
                        </span>
                    </div>
                </div>
            </div>`;
    container.append(jobPostHtml);
  }

  function renderJobType(jobType, container) {
    var jobTypeHtml = `
          <div class="col-lg-3 col-sm-6 wow fadeInUp job-type-item" data-wow-delay="0.1s">
              <a class="cat-item rounded p-4" href="/JobPost/JobByCategory?categoryId=${jobType.id}" target="_blank">
                  <i class="fa fa-3x ${jobType.jobTypeIcon} text-primary mb-4"></i>
                  <h6 class="mb-3">${jobType.jobTypeName}</h6>
                  <p class="mb-0">${jobType.totalJobPost} Vị trí</p>
              </a>
          </div>`;
    container.append(jobTypeHtml);
  }

  function renderSpinner(container) {
    var spinnerHtml = `
            <div class="d-flex justify-content-center">
                <div class="spinner-border text-primary spinner" role="status">
                    <span class="visually-hidden">Loading...</span>
                </div>
            </div>`;
    container.append(spinnerHtml);
  }

  function removeSpinner(container) {
    container.find(".spinner").remove();
  }

  function renderEmptyPage(container) {
    var emptyPageHtml = `
            <div class="d-flex justify-content-center align-items-center">
                <img src="../img/no-result-found.jpg" alt="" style="width: 350px; " />
            </div>`;
    container.append(emptyPageHtml);
  }

  function renderPagingPartial(currentPage, countPages, container) {
    if (currentPage > countPages) {
      currentPage = countPages;
    }

    if (countPages <= 1) {
      return container.html("");
    }

    var preview = null;
    var next = null;

    if (currentPage > 1) {
      preview = currentPage - 1;
    }

    if (currentPage < countPages) {
      next = currentPage + 1;
    }

    var delta = 5;
    var remain = delta * 2;

    var pagesRanges = [];
    pagesRanges.push(currentPage);

    for (var i = 1; i <= delta; i++) {
      if (currentPage + i <= countPages) {
        pagesRanges.push(currentPage + i);
        remain--;
      }

      if (currentPage - i >= 1) {
        pagesRanges.unshift(currentPage - i);
        remain--;
      }
    }

    if (remain > 0) {
      if (pagesRanges[0] === 1) {
        for (var i = 1; i <= remain; i++) {
          if (pagesRanges[pagesRanges.length - 1] + 1 <= countPages) {
            pagesRanges.push(pagesRanges[pagesRanges.length - 1] + 1);
          }
        }
      } else {
        for (var i = 1; i <= remain; i++) {
          if (pagesRanges[0] - 1 > 1) {
            pagesRanges.unshift(pagesRanges[0] - 1);
          }
        }
      }
    }

    var pagingHtml = '<ul class="pagination">';

    if (preview !== null) {
      pagingHtml += `<li class="page-item"><a class="page-link" data-page="${preview}" role="button"><i class="d-inline-block d-lg-none fa-solid fa-angle-left"></i><span class="d-none d-lg-block">Trang trước</span></a></li>`;
    } else {
      pagingHtml +=
        '<li class="page-item disabled"><a class="page-link" href="#" role="button" tabindex="-1" aria-disabled="true"><i class="d-inline-block d-lg-none fa-solid fa-angle-left"></i><span class="d-none d-lg-block">Trang trước</span></a></li>';
    }

    pagesRanges.forEach(function (pageitem) {
      if (pageitem !== currentPage) {
        pagingHtml += `<li class="page-item"><a class="page-link" data-page="${pageitem}" role="button">${pageitem}</a></li>`;
      } else {
        pagingHtml +=
          `<li class="page-item active" aria-current="page"><a class="page-link" data-page="${pageitem}" role="button">` +
          pageitem +
          '<span class="sr-only">(current)</span></a></li>';
      }
    });

    if (next !== null) {
      pagingHtml += `<li class="page-item"><a class="page-link" data-page="${next}" role="button"><span class="d-none d-lg-block">Trang sau</span><i class="d-inline-block d-lg-none fa-solid fa-angle-right"></i></a></li>`;
    } else {
      pagingHtml +=
        '<li class="page-item disabled"><a class="page-link" href="#" role="button" tabindex="-1" aria-disabled="true"><span class="d-none d-lg-block">Trang sau</span><i class="d-inline-block d-lg-none fa-solid fa-angle-right"></i></a></li>';
    }

    pagingHtml += "</ul>";
    container.html(pagingHtml);

    // Bắt sự kiện click trên các phần tử <a> trong thanh phân trang
    container.find("a.page-link").click(function (event) {
      var page = $(this).data("page");
      fetchData(page, sortBy);
    });
  }

  //Khởi tạo dữ liệu tĩnh
  new LocalPicker({
    province: "ls_province",
    district: "ls_district",
    ward: "ls_ward",
  });

  var option = $("<option>").val("").text("Tất cả thành phố");
  $(".ls_province").prepend(option);
});
