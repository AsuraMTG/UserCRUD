using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http; //!!!!!!!!!
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserCRUD
{
    public partial class Form1 : Form
    {
        string baseURL = "https://retoolapi.dev/MVwfIW/data";
        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await getUsers();
            
            dataGridView1.DataSource = users;
        }

        private async Task getUsers()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(baseURL);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                users = User.FromJson(json);
            }
        }
    }
}
