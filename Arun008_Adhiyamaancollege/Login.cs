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
using System.Diagnostics.Eventing.Reader;

namespace Arun008_Adhiyamaancollege
{ 
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source =DESKTOP-DES2J3V;initial catalog =registration_form;Integrated Security = True;");
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_Username.Text == "" && txt_Password.Text == "") 
                {
                    MessageBox.Show("Please Enter Username and Password");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select * from Loginuser where login_Name =@Name and login_Password =@Pass", con);
                    cmd.Parameters.Add("@Name", txt_Username.Text);
                    cmd.Parameters.Add("@Pass", txt_Password.Text);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                  


                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        MessageBox.Show("You have Successfully Logged In");
                        Form1 ob = new Form1();
                        ob.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Usename and Password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
