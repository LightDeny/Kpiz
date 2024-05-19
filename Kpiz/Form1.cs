using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kpiz
{
    public partial class Form1 : Form
    {
        public static string _path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
        public static string _fileName = "text.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fullPath = Path.Combine(_path, _fileName);
            GenerateMD5FromFile(fullPath);
        }

        public string GenerateMD5(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }

            var hash = sb.ToString().ToLower();
            Console.WriteLine("Message :" + hash);
            return hash;
        }

        public string GenerateMD5FromFile(string path)
        {
            var md5 = MD5.Create();
            var stream = File.OpenRead(path);
            var hashBytes = md5.ComputeHash(stream);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            var hash = sb.ToString().ToLower();
            Console.WriteLine("File :" + hash);
            return hash;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var message = messageInputBox.Text;
            var hash = GenerateMD5(message);
            answerText.Text = "MD5 хеш : " + hash;
        }

        private void generateButtonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {                
               var filePath = openFileDialog.FileName;
                var hash = GenerateMD5FromFile(filePath);
                answerText.Text = "MD5 хеш : " + hash;
            }
        }
    }
}
