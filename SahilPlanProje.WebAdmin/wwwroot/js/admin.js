
const API_BASE_URL = "https://api.sahilplanproje.com/api";

const apiConfig = {
    cities: {
        title: "İller",
        listUrl: "/Cities",
        getUrl: "/Cities/{id}",
        createUrl: "/Cities",
        updateUrl: "/Cities/{id}",
        deleteUrl: "/Cities/{id}",
        fields: ["code", "plate_code", "name", "country_code", "is_active"],
        labels: {
            code: "Kod",
            plate_code: "Plaka",
            name: "İl Adı",
            country_code: "Ülke Kodu",
            is_active: "Aktif"
        },
        required: ["code", "plate_code", "name", "country_code"],
        defaults: {
            country_code: "TR",
            is_active: true
        }
    },

    districts: {
        title: "İlçeler",
        listUrl: "/Districts",
        getUrl: "/Districts/{id}",
        createUrl: "/Districts",
        updateUrl: "/Districts/{id}",
        deleteUrl: "/Districts/{id}",
        fields: ["city_id", "code", "district_no", "district_group_no", "name", "is_central", "is_active"],
        labels: {
            city_id: "İl",
            code: "İlçe Kodu",
            district_no: "İlçe No",
            district_group_no: "İlçe Grup No",
            name: "İlçe Adı",
            is_central: "Merkez",
            is_active: "Aktif"
        },
        required: ["city_id", "code", "district_no", "name"],
        lookups: {
            city_id: { url: "/Cities", valueField: "id", textField: "name" }
        },
        display: {
            city_id: "city.name"
        },
        defaults: {
            is_active: true,
            is_central: false
        }
    },

    tahakkukYears: {
        title: "Tahakkuk Yılları",
        listUrl: "/TahakkukYears",
        getUrl: "/TahakkukYears/{id}",
        createUrl: "/TahakkukYears",
        updateUrl: "/TahakkukYears/{id}",
        deleteUrl: "/TahakkukYears/{id}",
        fields: ["year", "is_active"],
        labels: {
            year: "Yıl",
            is_active: "Aktif"
        },
        required: ["year"],
        defaults: {
            year: new Date().getFullYear(),
            is_active: true
        }
    },

    institutions: {
        title: "Kurumlar",
        listUrl: "/TahakkukInstitutions",
        getUrl: "/TahakkukInstitutions/{id}",
        createUrl: "/TahakkukInstitutions",
        updateUrl: "/TahakkukInstitutions/{id}",
        deleteUrl: "/TahakkukInstitutions/{id}",

        fields: ["name", "institution_type", "is_active"],

        labels: {
            name: "Kurum Adı",
            institution_type: "Kurum Tipi",
            is_active: "Aktif"
        },

        required: ["name"],

        defaults: {
            institution_type: 1,
            is_active: true
        },

        lookups: {
            institution_type: {
                static: true,
                valueField: "value",
                textField: "text",
                items: [
                    { value: 0, text: "İlçe Belediyesi" },
                    { value: 1, text: "Büyükşehir Belediyesi" }
                    //{ value: 2, text: "Kamu Kurumu" },
                    //{ value: 3, text: "Özel Kurum" }
                ]
            }
        }
    }, 


    departments: {
        title: "Daire Başkanlıkları",
        listUrl: "/TahakkukDepartments",
        getUrl: "/TahakkukDepartments/{id}",
        createUrl: "/TahakkukDepartments",
        updateUrl: "/TahakkukDepartments/{id}",
        deleteUrl: "/TahakkukDepartments/{id}",
        fields: ["tahakkuk_institution_id", "name", "is_active"],
        labels: {
            tahakkuk_institution_id: "Kurum",
            name: "Daire Başkanlığı",
            is_active: "Aktif"
        },
        required: ["tahakkuk_institution_id", "name"],
        lookups: {
            tahakkuk_institution_id: { url: "/TahakkukInstitutions", valueField: "id", textField: "name" }
        },
        display: {
            tahakkuk_institution_id: "tahakkuk_institution.name"
        },
        defaults: {
            is_active: true
        }
    },

    directorates: {
        title: "Müdürlükler",
        listUrl: "/TahakkukDirectorates",
        getUrl: "/TahakkukDirectorates/{id}",
        createUrl: "/TahakkukDirectorates",
        updateUrl: "/TahakkukDirectorates/{id}",
        deleteUrl: "/TahakkukDirectorates/{id}",
        fields: ["tahakkuk_institution_id", "tahakkuk_department_id", "name", "is_active"],
        labels: {
            tahakkuk_institution_id: "Kurum",
            tahakkuk_department_id: "Daire Başkanlığı",
            name: "Müdürlük Adı",
            is_active: "Aktif"
        },
        required: ["tahakkuk_institution_id", "name"],
        lookups: {
            tahakkuk_institution_id: { url: "/TahakkukInstitutions", valueField: "id", textField: "name" },
            tahakkuk_department_id: { url: "/TahakkukDepartments", valueField: "id", textField: "name" }
        },
        display: {
            tahakkuk_institution_id: "tahakkuk_institution.name",
            tahakkuk_department_id: "tahakkuk_department.name"
        },
        defaults: {
            is_active: true
        }
    },

    scales: {
        title: "Ölçekler",
        listUrl: "/TahakkukScales",
        getUrl: "/TahakkukScales/{id}",
        createUrl: "/TahakkukScales",
        updateUrl: "/TahakkukScales/{id}",
        deleteUrl: "/TahakkukScales/{id}",
        fields: ["name", "is_active"],
        labels: {
            name: "Ölçek Adı",
            is_active: "Aktif"
        },
        required: ["name"],
        defaults: {
            is_active: true
        }
    },

    feeSubjects: {
        title: "Ücret Konuları",
        listUrl: "/TahakkukFeeSubjects",
        getUrl: "/TahakkukFeeSubjects/{id}",
        createUrl: "/TahakkukFeeSubjects",
        updateUrl: "/TahakkukFeeSubjects/{id}",
        deleteUrl: "/TahakkukFeeSubjects/{id}",
        fields: ["name", "is_active"],
        labels: {
            name: "Ücret Konusu",
            is_active: "Aktif"
        },
        required: ["name"],
        defaults: {
            is_active: true
        }
    },

    feeSubSubjects: {
        title: "Ücret Alt Konuları",
        listUrl: "/TahakkukFeeSubSubjects",
        getUrl: "/TahakkukFeeSubSubjects/{id}",
        createUrl: "/TahakkukFeeSubSubjects",
        updateUrl: "/TahakkukFeeSubSubjects/{id}",
        deleteUrl: "/TahakkukFeeSubSubjects/{id}",
        fields: ["tahakkuk_fee_subject_id", "name", "is_active"],
        labels: {
            tahakkuk_fee_subject_id: "Ücret Konusu",
            name: "Ücret Alt Konusu",
            is_active: "Aktif"
        },
        required: ["tahakkuk_fee_subject_id", "name"],
        lookups: {
            tahakkuk_fee_subject_id: { url: "/TahakkukFeeSubjects", valueField: "id", textField: "name" }
        },
        display: {
            tahakkuk_fee_subject_id: "tahakkuk_fee_subject.name"
        },
        defaults: {
            is_active: true
        }
    },

    definitions: {
        title: "Tahakkuk Tanımları",
        listUrl: "/TahakkukDefinitions",
        getUrl: "/TahakkukDefinitions/{id}",
        createUrl: "/TahakkukDefinitions",
        updateUrl: "/TahakkukDefinitions/{id}",
        deleteUrl: "/TahakkukDefinitions/{id}",
        fields: [
            "city_id",
            "district_id",
            //"district_group_no",
            "tahakkuk_year_id",
            "tahakkuk_institution_id",
            "tahakkuk_department_id",
            "tahakkuk_directorate_id",
            "tahakkuk_scale_id",
            "tahakkuk_fee_subject_id",
            "tahakkuk_fee_sub_subject_id",
            "description",
            "price",
            "price2",
            "price3",
            "price4",
            "has_vat",
            "is_active",
            "description2"
        ],
        labels: {
            city_id: "İl",
            district_id: "İlçe",
            //district_group_no: "İlçe Grup No",
            tahakkuk_year_id: "Tahakkuk Yılı",
            tahakkuk_institution_id: "Kurum",
            tahakkuk_department_id: "Daire Başkanlığı",
            tahakkuk_directorate_id: "Müdürlük",
            tahakkuk_scale_id: "Ölçek",
            tahakkuk_fee_subject_id: "Ücret Konusu",
            tahakkuk_fee_sub_subject_id: "Ücret Alt Konusu",
            description: "Açıklama",
            description2: "Açıklama 2",
            price: "1.Grup Fiyat",
            price2: "2.Grup Fiyat",
            price3: "3.Grup Fiyat",
            price4: "4.Grup Fiyat",
            has_vat: "KDV Var",
            is_active: "Aktif"
        },
        required: [
            "tahakkuk_year_id",
            "tahakkuk_institution_id",
            "tahakkuk_fee_subject_id",
            "tahakkuk_fee_sub_subject_id",
            "description",
            "price"
        ],
        nullableFields: [
            "city_id",
            "district_id",
            //"district_group_no",
            "tahakkuk_department_id",
            "tahakkuk_directorate_id",
            "tahakkuk_scale_id"
        ],
        listFields: [
            "city_id",
            "district_id",
            "tahakkuk_year_id",
            "tahakkuk_fee_subject_id",
            "tahakkuk_fee_sub_subject_id",
            "description",
            "price",
            "price2",
            "price3",
            "price4"
        ],
        lookups: {
            city_id: { url: "/Cities", valueField: "id", textField: "name" },
            district_id: { url: "/Districts", valueField: "id", textField: "name" },
            tahakkuk_year_id: { url: "/TahakkukYears", valueField: "id", textField: "year" },
            tahakkuk_institution_id: { url: "/TahakkukInstitutions", valueField: "id", textField: "name" },
            tahakkuk_department_id: { url: "/TahakkukDepartments", valueField: "id", textField: "name" },
            tahakkuk_directorate_id: { url: "/TahakkukDirectorates", valueField: "id", textField: "name" },
            tahakkuk_scale_id: { url: "/TahakkukScales", valueField: "id", textField: "name" },
            tahakkuk_fee_subject_id: { url: "/TahakkukFeeSubjects", valueField: "id", textField: "name" },
            tahakkuk_fee_sub_subject_id: { url: "/TahakkukFeeSubSubjects", valueField: "id", textField: "name" }
        },
        display: {
            city_id: "city.name",
            district_id: "district.name",
            tahakkuk_year_id: "tahakkuk_year.year",
            tahakkuk_institution_id: "tahakkuk_institution.name",
            tahakkuk_department_id: "tahakkuk_department.name",
            tahakkuk_directorate_id: "tahakkuk_directorate.name",
            tahakkuk_scale_id: "tahakkuk_scale.name",
            tahakkuk_fee_subject_id: "tahakkuk_fee_subject.name",
            tahakkuk_fee_sub_subject_id: "tahakkuk_fee_sub_subject.name"
        },
        defaults: {
            has_vat: true,
            is_active: true
        }
    }
};

