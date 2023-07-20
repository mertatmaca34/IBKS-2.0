using System.ComponentModel;

namespace IBKS_2._0.Components
{
    public partial class StationInfoControl : UserControl
    {
        [Description("Son Yıkama Akm"), Category("IBKS")]
        public string LastWashAkm
        {
            get => LabelLastWashAkm.Text;
            set => LabelLastWashAkm.Text = value;
        }

        [Description("Son Yıkama CozunmusOksijen"), Category("IBKS")]
        public string LastWashCozunmusOksijen
        {
            get => LabelLastWashCozunmusOksijen.Text;
            set => LabelLastWashCozunmusOksijen.Text = value;
        }

        [Description("Son Yıkama Debi"), Category("IBKS")]
        public string LastWashDebi
        {
            get => LabelLastWashDebi.Text;
            set => LabelLastWashDebi.Text = value;
        }

        [Description("Son Yıkama KOi"), Category("IBKS")]
        public string LastWashKoi
        {
            get => LabelLastWashKoi.Text;
            set => LabelLastWashKoi.Text = value;
        }

        [Description("Son Yıkama pH"), Category("IBKS")]
        public string LastWashPh
        {
            get => LabelLastWashPh.Text;
            set => LabelLastWashPh.Text = value;
        }

        [Description("Son Yıkama Sıcaklık"), Category("IBKS")]
        public string LastWashSicaklik
        {
            get => LabelLastWashSicaklik.Text;
            set => LabelLastWashSicaklik.Text = value;
        }

        [Description("Son Yıkama İletkenlik"), Category("IBKS")]
        public string LastWashIletkenlik
        {
            get => LabelLastWashIletkenlik.Text;
            set => LabelLastWashIletkenlik.Text = value;
        }

        [Description("Son Yıkama DesarjDebi"), Category("IBKS")]
        public string LastWashDesarjDebi
        {
            get => LabelLastWashDesarjDebi.Text;
            set => LabelLastWashDesarjDebi.Text = value;
        }

        [Description("Son Yıkama HariciDebi"), Category("IBKS")]
        public string LastWashHariciDebi
        {
            get => LabelLastWashHariciDebi.Text;
            set => LabelLastWashHariciDebi.Text = value;
        }

        [Description("Son Yıkama HariciDebi2"), Category("IBKS")]
        public string LastWashHariciDebi2
        {
            get => LabelLastWashHariciDebi2.Text;
            set => LabelLastWashHariciDebi2.Text = value;
        }

        [Description("AKM Image"), Category("IBKS")]
        public Image LastWashAkmImage
        {
            get => LabelLastWashAkm.Image;
            set => LabelLastWashAkm.Image = value;
        }

        [Description("CozunmusOksijen Image"), Category("IBKS")]
        public Image LastWashCozunmusOksijenImage
        {
            get => LabelLastWashCozunmusOksijen.Image;
            set => LabelLastWashCozunmusOksijen.Image = value;
        }

        [Description("Debi Image"), Category("IBKS")]
        public Image LastWashDebiImage
        {
            get => LabelLastWashDebi.Image;
            set => LabelLastWashDebi.Image = value;
        }

        [Description("KOi Image"), Category("IBKS")]
        public Image LastWashKoiImage
        {
            get => LabelLastWashKoi.Image;
            set => LabelLastWashKoi.Image = value;
        }

        [Description("pH Image"), Category("IBKS")]
        public Image LastWashPhImage
        {
            get => LabelLastWashPh.Image;
            set => LabelLastWashPh.Image = value;
        }

        [Description("Sıcaklık Image"), Category("IBKS")]
        public Image LastWashSicaklikImage
        {
            get => LabelLastWashSicaklik.Image;
            set => LabelLastWashSicaklik.Image = value;
        }

        [Description("İletkenlik Image"), Category("IBKS")]
        public Image LastWashIletkenlikImage
        {
            get => LabelLastWashIletkenlik.Image;
            set => LabelLastWashIletkenlik.Image = value;
        }

        [Description("DesarjDebi Image"), Category("IBKS")]
        public Image LastWashDesarjDebiImage
        {
            get => LabelLastWashDesarjDebi.Image;
            set => LabelLastWashDesarjDebi.Image = value;
        }

        [Description("HariciDebi Image"), Category("IBKS")]
        public Image LastWashHariciDebiImage
        {
            get => LabelLastWashHariciDebi.Image;
            set => LabelLastWashHariciDebi.Image = value;
        }

        [Description("HariciDebi2 Image"), Category("IBKS")]
        public Image LastWashHariciDebi2Image
        {
            get => LabelLastWashHariciDebi2.Image;
            set => LabelLastWashHariciDebi2.Image = value;
        }
        [Description("Son Haftalık Yıkama Akm"), Category("IBKS")]
        public string LastWashWeekAkm
        {
            get => LabelLastWashWeekAkm.Text;
            set => LabelLastWashWeekAkm.Text = value;
        }

        [Description("Son Haftalık Yıkama CozunmusOksijen"), Category("IBKS")]
        public string LastWashWeekCozunmusOksijen
        {
            get => LabelLastWashWeekCozunmusOksijen.Text;
            set => LabelLastWashWeekCozunmusOksijen.Text = value;
        }

        [Description("Son Haftalık Yıkama Debi"), Category("IBKS")]
        public string LastWashWeekDebi
        {
            get => LabelLastWashWeekDebi.Text;
            set => LabelLastWashWeekDebi.Text = value;
        }

