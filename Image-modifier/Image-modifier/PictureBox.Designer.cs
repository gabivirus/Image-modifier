
namespace Image_modifier
{
    partial class PictureBox
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Visible = new System.Windows.Forms.CheckBox();
            this.ImageGroup = new System.Windows.Forms.GroupBox();
            this.BorderGroup = new System.Windows.Forms.GroupBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ImageContainer = new System.Windows.Forms.PictureBox();
            this.Image1 = new System.Windows.Forms.RadioButton();
            this.Image2 = new System.Windows.Forms.RadioButton();
            this.ImageNone = new System.Windows.Forms.RadioButton();
            this.BorderNone = new System.Windows.Forms.RadioButton();
            this.Border2 = new System.Windows.Forms.RadioButton();
            this.Border1 = new System.Windows.Forms.RadioButton();
            this.ImageGroup.SuspendLayout();
            this.BorderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // Visible
            // 
            this.Visible.AutoSize = true;
            this.Visible.Location = new System.Drawing.Point(539, 304);
            this.Visible.Name = "Visible";
            this.Visible.Size = new System.Drawing.Size(103, 17);
            this.Visible.TabIndex = 0;
            this.Visible.Text = "Visível/Invisível";
            this.Visible.UseVisualStyleBackColor = true;
            this.Visible.CheckedChanged += new System.EventHandler(this.Visible_CheckedChanged);
            // 
            // ImageGroup
            // 
            this.ImageGroup.Controls.Add(this.ImageNone);
            this.ImageGroup.Controls.Add(this.Image2);
            this.ImageGroup.Controls.Add(this.Image1);
            this.ImageGroup.Location = new System.Drawing.Point(12, 295);
            this.ImageGroup.Name = "ImageGroup";
            this.ImageGroup.Size = new System.Drawing.Size(249, 143);
            this.ImageGroup.TabIndex = 1;
            this.ImageGroup.TabStop = false;
            this.ImageGroup.Text = "Imagens";
            // 
            // BorderGroup
            // 
            this.BorderGroup.Controls.Add(this.BorderNone);
            this.BorderGroup.Controls.Add(this.Border2);
            this.BorderGroup.Controls.Add(this.Border1);
            this.BorderGroup.Location = new System.Drawing.Point(267, 295);
            this.BorderGroup.Name = "BorderGroup";
            this.BorderGroup.Size = new System.Drawing.Size(249, 143);
            this.BorderGroup.TabIndex = 1;
            this.BorderGroup.TabStop = false;
            this.BorderGroup.Text = "Bordas";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(539, 328);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(249, 110);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Sair";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ImageContainer
            // 
            this.ImageContainer.Location = new System.Drawing.Point(12, 12);
            this.ImageContainer.Name = "ImageContainer";
            this.ImageContainer.Size = new System.Drawing.Size(775, 277);
            this.ImageContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageContainer.TabIndex = 3;
            this.ImageContainer.TabStop = false;
            // 
            // Image1
            // 
            this.Image1.AutoSize = true;
            this.Image1.Location = new System.Drawing.Point(7, 33);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(58, 17);
            this.Image1.TabIndex = 0;
            this.Image1.TabStop = true;
            this.Image1.Text = "Python";
            this.Image1.UseVisualStyleBackColor = true;
            this.Image1.CheckedChanged += new System.EventHandler(this.Image1_CheckedChanged);
            // 
            // Image2
            // 
            this.Image2.AutoSize = true;
            this.Image2.Location = new System.Drawing.Point(7, 56);
            this.Image2.Name = "Image2";
            this.Image2.Size = new System.Drawing.Size(75, 17);
            this.Image2.TabIndex = 0;
            this.Image2.TabStop = true;
            this.Image2.Text = "JavaScript";
            this.Image2.UseVisualStyleBackColor = true;
            this.Image2.CheckedChanged += new System.EventHandler(this.Image2_CheckedChanged);
            // 
            // ImageNone
            // 
            this.ImageNone.AutoSize = true;
            this.ImageNone.Location = new System.Drawing.Point(7, 79);
            this.ImageNone.Name = "ImageNone";
            this.ImageNone.Size = new System.Drawing.Size(85, 17);
            this.ImageNone.TabIndex = 0;
            this.ImageNone.TabStop = true;
            this.ImageNone.Text = "radioButton1";
            this.ImageNone.UseVisualStyleBackColor = true;
            this.ImageNone.CheckedChanged += new System.EventHandler(this.ImageNone_CheckedChanged);
            // 
            // BorderNone
            // 
            this.BorderNone.AutoSize = true;
            this.BorderNone.Location = new System.Drawing.Point(6, 79);
            this.BorderNone.Name = "BorderNone";
            this.BorderNone.Size = new System.Drawing.Size(77, 17);
            this.BorderNone.TabIndex = 1;
            this.BorderNone.TabStop = true;
            this.BorderNone.Text = "Sem Borda";
            this.BorderNone.UseVisualStyleBackColor = true;
            this.BorderNone.CheckedChanged += new System.EventHandler(this.BorderNone_CheckedChanged);
            // 
            // Border2
            // 
            this.Border2.AutoSize = true;
            this.Border2.Location = new System.Drawing.Point(6, 56);
            this.Border2.Name = "Border2";
            this.Border2.Size = new System.Drawing.Size(70, 17);
            this.Border2.TabIndex = 2;
            this.Border2.TabStop = true;
            this.Border2.Text = "Borda 3D";
            this.Border2.UseVisualStyleBackColor = true;
            this.Border2.CheckedChanged += new System.EventHandler(this.Border2_CheckedChanged);
            // 
            // Border1
            // 
            this.Border1.AutoSize = true;
            this.Border1.Location = new System.Drawing.Point(6, 33);
            this.Border1.Name = "Border1";
            this.Border1.Size = new System.Drawing.Size(92, 17);
            this.Border1.TabIndex = 3;
            this.Border1.TabStop = true;
            this.Border1.Text = "Borda Simples";
            this.Border1.UseVisualStyleBackColor = true;
            this.Border1.CheckedChanged += new System.EventHandler(this.Border1_CheckedChanged);
            // 
            // PictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImageContainer);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Visible);
            this.Controls.Add(this.BorderGroup);
            this.Controls.Add(this.ImageGroup);
            this.Name = "PictureBox";
            this.Text = "PictureBox";
            this.ImageGroup.ResumeLayout(false);
            this.ImageGroup.PerformLayout();
            this.BorderGroup.ResumeLayout(false);
            this.BorderGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Visible;
        private System.Windows.Forms.GroupBox ImageGroup;
        private System.Windows.Forms.RadioButton ImageNone;
        private System.Windows.Forms.RadioButton Image2;
        private System.Windows.Forms.RadioButton Image1;
        private System.Windows.Forms.GroupBox BorderGroup;
        private System.Windows.Forms.RadioButton BorderNone;
        private System.Windows.Forms.RadioButton Border2;
        private System.Windows.Forms.RadioButton Border1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox ImageContainer;
    }
}

