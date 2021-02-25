namespace WachtrijApp
{
    partial class FormWachtrij
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWachtrij));
            this.labelTitel = new System.Windows.Forms.Label();
            this.labelWachttijd = new System.Windows.Forms.Label();
            this.labelWachttijdMelding = new System.Windows.Forms.Label();
            this.AttractieLogo = new System.Windows.Forms.PictureBox();
            this.labelKar2 = new System.Windows.Forms.Label();
            this.labelKar1 = new System.Windows.Forms.Label();
            this.labelKar3 = new System.Windows.Forms.Label();
            this.btnStatusUpdate = new System.Windows.Forms.Button();
            this.tmrUpdateStatus = new System.Windows.Forms.Timer(this.components);
            this.btnResetStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AttractieLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitel.Location = new System.Drawing.Point(32, 43);
            this.labelTitel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(479, 88);
            this.labelTitel.TabIndex = 0;
            this.labelTitel.Text = "Debug Hero";
            this.labelTitel.Click += new System.EventHandler(this.labelTitel_Click);
            // 
            // labelWachttijd
            // 
            this.labelWachttijd.AutoSize = true;
            this.labelWachttijd.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWachttijd.Location = new System.Drawing.Point(32, 351);
            this.labelWachttijd.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelWachttijd.Name = "labelWachttijd";
            this.labelWachttijd.Size = new System.Drawing.Size(295, 63);
            this.labelWachttijd.TabIndex = 4;
            this.labelWachttijd.Text = "Wachttijd";
            // 
            // labelWachttijdMelding
            // 
            this.labelWachttijdMelding.AutoSize = true;
            this.labelWachttijdMelding.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWachttijdMelding.Location = new System.Drawing.Point(77, 415);
            this.labelWachttijdMelding.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelWachttijdMelding.Name = "labelWachttijdMelding";
            this.labelWachttijdMelding.Size = new System.Drawing.Size(208, 43);
            this.labelWachttijdMelding.TabIndex = 5;
            this.labelWachttijdMelding.Text = "0 minuten";
            // 
            // AttractieLogo
            // 
            this.AttractieLogo.ErrorImage = null;
            this.AttractieLogo.Image = ((System.Drawing.Image)(resources.GetObject("AttractieLogo.Image")));
            this.AttractieLogo.Location = new System.Drawing.Point(560, 281);
            this.AttractieLogo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AttractieLogo.Name = "AttractieLogo";
            this.AttractieLogo.Size = new System.Drawing.Size(360, 331);
            this.AttractieLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AttractieLogo.TabIndex = 6;
            this.AttractieLogo.TabStop = false;
            this.AttractieLogo.Click += new System.EventHandler(this.AttractieLogo_Click);
            // 
            // labelKar2
            // 
            this.labelKar2.AutoSize = true;
            this.labelKar2.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKar2.Location = new System.Drawing.Point(77, 207);
            this.labelKar2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelKar2.Name = "labelKar2";
            this.labelKar2.Size = new System.Drawing.Size(192, 43);
            this.labelKar2.TabIndex = 8;
            this.labelKar2.Text = "Kar 2: ...";
            // 
            // labelKar1
            // 
            this.labelKar1.AutoSize = true;
            this.labelKar1.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKar1.Location = new System.Drawing.Point(77, 162);
            this.labelKar1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelKar1.Name = "labelKar1";
            this.labelKar1.Size = new System.Drawing.Size(183, 43);
            this.labelKar1.TabIndex = 9;
            this.labelKar1.Text = "Kar 1: ...";
            // 
            // labelKar3
            // 
            this.labelKar3.AutoSize = true;
            this.labelKar3.Font = new System.Drawing.Font("Snap ITC", 9.75F);
            this.labelKar3.Location = new System.Drawing.Point(77, 248);
            this.labelKar3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelKar3.Name = "labelKar3";
            this.labelKar3.Size = new System.Drawing.Size(194, 43);
            this.labelKar3.TabIndex = 10;
            this.labelKar3.Text = "Kar 3: ...";
            // 
            // btnStatusUpdate
            // 
            this.btnStatusUpdate.Font = new System.Drawing.Font("Snap ITC", 9.75F);
            this.btnStatusUpdate.Location = new System.Drawing.Point(407, 162);
            this.btnStatusUpdate.Name = "btnStatusUpdate";
            this.btnStatusUpdate.Size = new System.Drawing.Size(164, 30);
            this.btnStatusUpdate.TabIndex = 11;
            this.btnStatusUpdate.Text = "Update Status";
            this.btnStatusUpdate.UseVisualStyleBackColor = true;
            this.btnStatusUpdate.Click += new System.EventHandler(this.btnStatusUpdate_Click);
            // 
            // tmrUpdateStatus
            // 
            this.tmrUpdateStatus.Enabled = true;
            this.tmrUpdateStatus.Interval = 10000;
            this.tmrUpdateStatus.Tick += new System.EventHandler(this.tmrUpdateStatus_Tick);
            // 
            // btnResetStatus
            // 
            this.btnResetStatus.Font = new System.Drawing.Font("Snap ITC", 9.75F);
            this.btnResetStatus.Location = new System.Drawing.Point(17, 294);
            this.btnResetStatus.Name = "btnResetStatus";
            this.btnResetStatus.Size = new System.Drawing.Size(164, 29);
            this.btnResetStatus.TabIndex = 12;
            this.btnResetStatus.Text = "Reset Status";
            this.btnResetStatus.UseVisualStyleBackColor = true;
            this.btnResetStatus.Click += new System.EventHandler(this.btnResetStatus_Click);
            // 
            // FormWachtrij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(353, 386);
            this.Controls.Add(this.btnResetStatus);
            this.Controls.Add(this.btnStatusUpdate);
            this.Controls.Add(this.labelKar3);
            this.Controls.Add(this.labelKar1);
            this.Controls.Add(this.labelKar2);
            this.Controls.Add(this.AttractieLogo);
            this.Controls.Add(this.labelWachttijdMelding);
            this.Controls.Add(this.labelWachttijd);
            this.Controls.Add(this.labelTitel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormWachtrij";
            this.Text = "Debug Hero";
            this.Load += new System.EventHandler(this.FormWachtrij_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttractieLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Label labelWachttijd;
        private System.Windows.Forms.Label labelWachttijdMelding;
        private System.Windows.Forms.PictureBox AttractieLogo;
        private System.Windows.Forms.Label labelKar2;
        private System.Windows.Forms.Label labelKar1;
        private System.Windows.Forms.Label labelKar3;
        private System.Windows.Forms.Button btnStatusUpdate;
        private System.Windows.Forms.Timer tmrUpdateStatus;
        private System.Windows.Forms.Button btnResetStatus;
    }
}

