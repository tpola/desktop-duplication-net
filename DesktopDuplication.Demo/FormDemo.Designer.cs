namespace DesktopDuplication.Demo
{
    partial class FormDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UpdatedRegion = new System.Windows.Forms.Label();
            this.MovedRegion = new System.Windows.Forms.Label();
            this.LabelCursor = new System.Windows.Forms.Label();
            this.timerDXGI = new System.Windows.Forms.Timer(this.components);
            this.timerGDI = new System.Windows.Forms.Timer(this.components);
            this.timerStat = new System.Windows.Forms.Timer(this.components);
            this.labelStat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdatedRegion
            // 
            this.UpdatedRegion.BackColor = System.Drawing.Color.Orange;
            this.UpdatedRegion.Location = new System.Drawing.Point(37, 109);
            this.UpdatedRegion.Name = "UpdatedRegion";
            this.UpdatedRegion.Size = new System.Drawing.Size(1, 1);
            this.UpdatedRegion.TabIndex = 0;
            // 
            // MovedRegion
            // 
            this.MovedRegion.BackColor = System.Drawing.Color.Purple;
            this.MovedRegion.Location = new System.Drawing.Point(308, 215);
            this.MovedRegion.Name = "MovedRegion";
            this.MovedRegion.Size = new System.Drawing.Size(1, 1);
            this.MovedRegion.TabIndex = 1;
            // 
            // LabelCursor
            // 
            this.LabelCursor.BackColor = System.Drawing.Color.Red;
            this.LabelCursor.Location = new System.Drawing.Point(141, 97);
            this.LabelCursor.Name = "LabelCursor";
            this.LabelCursor.Size = new System.Drawing.Size(15, 15);
            this.LabelCursor.TabIndex = 2;
            // 
            // timerDXGI
            // 
            this.timerDXGI.Interval = 10;
            this.timerDXGI.Tick += new System.EventHandler(this.TimerDXGI_Tick);
            // 
            // timerGDI
            // 
            this.timerGDI.Interval = 50;
            this.timerGDI.Tick += new System.EventHandler(this.TimerGDI_Tick);
            // 
            // timerStat
            // 
            this.timerStat.Enabled = true;
            this.timerStat.Interval = 1000;
            this.timerStat.Tick += new System.EventHandler(this.TimerStat_Tick);
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Location = new System.Drawing.Point(12, 9);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(35, 13);
            this.labelStat.TabIndex = 3;
            this.labelStat.Text = "label1";
            // 
            // FormDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 431);
            this.Controls.Add(this.labelStat);
            this.Controls.Add(this.LabelCursor);
            this.Controls.Add(this.MovedRegion);
            this.Controls.Add(this.UpdatedRegion);
            this.DoubleBuffered = true;
            this.Name = "FormDemo";
            this.Text = "Desktop Duplication API Demo";
            this.Shown += new System.EventHandler(this.FormDemo_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpdatedRegion;
        private System.Windows.Forms.Label MovedRegion;
        private System.Windows.Forms.Label LabelCursor;
        private System.Windows.Forms.Timer timerDXGI;
        private System.Windows.Forms.Timer timerGDI;
        private System.Windows.Forms.Timer timerStat;
        private System.Windows.Forms.Label labelStat;
    }
}