        [Description("Son Haftalık Yıkama KOi"), Category("IBKS")]
        public string LastWashWeekKoi
        {
            get => LabelLastWashWeekKoi.Text;
            set => LabelLastWashWeekKoi.Text = value;
        }

        [Description("Son Haftalık Yıkama pH"), Category("IBKS")]
        public string LastWashWeekPh
        {
            get => LabelLastWashWeekPh.Text;
            set => LabelLastWashWeekPh.Text = value;
        }

        [Description("Son Haftalık Yıkama Sıcaklık"), Category("IBKS")]
        public string LastWashWeekSicaklik
        {
            get => LabelLastWashWeekSicaklik.Text;
            set => LabelLastWashWeekSicaklik.Text = value;
        }

        [Description("Son Haftalık Yıkama İletkenlik"), Category("IBKS")]
        public string LastWashWeekIletkenlik
        {
            get => LabelLastWashWeekIletkenlik.Text;
            set => LabelLastWashWeekIletkenlik.Text = value;
        }

        [Description("Son Haftalık Yıkama DesarjDebi"), Category("IBKS")]
        public string LastWashWeekDesarjDebi
        {
            get => LabelLastWashWeekDesarjDebi.Text;
            set => LabelLastWashWeekDesarjDebi.Text = value;
        }

        [Description("Son Haftalık Yıkama HariciDebi"), Category("IBKS")]
        public string LastWashWeekHariciDebi
        {
            get => LabelLastWashWeekHariciDebi.Text;
            set => LabelLastWashWeekHariciDebi.Text = value;
        }

        [Description("Son Haftalık Yıkama HariciDebi2"), Category("IBKS")]
        public string LastWashWeekHariciDebi2
        {
            get => LabelLastWashWeekHariciDebi2.Text;
            set => LabelLastWashWeekHariciDebi2.Text = value;
        }

        [Description("AKM Haftalik Image"), Category("IBKS")]
        public Image LastWashWeekAkmImage
        {
            get => LabelLastWashWeekAkm.Image;
            set => LabelLastWashWeekAkm.Image = value;
        }

        [Description("CozunmusOksijen Haftalik Image"), Category("IBKS")]
        public Image LastWashWeekCozunmusOksijenImage
        {
            get => LabelLastWashWeekCozunmusOksijen.Image;
            set => LabelLastWashWeekCozunmusOksijen.Image = value;
        }

        [Description("Debi Haftalik Image"), Category("IBKS")]
        public Image LastWashWeekDebiImage
        {
            get => LabelLastWashWeekDebi.Image;
            set => LabelLastWashWeekDebi.Image = value;
        }

        [Description("KOi Haftalik Image"), Category("IBKS")]
        public Image LastWashWeekKoiImage
        {
            get => LabelLastWashWeekKoi.Image;
            set => LabelLastWashWeekKoi.Image = value;
        }

        [Description("pH Haftalik Image"), Category("IBKS")]
        public Image LastWashWeekPhImage
        {
            get => LabelLastWashWeekPh.Image;
            set => LabelLastWashWeekPh.Image = value;
        }

        [Description("Sıcaklık Haftalik Image"), Category("IBKS")]
        public Image LastWashWeekSicaklikImage
        {
            get => LabelLastWashWeekSicaklik.Image;
            set => LabelLastWashWeekSicaklik.Image = value;
        }

        [Description("İletkenlik Haftalik Image"), Category("IBKS")]
        public Image LastWashWeekIletkenlikImage
        {
            get => LabelLastWashWeekIletkenlik.Image;
            set => LabelLastWashWeekIletkenlik.Image = value;
        }

        [Description("DesarjDebi Haftalik Image"), Category("IBKS")]
        public Image LastWashWeekDesarjDebiImage
        {
            get => LabelLastWashWeekDesarjDebi.Image;
            set => LabelLastWashWeekDesarjDebi.Image = value;
        }

        [Description("HariciDebi Haftalik Image"), Category("IBKS")]
        public Image LastWashWeekHariciDebiImage
        {
            get => LabelLastWashWeekHariciDebi.Image;
            set => LabelLastWashWeekHariciDebi.Image = value;
        }

        [Description("HariciDebi2 Haftalik Image"), Category("IBKS")]
        public Image LastWashWeekHariciDebi2Image
        {
            get => LabelLastWashWeekHariciDebi2.Image;
            set => LabelLastWashWeekHariciDebi2.Image = value;
        }

        [Description("Ph Kalibrasyon"), Category("IBKS")]
        public string PhCalibration
        {
            get => LabelPhCalibration.Text;
            set => LabelPhCalibration.Text = value;
        }

        [Description("Ph Kalibrasyon Image"), Category("IBKS")]
        public Image PhCalibrationImage
        {
            get => LabelPhCalibration.Image;
            set => LabelPhCalibration.Image = value;
        }

        [Description("Iletkenlik Kalibrasyon"), Category("IBKS")]
        public string IletkenlikCalibration
        {
            get => LabelIletkenlikCalibration.Text;
            set => LabelIletkenlikCalibration.Text = value;
        }

        [Description("Iletkenlik Kalibrasyon Image"), Category("IBKS")]
        public Image IletkenlikCalibrationImage
        {
            get => LabelIletkenlikCalibration.Image;
            set => LabelIletkenlikCalibration.Image = value;
        }

        public StationInfoControl()
        {
            InitializeComponent();
        }
    }
}
