namespace Business.Constants
{
    public static class Messages
    {
        //Global
        public static string ItsAlreadyExist = "Bu bilgilere zaten sisteme tanımlanmış";
        public static string InvalidDateTimes = "Seçilen tarih aralıkları geçersiz";
        public static string InvalidDelete = "Silinecek veri veritabanında kayıtlı değil";


        //Custom
        public static string ApiAdded = "Api bilgileri sisteme eklendi";
        public static string ApiUpdated = "Api bilgileri güncellendi";

        public static string CalibrationAdded = "Kalibrasyon kaydedildi";
        public static string CalibrationNotAdded = "Kalibrasyon kaydedilemedi";
        public static string CalibrationNotFound = "Silinecek kalibrasyon bulunamadı";

        public static string ChannelAdded = "Kanal sisteme kaydedildi";

        public static string MailServerAdded = "Mail sunucu bilgileri başarıyla eklendi";
        public static string MailServerUpdated = "Seçili mail sunucu bilgileri başarıyla güncellendi";


        public static string MailStatementDeleted = "Seçili mail durumu başarıyla silindi";
        public static string MailStatementUpdated = "Seçili mail durumu başarıyla güncellendi";
        public static string MailStatementAdded = "Mail durumu başarıyla eklendi";

        public static string PlcAdded = "PLC bilgileri başarıyla eklendi";
        public static string PlcUpdated = "PLC bilgileri başarıyla güncellendi";

        public static string SampleAdded = "Numune bilgileri başarıyla eklendi";
        public static string SampleUpdated = "Numune bilgileri başarıyla güncellendi";

        public static string StationAdded = "İstasyon bilgileri sisteme eklendi";
        public static string StationUpdated = "İstasyon bilgileri güncellendi";

        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}