let currentModule = "cities";
let currentRecords = [];
let lookupData = {};

function buildUrl(url, id = null) {
    let result = API_BASE_URL + url;
    if (id !== null && id !== undefined) {
        result = result.replace("{id}", id);
    }
    return result;
}

async function apiRequest(url, method = "GET", data = null) {
    const options = { method };

    if (data !== null) {
        options.headers = { "Content-Type": "application/json" };
        options.body = JSON.stringify(data);
    }

    const response = await fetch(url, options);

    if (!response.ok) {
        const errorText = await response.text();
        throw new Error(errorText || "API isteği başarısız oldu.");
    }

    const text = await response.text();
    if (!text) return null;

    try {
        return JSON.parse(text);
    } catch {
        return text;
    }
}

async function loadRecords() {
    const config = apiConfig[currentModule];

    try {
        document.getElementById("current-module-title").innerText = config.title + " Yönetimi";
        document.getElementById("listContainer").innerHTML = "<div class='empty-msg'>Yükleniyor...</div>";

        await loadLookups(config);

        const result = await apiRequest(buildUrl(config.listUrl));
        currentRecords = Array.isArray(result) ? result : (result?.data || []);

        document.getElementById("record-count").innerText = currentRecords.length + " kayıt";
        renderList();
    } catch (error) {
        console.error(error);
        document.getElementById("listContainer").innerHTML = `<div class='empty-msg'>Liste yüklenemedi: ${escapeHtml(error.message)}</div>`;
    }
}

