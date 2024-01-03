using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFtoBase
{
    public partial class PasswordInsert : Form
    {

        public const string JavierPassword = "Password";
        public const string IsraelPassword = "Password";
        public const string AdrianPassword = "Password";
        public const string fichero_preguntas = "";
        public PasswordInsert()
        {
            InitializeComponent();
        }

        private void GetFileBut_Click(object sender, EventArgs e)
        {

            if(JavierPassword.ToUpper() == JaviertextBox.Text.ToUpper() && 
                IsraelPassword.ToUpper() == IsraeltextBox.Text.ToUpper() && 
                AdrianPassword.ToUpper() == AdriantextBox.Text.ToUpper())
            {
                var base64String = Convert.FromBase64String(fichero_preguntas);
                File.WriteAllBytes(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\preguntas.pdf", base64String);
            }

        }
    }
}
