namespace DMU.Samples
{
    partial class HopfieldRec
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
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkPostProcess = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(157, 382);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(104, 32);
            this.btnTrain.TabIndex = 0;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(269, 382);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(104, 32);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(45, 382);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 32);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkPostProcess
            // 
            this.chkPostProcess.AutoSize = true;
            this.chkPostProcess.Checked = true;
            this.chkPostProcess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPostProcess.Location = new System.Drawing.Point(157, 439);
            this.chkPostProcess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPostProcess.Name = "chkPostProcess";
            this.chkPostProcess.Size = new System.Drawing.Size(113, 21);
            this.chkPostProcess.TabIndex = 3;
            this.chkPostProcess.Text = "Post Process";
            this.chkPostProcess.UseVisualStyleBackColor = true;
            // 
            // HopfieldRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 494);
            this.Controls.Add(this.chkPostProcess);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnTrain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HopfieldRec";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hopfield Test";
            this.Load += new System.EventHandler(this.HopfieldRec_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HopfieldRec_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HopfieldRec_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HopfieldRec_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkPostProcess;
    }
}