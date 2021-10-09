using System;
using System.Collections.Generic;
enum Menu
{
    RegisterNewStudent = 1,
    RegisterNewTecher,
    GetListPersons,
    Exit
}
namespace Homework2
{
    class Program
    {
        public static PersonList personList = new PersonList();
        static void Main(string[] args)
        {
            PrintMenuScreen();
        }
        public static void PrintMenuScreen()
        {
            Console.Clear();
            PrintHeader();
            PrintLisMenu();
            InputMenuFromKeyboard();
        }
        public static void PrintHeader()
        {
            Console.WriteLine("Welcome for register.");
            Console.WriteLine("---------------------");
        }
        public static void PrintLisMenu()
        {
            Console.WriteLine("1.Register new student.");
            Console.WriteLine("2.Register new teacher.");
            Console.WriteLine("3.Get List Persons.");
            Console.WriteLine("4.Exit.");
        }
        static void InputMenuFromKeyboard()
        {
            Console.Write("Please Select Menu: ");
            Menu InputMenu = (Menu)(int.Parse(Console.ReadLine()));
            PresentMenu(InputMenu);
        }
        static void PresentMenu(Menu menu)
        {
            if (menu == Menu.RegisterNewStudent)
            {
                ShowInputRegisterNewStudentScreen();
            }
            else if (menu == Menu.RegisterNewTecher)
            {
                NewInformation.ShowInputRegisterNewTeacherScreen();
            }
            else if (menu == Menu.GetListPersons)
            {
                ShowGetListPersonScreen();
            }
            else if (menu == Menu.Exit)
            {

            }
            else
            {
                ShowMessageInputMenuIsInCorrect();
            }
        }
        public static void ShowGetListPersonScreen()
        {
            Console.Clear();
            personList.FetchPersonsList();
            InputExitFromKeyboard();
        }
        public static void InputExitFromKeyboard()
        {
            string text = "";

            while (text != "exit")
            {
                Console.Write("If you want to exit <3 :");
                text = Console.ReadLine();
            }
            Console.Clear();
            PrintMenuScreen();
        }
        public  static void ShowInputRegisterNewStudentScreen()
        {
            Console.Clear();
            PrintHeaderRegisterStudent();
            int totalStudent = TotalNewStudents();
            InputNewStudent(totalStudent);
        }
        public static int TotalNewStudents()
        {
            Console.Write("Input Total new Student: ");
            return int.Parse(Console.ReadLine());
        }
        public static void ShowMessageInputMenuIsInCorrect()
        {
            Console.Clear();
            Console.WriteLine("Menu Incorrect Please try agian.");
            PrintLisMenu();
            InputMenuFromKeyboard();
        }
        public static void PrintHeaderRegisterStudent()
        {
            Console.WriteLine("Register new student.");
            Console.WriteLine("---------------------");
        }
        public static void InputNewStudent(int totalStudent)
        {
            for (int i = 0; i < totalStudent; i++)
            {
                Console.Clear();
                PrintHeaderRegisterStudent();
                Student student = CreateNewStudent();
                personList.AddNewPerson(student);
            }
            Console.Clear();
            PrintMenuScreen();
        }
        public static Student CreateNewStudent()
        {
            return new Student(InputName(), InputAddress(),
                InputCitizenID(), InputStudentID());
        }
        public static string InputName()
        {
            Console.Write("Name: ");

            return Console.ReadLine();
        }
        public static string InputStudentID()
        {
            Console.Write("Student ID: ");
            return Console.ReadLine();
        }
        public static string InputAddress()
        {
            Console.Write("Address: ");
            return Console.ReadLine();
        }
        public static string InputCitizenID()
        {
            Console.Write("CitizenID: ");
            return Console.ReadLine();
        }
                
    }
    class NewInformation
    {

        public static void ShowInputRegisterNewTeacherScreen()
        {
            Console.Clear();
            PrintHeaderRegisterTeacher();
            int totalTeacher = TotalNewTeacher();
            InputNewTeacherFromKeyboard(totalTeacher);
        }
        public static void InputNewTeacherFromKeyboard(int totalTeacher)
        {
            for (int i = 0; i < totalTeacher; i++)
            {
                Console.Clear();
                PrintHeaderRegisterTeacher();
                Teacher teacher = CreateNewTeacher();
                Program.personList.AddNewPerson(teacher);
            }
            Console.Clear();
            Program.PrintMenuScreen();
        }
        public static Teacher CreateNewTeacher()
        {
            return new Teacher(Program.InputName(),
            Program.InputAddress(),
            Program.InputCitizenID(),
            InputEmployeeID());
        }
        static string InputEmployeeID()
        {
            Console.Write("Employee ID: ");
            return Console.ReadLine();
        }
        public static void PrintHeaderRegisterTeacher()
        {
            Console.WriteLine("Register new teacher.");
            Console.WriteLine("---------------------");
        }
        public static int TotalNewTeacher()
        {
            Console.Write("Input Total new Teacher: ");
            return int.Parse(Console.ReadLine());
        }

    }
    class Person
    {
        protected string Name;
        protected string Address;
        protected string CitizenID;

        public Person(string name, string address, string citizenID)
        {
            this.Name = name;
            this.Address = address;
            this.CitizenID = citizenID;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
    class Student : Person
    {
        private string StudentID;

        public Student(string name, string address, string citizenID, string studentID) : base(name, address, citizenID)
        {
            this.StudentID = studentID;
        }
    }
    class Teacher : Person
    {
        private string TeacherID;

        public Teacher(string name, string address, string citizenID, string teacherID) : base(name, address, citizenID)
        {
            this.TeacherID = teacherID;
        }
    }
    class PersonList
    {
        private List<Person> personList;

        public PersonList()
        {
            this.personList = new List<Person>();
        }
        public void AddNewPerson(Person person)
        {
            this.personList.Add(person);
        }
        public void FetchPersonsList()
        {
            Console.WriteLine("List Person");
            Console.WriteLine("___________");
            foreach (Person person in this.personList)
            {
                if (person is Student)
                {
                    Console.WriteLine("Name : {0} \n Type : Student \n", person.GetName());
                }
                else if (person is Teacher)
                {
                    Console.WriteLine("Name : {0} \n Type : Teacher \n", person.GetName());
                }
            }
        }
    }
}