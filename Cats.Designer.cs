namespace Кот
{
    partial class Cats
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
            this.DianaButton = new System.Windows.Forms.Button();
            this.DianaPicture = new System.Windows.Forms.PictureBox();
            this.BigCatPicture = new System.Windows.Forms.PictureBox();
            this.CatPicture = new System.Windows.Forms.PictureBox();
            this.LittleCatPicture = new System.Windows.Forms.PictureBox();
            this.BigCatButton = new System.Windows.Forms.Button();
            this.LittleCatButton = new System.Windows.Forms.Button();
            this.NormalCatButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DianaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigCatPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LittleCatPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.DianaButton);
            this.panel1.Controls.Add(this.DianaPicture);
            this.panel1.Controls.Add(this.BigCatPicture);
            this.panel1.Controls.Add(this.CatPicture);
            this.panel1.Controls.Add(this.LittleCatPicture);
            this.panel1.Controls.Add(this.BigCatButton);
            this.panel1.Controls.Add(this.LittleCatButton);
            this.panel1.Controls.Add(this.NormalCatButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 327);
            this.panel1.TabIndex = 0;
            // 
            // DianaButton
            // 
            this.DianaButton.BackColor = System.Drawing.Color.White;
            this.DianaButton.Location = new System.Drawing.Point(91, 227);
            this.DianaButton.Name = "DianaButton";
            this.DianaButton.Size = new System.Drawing.Size(224, 60);
            this.DianaButton.TabIndex = 2;
            this.DianaButton.Text = "Как мяукает Диана";
            this.DianaButton.UseVisualStyleBackColor = false;
            this.DianaButton.Click += new System.EventHandler(this.DianaButton_CLick);
            // 
            // DianaPicture
            // 
            this.DianaPicture.Location = new System.Drawing.Point(25, 227);
            this.DianaPicture.Name = "DianaPicture";
            this.DianaPicture.Size = new System.Drawing.Size(60, 60);
            this.DianaPicture.TabIndex = 6;
            this.DianaPicture.TabStop = false;
            // 
            // BigCatPicture
            // 
            this.BigCatPicture.Location = new System.Drawing.Point(25, 161);
            this.BigCatPicture.Name = "BigCatPicture";
            this.BigCatPicture.Size = new System.Drawing.Size(60, 60);
            this.BigCatPicture.TabIndex = 6;
            this.BigCatPicture.TabStop = false;
            // 
            // CatPicture
            // 
            this.CatPicture.Location = new System.Drawing.Point(24, 29);
            this.CatPicture.Name = "CatPicture";
            this.CatPicture.Size = new System.Drawing.Size(60, 60);
            this.CatPicture.TabIndex = 5;
            this.CatPicture.TabStop = false;
            // 
            // LittleCatPicture
            // 
            this.LittleCatPicture.Location = new System.Drawing.Point(24, 95);
            this.LittleCatPicture.Name = "LittleCatPicture";
            this.LittleCatPicture.Size = new System.Drawing.Size(60, 60);
            this.LittleCatPicture.TabIndex = 4;
            this.LittleCatPicture.TabStop = false;
            // 
            // BigCatButton
            // 
            this.BigCatButton.BackColor = System.Drawing.Color.White;
            this.BigCatButton.Location = new System.Drawing.Point(90, 161);
            this.BigCatButton.Name = "BigCatButton";
            this.BigCatButton.Size = new System.Drawing.Size(224, 60);
            this.BigCatButton.TabIndex = 2;
            this.BigCatButton.Text = "Как мяукает большой кот";
            this.BigCatButton.UseVisualStyleBackColor = false;
            this.BigCatButton.Click += new System.EventHandler(this.BigCatButton_Click);
            // 
            // LittleCatButton
            // 
            this.LittleCatButton.BackColor = System.Drawing.Color.White;
            this.LittleCatButton.Location = new System.Drawing.Point(91, 95);
            this.LittleCatButton.Name = "LittleCatButton";
            this.LittleCatButton.Size = new System.Drawing.Size(224, 60);
            this.LittleCatButton.TabIndex = 1;
            this.LittleCatButton.Text = "Как мяукает котенок";
            this.LittleCatButton.UseVisualStyleBackColor = false;
            this.LittleCatButton.Click += new System.EventHandler(this.LittleCatButton_Click);
            // 
            // NormalCatButton
            // 
            this.NormalCatButton.BackColor = System.Drawing.Color.White;
            this.NormalCatButton.Location = new System.Drawing.Point(90, 29);
            this.NormalCatButton.Name = "NormalCatButton";
            this.NormalCatButton.Size = new System.Drawing.Size(224, 60);
            this.NormalCatButton.TabIndex = 0;
            this.NormalCatButton.Text = "Как мяукает обычный кот";
            this.NormalCatButton.UseVisualStyleBackColor = false;
            this.NormalCatButton.Click += new System.EventHandler(this.NormalCatButton_Click);
            // 
            // Cats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 327);
            this.Controls.Add(this.panel1);
            this.Name = "Cats";
            this.Text = "Как мяукают коты?";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DianaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigCatPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LittleCatPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        
        private System.Windows.Forms.PictureBox LittleCatPicture;
        private System.Windows.Forms.PictureBox BigCatPicture;
        private System.Windows.Forms.PictureBox CatPicture;
        private System.Windows.Forms.Button NormalCatButton;
        private System.Windows.Forms.Button LittleCatButton;
        private System.Windows.Forms.Button BigCatButton;
        private System.Windows.Forms.Button DianaButton;
        private System.Windows.Forms.PictureBox DianaPicture;
    }
}