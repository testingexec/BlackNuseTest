using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BlackNuse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



      
        private async void Form1_Load(object sender, EventArgs e)
        {

           
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.Inject();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

