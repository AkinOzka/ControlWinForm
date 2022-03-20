namespace ControlWinForm
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
            this.lstAllPeople = new System.Windows.Forms.ListBox();
            this.lblAllPeople = new System.Windows.Forms.Label();
            this.lstAllCountries = new System.Windows.Forms.ListBox();
            this.lstDemo = new System.Windows.Forms.ListBox();
            this.btnFilterByAge = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterByCountry = new System.Windows.Forms.Button();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAllPeople
            // 
            this.lstAllPeople.FormattingEnabled = true;
            this.lstAllPeople.ItemHeight = 20;
            this.lstAllPeople.Location = new System.Drawing.Point(12, 188);
            this.lstAllPeople.Name = "lstAllPeople";
            this.lstAllPeople.Size = new System.Drawing.Size(668, 64);
            this.lstAllPeople.TabIndex = 0;
            // 
            // lblAllPeople
            // 
            this.lblAllPeople.AutoSize = true;
            this.lblAllPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllPeople.Location = new System.Drawing.Point(12, 165);
            this.lblAllPeople.Name = "lblAllPeople";
            this.lblAllPeople.Size = new System.Drawing.Size(89, 20);
            this.lblAllPeople.TabIndex = 1;
            this.lblAllPeople.Text = "All People";
            // 
            // lstAllCountries
            // 
            this.lstAllCountries.FormattingEnabled = true;
            this.lstAllCountries.ItemHeight = 20;
            this.lstAllCountries.Location = new System.Drawing.Point(11, 258);
            this.lstAllCountries.Name = "lstAllCountries";
            this.lstAllCountries.Size = new System.Drawing.Size(668, 64);
            this.lstAllCountries.TabIndex = 2;
            // 
            // lstDemo
            // 
            this.lstDemo.FormattingEnabled = true;
            this.lstDemo.ItemHeight = 20;
            this.lstDemo.Location = new System.Drawing.Point(12, 338);
            this.lstDemo.Name = "lstDemo";
            this.lstDemo.Size = new System.Drawing.Size(668, 64);
            this.lstDemo.TabIndex = 3;
            // 
            // btnFilterByAge
            // 
            this.btnFilterByAge.Location = new System.Drawing.Point(12, 408);
            this.btnFilterByAge.Name = "btnFilterByAge";
            this.btnFilterByAge.Size = new System.Drawing.Size(147, 30);
            this.btnFilterByAge.TabIndex = 4;
            this.btnFilterByAge.Text = "Filter By Age";
            this.btnFilterByAge.UseVisualStyleBackColor = true;
            this.btnFilterByAge.Click += new System.EventHandler(this.btnFilterByAge_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(11, 136);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(663, 26);
            this.txtFilter.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Filter Criteria";
            // 
            // btnFilterByCountry
            // 
            this.btnFilterByCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterByCountry.Location = new System.Drawing.Point(193, 408);
            this.btnFilterByCountry.Name = "btnFilterByCountry";
            this.btnFilterByCountry.Size = new System.Drawing.Size(173, 30);
            this.btnFilterByCountry.TabIndex = 7;
            this.btnFilterByCountry.Text = "Filter By Country";
            this.btnFilterByCountry.UseVisualStyleBackColor = true;
            this.btnFilterByCountry.Click += new System.EventHandler(this.btnFilterByCountry_Click);
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(11, 68);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(121, 28);
            this.cmbCountry.TabIndex = 8;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Country";
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.Location = new System.Drawing.Point(413, 408);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(121, 30);
            this.btnFindPerson.TabIndex = 10;
            this.btnFindPerson.Text = "Find Person";
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.btnFindPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.btnFilterByCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnFilterByAge);
            this.Controls.Add(this.lstDemo);
            this.Controls.Add(this.lstAllCountries);
            this.Controls.Add(this.lblAllPeople);
            this.Controls.Add(this.lstAllPeople);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAllPeople;
        private System.Windows.Forms.Label lblAllPeople;
        private System.Windows.Forms.ListBox lstAllCountries;
        private System.Windows.Forms.ListBox lstDemo;
        private System.Windows.Forms.Button btnFilterByAge;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilterByCountry;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFindPerson;
    }
}

