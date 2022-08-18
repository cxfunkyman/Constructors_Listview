namespace Constructors_Listview.GUI
{
    partial class FormEmployee2
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
            this.labelLastNameemp = new System.Windows.Forms.Label();
            this.labelFirstNameemp = new System.Windows.Forms.Label();
            this.EmployeeIDemp = new System.Windows.Forms.Label();
            this.listViewemp = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListemp = new System.Windows.Forms.Button();
            this.btnAddemp = new System.Windows.Forms.Button();
            this.textBoxLastNameemp = new System.Windows.Forms.TextBox();
            this.textBoxFirstNameemp = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeIDemp = new System.Windows.Forms.TextBox();
            this.btnListForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLastNameemp
            // 
            this.labelLastNameemp.AutoSize = true;
            this.labelLastNameemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastNameemp.Location = new System.Drawing.Point(367, 17);
            this.labelLastNameemp.Name = "labelLastNameemp";
            this.labelLastNameemp.Size = new System.Drawing.Size(99, 24);
            this.labelLastNameemp.TabIndex = 17;
            this.labelLastNameemp.Text = "Last Name";
            // 
            // labelFirstNameemp
            // 
            this.labelFirstNameemp.AutoSize = true;
            this.labelFirstNameemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstNameemp.Location = new System.Drawing.Point(188, 17);
            this.labelFirstNameemp.Name = "labelFirstNameemp";
            this.labelFirstNameemp.Size = new System.Drawing.Size(101, 24);
            this.labelFirstNameemp.TabIndex = 16;
            this.labelFirstNameemp.Text = "First Name";
            // 
            // EmployeeIDemp
            // 
            this.EmployeeIDemp.AutoSize = true;
            this.EmployeeIDemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDemp.Location = new System.Drawing.Point(10, 17);
            this.EmployeeIDemp.Name = "EmployeeIDemp";
            this.EmployeeIDemp.Size = new System.Drawing.Size(118, 24);
            this.EmployeeIDemp.TabIndex = 15;
            this.EmployeeIDemp.Text = "Employee ID";
            // 
            // listViewemp
            // 
            this.listViewemp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewemp.HideSelection = false;
            this.listViewemp.Location = new System.Drawing.Point(15, 102);
            this.listViewemp.Name = "listViewemp";
            this.listViewemp.Size = new System.Drawing.Size(525, 423);
            this.listViewemp.TabIndex = 14;
            this.listViewemp.UseCompatibleStateImageBehavior = false;
            this.listViewemp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "EmployeeI ID";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 199;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 202;
            // 
            // btnListemp
            // 
            this.btnListemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListemp.Location = new System.Drawing.Point(552, 102);
            this.btnListemp.Name = "btnListemp";
            this.btnListemp.Size = new System.Drawing.Size(94, 36);
            this.btnListemp.TabIndex = 13;
            this.btnListemp.Text = "Search";
            this.btnListemp.UseVisualStyleBackColor = true;
            this.btnListemp.Click += new System.EventHandler(this.btnListemp_Click);
            // 
            // btnAddemp
            // 
            this.btnAddemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddemp.Location = new System.Drawing.Point(552, 44);
            this.btnAddemp.Name = "btnAddemp";
            this.btnAddemp.Size = new System.Drawing.Size(94, 36);
            this.btnAddemp.TabIndex = 12;
            this.btnAddemp.Text = "Save";
            this.btnAddemp.UseVisualStyleBackColor = true;
            this.btnAddemp.Click += new System.EventHandler(this.btnAddemp_Click);
            // 
            // textBoxLastNameemp
            // 
            this.textBoxLastNameemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastNameemp.Location = new System.Drawing.Point(371, 44);
            this.textBoxLastNameemp.Name = "textBoxLastNameemp";
            this.textBoxLastNameemp.Size = new System.Drawing.Size(169, 29);
            this.textBoxLastNameemp.TabIndex = 11;
            // 
            // textBoxFirstNameemp
            // 
            this.textBoxFirstNameemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstNameemp.Location = new System.Drawing.Point(192, 44);
            this.textBoxFirstNameemp.Name = "textBoxFirstNameemp";
            this.textBoxFirstNameemp.Size = new System.Drawing.Size(169, 29);
            this.textBoxFirstNameemp.TabIndex = 10;
            // 
            // textBoxEmployeeIDemp
            // 
            this.textBoxEmployeeIDemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeIDemp.Location = new System.Drawing.Point(14, 44);
            this.textBoxEmployeeIDemp.Name = "textBoxEmployeeIDemp";
            this.textBoxEmployeeIDemp.Size = new System.Drawing.Size(169, 29);
            this.textBoxEmployeeIDemp.TabIndex = 9;
            // 
            // btnListForm
            // 
            this.btnListForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListForm.Location = new System.Drawing.Point(552, 164);
            this.btnListForm.Name = "btnListForm";
            this.btnListForm.Size = new System.Drawing.Size(94, 59);
            this.btnListForm.TabIndex = 18;
            this.btnListForm.Text = "List Form";
            this.btnListForm.UseVisualStyleBackColor = true;
            this.btnListForm.Click += new System.EventHandler(this.btnListForm_Click);
            // 
            // FormEmployee2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 542);
            this.Controls.Add(this.btnListForm);
            this.Controls.Add(this.labelLastNameemp);
            this.Controls.Add(this.labelFirstNameemp);
            this.Controls.Add(this.EmployeeIDemp);
            this.Controls.Add(this.listViewemp);
            this.Controls.Add(this.btnListemp);
            this.Controls.Add(this.btnAddemp);
            this.Controls.Add(this.textBoxLastNameemp);
            this.Controls.Add(this.textBoxFirstNameemp);
            this.Controls.Add(this.textBoxEmployeeIDemp);
            this.Name = "FormEmployee2";
            this.Text = "FormEmployee2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLastNameemp;
        private System.Windows.Forms.Label labelFirstNameemp;
        private System.Windows.Forms.Label EmployeeIDemp;
        private System.Windows.Forms.ListView listViewemp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnListemp;
        private System.Windows.Forms.Button btnAddemp;
        private System.Windows.Forms.TextBox textBoxLastNameemp;
        private System.Windows.Forms.TextBox textBoxFirstNameemp;
        private System.Windows.Forms.TextBox textBoxEmployeeIDemp;
        private System.Windows.Forms.Button btnListForm;
    }
}