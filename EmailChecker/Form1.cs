using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailKeeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string emailId;

        private  List< string>list=new List<string>();
 
        private  bool isvalid;

        private string pattern =@"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$";
  
        private void addEmailButton_Click(object sender, EventArgs e)
        {
           

            emailId = addEmailTextBox.Text;

            isvalid = Regex.IsMatch(emailId,pattern);

            if (isvalid)
            {
                list.Add(emailId);
                addEmailListBox.Items.Add(emailId);
                addEmailTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Email id is not in your correct format.");
            }
        }

        private void searchEmailButton_Click(object sender, EventArgs e)
        {
            emailId = searchEmailTextBox.Text;

            isvalid = Regex.IsMatch(emailId,pattern);

            if (isvalid)
            {

                bool result;

                if (list.Contains(emailId))
                {
                    MessageBox.Show("Email Id is found in the system.");

                    searchEmailListBox.Items.Add(emailId);
                    searchEmailTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Emaild Not Found");
                    searchEmailListBox.Items.Clear();
                }
               
            }
            else
            {
                MessageBox.Show("Enter Email id in correct format to search.");
                searchEmailListBox.Items.Clear();
            }
            
        }

       
    }
}
