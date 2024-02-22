using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracownicy
{
    public enum Position { Tester, Designer, Engineer, JuniorProgrammer, SeniorProgrammer }
    public enum TypeOfContract { FullContract, TimeContract, MandateContract }

    public class Employee
    {
        private string _firstname;
        private string _lastname;
        private DateTime _birthdate;
        private decimal _salary;
        private Position _position;
        private TypeOfContract _contract;

        public Employee() { }

        public Employee(string firstname, string lastname, DateTime birthdate, decimal salary,
            Position position, TypeOfContract contract)
        {
            _firstname = firstname;
            _lastname = lastname;
            _birthdate = birthdate;
            _salary = salary;
            _position = position;
            _contract = contract;
        }

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string BirthDate
        {
            get { return _birthdate.ToString(); }
            set { _birthdate = DateTime.Parse(value); }
        }

        public string Salary
        {
            get { return _salary.ToString(); }
            set { _salary = decimal.Parse(value); }
        }

        public Position Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public TypeOfContract Contract
        {
            get { return _contract; }
            set { _contract = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(_firstname + " ");
            sb.Append(_lastname + ", ");
            sb.Append(_birthdate.ToShortDateString() + ", ");

            string pos;
            switch (_position)
            {
                case Position.Tester:
                    pos = "tester";
                    break;
                case Position.Designer:
                    pos = "projektant";
                    break;
                case Position.Engineer:
                    pos = "inżynier";
                    break;
                case Position.JuniorProgrammer:
                    pos = "młodszy programista";
                    break;
                case Position.SeniorProgrammer:
                    pos = "starszy programista";
                    break;
                default:
                    pos = "tester";
                    break;
            }

            sb.Append(pos + ", ");
            sb.Append(_salary + " PLN, ");

            string contr;
            switch (_contract)
            {
                case TypeOfContract.FullContract:
                    contr = "umowa na czas nieokreślony";
                    break;
                case TypeOfContract.TimeContract:
                    contr = "umowa na czas określony";
                    break;
                case TypeOfContract.MandateContract:
                    contr = "umowa zlecenie";
                    break;
                default:
                    contr = "umowa na czas nieokreślony";
                    break;
            }
            sb.Append(contr);

            return sb.ToString();
        }
    }
}
