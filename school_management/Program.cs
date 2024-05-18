using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public int Age { get; set; }
        public string Levelofstudy { get; set; }
    }

    class SchoolManagement
    {
        private List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("The student was added successfully");
        }
        public void ViewStudents()
        {
            Console.WriteLine("All students are :");
            foreach (var student in students)
            {
                Console.WriteLine($"ID:{student.Id},Name:{student.Name},Grade:{student.Grade},Age:{student.Age}, level of study:{student.Levelofstudy}");
            }
        }
        public void UpdateStudent(int id)
        {
            var student = students.Find(s => s.Id == id);
            if (student != null)
            {
                Console.WriteLine("Enter the name of the new student :");
                student.Name = Console.ReadLine();
                Console.WriteLine("Enter the new grade :");
                student.Grade = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter level of study to new student :");
                student.Levelofstudy = Console.ReadLine();
                Console.WriteLine("Enter age of the new student:");
                student.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Student data has been updated");
            }
            else
            {
                Console.WriteLine("The student was not found");
            }
        }
        public void DeleteStudent(int id)
        {
            var student = students.Find(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("The student has been deleted successfully");
            }
            else
            {
                Console.WriteLine("The student was not found with this Id ");
            }
        }
    }

    class SchoolMembers
    {
        protected string firstname;
        protected string lastname;
        protected int age;
        protected string levelofstudy;
        protected int class_room;
        protected int dayss;
        protected string subject;
        protected int sunday;
        protected int monday;
        protected int tuesday;
        protected int wednesday;
        protected int thursday;
        public virtual void GetSchedule()
        {

        }

    }
    class Students : SchoolMembers
    {
        private string namee;
        private int studentID;
        private double exam1;
        private double exam2;
        private double homework;
        private double project;
        private int SubjectsScore;
        public Students(int studentID, string firstname, string lastname, int age, string levelofstudy, int class_room)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.studentID = studentID;
            this.age = age;
            this.levelofstudy = levelofstudy;
            this.class_room = class_room;
        }
        public void info_personal()
        {
            Console.WriteLine("_________________" + "                                " + "_________________");
            Console.WriteLine("                 *This information about student*");
            Console.WriteLine("The studentID of studen :" + this.studentID);
            Console.WriteLine("The full name of student :" + this.firstname + "  " + this.lastname);
            Console.WriteLine("The age of student : " + this.age);
            Console.WriteLine("The level of stud to student :" + this.levelofstudy);
            Console.WriteLine("The class room of student :" + this.class_room);
            Console.WriteLine("_________________________________________________________________");
        }
        public Students(string namee, double exam1, double exam2, double homework, double project, int SubjectsScore)
        {
            this.namee = namee;
            this.exam1 = exam1;
            this.exam2 = exam2;
            this.homework = homework;
            this.project = project;
            this.SubjectsScore = SubjectsScore;
        }
        public double score_of_grades()
        {
            return (exam1 + exam2 + homework + project);
        }
        public double Proportion()
        {
            return ((exam1 + exam2 + homework + project) * 100 / SubjectsScore);
        }


        public Students(int dayss, int sunday, int monday, int tuesday, int wednesday, int thursday, string subject)
        {

            this.sunday = sunday;
            this.monday = monday;
            this.tuesday = tuesday;
            this.wednesday = wednesday;
            this.thursday = thursday;
            this.dayss = dayss;
            this.subject = subject;
        }
        public override void GetSchedule()
        {
            Console.WriteLine("The numer of days in a week is " + dayss);
            Console.WriteLine("The number of periods in week = " + (sunday + monday + tuesday + wednesday + thursday));
            Console.WriteLine("subjects :" + subject);

        }





    }
    class Teachers : SchoolMembers
    {
        private int TeacherID;
        private int numphon;
        private double daialysalary;
        private int dayPresence;
        public Teachers(int TeacherID, string firstname, string lastname, int age, int numphon, int class_room)
        {

            this.firstname = firstname;
            this.lastname = lastname;
            this.TeacherID = TeacherID;
            this.age = age;
            this.numphon = numphon;
            this.class_room = class_room;
        }
        public void info_personal()
        {
            Console.WriteLine("_________________" + "                                " + "_________________");
            Console.WriteLine("                 *This information about student*");
            Console.WriteLine("The TeacherID of Teacher :" + this.TeacherID);
            Console.WriteLine("The full name of Teacher :" + this.firstname + "  " + this.lastname);
            Console.WriteLine("The age of  Teacher : " + this.age);
            Console.WriteLine("The number phone Teacher :" + this.numphon);
            Console.WriteLine("The class room of student :" + this.class_room);
            Console.WriteLine("_________________________________________________________________");
        }
        public Teachers(double daialysalary, int dayPresence)
        {
            this.daialysalary = daialysalary;
            this.dayPresence = dayPresence;
        }
        public double GetSalary()
        {
            return daialysalary * dayPresence;
        }
        public Teachers(int dayss, int sunday, int monday, int tuesday, int wednesday, int thursday, string subject)
        {

            this.sunday = sunday;
            this.monday = monday;
            this.tuesday = tuesday;
            this.wednesday = wednesday;
            this.thursday = thursday;
            this.dayss = dayss;
            this.subject = subject;
        }
        public override void GetSchedule()
        {
            Console.WriteLine("The numer of days in a week is " + dayss);
            Console.WriteLine("The number of periods in week = " + (sunday + monday + tuesday + wednesday + thursday));
            Console.WriteLine("subjects :" + subject);

        }


    }
    abstract class Course
    {

        public abstract void Coursename();
        public void book()
        {
            Console.WriteLine(" **************************************************************\n\n");
        }
    }
    class primary_stage : Course
    {

        public override void Coursename()
        {

            Console.WriteLine("           ``SUBJECT FOR PRIMARY SCHOOL STUDENT``:");
            Console.WriteLine(" ______________________________________________________________");
            Console.WriteLine(" |[1] `The Holy quran ______|[2] `Islamic Studies ____________|");
            Console.WriteLine(" |[3] `The sciences ________|[4] `Mathematics ________________|");
            Console.WriteLine(" |[5] `Sociology____________|[6] `Arabic______________________|");
            Console.WriteLine(" |__________________________|_________________________________|");

        }
    }
    class middle_stage : Course
    {
        public override void Coursename()
        {
            Console.WriteLine("            ``SUBJECT FOR MIDDLE SCHOOL STUDENT``:");
            Console.WriteLine(" _____________________________________________________________");
            Console.WriteLine(" |[1] `The Holy quran_______|[2] `Islamic Studies____________|");
            Console.WriteLine(" |[3] `The sciences_________|[4] `Mathematics________________|");
            Console.WriteLine(" |[5] `Sociology____________|[6] `National Education_________|");
            Console.WriteLine(" |[7] `Histor_______________|[8] `Geography__________________|");
            Console.WriteLine(" |[9] `Arabic_______________|________________________________|");
            Console.WriteLine(" |__________________________|________________________________|");
        }
    }
    class high_stage : Course
    {
        public override void Coursename()
        {
            Console.WriteLine("          ``COURSE FOR HIGH SCHOOL STUDENT [SCIENTIFIC]``:");
            Console.WriteLine(" ______________________________________________________________");
            Console.WriteLine(" |[1] `The Holy quran_______|[2] `Islamic Studies_____________|");
            Console.WriteLine(" |[3] `Chemistry____________|[4] `Mathematics_________________|");
            Console.WriteLine(" |[5] `physics______________|[6] `biology_____________________|");
            Console.WriteLine(" |[7] `Arabic_______________|[8] `English language____________|");
            Console.WriteLine(" |__________________________|_________________________________|");
            Console.WriteLine(" **************************************************************\n");


            Console.WriteLine("\n          ``SUBJECT FOR HIGH SCHOOL STUDENT [LITERARY]``:");
            Console.WriteLine(" ______________________________________________________________");
            Console.WriteLine(" |[1] `The Holy quran_______|[2] `Islamic Studies_____________|");
            Console.WriteLine(" |[3] `Arabic_______________|[4] `English language____________|");
            Console.WriteLine(" |[5] `Histor_______________|[6] `Geograph____________________|");
            Console.WriteLine(" |[7] `Mathematics__________|[8] `Philosophy,Logoc,Psychology_|");
            Console.WriteLine(" |__________________________|_________________________________|");
        }
    }
    class Libraiy
    {
        private string BookName;

        private int day;
        private int month;
        private int year;

        private int day1;
        private int month1;
        private int year1;

        public Libraiy(string BookName, int day, int month, int year, int day1, int month1, int year1)
        {
            this.BookName = BookName;
            this.day = day;
            this.month = month;
            this.year = year;
            this.day1 = day1;
            this.month1 = month1;
            this.year1 = year1;

        }

        public void DisplayBookInfo()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("The book you took is: " + BookName);
            Console.WriteLine("Date borrow " + day + "/" + month + "/" + year);
            Console.WriteLine("Date return" + day1 + "/" + month1 + "/" + year1);
        }
    }
    abstract class Class_room
    {
        public abstract void classroom();

        public void classfloor()
        {

            Console.WriteLine(" >>");
        }
    }
    class first_floor : Class_room
    {
        public override void classroom()
        {
            Console.WriteLine("    __________________           ");
            Console.WriteLine(" __________________________      ");
            Console.WriteLine("`ON THE FIRST FLOOR:         )   ");
            Console.WriteLine(" FOR STAGE [PRIMARY] ONLY ~  )   ");
            Console.WriteLine("    [1] Bathrooms.           )   ");
            Console.WriteLine("    [2] Class.               )   ");
            Console.WriteLine("    [3] Director's Office.   )   ");
            Console.WriteLine("    [4] Cafeteria.           )   ");
            Console.WriteLine("    [5] Employee.            )   ");
            Console.WriteLine(" _________________________   ) \n");
        }
    }
    class Second_floor : Class_room
    {
        public override void classroom()
        {
            Console.WriteLine("     __________________         ");
            Console.WriteLine(" _________________________      ");
            Console.WriteLine(" `ON THE SECOND FLOOR:       )  ");
            Console.WriteLine(" FOR STAGE [MIDDLE] ONLY ~   )  ");
            Console.WriteLine("    [1] Bathrooms.           )  ");
            Console.WriteLine("    [2] Class.               )  ");
            Console.WriteLine("    [3] Teachers Office.     )  ");
            Console.WriteLine("    [4] Student Library.     )  ");
            Console.WriteLine("    [5] Pring.               )  ");
            Console.WriteLine(" _________________________   )\n");
        }
    }
    class Third_floor : Class_room
    {
        public override void classroom()
        {
            Console.WriteLine("    ___________________          ");
            Console.WriteLine(" _________________________       ");
            Console.WriteLine(" `ON THE THIRD FLOOR:        )   ");
            Console.WriteLine(" FOR STAGE [HIGH] ONLY ~     )   ");
            Console.WriteLine("    [1] Class.               )   ");
            Console.WriteLine("    [2] Laps.                )   ");
            Console.WriteLine("    [3] Computer Lab         )   ");
            Console.WriteLine("    [4] Teachers Office.     )   ");
            Console.WriteLine("    [5]                      )   ");
            Console.WriteLine(" _________________________   )   ");


        }
    }
    class Tuition_fees
    {
        public void fee(double days, double faretoday)
        {
            Console.WriteLine("Bus fee =");

            Console.WriteLine($"Bus feed= {faretoday * days}");
        }
        public void fee(int installment_1, int installment_2, int installment_3, int installment_4)
        {
            Console.WriteLine($"Year Fee = {installment_1}+ {installment_2} +{installment_3} +{installment_4} = {installment_1 + installment_2 + installment_3 + installment_4}");
        }
        public void fee(int Food, int drinks, int reservation_place)
        {

            Console.WriteLine($"Trips Fee = {Food}+{drinks}+{reservation_place} = {Food + drinks + reservation_place}");
        }

    }
    class Employee
    {
        public string Name;
        public double HourlyRate;
        public double HoursWorked;
        public double vacationDays;
        public double Bonus;
        public double Salary;
        private string name_employee;
        private string job;
        private static int numofemp;
        public static double calculateSalary(string name, double HourlyRate, double HoursWorked, double vacationDays, double Bonus)
        {

            double salary = HourlyRate * HoursWorked;
            double vacationDeduction = HourlyRate * vacationDays;
            double totalSalary = (salary - vacationDeduction) + Bonus;
            return totalSalary;
        }
        public Employee(string name_employee, string job)
        {
            this.name_employee = name_employee;
            this.job = job;
            numofemp++;
        }
        public static int getnumofemp()
        {
            return numofemp;
        }

    }
    class Cafeteria
    {
        public Cafeteria()
        {
            Console.WriteLine("'~SCHOOL CAFETERIA:__________________________________________________________________________________________________________________________________________________________________________|");
            Console.WriteLine("|_SANDWICHES:____________________PRICE___|_SWEETS:__________________PRICE______|_COLD DRINKS:______________PRICE______|_HOT DRINKS:_______________PRICE______|_SNACKS:_____________PRICE_____|");
            Console.WriteLine("|_______ Cheese Sandwiches _______(2$)___|___________Donuts__________(5$)______|___________Mango Juice______(5$)______|_______Tea_________________(3$)_______|_______Chips__________(1$)_____|");
            Console.WriteLine("|_______egg Sandwiche_____________(2$)___|__________Cupcake__________(8$)______|___________Orange Juice_____(5$)______|_______Capchino____________(5$)_______|_______Chocolate______(2$)_____|");
            Console.WriteLine("|_______chees with egg Sandwiche__(3.5$)_|__________Cookies__________(3$)______|___________Water____________(3$)______|_______Hotchocolate________(5$)_______|_______Wafer__________(2$)_____|");
            Console.WriteLine("|_______jam Sandwiches____________(2$)___|__________Cheees Cake______(10$)_____|___________Ice Coffe________(8$)______|_______Arabic coffee_______(5$)_______|_______Nuts___________(2$)_____|");
            Console.WriteLine("|_______chickens Sandwiches_______(2$)___|__________Croissant________(5$)______|____________Pepsi___________(3$)______|_______Green tea___________(3$)_______|_______Candy__________(2$)_____|");
            Console.WriteLine("_________________________________________|_____________________________________|______________________________________|______________________________________|_______________________________|");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                 *`Welcome To International Inspiration School*`");
            Console.WriteLine("                                                                                                INTERNATIONAL ISPRATION");
            Console.WriteLine("                                                                                                   JAPAN,TOKYO,9 STREET ");
            Console.WriteLine("                                                                                             DATE CREATED: 21th.MAY.2023");

            Console.WriteLine("1) |____________________`Class School_Managemet`_______________|");
            Console.WriteLine("2) |____________________`Class Student`________________________|");
            Console.WriteLine("3) |_____________________`Class Teacher`_______________________|");
            Console.WriteLine("4) |____________________`Class Subject`________________________|");
            Console.WriteLine("5) |_____________________`Class Library`_______________________|");
            Console.WriteLine("6) |____________________`Class  Fee`___________________________|");
            Console.WriteLine("7) |____________________`Class Class_Room`_____________________|");
            Console.WriteLine("8) |____________________`Class  Employee`______________________|");
            Console.WriteLine("9) |____________________`Class Cafeteria`______________________|");
            Console.WriteLine("10)|________________________`Exit'_____________________________|");


            Console.WriteLine("   |___________________________________________________________|");
        cc:
            Console.WriteLine("Please choose the right option (1-9)");
            string choicee = Console.ReadLine();
            int cho = Convert.ToInt32(choicee);
            switch (cho)
            {
                case 1:
                    {
                        var schoolManager = new SchoolManagement();
                        int choice;
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Menu to school management ");
                            Console.WriteLine("1)Add a student: ");
                            Console.WriteLine("2)View students:");
                            Console.WriteLine("3)Update student data:");
                            Console.WriteLine("4)Delete student: ");
                            Console.WriteLine("5)Exit from this class to classes(1_9)");
                            Console.WriteLine("\n(5-1) Choose best option:");

                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    var student = new Student();
                                    Console.WriteLine("Enter the students ID number :");
                                    student.Id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the student name :");
                                    student.Name = Console.ReadLine();
                                    Console.WriteLine("Enter the student grade :");
                                    student.Grade = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter age of student :");
                                    student.Age = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter level of study to student :");
                                    student.Levelofstudy = Console.ReadLine();

                                    schoolManager.AddStudent(student);

                                    break;
                                case 2:
                                    schoolManager.ViewStudents();

                                    break;
                                case 3:
                                    Console.WriteLine("Enter the student ID to be updated :");

                                    int idToUpdate = int.Parse(Console.ReadLine());
                                    schoolManager.UpdateStudent(idToUpdate);

                                    break;
                                case 4:
                                    Console.WriteLine("Enter the student is ID to delete :  ");
                                    int idToDelete = int.Parse(Console.ReadLine());
                                    schoolManager.DeleteStudent(idToDelete);
                                    break;

                                case 5:
                                    Console.WriteLine("Exit from this class");
                                    goto cc;
                                    break;
                            }



                            Console.ReadKey();
                        }
                        goto cc;
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("_________________________________________________________________");
                        Console.WriteLine("*Method Get at Information Personal of student*");
                        Console.WriteLine("Please enter information of student :");
                        Console.WriteLine("Enter studentID :");
                        string s_id = Console.ReadLine();
                        int sid1 = Convert.ToInt32(s_id);
                        Console.WriteLine("Enter First Name Of Student :");
                        string fn = Console.ReadLine();
                        Console.WriteLine("Enter Last Name Of Student :");
                        string ln = Console.ReadLine();
                        Console.WriteLine("Enter age of student :");
                        string s_age = Console.ReadLine();
                        int sg = Convert.ToInt32(s_age);
                        Console.WriteLine("Enter level of study to student:");
                        string ls = Console.ReadLine();
                        Console.WriteLine("Enter number the class room of Teacher :");
                        string crs = Console.ReadLine();
                        int cls = Convert.ToInt32(crs);
                        Students s = new Students(sid1, fn, ln, sg, ls, cls);
                        s.info_personal();
                        Console.WriteLine("_________________________________________________________________");
                        Console.WriteLine("*Method For Calculation Grades* : ");
                        Console.WriteLine("Enter  Name Of Student : ");
                        string na = Console.ReadLine();
                        Console.WriteLine("How many subjects score? ");
                        string sub = Console.ReadLine();
                        int sb = Convert.ToInt32(sub);
                        Console.WriteLine("Enter Grade The First Exam : ");
                        string exa1 = Console.ReadLine();
                        double ex1 = Convert.ToDouble(exa1);
                        Console.WriteLine("Enter Grade The Second Exam :  ");
                        string exa2 = Console.ReadLine();
                        double ex2 = Convert.ToDouble(exa2);
                        Console.WriteLine("Enter Grade Homework : ");
                        string hom = Console.ReadLine();
                        double h = Convert.ToDouble(hom);
                        Console.WriteLine("Enter Grade project : ");
                        string pro = Console.ReadLine();
                        double p = Convert.ToDouble(pro);
                        Students s1 = new Students(na, ex1, ex2, h, p, sb);
                        Console.WriteLine("Score Of Grade = " + s1.score_of_grades());
                        Console.WriteLine("Proportion =" + s1.Proportion() + "%");
                        if (s1.Proportion() >= 90 && s1.Proportion() <= 100)
                            Console.WriteLine("^The Result student is Excellent^");
                        else if (s1.Proportion() >= 80 && s1.Proportion() < 90)
                            Console.WriteLine("^The Result student  is Very good^");
                        else if (s1.Proportion() >= 70 && s1.Proportion() < 80)
                            Console.WriteLine("^Good^");
                        else if (s1.Proportion() >= 50 && s1.Proportion() < 70)
                            Console.WriteLine("^The Result student is Acceptable^");
                        else if (s1.Proportion() <= 49)
                            Console.WriteLine("^The Result student is Fail^");
                        Console.WriteLine("_________________________________________________________________");
                        Console.WriteLine("*Method Get at Schedule to sudent* ");
                        Console.WriteLine("Enter the number of presence days : ");
                        string day = Console.ReadLine();
                        int dd = Convert.ToInt32(day);
                        Console.WriteLine("Enter number of periods : ");
                        Console.WriteLine("in Sunday : ");
                        string sun = Console.ReadLine();
                        int sn = Convert.ToInt32(sun);
                        Console.WriteLine("in Monday : ");
                        string mon = Console.ReadLine();
                        int mo = Convert.ToInt32(mon);
                        Console.WriteLine("in Tuesday : ");
                        string tues = Console.ReadLine();
                        int tue = Convert.ToInt32(tues);
                        Console.WriteLine("in Wednsday : ");
                        string wed = Console.ReadLine();
                        int we = Convert.ToInt32(wed);
                        Console.WriteLine("in Thursday : ");
                        string thur = Console.ReadLine();
                        int thu = Convert.ToInt32(thur);
                        Console.WriteLine("Enter subjects :");
                        string subb = Console.ReadLine();
                        Students sm = new Students(dd, sn, mo, tue, we, thu, subb);
                        sm.GetSchedule();
                        Console.WriteLine("_________________________________________________________________");

                        goto cc;
                        break;
                    }

                case 3:
                    {

                        Console.WriteLine("_________________________________________________________________");
                        Console.WriteLine("*Method Get at Information Personal of teacher*");
                        Console.WriteLine("_________________________________________________________________");
                        Console.WriteLine("Please enter information of teacher:");
                        Console.WriteLine("Enter teacherID :");
                        string t_id1 = Console.ReadLine();
                        int tid1 = Convert.ToInt32(t_id1);
                        Console.WriteLine("Enter First Name Of Teacher :");
                        string fn1 = Console.ReadLine();
                        Console.WriteLine("Enter Last Name Of Teacher :");
                        string ln1 = Console.ReadLine();
                        Console.WriteLine("Enter age of Teacher :");
                        string t_age1 = Console.ReadLine();
                        int tg1 = Convert.ToInt32(t_age1);
                        Console.WriteLine("Enter number phone of Teacher :");
                        string numpp = Console.ReadLine();
                        int nump = Convert.ToInt32(numpp);
                        Console.WriteLine("Enter number the class room of Teacher :");
                        string crr = Console.ReadLine();
                        int clr = Convert.ToInt32(crr);
                        Teachers her = new Teachers(tid1, fn1, ln1, tg1, nump, clr);
                        her.info_personal();
                        Console.WriteLine("_________________________________________________________________");
                        Console.WriteLine("*Method Get Net Salary To Teacher*");
                        Console.WriteLine("Enter daily salary: ");
                        string daisa = Console.ReadLine();
                        int ddss = Convert.ToInt32(daisa);
                        Console.WriteLine("Enter number of day presence: ");
                        string dapre = Console.ReadLine();
                        int dap = Convert.ToInt32(dapre);
                        Teachers tea = new Teachers(ddss, dap);
                        Console.WriteLine("Net Salary = " + tea.GetSalary() + "$");
                        Console.WriteLine("The bonus =  " + tea.GetSalary() * 0.1 + "$");
                        Console.WriteLine("_________________________________________________________________");
                        Console.WriteLine("*Method Get at Schedule to teacher* ");
                        Console.WriteLine("Enter numer of days: ");
                        string day2 = Console.ReadLine();
                        int dd2 = Convert.ToInt32(day2);
                        Console.WriteLine("Enter numert of periods : ");
                        Console.WriteLine("in Sunday : ");
                        string sun2 = Console.ReadLine();
                        int sn2 = Convert.ToInt32(sun2);
                        Console.WriteLine("in Monday : ");
                        string mon2 = Console.ReadLine();
                        int mo2 = Convert.ToInt32(mon2);
                        Console.WriteLine("in Tuesday : ");
                        string tues2 = Console.ReadLine();
                        int tue2 = Convert.ToInt32(tues2);
                        Console.WriteLine("in Wednsday : ");
                        string wed2 = Console.ReadLine();
                        int we2 = Convert.ToInt32(wed2);
                        Console.WriteLine("in Thursday : ");
                        string thur2 = Console.ReadLine();
                        int thu2 = Convert.ToInt32(thur2);
                        Console.WriteLine("Enter subjects :");
                        string subb2 = Console.ReadLine();
                        Teachers sm2 = new Teachers(dd2, sn2, mo2, tue2, we2, thu2, subb2);
                        sm2.GetSchedule();
                        goto cc;
                        break;
                    }
                case 4:
                    {
                        Course a11;
                        a11 = new primary_stage();
                        a11.Coursename();
                        a11.book();
                        a11 = new middle_stage();
                        a11.Coursename();
                        a11.book();
                        a11 = new high_stage();
                        a11.Coursename();
                        a11.book();
                        goto cc;
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("                         WE HAVE THE BOOKS : ");
                        Console.WriteLine("|_________________________________________________________________________|");
                        Console.WriteLine("|________Educational Boooks___________|________Entertainment Books________|");
                        Console.WriteLine("|-------------------------------------|-----------------------------------|");
                        Console.WriteLine("|__Astronomy book_____________________|__The Miserables novel_____________|");
                        Console.WriteLine("|__Biology book_______________________|__A novel of war and peace_________|");
                        Console.WriteLine("|__chemistry book_____________________|__The little prine novel___________|");
                        Console.WriteLine("|__Management Principles______________|__Series fo Harry potter novel_____|");
                        Console.WriteLine("|__Information secuity and encryption_|__Ibn BattUta's journey____________|");
                        Console.WriteLine("|--Machine Learning AI________________|__One Thousand and One Nights______|");
                        Console.WriteLine("|_________________________________________________________________________|");

                        Console.WriteLine("\n");

                        Console.WriteLine("What Book do you want to restore ? ");
                        Console.WriteLine("Enter Book name:");
                        string BookName = Console.ReadLine();

                        Console.WriteLine("Enter Borrow Date :  Day / Month / Year  ");
                        Console.WriteLine("Enter Day:");
                        string day = Console.ReadLine();
                        int da = Convert.ToInt32(day);
                        Console.WriteLine("Enter Month :");
                        string month = Console.ReadLine();
                        int mo = Convert.ToInt32(month);
                        Console.WriteLine("Enter year :");
                        string year = Console.ReadLine();
                        int ye = Convert.ToInt32(year);

                        Console.WriteLine("***************************************");

                        Console.WriteLine("Enter Return Date : Day / Month / Year ");
                        Console.WriteLine("Enter Date :");
                        string day1 = Console.ReadLine();
                        int d = Convert.ToInt32(day1);
                        Console.WriteLine("Enter Month :");
                        string month1 = Console.ReadLine();
                        int m = Convert.ToInt32(month1);
                        Console.WriteLine("Enter year :");
                        string year1 = Console.ReadLine();
                        int y = Convert.ToInt32(year1);
                        Libraiy l = new Libraiy(BookName, da, mo, ye, d, m, y);
                        l.DisplayBookInfo();
                        goto cc;
                        break;
                    }

                case 6:
                    {

                        Tuition_fees c = new Tuition_fees();

                        Console.WriteLine("*Method Get at BUS FEE* : ");
                        Console.WriteLine("Enter number of days :");
                        string days = Console.ReadLine();
                        double da = Convert.ToDouble(days);

                        Console.WriteLine("Enter Fare today :");
                        string Fare_today = Console.ReadLine();
                        double fa = Convert.ToDouble(Fare_today);
                        c.fee(da, fa);
                        Console.WriteLine("*Method Get at YEAR FEE* :");
                        Console.WriteLine("Enter installment_1 :");
                        string installment_1 = Console.ReadLine();
                        int in1 = Convert.ToInt32(installment_1);

                        Console.WriteLine("Enter installment_2 :");
                        string installment_2 = Console.ReadLine();
                        int in2 = Convert.ToInt32(installment_2);

                        Console.WriteLine("Enter installment_3 :");
                        string installment_3 = Console.ReadLine();
                        int in3 = Convert.ToInt32(installment_3);

                        Console.WriteLine("Enter installment_4 :");
                        string installment_4 = Console.ReadLine();
                        int in4 = Convert.ToInt32(installment_4);
                        c.fee(in1, in2, in3, in4);

                        Console.WriteLine("*Method Get atTrips_Fee* : ");
                        Console.WriteLine("Enter Food :");
                        string Food = Console.ReadLine();
                        int fo = Convert.ToInt32(Food);

                        Console.WriteLine("Enter Drinks :");
                        string Drinks = Console.ReadLine();
                        int dr = Convert.ToInt32(Drinks);

                        Console.WriteLine("Enter Reservation Place :");
                        string Reservation_Place = Console.ReadLine();
                        int rp = Convert.ToInt32(Reservation_Place);
                        c.fee(fo, dr, rp);
                        goto cc;
                        break;
                    }
                case 7:
                    {
                        Class_room school;
                        school = new first_floor();
                        school.classroom();

                        school = new Second_floor();
                        school.classroom();

                        school = new Third_floor();
                        school.classroom();

                        goto cc;
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("_________________________________________________________________");
                        Console.WriteLine("*Method Get at employee salary*");
                        Console.WriteLine("Enter the worker");
                        string n2 = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter the hourly wage for the worker");
                        string far = Console.ReadLine();
                        double f = Convert.ToInt32(far);
                        Console.WriteLine();

                        Console.WriteLine("Enter the numper of working hours for the worker");
                        string ver = Console.ReadLine();
                        double v = Convert.ToInt32(ver);
                        Console.WriteLine();

                        Console.WriteLine("Enter the numper of vacation days that were used");
                        string dir = Console.ReadLine();
                        double d = Convert.ToInt32(dir);
                        Console.WriteLine();

                        Console.WriteLine("Enter the value of allowances for the worker");
                        string han = Console.ReadLine();
                        double h = Convert.ToInt32(han);
                        Console.WriteLine();

                        double totalSalary = Employee.calculateSalary(n2, f, v, d, h);
                        Console.WriteLine("The name of the employee is :" + n2);
                        Console.WriteLine();
                        Console.WriteLine("Salary: " + (totalSalary));
                        Console.WriteLine("*Method Get at Number of emploees* ");
                        Console.WriteLine("Enter name of employee1:");
                        string namemp1 = Console.ReadLine();
                        Console.WriteLine("Enter job of employee1:");
                        string job1 = Console.ReadLine();
                        Employee emp1 = new Employee(namemp1, job1);
                        Console.WriteLine("Enter name of employee2:");
                        string namemp2 = Console.ReadLine();
                        Console.WriteLine("Enter job of employee2:");
                        string job2 = Console.ReadLine();
                        Employee emp2 = new Employee(namemp2, job2);
                        Console.WriteLine("Enter name of employee2:");
                        string namemp3 = Console.ReadLine();
                        Console.WriteLine("Enter job of employee3:");
                        string job3 = Console.ReadLine();
                        Employee emp3 = new Employee(namemp3, job3);
                        Console.WriteLine("Enter name of employee3:");
                        string namemp4 = Console.ReadLine();
                        Console.WriteLine("Enter job of employee4:");
                        string job4 = Console.ReadLine();
                        Employee emp4 = new Employee(namemp4, job4);
                        Console.WriteLine("Number of emploees= " + Employee.getnumofemp());

                        goto cc;
                        break;
                    }
                case 9:
                    {
                        Cafeteria caf = new Cafeteria();
                        goto cc;
                        break;
                    }
                default:
                    Console.WriteLine("Please choose the right option");
                    goto cc;
                    break;

            }
            Console.ReadKey();
        }
    }
}
