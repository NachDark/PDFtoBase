using System.Buffers.Text;
using System.Net.Http.Headers;

namespace PDFtoBase
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string base64String = Convert.ToBase64String(File.ReadAllBytes(PathBox.Text));
            File.WriteAllText(PathBox.Text + "_base.txt", base64String);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var base64String = Convert.FromBase64String(File.ReadAllText(PathBox.Text));
            File.WriteAllBytes(PathBox.Text + "_basepdf.pdf", base64String);
        }
        static HttpClient client = new HttpClient();
        //private void button3_Click(object sender, EventArgs e)
        //{


        //    // Put the following code where you want to initialize the class
        //    // It can be the static constructor or a one-time initializer
        //    client.BaseAddress = new Uri("http://api.guerrillamail.com/ajax.php?f=get_email_address");
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/json"));
        //    client.GetAsync(client.BaseAddress).Wait();
        //}
    }
}