namespace Business.Constants
{
    public static class Messages
    {
        //Global
        public static string ItsAlreadyExist = "Bu bilgilere zaten sisteme tanımlanmış";
        public static string InvalidDateTimes = "Seçilen tarih aralıkları geçersiz";

        //Custom
        public static string ApiAdded = "Api bilgileri sisteme eklendi";
        public static string ApiUpdated = "Api bilgileri güncellendi";

        public static string CalibrationAdded = "Kalibrasyon kaydedildi";
        public static string CalibrationNotAdded = "Kalibrasyon kaydedilemedi";
        public static string CalibrationNotFound = "Silinecek kalibrasyon bulunamadı";

        public static string ChannelAdded = "Kanal sisteme kaydedildi";

        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}