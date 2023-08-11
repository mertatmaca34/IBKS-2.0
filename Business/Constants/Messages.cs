namespace Business.Constants
{
    public static class Messages
    {
        //Global
        public static string ItsAlreadyExist = "Bu bilgilere zaten sisteme tanımlanmış";
        public static string InvalidDateTimes = "Seçilen tarih aralıkları geçersiz";
        public static string InvalidDelete = "Silinecek veri veritabanında kayıtlı değil";

        //Custom
        public static string ApiAdded = "API bilgileri sisteme eklendi";
        public static string ApiUpdated = "API bilgileri güncellendi";
        public static string ApiSendDataSuccces = "Tarihli veri başarıyla gönderildi";
        public static string ApiSendDataFault = "Tarihli veri gönderilemedi";
        public static string ApiLoginFailed = "Henüz API'ye giriş yapılmamış";

        public static string CalibrationAdded = "Kalibrasyon kaydedildi";
        public static string CalibrationNotAdded = "Kalibrasyon kaydedilemedi";
        public static string CalibrationNotFound = "Silinecek kalibrasyon bulunamadı";
        public static string CalibrationSent = "Kalibrasyon başarıyla gönderildi";
        public static string CalibrationNotSent = "Kalibrasyon gönderilemedi";

        public static string CalibrationLimitAdded = "Kalibrasyon limit bilgileri sisteme eklendi";
        public static string CalibrationLimitUpdated = "Kalibrasyon limit bilgileri güncellendi";
        public static string CalibrationLimitIncompleteInfo = "Kalibrasyon limit bilgilerini tam şekilde girin";

        public static string ChannelAdded = "Kanal sisteme kaydedildi";

        public static string DataNotFound = "Veri Yok";

        public static string DataSent = "Data başarıyla gönderildi";
        public static string DataNotSent = "Data gönderilemedi";

        public static string DB41Added = "Data başarıyla eklendi";
        public static string DB41Updated = "Data başarıyla güncellendi";
        public static string DB41Deleted = "Data başarıyla silindi";

        public static string IncompleteInfo = "Lütfen bilgileri tam şekilde girin";
        public static string InvalidUser = "Lütfen geçerli bir kullanıcı seçin";

        public static string MailServerAdded = "Mail sunucu bilgileri başarıyla eklendi";
        public static string MailServerUpdated = "Mail sunucu bilgileri başarıyla güncellendi";

        public static string MailStatementDeleted = "Seçili mail durumu başarıyla silindi";
        public static string MailStatementUpdated = "Seçili mail durumu başarıyla güncellendi";
        public static string MailStatementAdded = "Mail durumu başarıyla eklendi";
        public static string MailStatementCantBeAdded = "Mail durumu eklenemedi";

        public static string UserMailStatementDeleted = "Seçili mail durumu başarıyla silindi";
        public static string UserMailStatementUpdated = "Seçili mail durumu başarıyla güncellendi";
        public static string UserMailStatementAdded = "Seçili mail durumu başarıyla eklendi";
        public static string UserMailStatementCantBeAdded = "Mail durumu eklenemedi";

        public static string MissData = "Lütfen eksik bilgileri doldurun";

        public static string PlcAdded = "PLC bilgileri başarıyla eklendi";
        public static string PlcUpdated = "PLC bilgileri başarıyla güncellendi";

        public static string SampleAdded = "Numune bilgileri başarıyla eklendi";
        public static string SampleUpdated = "Numune bilgileri başarıyla güncellendi";

        public static string SameMinuteData = "Bu dakikanın verisi daha önce kaydedilmiştir";

        public static string StationAdded = "İstasyon bilgileri sisteme eklendi";
        public static string StationUpdated = "İstasyon bilgileri güncellendi";
        public static string StationIsNotDefined = "İstasyon bilgileri tanımlı değil";

        public static string SendDataDeleted = "Gönderilen data başarıyla silindi";
        public static string SendDataUpdated = "Gönderilen data güncellendi";
        public static string SendDataAdded = "Gönderilen data başarıyla kaydedildi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserWrongPassword = "Kullanıcı adı veya şifre yanlış";
        public static string UserAdded = "Kullanıcı başarıyla sisteme eklendi";
        public static string UserSuccessfullyLogin = "Giriş başarılı";
        public static string UserAlreadyExist  = "Kullanıcı sistemde zaten mevcut";

        public static string WashDataNotFound = "Sistemde yıkama verisi bulunamadı";

        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}