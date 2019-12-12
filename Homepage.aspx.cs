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
            SQLiteConnection myConnection = new SQLiteConnection("Data Source=C:\\Users\\Peyton\\source\\repos\\Assignment5.3\\Assignment5.3\\flowers2019.db;");
            myConnection.Open();
            //dsff
            string getFlowers =
                "SELECT comname " +
                "FROM flowers";

            /*string getSize =
                "SELECT Count(comname) AS countX " +
                "FROM flowers ";*/

            // Execute query on database
            SQLiteCommand selectCommand = new SQLiteCommand(getFlowers, myConnection);
            SQLiteDataReader dataReader = selectCommand.ExecuteReader();

            //SQLiteCommand selectCommandSize = new SQLiteCommand(getSize, myConnection);
            //SQLiteDataReader dataReaderSize = selectCommandSize.ExecuteReader();

            // Iterate every record in the AppUser table
           // while (dataReaderSize.Read())
           // flowerList.TabIndex = dataReaderSize.GetInt16(0);
            while (dataReader.Read())
            {
                flowerList.Items.Add(dataReader.GetString(0));
            }
            flowerList.Visible = true;
            enter.Visible = true;
            myConnection.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            nameLabel.Visible = true;
            nameTB.Visible = true;
            personLabel.Visible = true;
            personTB.Visible = true;
            locationLabel.Visible = true;
            locationTB.Visible = true;
            DateLabel.Visible = true;
            dateTB.Visible = true;
            enter3.Visible = true;

        }

        protected void enter_Click(object sender, EventArgs e)
        {

        }

        protected void enter2_Click(object sender, EventArgs e)
        {
            SQLiteConnection myConnection = new SQLiteConnection("Data Source=C:\\Users\\Peyton\\source\\repos\\Assignment5.3\\Assignment5.3\\flowers2019.db;");
            myConnection.Open();
            string getSightings = "SELECT sighted, location, person FROM SIGHTINGS, FLOWERS " +
            "where FLOWERS.COMNAME = " + flowerList.SelectedValue + " and SIGHTINGS.NAME = FLOWERS.COMNAME " +
            "ORDER BY SIGHTINGS.SIGHTED DESC " +
            "LIMIT 10;";

            SQLiteCommand selectCommandSightings = new SQLiteCommand(getSightings, myConnection);
            SQLiteDataReader dataReaderSightings = selectCommandSightings.ExecuteReader();
            while (dataReaderSightings.Read())
            {
                TableRow trow = new TableRow();
                TableCell date = new TableCell { Text = dataReaderSightings.GetString(0) };
                TableCell location = new TableCell { Text = dataReaderSightings.GetString(1) };
                TableCell person = new TableCell { Text = dataReaderSightings.GetString(2) };
                trow.Cells.Add(date);
                trow.Cells.Add(location);
                trow.Cells.Add(person);
                flowers.Rows.Add(trow);

            }
            myConnection.Close();
        }

        protected void enter_Click1(object sender, EventArgs e)
        {
            SQLiteConnection myConnection = new SQLiteConnection("Data Source=C:\\Users\\Peyton\\source\\repos\\Assignment5.3\\Assignment5.3\\flowers2019.db;");
            myConnection.Open();
            string getSightings = "SELECT sighted, location, person FROM SIGHTINGS, FLOWERS where FLOWERS.COMNAME = '" + flowerList.SelectedValue+ "' and SIGHTINGS.NAME = FLOWERS.COMNAME ORDER BY SIGHTINGS.SIGHTED DESC LIMIT 10;";

            SQLiteCommand selectCommandSightings = new SQLiteCommand(getSightings, myConnection);
            SQLiteDataReader dataReaderSightings = selectCommandSightings.ExecuteReader();
            while (dataReaderSightings.Read())
            {
                TableRow trow = new TableRow();
                TableCell date = new TableCell { Text = dataReaderSightings.GetString(0) };
                TableCell location = new TableCell { Text = dataReaderSightings.GetString(1) };
                TableCell person = new TableCell { Text = dataReaderSightings.GetString(2) };
                trow.Cells.Add(date);
                trow.Cells.Add(location);
                trow.Cells.Add(person);
                flowers.Rows.Add(trow);

            }
            flowers.Visible = true;
            myConnection.Close();
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            SQLiteConnection myConnection = new SQLiteConnection("Data Source=C:\\Users\\Peyton\\source\\repos\\Assignment5.3\\Assignment5.3\\flowers2019.db;");
            myConnection.Open();
            //dsff
            string getFlowers =
                "SELECT comname " +
                "FROM flowers";

            /*string getSize =
                "SELECT Count(comname) AS countX " +
                "FROM flowers ";*/

            // Execute query on database
            SQLiteCommand selectCommand = new SQLiteCommand(getFlowers, myConnection);
            SQLiteDataReader dataReader = selectCommand.ExecuteReader();

            //SQLiteCommand selectCommandSize = new SQLiteCommand(getSize, myConnection);
            //SQLiteDataReader dataReaderSize = selectCommandSize.ExecuteReader();

            // Iterate every record in the AppUser table
            // while (dataReaderSize.Read())
            // flowerList.TabIndex = dataReaderSize.GetInt16(0);
            while (dataReader.Read())
            {
                flowerList.Items.Add(dataReader.GetString(0));
            }
            flowerList.Visible = true;
            enter2.Visible = true;
            myConnection.Close();
        }

        protected void enter3_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text;
            string person = personTB.Text;
            string location = locationTB.Text;
            string date = dateTB.Text;
            if (name == "")
                name = "null";
            else name = "\"" + name + "\"";
            if (person == "")
                person = "null";
            else name = "\"" + person + "\"";
            if (location == "")
                location = "null";
            else name = "\"" + location+ "\"";
            if (date == "")
                date = "null";

            SQLiteConnection myConnection = new SQLiteConnection("Data Source=C:\\Users\\Peyton\\source\\repos\\Assignment5.3\\Assignment5.3\\flowers2019.db;");
            myConnection.Open();
            

            using (SQLiteTransaction sqlTransaction = myConnection.BeginTransaction())
            {
                // Update the expiry date of the application
                string insertSightings = "INSERT INTO SIGHTINGS VALUES(" + name + ", " + person + ", " + location + ", " + date + ");";
                SQLiteCommand insertCommand = new SQLiteCommand(insertSightings
                                                                    , myConnection);
                insertCommand.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
            
        }

        protected void Refresh_Click(object sender, EventArgs e)
        {
            
            flowerList.Visible = false;
            enter.Visible = false;
            enter2.Visible = false;
            nameLabel.Visible = false;
            nameTB.Visible = false;
            personLabel.Visible = false;
            personTB.Visible = false;
            dateTB.Visible = false;
            DateLabel.Visible = false;
            locationLabel.Visible = false;
            locationTB.Visible = false;
            enter3.Visible = false;
            flowers.Visible = false;
            speciesLabel.Visible = false;
            speciesTB.Visible = false;
            genusLabel.Visible = false;
            genusTB.Visible = false;
            comnameLabel.Visible = false;
            comnameTB.Visible = false;
            enter4.Visible = false;
        }

        protected void enter2_Click1(object sender, EventArgs e)
        {
            SQLiteConnection myConnection = new SQLiteConnection("Data Source=C:\\Users\\Peyton\\source\\repos\\Assignment5.3\\Assignment5.3\\flowers2019.db;");
            myConnection.Open();

            string getFlowers = "SELECT comname, genus, species FROM Flowers WHERE Comname = \"" + flowerList.Text + "\"";

            SQLiteCommand selectCommandFlowers = new SQLiteCommand(getFlowers, myConnection);
            SQLiteDataReader dataReaderFlowers = selectCommandFlowers.ExecuteReader();
            while (dataReaderFlowers.Read())
            {

                comnameTB.Text = dataReaderFlowers.GetString(0);
                genusTB.Text = dataReaderFlowers.GetString(1);
                speciesTB.Text = dataReaderFlowers.GetString(2);

            }

            speciesLabel.Visible = true;
            speciesTB.Visible = true;
            genusLabel.Visible = true;
            genusTB.Visible = true;
            comnameLabel.Visible = true;
            comnameTB.Visible = true;
            enter4.Visible = true;
        }

        protected void enter4_Click(object sender, EventArgs e)
        {
            SQLiteConnection myConnection = new SQLiteConnection("Data Source=C:\\Users\\Peyton\\source\\repos\\Assignment5.3\\Assignment5.3\\flowers2019.db;");
            myConnection.Open();

            string comname = comnameTB.Text;
            string genus = genusTB.Text;
            string species = speciesTB.Text;
            if (comname == "")
                comname = "null";
            else comname = "\"" + comname + "\"";
            if (genus == "")
                genus = "null";
            else genus = "\"" + genus + "\"";
            if (species == "")
                species = "null";
            else species = "\"" + species + "\"";


            using (SQLiteTransaction sqlTransaction = myConnection.BeginTransaction())
            {
                // Update the expiry date of the application
                string updateFlowers = "UPDATE FLOWERS SET comname = "+ comname +", genus = " + genus + ", species = " +species + " WHERE COMNAME = \"" + flowerList.Text + "\"";
                SQLiteCommand insertCommand = new SQLiteCommand(updateFlowers , myConnection);
                insertCommand.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
        }
    }
}