
namespace DataGridVİewCellTypes
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
            this.dataGridViewExamine = new System.Windows.Forms.DataGridView();
            this.textboxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonName = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CheckBoxName = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Doldur = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExamine
            // 
            this.dataGridViewExamine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExamine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textboxName,
            this.ButtonName,
            this.CheckBoxName});
            this.dataGridViewExamine.Location = new System.Drawing.Point(248, 12);
            this.dataGridViewExamine.Name = "dataGridViewExamine";
            this.dataGridViewExamine.Size = new System.Drawing.Size(345, 70);
            this.dataGridViewExamine.TabIndex = 0;
            this.dataGridViewExamine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textboxName
            // 
            this.textboxName.HeaderText = "textboxHeaderText";
            this.textboxName.Name = "textboxName";
            // 
            // ButtonName
            // 
            this.ButtonName.HeaderText = "ButtonHeaderText";
            this.ButtonName.Name = "ButtonName";
            // 
            // CheckBoxName
            // 
            this.CheckBoxName.HeaderText = "CheclHeaderText";
            this.CheckBoxName.Name = "CheckBoxName";
            // 
            // Doldur
            // 
            this.Doldur.Location = new System.Drawing.Point(248, 97);
            this.Doldur.Name = "Doldur";
            this.Doldur.Size = new System.Drawing.Size(275, 23);
            this.Doldur.TabIndex = 1;
            this.Doldur.Text = "Doldur";
            this.Doldur.UseVisualStyleBackColor = true;
            this.Doldur.Click += new System.EventHandler(this.Doldur_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Doldur);
            this.Controls.Add(this.dataGridViewExamine);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExamine;
        private System.Windows.Forms.DataGridViewTextBoxColumn textboxName;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxName;
        private System.Windows.Forms.Button Doldur;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

