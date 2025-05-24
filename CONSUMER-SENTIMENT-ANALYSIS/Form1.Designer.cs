namespace CONSUMER_SENTIMENT_ANALYSIS
{
    public partial class Form1 : Form

    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtBoxResponse = new TextBox();
            bttnEnter = new Button();
            picBoxBad = new PictureBox();
            picBoxAverage = new PictureBox();
            picBoxGood = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBoxBad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAverage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxGood).BeginInit();
            SuspendLayout();
            // 
            // txtBoxResponse
            // 
            txtBoxResponse.Location = new Point(356, 529);
            txtBoxResponse.Multiline = true;
            txtBoxResponse.Name = "txtBoxResponse";
            txtBoxResponse.Size = new Size(427, 57);
            txtBoxResponse.TabIndex = 1;
            // 
            // bttnEnter
            // 
            bttnEnter.Location = new Point(520, 612);
            bttnEnter.Name = "bttnEnter";
            bttnEnter.Size = new Size(94, 29);
            bttnEnter.TabIndex = 0;
            bttnEnter.Text = "button1";
            bttnEnter.UseVisualStyleBackColor = true;
            bttnEnter.Click += bttnEnter_Click_1;
            // 
            // picBoxBad
            // 
            picBoxBad.Image = (Image)resources.GetObject("picBoxBad.Image");
            picBoxBad.Location = new Point(283, 54);
            picBoxBad.Name = "picBoxBad";
            picBoxBad.Size = new Size(562, 444);
            picBoxBad.SizeMode = PictureBoxSizeMode.AutoSize;
            picBoxBad.TabIndex = 3;
            picBoxBad.TabStop = false;
            // 
            // picBoxAverage
            // 
            picBoxAverage.Image = (Image)resources.GetObject("picBoxAverage.Image");
            picBoxAverage.Location = new Point(288, 50);
            picBoxAverage.Name = "picBoxAverage";
            picBoxAverage.Size = new Size(557, 448);
            picBoxAverage.SizeMode = PictureBoxSizeMode.AutoSize;
            picBoxAverage.TabIndex = 2;
            picBoxAverage.TabStop = false;
            // 
            // picBoxGood
            // 
            picBoxGood.Image = (Image)resources.GetObject("picBoxGood.Image");
            picBoxGood.Location = new Point(288, 45);
            picBoxGood.Name = "picBoxGood";
            picBoxGood.Size = new Size(551, 453);
            picBoxGood.SizeMode = PictureBoxSizeMode.AutoSize;
            picBoxGood.TabIndex = 4;
            picBoxGood.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1080, 687);
            Controls.Add(txtBoxResponse);
            Controls.Add(bttnEnter);
            Controls.Add(picBoxAverage);
            Controls.Add(picBoxGood);
            Controls.Add(picBoxBad);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBoxBad).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAverage).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxGood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnEnter;
        private TextBox txtBoxResponse;
        private PictureBox picBoxAverage;
        private PictureBox picBoxBad;
        private PictureBox picBoxGood;
    }
}
