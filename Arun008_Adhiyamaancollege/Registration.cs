using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Diagnostics.Eventing.Reader;
using Microsoft.Office.Interop.Excel;

namespace Arun008_Adhiyamaancollege
{
    public partial class txt_RegistrationForm : Form
    {
        String path = @"Data source=DESKTOP-DES2J3V;Initial catalog=registration_form;Integrated security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        int ID;

        public txt_RegistrationForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            Display();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void design_txt_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FName_txt_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_txt_Click(object sender, EventArgs e)
        {

        }

        private void male_txt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Female_txt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void registration_txt_Enter(object sender, EventArgs e)
        {

        }

        internal void show()
        {
            throw new NotImplementedException();
        }

        private void save_txt_Click(object sender, EventArgs e)
        {
            if(txt_Name.Text=="" || txt_Surname.Text=="" || txt_Design.Text=="" || txt_Email.Text=="" || txt_id.Text=="" ||  txt_Address.Text=="")
            {
                MessageBox.Show("Fill in the empty field");
            }
            else 
            {
                try
                {

                    string gender;
                    if(txt_Male.Checked)
                    {
                        gender = "Male";
                    }
                   else
                    {
                        gender = "Female";
                    }
                        con.Open();
                        cmd = new SqlCommand("insert into employee (employee_Name, employee_Surname, employee_Designation, employee_email, emp_id, employee_gender, employee_address) values('"+ txt_Name.Text +"','"+ txt_Surname.Text +"','"+ txt_Design.Text +"','"+ txt_Email.Text +"','"+ txt_id.Text +"','"+ gender +"','"+ txt_Address.Text +"')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Successfully,Your data has been saved in the database");
                        Clear();
                        Display();
                }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }
        public void Clear()
        {
            txt_Name.Text ="";
            txt_Surname.Text = "";
            txt_Design.Text ="";
            txt_Email.Text = "";
            txt_id.Text = "";
            txt_Address.Text = "";
        }

        public void Display()
        {
            try
            {
                dt = new System.Data.DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from employee", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Surname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Design.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Email.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            txt_Male.Checked = true;
            txt_Female.Checked = false;

            if(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "Female")
            {
                txt_Male.Checked = false;
                txt_Female.Checked = true;
            }

            txt_Address.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

      

        private void txt_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from employee where employee_Id = '" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your data has been Deleted");
                Display();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excell = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = excell.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)excell.ActiveSheet;
                excell.Visible = true;

                for (int j = 2; j <= dataGridView1.Rows.Count; j++)
                {
                    for (int i = 1; i <= 1; i++)
                    {
                        ws.Cells[j, i] = dataGridView1.Rows[j - 2].Cells[i - 1].Value;
                    }
                }
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    ws.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;

                    }
                }
            
            }
            catch(Exception)
            {

            }

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

