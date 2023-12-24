
namespace ProjectV4
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelPhone1_SVM = new System.Windows.Forms.Panel();
            this.panelPhone2_SVM = new System.Windows.Forms.Panel();
            this.panelPhone3_SVM = new System.Windows.Forms.Panel();
            this.panelPhone4_SVM = new System.Windows.Forms.Panel();
            this.labelHello_SVM = new System.Windows.Forms.Label();
            this.buttonLib = new System.Windows.Forms.Button();
            this.panelPhone1_SVM.SuspendLayout();
            this.panelPhone2_SVM.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPhone1_SVM
            // 
            this.panelPhone1_SVM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(207)))));
            this.panelPhone1_SVM.Controls.Add(this.panelPhone3_SVM);
            this.panelPhone1_SVM.Controls.Add(this.panelPhone4_SVM);
            this.panelPhone1_SVM.Controls.Add(this.panelPhone2_SVM);
            this.panelPhone1_SVM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhone1_SVM.Location = new System.Drawing.Point(0, 0);
            this.panelPhone1_SVM.Name = "panelPhone1_SVM";
            this.panelPhone1_SVM.Size = new System.Drawing.Size(813, 450);
            this.panelPhone1_SVM.TabIndex = 3;
            // 
            // panelPhone2_SVM
            // 
            this.panelPhone2_SVM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(162)))));
            this.panelPhone2_SVM.Controls.Add(this.buttonLib);
            this.panelPhone2_SVM.Controls.Add(this.labelHello_SVM);
            this.panelPhone2_SVM.Location = new System.Drawing.Point(206, 3);
            this.panelPhone2_SVM.Name = "panelPhone2_SVM";
            this.panelPhone2_SVM.Size = new System.Drawing.Size(357, 438);
            this.panelPhone2_SVM.TabIndex = 0;
            // 
            // panelPhone3_SVM
            // 
            this.panelPhone3_SVM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.panelPhone3_SVM.Location = new System.Drawing.Point(75, 303);
            this.panelPhone3_SVM.Name = "panelPhone3_SVM";
            this.panelPhone3_SVM.Size = new System.Drawing.Size(171, 100);
            this.panelPhone3_SVM.TabIndex = 1;
            // 
            // panelPhone4_SVM
            // 
            this.panelPhone4_SVM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.panelPhone4_SVM.Location = new System.Drawing.Point(526, 73);
            this.panelPhone4_SVM.Name = "panelPhone4_SVM";
            this.panelPhone4_SVM.Size = new System.Drawing.Size(171, 100);
            this.panelPhone4_SVM.TabIndex = 1;
            // 
            // labelHello_SVM
            // 
            this.labelHello_SVM.AutoSize = true;
            this.labelHello_SVM.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello_SVM.Location = new System.Drawing.Point(15, 6);
            this.labelHello_SVM.Name = "labelHello_SVM";
            this.labelHello_SVM.Size = new System.Drawing.Size(337, 23);
            this.labelHello_SVM.TabIndex = 2;
            this.labelHello_SVM.Text = "Добро пожаловать  в главное меню!";
            this.labelHello_SVM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLib
            // 
            this.buttonLib.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLib.FlatAppearance.BorderSize = 0;
            this.buttonLib.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.buttonLib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLib.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLib.Location = new System.Drawing.Point(66, 181);
            this.buttonLib.Name = "buttonLib";
            this.buttonLib.Size = new System.Drawing.Size(238, 38);
            this.buttonLib.TabIndex = 3;
            this.buttonLib.Text = "Список книг";
            this.buttonLib.UseVisualStyleBackColor = true;
            this.buttonLib.Click += new System.EventHandler(this.buttonLib_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.panelPhone1_SVM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.panelPhone1_SVM.ResumeLayout(false);
            this.panelPhone2_SVM.ResumeLayout(false);
            this.panelPhone2_SVM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPhone1_SVM;
        private System.Windows.Forms.Panel panelPhone2_SVM;
        private System.Windows.Forms.Panel panelPhone3_SVM;
        private System.Windows.Forms.Panel panelPhone4_SVM;
        private System.Windows.Forms.Label labelHello_SVM;
        private System.Windows.Forms.Button buttonLib;
    }
}

