$(document).ready(() => {
    // Sayfa yüklendiğinde en üste kaydır
    $("html, body").scrollTop(0);

    // Periyot seçimi yapıldığında tarih aralığını otomatik belirle
    $("#period").on("change", updateDateRange);

    // Sayfa yüklendiğinde tarih aralığını güncelle
    updateDateRange();

    // Rapor butonuna tıklanınca AJAX ile verileri çek
    $("#reportForm").on("submit", (event) => {
        event.preventDefault();
        generateReport();
    });
});

// Raporu getirirken eski içeriği temizle ve hata yönetimi ekle
function generateReport() {
    $("#placeholderText").hide(); // Rapor oluşturulunca placeholder kaybolacak

    $.ajax({
        url: '/Reports/GetReport',
        type: 'POST',
        data: {
            reportType: $('#reportType').val(),
            startDate: $('#startDate').val(),
            endDate: $('#endDate').val(),
            sortOrder: $('#sortOrder').val()
        },
        success: (response) => {
            $('#reportResults').html(response);
        },
        error: (err) => {
            alert("Rapor getirilirken bir hata oluştu.");
        }
    });
}

// Excel dosyasını indir ve formu işlem sonrası kaldır
function downloadExcel() {
    const form = $("<form>", {
        action: "/Reports/DownloadExcel",
        method: "post"
    }).append(
        $("<input>", { type: "hidden", name: "reportType", value: $("#reportType").val() }),
        $("<input>", { type: "hidden", name: "startDate", value: $("#startDate").val() }),
        $("<input>", { type: "hidden", name: "endDate", value: $("#endDate").val() })
    );

    $("body").append(form);
    form.submit();
    form.remove();
}

// PDF dosyasını indir ve formu işlem sonrası kaldır
function downloadPdf() {
    const form = $("<form>", {
        action: "/Reports/DownloadPdf",
        method: "post"
    }).append(
        $("<input>", { type: "hidden", name: "reportType", value: $("#reportType").val() }),
        $("<input>", { type: "hidden", name: "startDate", value: $("#startDate").val() }),
        $("<input>", { type: "hidden", name: "endDate", value: $("#endDate").val() })
    );

    $("body").append(form);
    form.submit();
    form.remove();
}