async function loadLookups(config) {

    lookupData = {};

    if (!config.lookups)
        return;

    for (const field in config.lookups) {

        const lookup = config.lookups[field];

        // Static lookup ise API çağırma
        if (lookup.static === true) {

            lookupData[field] = lookup.items || [];
            continue;
        }

        const result = await apiRequest(buildUrl(lookup.url));

        lookupData[field] =
            Array.isArray(result)
                ? result
                : (result?.data || []);
    }
}

function renderList() {
    const config = apiConfig[currentModule];
    const container = document.getElementById("listContainer");

    if (currentRecords.length === 0) {
        container.innerHTML = "<div class='empty-msg'>Kayıt bulunamadı.</div>";
        return;
    }

    //const displayFields = config.fields.filter(x => x !== "is_active" && x !== "has_vat" && x !== "description2");
    const displayFields = config.listFields
        || config.fields.filter(x => x !== "is_active" && x !== "has_vat" && x !== "description2");
    let html = `
    <table class="entity-table">
        <thead>
            <tr>
                ${displayFields.map(f => `<th>${config.labels[f] || f}</th>`).join("")}
                <th>Durum</th>
                <th>İşlem</th>
            </tr>
        </thead>
        <tbody>
            `;

    currentRecords.forEach(item => {
        html += `
                <tr class="record-row" data-id="${item.id}">
                    ${displayFields.map(f => `<td>${escapeHtml(getDisplayValue(item, f, config))}</td>`).join("")}
                    <td>
                        ${item.is_active
                ? "<span class='badge-active'>Aktif</span>"
                : "<span class='badge-active badge-inactive'>Pasif</span>"}
                    </td>
                    <td class="action-icons">
                        <i class="fas fa-edit edit-icon" data-id="${item.id}"></i>
                        <i class="fas fa-trash-alt delete-icon" data-id="${item.id}"></i>
                    </td>
                </tr>
            `;
    });

    html += "</tbody></table>";
    container.innerHTML = html;

    document.querySelectorAll(".edit-icon").forEach(icon => {
        icon.addEventListener("click", function (e) {
            e.stopPropagation();

            document.querySelectorAll(".record-row")
                .forEach(x => x.classList.remove("selected-row"));

            this.closest(".record-row")?.classList.add("selected-row");

            loadToForm(this.dataset.id);
        });
    });

    document.querySelectorAll(".delete-icon").forEach(icon => {
        icon.addEventListener("click", function (e) {
            e.stopPropagation();
            deleteRecord(this.dataset.id);
        });
    });

    document.querySelectorAll(".record-row").forEach(row => {
        row.addEventListener("click", function () {
            document.querySelectorAll(".record-row")
                .forEach(x => x.classList.remove("selected-row"));

            this.classList.add("selected-row");

            loadToForm(this.dataset.id);
        });
    });
}

