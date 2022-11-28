namespace CliffordLab2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Information = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.lblTopic = new System.Windows.Forms.Label();
            this.lblDiscription = new System.Windows.Forms.Label();
            this.picMyPicture = new System.Windows.Forms.PictureBox();
            this.Multiplier = new System.Windows.Forms.GroupBox();
            this.lblAnswerTitle = new System.Windows.Forms.Label();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMyPicture)).BeginInit();
            this.Multiplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // Information
            // 
            this.Information.Controls.Add(this.btnExit);
            this.Information.Controls.Add(this.btnHide);
            this.Information.Controls.Add(this.btnData);
            this.Information.Controls.Add(this.btnPicture);
            this.Information.Controls.Add(this.lblTopic);
            this.Information.Controls.Add(this.lblDiscription);
            this.Information.Controls.Add(this.picMyPicture);
            this.Information.Location = new System.Drawing.Point(261, 12);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(446, 307);
            this.Information.TabIndex = 1;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(338, 223);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(228, 223);
            this.btnHide.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(100, 50);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "&Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(118, 223);
            this.btnData.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(100, 50);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "&Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(8, 223);
            this.btnPicture.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(100, 50);
            this.btnPicture.TabIndex = 0;
            this.btnPicture.Text = "&Print";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(147, 18);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(99, 16);
            this.lblTopic.TabIndex = 1;
            this.lblTopic.Text = "My dog Norman";
            // 
            // lblDiscription
            // 
            this.lblDiscription.Location = new System.Drawing.Point(6, 40);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(434, 177);
            this.lblDiscription.TabIndex = 4;
            this.lblDiscription.Text = "\r\n\r\nMy dogs name is norman\r\n\r\nHe enjoys belly rubs and going for walks\r\n\r\nHe is e" +
    "ight years old\r\n\r\nHe is a very good boy\r\n";
            this.lblDiscription.Visible = false;
            // 
            // picMyPicture
            // 
            this.picMyPicture.Image = ((System.Drawing.Image)(resources.GetObject("picMyPicture.Image")));
            this.picMyPicture.Location = new System.Drawing.Point(6, 40);
            this.picMyPicture.Name = "picMyPicture";
            this.picMyPicture.Size = new System.Drawing.Size(434, 177);
            this.picMyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMyPicture.TabIndex = 0;
            this.picMyPicture.TabStop = false;
            this.picMyPicture.Visible = false;
            this.picMyPicture.Click += new System.EventHandler(this.picMyPicture_Click);
            // 
            // Multiplier
            // 
            this.Multiplier.Controls.Add(this.lblAnswerTitle);
            this.Multiplier.Controls.Add(this.lblMultiplier);
            this.Multiplier.Controls.Add(this.lblNumber);
            this.Multiplier.Controls.Add(this.lblAnswer);
            this.Multiplier.Controls.Add(this.txtMultiplier);
            this.Multiplier.Controls.Add(this.txtNumber);
            this.Multiplier.Controls.Add(this.btnCalculate);
            this.Multiplier.Controls.Add(this.btnReset);
            this.Multiplier.Location = new System.Drawing.Point(12, 12);
            this.Multiplier.Name = "Multiplier";
            this.Multiplier.Size = new System.Drawing.Size(232, 307);
            this.Multiplier.TabIndex = 0;
            this.Multiplier.TabStop = false;
            this.Multiplier.Text = "Multiplier";
            // 
            // lblAnswerTitle
            // 
            this.lblAnswerTitle.AutoSize = true;
            this.lblAnswerTitle.Location = new System.Drawing.Point(24, 165);
            this.lblAnswerTitle.Name = "lblAnswerTitle";
            this.lblAnswerTitle.Size = new System.Drawing.Size(54, 16);
            this.lblAnswerTitle.TabIndex = 7;
            this.lblAnswerTitle.Text = "Answer:";
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Location = new System.Drawing.Point(24, 105);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(63, 16);
            this.lblMultiplier.TabIndex = 6;
            this.lblMultiplier.Text = "Multiplier:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(24, 40);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(56, 16);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "Number:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswer.Location = new System.Drawing.Point(94, 164);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(100, 22);
            this.lblAnswer.TabIndex = 3;
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(94, 102);
            this.txtMultiplier.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(100, 22);
            this.txtMultiplier.TabIndex = 2;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(94, 37);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(14, 222);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 50);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(124, 222);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 50);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPicture;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(719, 331);
            this.Controls.Add(this.Multiplier);
            this.Controls.Add(this.Information);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2 by Simon Clifford";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMyPicture)).EndInit();
            this.Multiplier.ResumeLayout(false);
            this.Multiplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.PictureBox picMyPicture;
        private System.Windows.Forms.GroupBox Multiplier;
        private System.Windows.Forms.Label lblAnswerTitle;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblDiscription;
    }
}

