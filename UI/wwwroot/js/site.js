// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function SendPostRequest(url, data, config) {
    return new Promise((resolve, reject) => {
        if (config == null || config == undefined) {
            config = {
                headers: {
                    'Content-Type': 'application/json; chartset-UTF-8'
                }
            };
        }
        axios.post(url, data, config)
            .then(response => {
                resolve(response.data);
            })
            .catch(error => {
                reject(error);
            });
    });
}

function SendGetRequest(url, params, config) {
    return new Promise((resolve, reject) => {
        if (config == null || config == undefined) {
            config = {
                headers: {
                    'Content-Type': 'application/json; chartset-UTF-8'
                }
            };
        }
        axios.get(url, { params }, config)
            .then(response => {
                resolve(response.data);
            })
            .catch(error => {
                reject(error);
            });
    });
}

function startLoader() {
    Swal.fire({
        title: 'Lütfen Bekleyiniz...',
        allowOutsideClick: false,
        showConfirmButton: false,
        didOpen: () => {
            Swal.showLoading()
        }
    });
}

function closeLoader() {
    Swal.close();
}

function HandleCatchBlock(err) {
    if (err.response?.status == 400) {
        let error_res = err.response?.data;
        if (error_res.length > 0) {
            for (let i = 0; i < error_res.length; i++) {
                let propertyDiv = document.getElementById(error_res[i].propertyName);
                let errorBox = `<div class="mt-3 alert alert-arrow-left alert-icon-left alert-danger"><i class="icon-warning2 mr-3 icon-2x"></i><strong>Uyarı! </strong>${error_res[i].errorMessage}</div>`;
                //<div class="mt-3 card bg-danger"><div class="card-body">${error_res[i].errorMessage}</div></div>
                let range = document.createRange();
                let errorBoxAsNode = range.createContextualFragment(errorBox);
                if (propertyDiv != null || propertyDiv != undefined) {
                    propertyDiv.append(errorBoxAsNode);
                }

            }
        }
    }
    else if (err.response?.status != 400) {
        //let details = JSON.parse(err?.response?.data);
        location.href = `/Error/Error?details= ${err.response?.data}`;
    }
    else {
        Swal.fire({
            title: "Bilinmeyen bir hata meydana geldi!",
            text: err,
            icon: "error",
            showCancelButton: false,
            showConfirmButton: true,
            willClose: () => {
                window.location.reload();
            }
        });
    }
}

const BreadCrumb = async () => { /// sayfada istemediğimiz alanları role yetkilendirmesinden, veritabanından taglare göre görünmemesini sağlayabiliyoruz

    try {
        const url = "/Helper/ConfigureBreadCrumb";
        const data = {};
        const result = await SendPostRequest(url, data);
        result.data ??= [];

        let bread_crumb_html = `<li class="breadcrumb-item"><a href="/"><i class="icon-home2 me-2"></i></a></li>`;
        if (result.data.length > 0)
            result.data[result.data.length - 1].slug = null;

        result.data.forEach(b => {
            if (b.slug && b.slug.length > 0)
                bread_crumb_html += `<li class="breadcrumb-item"><a href="${b.slug}">${b.text}</a></li>`;
            else
                bread_crumb_html += `<li class="breadcrumb-item active" aria-current="page">${b.text}</li>`;

        });
        $(".breadcrumb").html(bread_crumb_html);
    } catch (err) { } finally { }


}

const ActivedLiElement = async () => {
    let page_path = "/home/index";

    let page_path_arr = location.pathname.split("/");
    page_path_arr = page_path_arr.slice(1, page_path_arr.length);
    if (page_path_arr)
        page_path = "/" + page_path_arr[0] + "/" + page_path_arr[1];

    const targets_a = document.querySelectorAll(`#sidebar a[data-url^="${page_path}"]`);
    if (targets_a && targets_a.length > 0) {
        targets_a.forEach(item => {
            let absoluteParent = $(item).closest("li.menu");

            let firschild = absoluteParent.children().first();
            firschild.attr('aria-expanded', true);
            let ul = absoluteParent.children().last();
            ul.addClass("show");

            let parents_for_set_active = $(item).parentsUntil('li.menu');
            parents_for_set_active.addClass("active");
            let parents_for_set_active_serialize = [...parents_for_set_active];
            parents_for_set_active_serialize.forEach(w => {

                let firschild1 = $(w).children().first();
                if (firschild1[0].localName == "a") {
                    firschild1.attr('aria-expanded', true);
                }
                if ($(w)[0].localName == "ul") {
                    $(w).addClass("show");
                }

            });
        });
    }
    else {
        let url_util = new URL(document.referrer);
        page_path_arr = url_util.pathname.split("/");
        page_path_arr = page_path_arr.slice(1, page_path_arr.length);
        if (page_path_arr)
            page_path = "/" + page_path_arr[0] + "/" + page_path_arr[1];

        const old_targets_a = document.querySelectorAll(`#sidebar a[data-url^="${page_path}"]`);
        old_targets_a.forEach(item => {
            let absoluteParent = $(item).closest("li.menu");

            let firschild = absoluteParent.children().first();
            firschild.attr('aria-expanded', true);
            let ul = absoluteParent.children().last();
            ul.addClass("show");

            let parents_for_set_active = $(item).parentsUntil('li.menu');
            parents_for_set_active.addClass("active");
            let parents_for_set_active_serialize = [...parents_for_set_active];
            parents_for_set_active_serialize.forEach(w => {

                let firschild1 = $(w).children().first();
                if (firschild1[0].localName == "a") {
                    firschild1.attr('aria-expanded', true);
                }
                if ($(w)[0].localName == "ul") {
                    $(w).addClass("show");
                }

            });
        });
    }
}

const InitLoader = () => $('#load_screen').css('display', 'block');
const CloseInitLoader = () => $('#load_screen').css('display', 'none');