function getDisplayValue(item, field, config) {
    if (config.display && config.display[field]) {
        const nestedValue = getNestedValue(item, config.display[field]);
        if (nestedValue !== null && nestedValue !== undefined && nestedValue !== "") return nestedValue;
    }

    if (field === "price" && item[field] !== null && item[field] !== undefined) {
        return Number(item[field]).toLocaleString("tr-TR", { minimumFractionDigits: 2, maximumFractionDigits: 2 });
    }

    if (field === "price2" && item[field] !== null && item[field] !== undefined) {
        return Number(item[field]).toLocaleString("tr-TR", { minimumFractionDigits: 2, maximumFractionDigits: 2 });
    }

    if (field === "price3" && item[field] !== null && item[field] !== undefined) {
        return Number(item[field]).toLocaleString("tr-TR", { minimumFractionDigits: 2, maximumFractionDigits: 2 });
    }

    if (field === "price4" && item[field] !== null && item[field] !== undefined) {
        return Number(item[field]).toLocaleString("tr-TR", { minimumFractionDigits: 2, maximumFractionDigits: 2 });
    }
    if (field === "institution_type") {

        const map = {
            0: "İlçe Belediyesi",
            1: "Büyükşehir Belediyesi"
            //2: "Kamu Kurumu",
            //3: "Özel Kurum"
        };

        return map[item[field]] || "-";
    }
    if (field === "has_vat") {
        return item[field] ? "Var" : "Yok";
    }

    return item[field] ?? "-";
}

