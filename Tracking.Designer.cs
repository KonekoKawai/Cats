namespace Кот
{
    partial class Tracking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ArrowDown = new System.Windows.Forms.PictureBox();
            this.ForwardLabel = new System.Windows.Forms.Label();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.ForwardIcon = new System.Windows.Forms.PictureBox();
            this.HomeIcon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ArrowDown);
            this.panel1.Controls.Add(this.ForwardLabel);
            this.panel1.Controls.Add(this.HomeLabel);
            this.panel1.Controls.Add(this.ForwardIcon);
            this.panel1.Controls.Add(this.HomeIcon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 461);
            this.panel1.TabIndex = 0;
            // 
            // ArrowDown
            // 
            this.ArrowDown.Location = new System.Drawing.Point(225, 54);
            this.ArrowDown.Name = "ArrowDown";
            this.ArrowDown.Size = new System.Drawing.Size(32, 32);
            this.ArrowDown.TabIndex = 6;
            this.ArrowDown.TabStop = false;
            this.ArrowDown.Visible = false;
            // 
            // ForwardLabel
            // 
            this.ForwardLabel.AutoSize = true;
            this.ForwardLabel.Location = new System.Drawing.Point(260, 367);
            this.ForwardLabel.Name = "ForwardLabel";
            this.ForwardLabel.Size = new System.Drawing.Size(195, 15);
            this.ForwardLabel.TabIndex = 5;
            this.ForwardLabel.Text = "Перейти к следующему действию";
            this.ForwardLabel.Visible = false;
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Location = new System.Drawing.Point(68, 367);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(142, 15);
            this.HomeLabel.TabIndex = 4;
            this.HomeLabel.Text = "Вернутся к меню \"Коты\"";
            this.HomeLabel.Visible = false;
            // 
            // ForwardIcon
            // 
            this.ForwardIcon.Location = new System.Drawing.Point(325, 385);
            this.ForwardIcon.Name = "ForwardIcon";
            this.ForwardIcon.Size = new System.Drawing.Size(64, 64);
            this.ForwardIcon.TabIndex = 1;
            this.ForwardIcon.TabStop = false;
            this.ForwardIcon.Click += new System.EventHandler(this.ForwardIcon_Click);
            this.ForwardIcon.MouseEnter += new System.EventHandler(this.MouseEnter_Forward);
            this.ForwardIcon.MouseLeave += new System.EventHandler(this.MouseLeave_Forward);
            // 
            // HomeIcon
            // 
            this.HomeIcon.BackColor = System.Drawing.Color.White;
            this.HomeIcon.Location = new System.Drawing.Point(100, 385);
            this.HomeIcon.Name = "HomeIcon";
            this.HomeIcon.Size = new System.Drawing.Size(64, 64);
            this.HomeIcon.TabIndex = 2;
            this.HomeIcon.TabStop = false;
            this.HomeIcon.Click += new System.EventHandler(this.HomeIcon_Click);
            this.HomeIcon.MouseEnter += new System.EventHandler(this.MouseEnter_Home);
            this.HomeIcon.MouseLeave += new System.EventHandler(this.MouseLeave_Home);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(466, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Метод 4";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(466, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Метод 3";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Метод 2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Метод 1";
            // 
            // Tracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Tracking";
            this.Text = "Tracking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ForwardIcon;
        private System.Windows.Forms.PictureBox HomeIcon;
        private System.Windows.Forms.Label ForwardLabel;
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.PictureBox ArrowDown;
    }
}