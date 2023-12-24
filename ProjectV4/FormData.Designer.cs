
namespace ProjectV4
{
    partial class FormData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormData));
            this.dataGridViewLibGenre = new System.Windows.Forms.DataGridView();
            this.buttonLoadGenre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLibGenre
            // 
            this.dataGridViewLibGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibGenre.Location = new System.Drawing.Point(323, 0);
            this.dataGridViewLibGenre.Name = "dataGridViewLibGenre";
            this.dataGridViewLibGenre.Size = new System.Drawing.Size(740, 171);
            this.dataGridViewLibGenre.TabIndex = 0;
            // 
            // buttonLoadGenre
            // 
            this.buttonLoadGenre.FlatAppearance.BorderSize = 0;
            this.buttonLoadGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadGenre.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadGenre.Location = new System.Drawing.Point(58, 61);
            this.buttonLoadGenre.Name = "buttonLoadGenre";
            this.buttonLoadGenre.Size = new System.Drawing.Size(204, 40);
            this.buttonLoadGenre.TabIndex = 1;
            this.buttonLoadGenre.Text = "Загрузить жанры";
            this.buttonLoadGenre.UseVisualStyleBackColor = true;
            this.buttonLoadGenre.Click += new System.EventHandler(this.buttonLoadGenre_Click);
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(1061, 656);
            this.Controls.Add(this.buttonLoadGenre);
            this.Controls.Add(this.dataGridViewLibGenre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormData";
            this.Text = "Библиотека";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLibGenre;
        private System.Windows.Forms.Button buttonLoadGenre;
    }
}