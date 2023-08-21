using Business.Enums;

namespace ibks.Utils
{
    public static class FrameOperations
    {
        public static void ChangePanelFrame(Panel panel, Bitmap nextFrame)
        {
            if (panel.BackgroundImage == nextFrame)
            {
                return;
            }
            else
            {
                panel.BackgroundImage = nextFrame;
            }
        }

        public static void ChangePictureBoxFrame(PictureBox pictureBox, Bitmap animation, Bitmap idle, PumpStatements pumpStatements)
        {
            if (pictureBox.Image == animation && pumpStatements == PumpStatements.Working)
            {
                return;
            }
            else if (pictureBox.Image == animation && pumpStatements == PumpStatements.Idle)
            {
                pictureBox.Image = idle;
            }
            else if (pictureBox.Image == idle && pumpStatements == PumpStatements.Idle)
            {
                return;
            }
            else if (pictureBox.Image == idle && pumpStatements == PumpStatements.Working)
            {
                pictureBox.Image = animation;
            }
        }

        public static void ChangeFormFrame(Form form, Bitmap frame1, Bitmap frame2)
        {
            if (form.BackgroundImage == frame1)
            {
                form.BackgroundImage = frame2;
            }
            else
            {
                form.BackgroundImage = frame1;
            }
        }
    }
}