function getNestedValue(obj, path) {
    return path.split(".").reduce((current, key) => {
        if (current === null || current === undefined) return null;
        return current[key];
    }, obj);
}

async function loadToForm(id) {
    const config = apiConfig[currentModule];

    try {
        const record = await apiRequest(buildUrl(config.getUrl, id));

        document.getElementById("editId").value = record.id;
        document.getElementById("formTitle").innerText = "Kaydı Güncelle";

        generateFormFields(record);
    } catch (error) {
        alert("Kayıt getirme hatası: " + error.message);
    }
}

function generateFormFields(record = null) {
    const config = apiConfig[currentModule];
    const fieldsDiv = document.getElementById("dynamicFormFields");

    let html = "";

    config.fields.forEach(field => {
        const label = config.labels[field] || field;
        const value = record ? record[field] : getDefaultValue(config, field);
        const required = config.required?.includes(field) ? "required" : "";
        const requiredMark = config.required?.includes(field) ? " <span style='color:#ef4444'>*</span>" : "";

        if (field === "is_active" || field === "has_vat" || field === "is_central") {
            const checked = value ? "checked" : "";

            html += `
    <div class="form-group checkbox-group">
        <label>${label}${requiredMark}</label>
        <input type="checkbox" id="field_${field}" ${checked}>
    </div>
    `;
        } else if (config.lookups && config.lookups[field]) {
            const lookup = config.lookups[field];

            let options = [];

            if (lookup.static === true) {
                options = lookup.items || [];
            } else {
                options = lookupData[field] || [];
            }

            const valueField = lookup.valueField || "value";
            const textField = lookup.textField || "text";

            html += `
                <div class="form-group ${getFormGroupClass(field)}">
                    <label>${label}${requiredMark}</label>
                    <select id="field_${field}" ${required}>
                        <option value="">Seçiniz</option>
                        ${options.map(opt => `
                            <option value="${opt[valueField]}" ${Number(value) === Number(opt[valueField]) ? "selected" : ""}>
                                ${escapeHtml(opt[textField])}
                            </option>
                        `).join("")}
                    </select>
                </div>
            `;
        }
        else if (field === "price" || field === "price2" || field === "price3" || field === "price4") {
            html += `
    <div class="form-group ${getFormGroupClass(field)}">
        <label>${label}${requiredMark}</label>
        <input type="text"
               class="price-input"
               id="field_${field}"
               value="${formatPriceInput(value)}"
               ${required}>
    </div>
`;
        }
        else if (field === "year" || field === "district_no" || field === "district_group_no") {
            html += `
                    <div class="form-group ${getFormGroupClass(field)}">
                        <label>${label}${requiredMark}</label>
                        <input type="number" id="field_${field}" value="${value ?? ""}" ${required}>
                    </div>
                `;
        }
        else if (field === "description" || field === "description2") {
            html += `
                    <div class="form-group ${getFormGroupClass(field)}">
                        <label>${label}${requiredMark}</label>
                        <textarea id="field_${field}" ${required}>${value ?? ""}</textarea>
                    </div>
                `;
        }
        else {
            html += `
                    <div class="form-group ${getFormGroupClass(field)}">
                        <label>${label}${requiredMark}</label>
                        <input type="text" id="field_${field}" value="${value ?? ""}" ${required}>
                    </div>
                `;
        }
    });

    fieldsDiv.innerHTML = html;
}

function formatPriceInput(value) {

    if (value === null || value === undefined || value === "")
        return "";

    return Number(value).toLocaleString("tr-TR", {
        minimumFractionDigits: 2,
        maximumFractionDigits: 2
    });
}

function getFormGroupClass(field) {
    const fullRowFields = [
        "tahakkuk_fee_subject_id",
        "tahakkuk_fee_sub_subject_id",
        "description",
        "description2"
    ];

    return fullRowFields.includes(field) ? "full-row" : "";
}

function getDefaultValue(config, field) {
    if (config.defaults && Object.prototype.hasOwnProperty.call(config.defaults, field)) {
        return config.defaults[field];
    }

    if (field === "is_active") return true;
    if (field === "has_vat" || field === "is_central") return false;

    return "";
}

