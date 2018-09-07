using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
namespace GameApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
          
            using (var cn = GetConnection.OpenConnection())
            {
                var data = cn.Query("SELECT * FROM Testing");
                foreach(var item in data)
                {
                    lstGame.Items.Add(item);
                }
            }
        }
    }
}
