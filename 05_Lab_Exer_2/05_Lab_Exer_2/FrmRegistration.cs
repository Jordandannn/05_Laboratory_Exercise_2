using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Lab_Exer_2
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String[] value =
            {
                txtStudNo.Text,
                txtFirstName.Text +" "+txtMI.Text+" "+txtLastName.Text,
                cbProgram.Text,
                cbGender.Text,
                txtAge.Text,
                dtpBirthday.Value.ToString("yyyy-mm-dd"),
                txtContact.Text
            };
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, txtStudNo.Text + ".txt")))
            {
                outputFile.Write("Student No.: " + value[0] + "\nFull Name: " + value[1]
                    + "\nProgram: " + value[2] + "\nGender: " + value[3] + "\nAge: " + value[4]
                    + "\nBirthday: " + value[5] + "\nContact No.: " + value[6]);
            }
            this.Close();
        }
    }
}