function getFormData() {
    const config = apiConfig[currentModule];
    const data = {};
    const editId = document.getElementById("editId").value;

    if (editId) {
        data.id = Number(editId);
    }

    config.fields.forEach(field => {
        const el = document.getElementById("field_" + field);
        if (!el) return;

        if (el.type === "checkbox") {
            data[field] = el.checked;
        }
        else if (el.tagName === "SELECT") {
            data[field] = el.value === "" ? null : Number(el.value);
        }
        else if (el.type === "number") {
            data[field] = el.value === "" ? null : Number(el.value);
        } else if (el.classList.contains("price-input")) {

            if (el.value === "") {
                data[field] = null;
            } else {

                let normalized = el.value
                    .replace(/\./g, "")
                    .replace(",", ".");

                data[field] = Number(normalized);
            }
        }
        else {
            data[field] = el.value;
        }
    });

    return data;
}

function validateFormData(data) {
    const config = apiConfig[currentModule];
    const requiredFields = config.required || [];

    for (const field of requiredFields) {
        const value = data[field];

        if (value === null || value === undefined || value === "") {
            alert((config.labels[field] || field) + " alanı zorunludur.");
            const el = document.getElementById("field_" + field);
            if (el) el.focus();
            return false;
        }
    }

    return true;
}

async function saveRecord() {
    const config = apiConfig[currentModule];
    const editId = document.getElementById("editId").value;
    const data = getFormData();

    if (!validateFormData(data)) return;

    try {
        if (editId) {
            await apiRequest(buildUrl(config.updateUrl, editId), "PUT", data);
            alert("Kayıt güncellendi.");
        } else {
            await apiRequest(buildUrl(config.createUrl), "POST", data);
            alert("Kayıt eklendi.");
        }

        clearForm();
        await loadRecords();
    } catch (error) {
        console.error(error);
        alert("Kaydetme hatası: " + error.message);
    }
}

async function deleteRecord(id) {
    const config = apiConfig[currentModule];

    if (!confirm("Bu kayıt silinsin mi?")) return;

    try {
        await apiRequest(buildUrl(config.deleteUrl, id), "DELETE");
        alert("Kayıt silindi.");
        clearForm();
        await loadRecords();
    } catch (error) {
        alert("Silme hatası: " + error.message);
    }
}

function clearForm() {
    document.getElementById("editId").value = "";
    document.getElementById("formTitle").innerText = "Yeni Kayıt Ekle";
    generateFormFields(null);
}

async function switchModule(moduleName) {
    currentModule = moduleName;

    document.querySelectorAll(".nav-item").forEach(x => x.classList.remove("active"));
    document.querySelector(`.nav-item[data-module="${moduleName}"]`)?.classList.add("active");

    await loadRecords();
    clearForm();
}

function escapeHtml(value) {
    if (value === null || value === undefined) return "-";

    return String(value)
        .replace(/&/g, "&amp;")
        .replace(/</g, "&lt;")
        .replace(/>/g, "&gt;")
        .replace(/"/g, "&quot;")
        .replace(/'/g, "&#039;");
}

document.querySelectorAll(".nav-item").forEach(item => {
    item.addEventListener("click", function () {
        switchModule(this.dataset.module);
    });
});

document.getElementById("refreshListBtn").addEventListener("click", function () {
    loadRecords();
});

document.getElementById("clearFormBtn").addEventListener("click", function () {
    clearForm();
});

document.getElementById("dataForm").addEventListener("submit", function (e) {
    e.preventDefault();
    saveRecord();
});

document.getElementById("deleteBtn").addEventListener("click", function () {
    const id = document.getElementById("editId").value;

    if (!id) {
        alert("Silmek için önce listeden kayıt seçin.");
        return;
    }

    deleteRecord(id);
});

document.addEventListener("input", function (e) {

    if (!e.target.classList.contains("price-input"))
        return;

    let value = e.target.value
        .replace(/[^\d,]/g, "");

    const parts = value.split(",");

    if (parts.length > 2)
        return;

    let integerPart = parts[0].replace(/\./g, "");

    integerPart = Number(integerPart || 0)
        .toLocaleString("tr-TR");

    e.target.value =
        parts.length === 2
            ? integerPart + "," + parts[1]
            : integerPart;
});
switchModule("cities");

