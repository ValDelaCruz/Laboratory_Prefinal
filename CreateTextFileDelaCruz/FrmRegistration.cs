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

namespace CreateTextFileDelaCruz
{
    public partial class FrmRegistration : Form
    {
        public static string SetFileName;
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentNo = txtStdNum.Text;
            string lastname = txtLName.Text;
            string age = txtAge.Text;
            string firstname = txtFName.Text;
            string contact = txtContactNo.Text;
            string mi = txtMI.Text;
            string program = cbProgram.Text;
            string gender = cbGender.Text;
            string birthday = dateTimePicker.Text;


            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            lastname + ".txt")))
            {
                outputFile.WriteLine("Student No.: " + studentNo);
                outputFile.WriteLine("Full Name: " + firstname + mi + lastname);
                outputFile.WriteLine("Program: " + program); 
                outputFile.WriteLine("Gender: " + gender);
                outputFile.WriteLine("Birthday: " + birthday);
                outputFile.WriteLine("Contact No.: " + contact);
            }
            this.Close();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmOpenTextFile openTextFile = new FrmOpenTextFile();
            openTextFile.ShowDialog();
        }
    }
}
