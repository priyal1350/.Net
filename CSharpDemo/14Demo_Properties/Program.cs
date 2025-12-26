namespace _14Demo_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Eid = 10;
            int id = emp.Eid;
            Console.WriteLine($"ID ={id}");
            emp.Ename = "Hugh Jackman";
            Console.WriteLine($"Output:{emp.Ename}");
            emp.EAdress = "New York";
        }
    }

    public class Employee
    {
        private int _Eid;
        private string _EName;
        private string _EAddress;

        public int Eid
        {
            set
            {
                _Eid = value;

            }
            get
            {
                return _Eid;
            }
        }
        public string Ename
        {
            set
            {
                if (value != null)
                {
                    _EName = "Mr/Mrs." + value;
                }
                else
                {
                    _EName = "Invalid format";
                }
            }
            get { return _EName; }
        }
        public string EAdress
        {
            set
            {
                _EAddress = value;
                Console.WriteLine($"Address: {_EAddress}");

            }
        }
    }
}
