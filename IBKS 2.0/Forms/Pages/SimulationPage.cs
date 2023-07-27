using Business.Enums;
using Business.Helpers;
using IBKS_2._0.Properties;
using IBKS_2._0.Utils;
using PLC.Sharp7;
using System.ComponentModel;

namespace IBKS_2._0.Forms.Pages
{
    public partial class SimulationPage : Form
    {
        private readonly Sharp7Service _sharp7Service = Sharp7Service.Instance;

        private readonly Bitmap _autoFrame2, _autoFrame;
        private readonly Bitmap _doorClosed, _doorOpened;
        private readonly Bitmap _systemMaintenance1;
        private readonly Bitmap _wash1, _wash2;
        private readonly Bitmap _pump1Idle, _pump2Idle;
        private readonly Bitmap _pump1Animation, _pump2Animation;
        private readonly Bitmap _waterTankEmpty, _waterTankFull;

        #region No Image-Flick

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParms = base.CreateParams;
                handleParms.ExStyle |= 0x02000000;
                return handleParms;
            }
        }

        #endregion

        public SimulationPage()
        {
            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();

            _autoFrame = Resources.system_auto1;
            _autoFrame2 = Resources.system_auto2;

            _doorClosed = Resources.door_closed;
            _doorOpened = Resources.door_opened;

            _wash1 = Resources.wash1;
            _wash2 = Resources.wash2;

            _pump1Animation = Resources.pump1_animation;
            _pump2Animation = Resources.pump2_animation;

            _pump1Idle = Resources.pump1_idle;
            _pump2Idle = Resources.pump2_idle;

            _systemMaintenance1 = Resources.system_wait;

            _waterTankEmpty = Resources.water_tank_empty;
            _waterTankFull = Resources.water_tank_full;

            this.BackgroundImage = _autoFrame;
            PanelDoor.BackgroundImage = _doorClosed;
            PictureBoxPump1.Image = _pump1Idle;
            PictureBoxPump2.Image = _pump2Idle;
            PanelWaterTank.BackgroundImage = _waterTankEmpty;
        }

        private void TimerSimulation_Tick(object sender, EventArgs e)
        {
            var bgw = new BackgroundWorker();
            bgw.DoWork += delegate
            {
                Animation();
                AssignLabelValues();
            };
            bgw.RunWorkerAsync();
        }

        private void AssignLabelValues()
        {
            LabelAkm.Text = _sharp7Service.S71200.DB41.Akm.ToString();
            LabelPh.Text = _sharp7Service.S71200.DB41.Ph.ToString();
            LabelKoi.Text = _sharp7Service.S71200.DB41.Koi.ToString();
            LabelIletkenlik.Text = _sharp7Service.S71200.DB41.Iletkenlik.ToString();
            LabelOksijen.Text = _sharp7Service.S71200.DB41.CozunmusOksijen.ToString();
            LabelAkisHizi.Text = _sharp7Service.S71200.DB41.NumuneHiz.ToString();
            LabelSicaklik.Text = _sharp7Service.S71200.DB41.KabinSicaklik.ToString();
            LabelDebi.Text = _sharp7Service.S71200.DB41.TesisDebi.ToString();
            LabelDesarjDebi.Text = _sharp7Service.S71200.DB41.DesarjDebi.ToString();
            LabelHariciDebi.Text = _sharp7Service.S71200.DB41.HariciDebi.ToString();
            LabelHariciDebi2.Text = _sharp7Service.S71200.DB41.HariciDebi2.ToString();
            LabelNem.Text = _sharp7Service.S71200.DB41.KabinNem.ToString();
            LabelFrekans.Text = ActivePump.Frekans;
            LabelAktifPompa.Text = ActivePump.Pump;
        }

        private void Animation()
        {
            //Sistem Durumu
            if (_sharp7Service.S71200?.MBTags?.ModAutoMu == true && _sharp7Service.S71200?.MBTags?.HaftalikYikamaVarMi == false && _sharp7Service.S71200?.MBTags?.YikamaVarMi == false)
            {
                FrameOperations.ChangeFormFrame(this, _autoFrame, _autoFrame2);
            }
            else if (_sharp7Service.S71200?.MBTags?.ModBakimMi == true && _sharp7Service.S71200?.MBTags?.ModKalibrasyonMu == true)
            {
                FrameOperations.ChangeFormFrame(this, _systemMaintenance1, _systemMaintenance1);
            }
            else if (_sharp7Service.S71200?.MBTags?.YikamaVarMi == true || _sharp7Service.S71200?.MBTags?.HaftalikYikamaVarMi == true)
            {
                FrameOperations.ChangeFormFrame(this, _wash1, _wash2);
            }

            //Pompa1 Durumu
            if (_sharp7Service.S71200?.InputTags.Pompa1CalisiyorMu == true)
            {
                FrameOperations.ChangePictureBoxFrame(PictureBoxPump1, _pump1Animation, _pump1Idle, PumpStatements.Working);
            }
            else
            {
                FrameOperations.ChangePictureBoxFrame(PictureBoxPump1, _pump1Animation, _pump1Idle, PumpStatements.Idle);
            }

            //Pompa2 Durumu
            if (_sharp7Service.S71200?.InputTags.Pompa2CalisiyorMu == true)
            {
                FrameOperations.ChangePictureBoxFrame(PictureBoxPump2, _pump2Animation, _pump2Idle, PumpStatements.Working);
            }
            else
            {
                FrameOperations.ChangePictureBoxFrame(PictureBoxPump2, _pump2Animation, _pump2Idle, PumpStatements.Idle);
            }

            //Kapı Durumu
            if (_sharp7Service.S71200?.InputTags.Kapi == true)
            {
                FrameOperations.ChangePanelFrame(PanelDoor, _doorOpened);
            }
            else
            {
                FrameOperations.ChangePanelFrame(PanelDoor, _doorClosed);
            }

            //Yıkama Tankı Durumu
            if (_sharp7Service.S71200?.InputTags.YikamaTanki == true)
            {
                FrameOperations.ChangePanelFrame(PanelWaterTank, _waterTankEmpty);
            }
            else
            {
                FrameOperations.ChangePanelFrame(PanelWaterTank, _waterTankFull);
            }
        }
    }
}
