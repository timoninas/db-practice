using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_operator
{
    public partial class Form1 : Form
    {
        private ControllerForm1 controller = new ControllerForm1();
        public Form1(String username, String password)
        {
            InitializeComponent();
            
            errorLabel.Text = "";
            usernameLabel.Text = username;
            passwordLabel.Text = password;
        }

        private void ClearTextBoxes()
        {
            dataPerson.Rows.Clear();
            dataPersonInfo.Rows.Clear();
            dataCar.Rows.Clear();
            dataService.Rows.Clear();
            dataMessage.Rows.Clear();
            dataEquipment.Rows.Clear();
            dataEquipmentMaintenance.Rows.Clear();
        }

        private void GetDataButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();

            String IDString = IDTextBox.Text;
            int id = 0;

            if (int.TryParse(IDString, out id))
            {
                
                List<string> personArray = controller.GetPersonByID(id);
                for (int i = 0; i < personArray.Count; i += 3)
                {
                    dataPerson.Rows.Add(personArray[i], personArray[i+1], personArray[i+2]);
                }
                
                
                List<string> personInfoArray = controller.GetPersonInfoByID(id);
                for (int i = 0; i < personInfoArray.Count; i += 3)
                {
                    dataPersonInfo.Rows.Add(personInfoArray[i], personInfoArray[i+1], personInfoArray[i+2]);
                }

                List<string> carsArray = controller.GetCarsByID(id);
                for (int i = 0; i < carsArray.Count;)
                {
                    dataCar.Rows.Add(carsArray[i] + " " + carsArray[i + 1], carsArray[i + 2], carsArray[i + 3]);
                    i += 4;
                }

                List<string> servicesArray = controller.GetServicesByID(id);
                for (int i = 0; i < servicesArray.Count;)
                {
                    dataService.Rows.Add(servicesArray[i], servicesArray[i + 1], servicesArray[i + 2], servicesArray[i + 3]);
                    i += 4;
                }

                //GetMessagesByPersonID
                List<string> messagesArray = controller.GetMessagesByPersonID(id);
                for (int i = 0; i < messagesArray.Count;)
                {
                    dataMessage.Rows.Add(messagesArray[i], 
                                         messagesArray[i + 1], 
                                         messagesArray[i + 2], 
                                         messagesArray[i + 3],
                                         messagesArray[i + 4],
                                         messagesArray[i + 5]);
                    i += 6;
                }

                List<string> equipmentsArray = controller.GetEquipmentsByPersonID(id);
                for (int i = 0; i < equipmentsArray.Count;)
                {
                    dataEquipment.Rows.Add(equipmentsArray[i],
                                         equipmentsArray[i + 1],
                                         equipmentsArray[i + 2]);
                    i += 3;
                }

                List<string> equipmentMaintenanceArray = controller.GetEquipmentMaintenanceByPersonID(id);
                for (int i = 0; i < equipmentMaintenanceArray.Count;)
                {
                    dataEquipmentMaintenance.Rows.Add(equipmentMaintenanceArray[i],
                                         equipmentMaintenanceArray[i + 1],
                                         equipmentMaintenanceArray[i + 2],
                                         equipmentMaintenanceArray[i + 3]);
                    i += 4;
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAuth nextWindow = new FormAuth();
            nextWindow.ShowDialog();
        }

        private void dataEquipmentMaintenance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosenId = e.RowIndex;
            if (e.ColumnIndex == json_report.Index)
            {
                string json_message = dataEquipmentMaintenance[e.ColumnIndex, chosenId].Value.ToString();
                //MessageBox.Show(dataEquipmentMaintenance[e.ColumnIndex, chosenId].Value.ToString());
                //this.Hide();

                StatusEquipment eq = JsonConvert.DeserializeObject<StatusEquipment>(json_message);
                FormTechView nextWindow = new FormTechView(eq.title, eq.engine, eq.clutch, eq.doors, eq.machine_body, eq.wheels);
                nextWindow.ShowDialog();
            }
            errorLabel.Text = e.ColumnIndex.ToString();
        }
    }
}
