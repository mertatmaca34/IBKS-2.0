using System.ComponentModel;

namespace IBKS_2._0.Components
{
    public partial class WashingCalibrationInfoControl : UserControl
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
            get => LabelLastWashHariciDebi2.Image;
            set => LabelLastWashHariciDebi2.Image = value;
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
        public WashingCalibrationInfoControl()
        {
            InitializeComponent();
        }
    }
}
