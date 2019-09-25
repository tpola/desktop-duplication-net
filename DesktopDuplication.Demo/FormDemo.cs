using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDuplication.Demo
{
    public partial class FormDemo : Form
    {
        private DesktopDuplicator desktopDuplicator;

        public FormDemo()
        {
            InitializeComponent();

            try
            {
                desktopDuplicator = new DesktopDuplicator(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void FormDemo_Shown(object sender, EventArgs e)
        {
            while (true)
            {
                Application.DoEvents();

                DesktopFrame frame = null;
                try
                {
                    frame = desktopDuplicator.GetLatestFrame();
                }
                catch
                {
                    desktopDuplicator = new DesktopDuplicator(0);
                    continue;
                }

                if (frame != null)
                {
                    LabelCursor.Location = frame.CursorLocation;
                    LabelCursor.Visible = frame.CursorVisible;
                    //Debug.WriteLine("--------------------------------------------------------");
                    //foreach (var moved in frame.MovedRegions)
                    //{
                    //    Debug.WriteLine(String.Format("Moved: {0} -> {1}", moved.Source, moved.Destination));
                    //    MovedRegion.Location = moved.Destination.Location;
                    //    MovedRegion.Size = moved.Destination.Size;
                    //}
                    //foreach (var updated in frame.UpdatedRegions)
                    //{
                    //    Debug.WriteLine(String.Format("Updated: {0}", updated.ToString()));
                    //    UpdatedRegion.Location = updated.Location;
                    //    UpdatedRegion.Size = updated.Size;
                    //}
                    this.BackgroundImage = frame.DesktopImage;
                    fps++;
                }
            }
        }


        private void TimerDXGI_Tick(object sender, EventArgs e)
        {
            var s = Stopwatch.StartNew();
            DesktopFrame frame = null;
            try
            {
                frame = desktopDuplicator.GetLatestFrame();
            }
            catch
            {
                desktopDuplicator = new DesktopDuplicator(0);
            }
            if (frame != null)
            {
                this.BackgroundImage = frame.DesktopImage;
            }
            fps++;
            tim += s.ElapsedMilliseconds;
        }




        private void TimerGDI_Tick(object sender, EventArgs e)
        {
            var s = Stopwatch.StartNew();

            var screen = Screen.AllScreens[0];
            var bounds = screen.Bounds;
            var bitmap = new Bitmap(bounds.Width, bounds.Height);

            using (var g = Graphics.FromImage(bitmap))
                g.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size);

            var prev = BackgroundImage;
            this.BackgroundImage = bitmap;
            prev?.Dispose();

            fps++;
            tim += s.ElapsedMilliseconds;
        }

        private void TimerStat_Tick(object sender, EventArgs e)
        {
            labelStat.Text = $"fps:  {fps}\ntime: {tim/fps:0.0}";
            tim = fps = 0;
        }
        int fps;
        double tim;
    }
}
