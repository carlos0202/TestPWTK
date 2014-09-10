using PWDTK_DOTNET451;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPWTK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMinChars.Text = "6";
            TxtMaxChars.Text = "32";
            txtNonAlpha.Text = "1";
            txtUppercase.Text = "1";
            txtNumerics.Text = "2";
        }

        //Below is used to generate a password policy that you may use to check that passwords adhere to this policy
        private int numberUpper = 0;
        private int numberNonAlphaNumeric = 0;
        private int numberNumeric = 2;
        private int minPwdLength = 6;
        private int maxPwdLength = 32;
        //Number of hash iterations
        private const int iterations = 1500;
        //Salt length
        private const int saltSize = PWDTK.CDefaultSaltLength;
        public Byte[] Salt { get; set; }
        public Byte[] Hash { get; set; }
        private string password;

        private void assignRules()
        {
            int numberUpper = Convert.ToInt32(txtUppercase.Text);
            numberNonAlphaNumeric = Convert.ToInt32(txtNonAlpha.Text); 
            numberNumeric = Convert.ToInt32(txtNumerics.Text);
            minPwdLength = Convert.ToInt32(txtMinChars.Text);
            maxPwdLength = Convert.ToInt32(TxtMaxChars.Text); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            assignRules();
            password = txtPassword.Text;
            PWDTK.PasswordPolicy PwdPolicy = new PWDTK.PasswordPolicy(numberUpper, numberNonAlphaNumeric, numberNumeric, minPwdLength, maxPwdLength);
            //A check to make sure the supplied password meets our defined password
            //policy before using CPU resources to calculate hash, this step is optional
            if (PasswordMeetsPolicy(password, PwdPolicy))
            {
                //Get a random salt
                Salt = PWDTK.GetRandomSalt(saltSize);
                //Generate the hash value
                Hash = PWDTK.PasswordToHash(Salt, password, iterations);
                rtbResultado.Text = string.Format("Hash de contraseña: {0} {1} Salt generado: {2}", PWDTK.HashBytesToHexString(Hash), System.Environment.NewLine, PWDTK.HashBytesToHexString(Salt));
            }
            else
            {
                rtbResultado.Text = "La contraseña introducida no cumple con las politicas de seguridad establecidas.";
            }
        }

        private bool PasswordMeetsPolicy(String Password, PWDTK.PasswordPolicy PassPolicy)
        {

            if (PWDTK.TryPasswordPolicyCompliance(Password, PassPolicy))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ComparePassword(string password, string hash, string salt)
        {
            Hash = PWDTK.HashHexStringToBytes(hash);
            Salt = PWDTK.HashHexStringToBytes(salt);

            return PWDTK.ComparePasswordToHash(Salt, password, Hash, iterations);
        }
    }
}
