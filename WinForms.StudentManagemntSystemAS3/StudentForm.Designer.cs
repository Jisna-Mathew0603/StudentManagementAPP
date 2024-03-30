namespace WinForms.StudentManagemntSystemAS3
{
    partial class StudenDetailsForm
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
            this.button1Add = new System.Windows.Forms.Button();
            this.button2edit = new System.Windows.Forms.Button();
            this.Button3Delete = new System.Windows.Forms.Button();
            this.Button4Exit = new System.Windows.Forms.Button();
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5Search = new System.Windows.Forms.Button();
            this.textboxsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Add
            // 
            this.button1Add.Location = new System.Drawing.Point(423, 688);
            this.button1Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1Add.Name = "button1Add";
            this.button1Add.Size = new System.Drawing.Size(212, 131);
            this.button1Add.TabIndex = 1;
            this.button1Add.Text = "ADD";
            this.button1Add.UseVisualStyleBackColor = true;
            this.button1Add.Click += new System.EventHandler(this.button1Add_Click);
            // 
            // button2edit
            // 
            this.button2edit.Location = new System.Drawing.Point(423, 850);
            this.button2edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2edit.Name = "button2edit";
            this.button2edit.Size = new System.Drawing.Size(212, 131);
            this.button2edit.TabIndex = 2;
            this.button2edit.Text = "EDIT";
            this.button2edit.UseVisualStyleBackColor = true;
            this.button2edit.Click += new System.EventHandler(this.button2edit_Click);
            // 
            // Button3Delete
            // 
            this.Button3Delete.Location = new System.Drawing.Point(724, 688);
            this.Button3Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button3Delete.Name = "Button3Delete";
            this.Button3Delete.Size = new System.Drawing.Size(204, 131);
            this.Button3Delete.TabIndex = 3;
            this.Button3Delete.Text = "DELETE";
            this.Button3Delete.UseVisualStyleBackColor = true;
            this.Button3Delete.Click += new System.EventHandler(this.Button3Delete_Click);
            // 
            // Button4Exit
            // 
            this.Button4Exit.Location = new System.Drawing.Point(715, 850);
            this.Button4Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button4Exit.Name = "Button4Exit";
            this.Button4Exit.Size = new System.Drawing.Size(227, 136);
            this.Button4Exit.TabIndex = 4;
            this.Button4Exit.Text = "&EXIT";
            this.Button4Exit.UseVisualStyleBackColor = true;
            this.Button4Exit.Click += new System.EventHandler(this.Button4Exit_Click);
            // 
            // StudentDataGridView
            // 
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FirstName,
            this.LastName,
            this.Age,
            this.Gender,
            this.Class,
            this.Grade});
            this.StudentDataGridView.Location = new System.Drawing.Point(30, 83);
            this.StudentDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.RowHeadersWidth = 51;
            this.StudentDataGridView.RowTemplate.Height = 24;
            this.StudentDataGridView.Size = new System.Drawing.Size(1375, 545);
            this.StudentDataGridView.TabIndex = 0;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // Class
            // 
            this.Class.HeaderText = "Class";
            this.Class.MinimumWidth = 6;
            this.Class.Name = "Class";
            this.Class.Width = 125;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.Width = 125;
            // 
            // button5Search
            // 
            this.button5Search.Location = new System.Drawing.Point(1113, 717);
            this.button5Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5Search.Name = "button5Search";
            this.button5Search.Size = new System.Drawing.Size(307, 117);
            this.button5Search.TabIndex = 6;
            this.button5Search.Text = "Search";
            this.button5Search.UseVisualStyleBackColor = true;
            this.button5Search.Click += new System.EventHandler(this.button5Search_Click);
            // 
            // textboxsearch
            // 
            this.textboxsearch.Location = new System.Drawing.Point(1458, 771);
            this.textboxsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxsearch.Name = "textboxsearch";
            this.textboxsearch.Size = new System.Drawing.Size(216, 31);
            this.textboxsearch.TabIndex = 7;
            // 
            // StudenDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1869, 1103);
            this.Controls.Add(this.textboxsearch);
            this.Controls.Add(this.button5Search);
            this.Controls.Add(this.Button4Exit);
            this.Controls.Add(this.Button3Delete);
            this.Controls.Add(this.button2edit);
            this.Controls.Add(this.button1Add);
            this.Controls.Add(this.StudentDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudenDetailsForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1Add;
        private System.Windows.Forms.Button button2edit;
        private System.Windows.Forms.Button Button3Delete;
        private System.Windows.Forms.Button Button4Exit;
        private System.Windows.Forms.DataGridView StudentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.Button button5Search;
        private System.Windows.Forms.TextBox textboxsearch;
    }
}