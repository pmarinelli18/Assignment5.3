using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;

namespace Assignment5._3
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection myConnection = new SQLiteConnection("Data Source=C:\\flowers2019.db; Version=3");
            myConnection.Open();
            //dsff
            string getFlowers =
                "SELECT comname " +
                "FROM flowers";

            string getSize =
                "SELECT Count(comname) AS countX " +
                "FROM flowers ";

            // Execute query on database
            SQLiteCommand selectCommand = new SQLiteCommand(getFlowers, myConnection);
            SQLiteDataReader dataReader = selectCommand.ExecuteReader();

            SQLiteCommand selectCommandSize = new SQLiteCommand(getSize, myConnection);
            SQLiteDataReader dataReaderSize = selectCommandSize.ExecuteReader();

            // Iterate every record in the AppUser table
            while (dataReaderSize.Read())
            flowerList.TabIndex = dataReaderSize.GetInt16(0);
            while (dataReader.Read())
            {
                flowerList.DataValueField = dataReader.GetString(0) + "\n";
                //("Flower: " + dataReader.GetString(0));
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}