using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Text;

namespace jasukupon
{
    public partial class defaults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            string cs = @"server=localhost;port=3306;userid=root;password=;database=jasuindokupon";
            MySqlConnection con = new MySqlConnection(cs);

            con.Open();

            String sql = "Select id as '#',gendate as 'Generate Date', nobox as 'Boxs Number', nokupon as 'Coupons Number', hadiah as 'Rewards'  from genkupon";
            var cmd = new MySqlCommand(sql, con);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            cmd.Dispose();
            con.Close();

        }

        public void genrandom()
        { 
            //memasukkan jumlah kupon
            int kupon = int.Parse(numberCp.Text);
            //memasukkan jumlah box
            int jbox = int.Parse(box.Text);

            //membagi rata kupon per box
            int ttkupon = kupon / jbox;

            List<int> numbers = new List<int>();
            for (int t = 1; t <= ttkupon; t++)
            {
                numbers.Add(t);
            }

            //generate random nomer kupon
            Random rnd = new Random();
            HashSet<int> NUMBERS = new HashSet<int>();
            while (NUMBERS.Count <= ttkupon)
            {
                int random = rnd.Next(numbers.Count);
                NUMBERS.Add(random);
            }

            for (int i = 1; i <= jbox; i++)
            {
                foreach (int num in NUMBERS)
                {
                    for (int j = 1; j <= ((ttkupon * 81) / 100); j++)
                    {
                        string cs = @"server=localhost;port=3306;userid=root;password=;database=jasuindokupon";
                        MySqlConnection con = new MySqlConnection(cs);
                        con.Open();
                        String sql = "INSERT INTO `genkupon` (`id`, `gendate`, `nobox`, `nokupon`, `hadiah`) VALUES (NULL, now(), '" + j + "', '" + num.ToString().PadLeft(5, '0') + "', 'anda tidak beruntung')";
                        var cmd = new MySqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();

                    }
                    for (int h = 1; h <= ((ttkupon * 19) / 100); h++)
                    {
                        int g = ((ttkupon * 19) / 100);
                        if (h <= ((g * 2.63) / 100))
                        {
                            string cs = @"server=localhost;port=3306;userid=root;password=;database=jasuindokupon";
                            MySqlConnection con = new MySqlConnection(cs);
                            con.Open();
                            String sql = "INSERT INTO `genkupon` (`id`, `gendate`, `nobox`, `nokupon`, `hadiah`) VALUES (NULL, now(), '" + h + "', '" + num.ToString().PadLeft(5, '0') + "', '100000')";
                            var cmd = new MySqlCommand(sql, con);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            con.Close();
                        }
                        else if (h <= ((g * 5.26) / 100))
                        {
                            string cs = @"server=localhost;port=3306;userid=root;password=;database=jasuindokupon";
                            MySqlConnection con = new MySqlConnection(cs);
                            con.Open();
                            String sql = "INSERT INTO `genkupon` (`id`, `gendate`, `nobox`, `nokupon`, `hadiah`) VALUES (NULL, now(), '" + h + "', '" + num.ToString().PadLeft(5, '0') + "', '50000')";
                            var cmd = new MySqlCommand(sql, con);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            con.Close();
                        }
                        else if (h <= ((g * 13.16) / 100))
                        {
                            string cs = @"server=localhost;port=3306;userid=root;password=;database=jasuindokupon";
                            MySqlConnection con = new MySqlConnection(cs);
                            con.Open();
                            String sql = "INSERT INTO `genkupon` (`id`, `gendate`, `nobox`, `nokupon`, `hadiah`) VALUES (NULL, now(), '" + h + "', '" + num.ToString().PadLeft(5, '0') + "', '20000')";
                            var cmd = new MySqlCommand(sql, con);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            con.Close();
                        }
                        else if (h <= ((g * 26.32) / 100))
                        {
                            string cs = @"server=localhost;port=3306;userid=root;password=;database=jasuindokupon";
                            MySqlConnection con = new MySqlConnection(cs);
                            con.Open();
                            String sql = "INSERT INTO `genkupon` (`id`, `gendate`, `nobox`, `nokupon`, `hadiah`) VALUES (NULL, now(), '" + h + "', '" + num.ToString().PadLeft(5, '0') + "', '10000')";
                            var cmd = new MySqlCommand(sql, con);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            con.Close();
                        }
                        else if (h <= ((g * 52.63) / 100))
                        {
                            string cs = @"server=localhost;port=3306;userid=root;password=;database=jasuindokupon";
                            MySqlConnection con = new MySqlConnection(cs);
                            con.Open();
                            String sql = "INSERT INTO `genkupon` (`id`, `gendate`, `nobox`, `nokupon`, `hadiah`) VALUES (NULL, now(), '" + h + "', '" + num.ToString().PadLeft(5, '0') + "', '5000')";
                            var cmd = new MySqlCommand(sql, con);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            con.Close();
                        }

                    }
                }
            }
            BindData();
        }

        protected void btnGen_Click(object sender, EventArgs e)
        {
            genrandom();
        }
    }
}