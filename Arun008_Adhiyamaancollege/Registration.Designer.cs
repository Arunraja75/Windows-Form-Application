namespace Arun008_Adhiyamaancollege
{
    partial class txt_RegistrationForm
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
            this.txt_Registration = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.Address_txt = new System.Windows.Forms.Label();
            this.txt_Female = new System.Windows.Forms.RadioButton();
            this.txt_Male = new System.Windows.Forms.RadioButton();
            this.txt_Gender = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.Label();
            this.txt_Design = new System.Windows.Forms.TextBox();
            this.design_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.Surname_txt = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.Label();
            this.txt_Save = new System.Windows.Forms.Button();
            this.operations_txt = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Delete = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_Registration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.operations_txt.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Registration
            // 
            this.txt_Registration.Controls.Add(this.dataGridView1);
            this.txt_Registration.Controls.Add(this.txt_Address);
            this.txt_Registration.Controls.Add(this.Address_txt);
            this.txt_Registration.Controls.Add(this.txt_Female);
            this.txt_Registration.Controls.Add(this.txt_Male);
            this.txt_Registration.Controls.Add(this.txt_Gender);
            this.txt_Registration.Controls.Add(this.txt_id);
            this.txt_Registration.Controls.Add(this.id_txt);
            this.txt_Registration.Controls.Add(this.txt_Email);
            this.txt_Registration.Controls.Add(this.email_txt);
            this.txt_Registration.Controls.Add(this.txt_Design);
            this.txt_Registration.Controls.Add(this.design_txt);
            this.txt_Registration.Controls.Add(this.label1);
            this.txt_Registration.Controls.Add(this.label2);
            this.txt_Registration.Controls.Add(this.txt_Surname);
            this.txt_Registration.Controls.Add(this.Surname_txt);
            this.txt_Registration.Controls.Add(this.txt_Name);
            this.txt_Registration.Controls.Add(this.name_txt);
            this.txt_Registration.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Registration.Location = new System.Drawing.Point(16, 12);
            this.txt_Registration.Name = "txt_Registration";
            this.txt_Registration.Size = new System.Drawing.Size(652, 514);
            this.txt_Registration.TabIndex = 0;
            this.txt_Registration.TabStop = false;
            this.txt_Registration.Text = "Registration";
            this.txt_Registration.Enter += new System.EventHandler(this.registration_txt_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 186);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(83, 245);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(545, 60);
            this.txt_Address.TabIndex = 17;
            this.txt_Address.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            // 
            // Address_txt
            // 
            this.Address_txt.AutoSize = true;
            this.Address_txt.Location = new System.Drawing.Point(-1, 260);
            this.Address_txt.Name = "Address_txt";
            this.Address_txt.Size = new System.Drawing.Size(90, 22);
            this.Address_txt.TabIndex = 16;
            this.Address_txt.Text = "Address:";
            this.Address_txt.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_Female
            // 
            this.txt_Female.AutoSize = true;
            this.txt_Female.Location = new System.Drawing.Point(505, 170);
            this.txt_Female.Name = "txt_Female";
            this.txt_Female.Size = new System.Drawing.Size(88, 26);
            this.txt_Female.TabIndex = 15;
            this.txt_Female.TabStop = true;
            this.txt_Female.Text = "Female";
            this.txt_Female.UseVisualStyleBackColor = true;
            this.txt_Female.CheckedChanged += new System.EventHandler(this.Female_txt_CheckedChanged);
            // 
            // txt_Male
            // 
            this.txt_Male.AutoSize = true;
            this.txt_Male.Location = new System.Drawing.Point(412, 171);
            this.txt_Male.Name = "txt_Male";
            this.txt_Male.Size = new System.Drawing.Size(68, 26);
            this.txt_Male.TabIndex = 14;
            this.txt_Male.TabStop = true;
            this.txt_Male.Text = "Male";
            this.txt_Male.UseVisualStyleBackColor = true;
            this.txt_Male.CheckedChanged += new System.EventHandler(this.male_txt_CheckedChanged);
            // 
            // txt_Gender
            // 
            this.txt_Gender.AutoSize = true;
            this.txt_Gender.Location = new System.Drawing.Point(315, 174);
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.Size = new System.Drawing.Size(80, 22);
            this.txt_Gender.TabIndex = 13;
            this.txt_Gender.Text = "Gender:";
            this.txt_Gender.Click += new System.EventHandler(this.gender_txt_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(91, 172);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(208, 31);
            this.txt_id.TabIndex = 12;
            this.txt_id.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // id_txt
            // 
            this.id_txt.AutoSize = true;
            this.id_txt.Location = new System.Drawing.Point(9, 175);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(40, 22);
            this.id_txt.TabIndex = 11;
            this.id_txt.Text = "ID:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(400, 105);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(238, 31);
            this.txt_Email.TabIndex = 10;
            this.txt_Email.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // email_txt
            // 
            this.email_txt.AutoSize = true;
            this.email_txt.Location = new System.Drawing.Point(315, 111);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(70, 22);
            this.email_txt.TabIndex = 9;
            this.email_txt.Text = "Email:";
            this.email_txt.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_Design
            // 
            this.txt_Design.Location = new System.Drawing.Point(91, 108);
            this.txt_Design.Multiline = true;
            this.txt_Design.Name = "txt_Design";
            this.txt_Design.Size = new System.Drawing.Size(208, 31);
            this.txt_Design.TabIndex = 8;
            this.txt_Design.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // design_txt
            // 
            this.design_txt.AutoSize = true;
            this.design_txt.Location = new System.Drawing.Point(9, 108);
            this.design_txt.Name = "design_txt";
            this.design_txt.Size = new System.Drawing.Size(80, 22);
            this.design_txt.TabIndex = 7;
            this.design_txt.Text = "Design:";
            this.design_txt.Click += new System.EventHandler(this.design_txt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 4;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(400, 42);
            this.txt_Surname.Multiline = true;
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(238, 32);
            this.txt_Surname.TabIndex = 3;
            this.txt_Surname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Surname_txt
            // 
            this.Surname_txt.AutoSize = true;
            this.Surname_txt.Location = new System.Drawing.Point(315, 45);
            this.Surname_txt.Name = "Surname_txt";
            this.Surname_txt.Size = new System.Drawing.Size(90, 22);
            this.Surname_txt.TabIndex = 2;
            this.Surname_txt.Text = "Surname:";
            this.Surname_txt.Click += new System.EventHandler(this.FName_txt_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(91, 42);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(208, 32);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // name_txt
            // 
            this.name_txt.AutoSize = true;
            this.name_txt.Location = new System.Drawing.Point(9, 45);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(60, 22);
            this.name_txt.TabIndex = 0;
            this.name_txt.Text = "Name:";
            // 
            // txt_Save
            // 
            this.txt_Save.BackColor = System.Drawing.Color.Red;
            this.txt_Save.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Save.ForeColor = System.Drawing.Color.White;
            this.txt_Save.Location = new System.Drawing.Point(7, 77);
            this.txt_Save.Name = "txt_Save";
            this.txt_Save.Size = new System.Drawing.Size(196, 72);
            this.txt_Save.TabIndex = 0;
            this.txt_Save.Text = "SAVE";
            this.txt_Save.UseVisualStyleBackColor = false;
            this.txt_Save.Click += new System.EventHandler(this.save_txt_Click);
            // 
            // operations_txt
            // 
            this.operations_txt.Controls.Add(this.button1);
            this.operations_txt.Controls.Add(this.txt_Delete);
            this.operations_txt.Controls.Add(this.txt_Save);
            this.operations_txt.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operations_txt.Location = new System.Drawing.Point(674, 38);
            this.operations_txt.Name = "operations_txt";
            this.operations_txt.Size = new System.Drawing.Size(203, 471);
            this.operations_txt.TabIndex = 1;
            this.operations_txt.TabStop = false;
            this.operations_txt.Text = "Operations";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 72);
            this.button1.TabIndex = 3;
            this.button1.Text = "EXPORT IN EXCEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Delete
            // 
            this.txt_Delete.BackColor = System.Drawing.Color.Red;
            this.txt_Delete.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Delete.ForeColor = System.Drawing.Color.White;
            this.txt_Delete.Location = new System.Drawing.Point(6, 173);
            this.txt_Delete.Name = "txt_Delete";
            this.txt_Delete.Size = new System.Drawing.Size(196, 72);
            this.txt_Delete.TabIndex = 2;
            this.txt_Delete.Text = "DELETE";
            this.txt_Delete.UseVisualStyleBackColor = false;
            this.txt_Delete.Click += new System.EventHandler(this.txt_Delete_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(674, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 538);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.operations_txt);
            this.Controls.Add(this.txt_Registration);
            this.Name = "txt_RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.txt_Registration.ResumeLayout(false);
            this.txt_Registration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.operations_txt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txt_Registration;
        private System.Windows.Forms.Label name_txt;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.Label Surname_txt;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label design_txt;
        private System.Windows.Forms.TextBox txt_Design;
        private System.Windows.Forms.Label txt_Gender;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label id_txt;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label email_txt;
        private System.Windows.Forms.RadioButton txt_Female;
        private System.Windows.Forms.RadioButton txt_Male;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label Address_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txt_Save;
        private System.Windows.Forms.GroupBox operations_txt;
        private System.Windows.Forms.Button txt_Delete;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}