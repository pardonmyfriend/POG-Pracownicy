using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pracownicy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            ValidateFirstName();
        }

        private bool ValidateFirstName()
        {
            bool bStatus = true;
            if (string.IsNullOrEmpty(tbFirstName.Text))
            {
                errorProvider.SetError(tbFirstName, "Pole nie może być puste");
                bStatus = false;
            }
            else
                errorProvider.SetError(tbFirstName, null);
            return bStatus;
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            ValidateLastName();
        }

        private bool ValidateLastName()
        {
            bool bStatus = true;
            if (string.IsNullOrEmpty(tbLastName.Text))
            {
                errorProvider.SetError(tbLastName, "Pole nie może być puste");
                bStatus = false;
            }
            else
                errorProvider.SetError(tbLastName, null);
            return bStatus;
        }

        private void dataPosition_Validating(object sender, CancelEventArgs e)
        {
            ValidatePosition();
        }

        private bool ValidatePosition()
        {
            bool bStatus = true;
            if (dataPosition.SelectedItem == null)
            {
                errorProvider.SetError(dataPosition, "Pole nie może być puste");
                bStatus = false;
            }
            else
                errorProvider.SetError(dataPosition, null);
            return bStatus;
        }

        private void dataPosition_DropDown(object sender, EventArgs e)
        {
            dataPosition.ForeColor = Color.Black;
        }

        private void dataPosition_DropDownClosed(object sender, EventArgs e)
        {
            if(dataPosition.SelectedItem == null)
                dataPosition.ForeColor = Color.LightGray;
            else
                dataPosition.ForeColor = Color.Black;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbLastName.Text) ||
                dataPosition.SelectedItem == null))
            {
                string firstname = tbFirstName.Text;
                string lastname = tbLastName.Text;
                DateTime birthdate = dataBirthDate.Value;
                decimal salary = dataSalary.Value;

                string pos = dataPosition.Text;
                Position position;
                switch (pos)
                {
                    case "Tester":
                        position = Position.Tester;
                        break;
                    case "Projektant":
                        position = Position.Designer;
                        break;
                    case "Inżynier":
                        position = Position.Engineer;
                        break;
                    case "Młodszy programista":
                        position = Position.JuniorProgrammer;
                        break;
                    case "Starszy programista":
                        position = Position.SeniorProgrammer;
                        break;
                    default:
                        position = Position.Tester;
                        break;
                }

                TypeOfContract contract;

                if (rb1.Checked)
                    contract = TypeOfContract.FullContract;
                else if (rb2.Checked)
                    contract = TypeOfContract.TimeContract;
                else
                    contract = TypeOfContract.MandateContract;

                Employee employee = new Employee(firstname, lastname, birthdate, salary, position, contract);

                employeesList.Items.Add(employee);
            }
            else
            {
                ValidateFirstName();
                ValidateLastName();
                ValidatePosition();
                MessageBox.Show("Należy podać wszystkie dane pracownika.", "Brak informacji!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Employee> list = new List<Employee>();

            foreach (Employee employee in employeesList.Items)
                list.Add(employee);

            if (File.Exists("employees.xml"))
                File.Delete("employees.xml");

            Stream stream = File.OpenWrite("employees.xml");

            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Employee>));

            xmlSer.Serialize(stream, list);

            stream.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists("employees.xml"))
            {
                Stream stream = File.OpenRead("employees.xml");

                List<Employee> list = new List<Employee>();

                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Employee>));

                List<Employee> employees = (List<Employee>)xmlSer.Deserialize(stream);

                foreach (Employee employee in employees)
                    employeesList.Items.Add(employee);

                stream.Close();
            }
            else
                MessageBox.Show("Upewnij się, że istnieje plik do wczytania.", "Nie znaleziono pliku!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
