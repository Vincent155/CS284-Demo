using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace maintaindatabaseForms
{
    public partial class maintaindatabaseForm : Form
    {
        private SQLiteConnection sqlite_connect;
        private SQLiteCommand sqlite_cmd;

        public maintaindatabaseForm()
        {
            InitializeComponent();
        }

        private void writebutton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\myData.db"))
            {
                SQLiteConnection.CreateFile("myData.db");
            }

            string name = nameBox.Text;
            string phone_number = phoneBox.Text;
            string car_number = carnumberBox.Text;
            string car_maintenace = maintenanceBox.Text;
            string car_nextmaintenace = nextBox.Text;

            sqlite_connect = new SQLiteConnection("Data source=myData.db");
            //建立資料庫連線

            sqlite_connect.Open();// Open
            sqlite_cmd = sqlite_connect.CreateCommand();//create command

            sqlite_cmd.CommandText = @"CREATE TABLE IF NOT EXISTS phone (num INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, phone_number TEXT, car_number, car_maintenace TEXT, car_nextmaintenace TEXT)";
            //create table header
            //INTEGER PRIMARY KEY AUTOINCREMENT=>auto increase index
            sqlite_cmd.ExecuteNonQuery(); //using behind every write cmd

            sqlite_cmd.CommandText = "INSERT INTO phone VALUES (null, '" + name + "','" + phone_number + "','" + car_number + "','" + car_maintenace + "','" + car_nextmaintenace + "');";
            sqlite_cmd.ExecuteNonQuery();//using behind every write cmd

            sqlite_connect.Close();
        }

        private void checkbutton_Click(object sender, EventArgs e)
        {
            sqlite_connect = new SQLiteConnection("Data source=myData.db");
            //建立資料庫連線
            sqlite_connect.Open();// Open
            sqlite_cmd = sqlite_connect.CreateCommand();//create command

            sqlite_cmd.CommandText = "SELECT * FROM phone"; //select table

            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read()) //read every data
            {
                String name_load = sqlite_datareader["name"].ToString();
                String phone_number_load = sqlite_datareader["phone_number"].ToString();
                String car_number_load = sqlite_datareader["car_number"].ToString();
                String car_maintenace_load = sqlite_datareader["car_maintenace"].ToString();
                String car_nextmaintenace_load = sqlite_datareader["car_nextmaintenace"].ToString();

                MessageBox.Show("姓名" + name_load + "," + "連絡電話" + phone_number_load + "," + "車牌" + car_number_load + "," + "回廠日期" + car_maintenace_load + "," + "下次回廠日期" + car_nextmaintenace_load);
            }
            sqlite_connect.Close();
        }
    }
}