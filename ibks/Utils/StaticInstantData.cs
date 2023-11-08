using Entities.Concrete.API;

namespace ibks.Utils
{
    public static class StaticInstantData
    {
        public static int Period { get; set; }
        public static DateTime ReadTime { get; set; }
        public static double AKM { get; set; }
        public static int AKM_Status { get; set; }
        public static double CozunmusOksijen { get; set; }
        public static int CozunmusOksijen_Status { get; set; }
        public static double Debi { get; set; }
        public static int Debi_Status { get; set; }
        public static double KOi { get; set; }
        public static int KOi_Status { get; set; }
        public static double pH { get; set; }
        public static int pH_Status { get; set; }
        public static double Sicaklik { get; set; }
        public static int Sicaklik_Status { get; set; }
        public static double Iletkenlik { get; set; }
        public static int Iletkenlik_Status { get; set; }
        public static double AkisHizi { get; set; }
        public static int AkisHizi_Status { get; set; }
        public static double AKM_N { get; set; }
        public static int AKM_N_Status { get; set; }
        public static double CozunmusOksijen_N { get; set; }
        public static int CozunmusOksijen_N_Status { get; set; }
        public static double Debi_N { get; set; }
        public static int Debi_N_Status { get; set; }
        public static double AkisHizi_N { get; set; }
        public static int AkisHizi_N_Status { get; set; }
        public static double KOi_N { get; set; }
        public static int KOi_N_Status { get; set; }
        public static double pH_N { get; set; }
        public static int pH_N_Status { get; set; }
        public static double Iletkenlik_N { get; set; }
        public static int Iletkenlik_N_Status { get; set; }
        public static double Sicaklik_N { get; set; }
        public static int Sicaklik_N_Status { get; set; }

        public static void Assign(SendDataResult sendDataResult)
        {
            if(sendDataResult != null)
            {
                Period = sendDataResult.Period;
                ReadTime = sendDataResult.ReadTime;
                AKM = sendDataResult.AKM;
                AKM_Status = sendDataResult.AKM_Status;
                CozunmusOksijen = sendDataResult.CozunmusOksijen;
                CozunmusOksijen_Status = sendDataResult.CozunmusOksijen_Status;
                Debi = sendDataResult.Debi;
                Debi_Status = sendDataResult.Debi_Status;
                KOi = sendDataResult.KOi;
                KOi_Status = sendDataResult.KOi_Status;
                pH = sendDataResult.pH;
                pH_Status = sendDataResult.pH_Status;
                Sicaklik = sendDataResult.Sicaklik;
                Sicaklik_Status = sendDataResult.Sicaklik_Status;
                Iletkenlik = sendDataResult.Iletkenlik;
                Iletkenlik_Status = sendDataResult.Iletkenlik_Status;
                AkisHizi = sendDataResult.AkisHizi;
                AkisHizi_Status = sendDataResult.AkisHizi_Status;
                AKM_N = sendDataResult.AKM_N;
                AKM_N_Status = sendDataResult.AKM_N_Status;
                CozunmusOksijen_N = sendDataResult.CozunmusOksijen_N;
                CozunmusOksijen_N_Status = sendDataResult.CozunmusOksijen_N_Status;
                Debi_N = sendDataResult.Debi_N;
                Debi_N_Status = sendDataResult.Debi_N_Status;
                AkisHizi_N = sendDataResult.AkisHizi_N;
                AkisHizi_N_Status = sendDataResult.AkisHizi_N_Status;
                KOi_N = sendDataResult.KOi_N;
                KOi_N_Status = sendDataResult.KOi_N_Status;
                pH_N = sendDataResult.pH_N;
                pH_N_Status = sendDataResult.pH_N_Status;
                Iletkenlik_N = sendDataResult.Iletkenlik_N;
                Iletkenlik_N_Status = sendDataResult.Iletkenlik_N_Status;
                Sicaklik_N = sendDataResult.Sicaklik_N;
                Sicaklik_N_Status = sendDataResult.Sicaklik_N_Status;
            }
        }
    }
}
