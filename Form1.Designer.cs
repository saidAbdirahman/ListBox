namespace ListBox
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
            this.lbxCountries = new System.Windows.Forms.ListBox();
            this.textUserdata = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnUnsort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxCountries
            // 
            this.lbxCountries.FormattingEnabled = true;
            this.lbxCountries.ItemHeight = 16;
            this.lbxCountries.Location = new System.Drawing.Point(442, 2);
            this.lbxCountries.Name = "lbxCountries";
            this.lbxCountries.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxCountries.Size = new System.Drawing.Size(337, 404);
            this.lbxCountries.TabIndex = 0;
            // 
            // textUserdata
            // 
            this.textUserdata.Location = new System.Drawing.Point(176, 27);
            this.textUserdata.Multiline = true;
            this.textUserdata.Name = "textUserdata";
            this.textUserdata.Size = new System.Drawing.Size(203, 42);
            this.textUserdata.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(211, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(211, 146);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 33);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(211, 200);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(114, 33);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnUnsort
            // 
            this.btnUnsort.Location = new System.Drawing.Point(211, 255);
            this.btnUnsort.Name = "btnUnsort";
            this.btnUnsort.Size = new System.Drawing.Size(114, 33);
            this.btnUnsort.TabIndex = 5;
            this.btnUnsort.Text = "Reverse";
            this.btnUnsort.UseVisualStyleBackColor = true;
            this.btnUnsort.Click += new System.EventHandler(this.btnUnsort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUnsort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textUserdata);
            this.Controls.Add(this.lbxCountries);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCountries;
        private System.Windows.Forms.TextBox textUserdata;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnUnsort;
    }
}

