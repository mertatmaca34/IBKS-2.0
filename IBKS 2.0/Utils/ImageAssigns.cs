using Business.Enums;
using Entities.Concrete.API;
using IBKS_2._0.Properties;

namespace IBKS_2._0.Utils
{
    public static class ImageAssigns
    {
        public static Image AssignImage(DeserializeResult deserializedResult)
        {
            switch (deserializedResult.AKM_N_Status)
            {
                case (int)StationStatements.Gecerli:
                    return Resources.Checkmark_12px;

                case (int)StationStatements.Gecersiz:
                    return Resources.cancel;

                case (int)StationStatements.Kalibrasyon:
                    return Resources.Checkmark_12px;

                case (int)StationStatements.Yikama:
                    return Resources.Checkmark_12px;

                case (int)StationStatements.HaftalikYikama:
                    return Resources.Checkmark_12px;

                case (int)StationStatements.GecersizYikama:
                    return Resources.cancel;

                case (int)StationStatements.GecersizHaftalikYikama:
                    return Resources.cancel;

                case (int)StationStatements.GecersizAkisHizi:
                    return Resources.cancel;

                case (int)StationStatements.GecersizDebi:
                    return Resources.cancel;

                case (int)StationStatements.TekrarVeri:
                    return Resources.cancel;

                case (int)StationStatements.GecersizOlcumBirimi:
                    return Resources.cancel;

                default:
                    return Resources.cancel;
            }
        }
    }
}
