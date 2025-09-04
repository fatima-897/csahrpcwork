using System;
using System.Data;
namespace OOP
{
    //class Program
    //{
    //   // public Program() //constructor
    //   // {
    //   //     Console.WriteLine("Constructor!");  
    //   // }
    //   ////parametarized cunstroctor
    //   //public Program(int a , int b)
    //   // {
    //   //     Console.WriteLine("A + B = {0}", a + b);
    //   // }
    //   // public Program(int a, int b, int c)
    //   // {
    //   //     Console.WriteLine("Addition on three numbers = {0}", a + b + c);
    //   // }
    //   // public Program(string a, string b, string c)
    //   // {
    //   //     Console.WriteLine("Addition on three students = {0}", a + b + c);
    //   // }

    //   // public static void Main(string[] args)
    //   // {
    //   //     Program p = new Program();
    //   //     Program p1 = new Program(40,50);
    //   //     Program p2 = new Program(12, 78, 65);
    //   //     Program p3 = new Program("sara ", "ali " , "jhon");

    //   //     Console.ReadLine();
    //   // }
    
    
    //}
    
    //class rectangle pg 205

    //class Rectangle
    //{
    //    double length;
    //    double breadth;
    //    public Rectangle()
    //    {
    //         length = 13.5;
    //         breadth = 20.5;
    //    }

    //    //method/function
    //    public Rectangle(double x , double y)
    //    {
    //        length = x;
    //        breadth = y;
    //    }
    //    public double Area()
    //    {
    //        return length*breadth;
    //    }
    //    static void Main(string[] args)
    //    {
    //        //objects
    //        Rectangle rectangle = new Rectangle();
    //        Console.WriteLine(rectangle.Area());

    //        Rectangle rectangle1 = new Rectangle(2.5,6.5);
    //        Console.WriteLine(rectangle1.Area());
    //    }
    //}

    //pg 206

    //class Employee
    //{
    //    private int Empid;
    //    private string Empname;
    //    private int Empage;
    //    private int Empsalary;

    //    public Employee(int id, string name,int age, int salary)
    //    {
    //        Empid = id;
    //        Empname = name;
    //        Empage = age;
    //        Empsalary = salary;
    //    }
    //    ~Employee() 
    //    {
    //        Console.WriteLine("Destructor for Employee called");
    //    }//it deallocate the memorie after being called
    //    static void Main(string[] args)
    //    {

    //        Employee employee1 = new Employee(1, "jhon", 34, 55000);
    //        Console.WriteLine("Employee ID: "+employee1.Empid);
    //        Console.WriteLine("Employee Name: " + employee1.Empname);
    //        Console.WriteLine("Employee Age: " + employee1.Empage);
    //        Console.WriteLine("Employee Salary: " + employee1.Empsalary);
    //    }
    //}

    //Inheritance(Sharing of information)
}

// constructor is named after your class
// same ==> constructor class === program
// constructor wo hota hai jo apni class ke nam pr bnaya jaiy

//        }
//    }

//    class program
//    {
//        static void Main(string[] args)
//        {

//            Departement objDep = new Departement();
//            objDep.Display();
//        }
//    }


//class Animal
//    {
//public virtual void Eat()
//        {
//            Console.WriteLine("Every animals eats something.");
//        }
//    }


//    class Cat : Animal
//    {
////class cat override the method Eat() of class Animal
//public override void Eat()
//        {
//            Console.WriteLine("cat loves to eat biscuits.");
//        }

//        static void Main(string[] args)
//        {
//            Cat cat = new Cat();
//            cat.Eat();
//        }

//    }
//class Vehicle
//    {
//        //virtual method base/psrent class method(overriden)
//        public virtual void Honk()
//        {
//            Console.WriteLine("Generic vehicle honk!");
//        }
//    }

//    class Car : Vehicle
//    {
//        //override: provides its own version of  Honk()
//        public override void Honk()
//        {
//            Console.WriteLine("car honk: Beep beep!");
//        }
//    }


//class Bike : Vehicle
//    {
//public override void Honk()
//        {
//            Console.WriteLine("Bike honk: peep peep!");
//        }
//    }


//class Truck : Vehicle
//    {
//        public override void Honk()
//        {
//            Console.WriteLine("Truck honk: hoooooonkk!");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//            {
//            Car Alto = new Car();
//            Alto.Honk();

//            Bike Honk = new Bike();
//            Honk.Honk();
//        }
//    }







// pg 230 code 9
// class Student
//{
//    string studentName = "Janems";
//    string address = "Califtornia";

//    public virtual void BioData()
//    {
//        Console.WriteLine("Student Name: "+ studentName);
//        Console.WriteLine("Address: "+address);
//    }
//}

//class Graed : Student
//{
//    string grade = "Four";
//    float percentage = 81.7f;

//    public override void BioData()
//    {
//        Console.WriteLine("class: "+ grade);
//        Console.WriteLine("percentage: "+ percentage);
//    }
//    static void Main()
//    {
//        Student student = new Student();
//        student.BioData();

//        Grade grade = new Grade();
//        grade.BioData();

//    }







//class Father 
//{
//    public void Speak()
//    {
//        Console.WriteLine("I am the father.");
//    }
//}

//class Son : Father
//{
//    public void play()
//    {
//        Console.WriteLine("I love to play cricket");
//    }

//    static void Main()
//    {
//        Son son = new Son();
//        son.Speak();
//        son.play();

//    }

//}

//MULTI_LEVEL INHERITANCE
//grand father->father->son


//    class GrandFather
//    {
//        public void Legacy()
//        {
//            Console.WriteLine("This is grandfathers legacy.");
//        }
//    }
//    class Father : GrandFather
//    {
//        public void Wisdom()
//        {
//            Console.WriteLine("Father Wisdom passed down.");
//        }

//    }

//class son : Father
//    {
//        public void play()
//        {
//            Console.WriteLine("I love to play cricket.");
//        }
//        static void Man()
//        {
//            son Ali = new son();
//            Ali.Legacy();
//            Ali.Wisdom();
//            Ali.play();
//        }


//    }


//HERIRATCHICAL INHERITANCE
//one parent, multilple children
//teacher base class
//Mathteacher , scienceteacher , Englishteacher
//




//class Teacher
//{
//public void Teach()
//{
//    Console.WriteLine("Teaching students...");
//  }
//}

//class MathTeacher : Teacher
//{
//public void SolveMaths()
//{
//    Console.WriteLine("Solving math problems.");
//  }
//}

//class ScienceTeacher : Teacher
//{
//public void DoExperiment()
//{
//  Console.WriteLine("Doing science experiments.");
//}

//static void Main()
//{
// Create instances to call instance methods
//MathTeacher mathTeacher = new MathTeacher();
//  mathTeacher.SolveMaths();

//    ScienceTeacher scienceTeacher = new ScienceTeacher();
//      scienceTeacher.DoExperiment();
//}
//}








//MULTIPLEINHERITANCE 
//one class inheritance form multiple classess
//smartPhone interitance from camera and phone 


// Define the Camera interface
//interface ICamera
//{
//  void TakePhoto();
//}

// Define the Phone interface
//interface IPhone
//{
//  void MakeCall(string number);
//}

// Implement both interfaces in SmartPhone
//class SmartPhone : IPhone, ICamera
//{
//public void MakeCall(string number)
//{
//  Console.WriteLine($"Calling {number}...");
//}

//public void TakePhoto()
//{
//    Console.WriteLine("Taking a photo...");
//  }
//}

//class Program
//{
//static void Main()
//{
//SmartPhone myPhone = new SmartPhone();
//  myPhone.MakeCall("123‑456‑7890");
//    myPhone.TakePhoto();
//  }
//}


///abrhamwork

using opp;
using System;
namespace opp
{
    //class Program //constructer wahi hai jo class ka naam par banaya jaye
    //{
    //    public Program() //class is blueprint
    //        {
    //        Console.WriteLine("Constructor!!");
    //        }
    //    static void Main(string[] args)
    //        //object
    //    {
    //      Program p= new Program();
    //        //class variable obj constructor

    //    }

    //}


    //BOOK PAGE 205 Parameterize function


    // Default constructor
    //    public Program()
    //    {
    //        Console.WriteLine("constructor!!");
    //    }

    //    // Constructor with two integers
    //    public Program(int a, int b)
    //    {
    //        Console.WriteLine("A+B = {0}", a + b);
    //    }

    //    // Constructor with three integers
    //    public Program(int a, int b, int c)
    //    {
    //        Console.WriteLine("Sum of three number = {0}", a + b + c);
    //    }

    //    // Constructor with three strings
    //    public Program(string a, string b, string c)
    //    {
    //        Console.WriteLine("Sum of three students = {0}", a + b + c);
    //    }

    //    // Main method (entry point)
    //    static void Main(string[] args)
    //    {
    //        Program p = new Program();
    //        Program p1 = new Program(140, 50);
    //        Program p2 = new Program(50, 20, 50);
    //        Program p3 = new Program("sara", "umer", "zayn");
    //        Console.ReadLine();
    //    }
    //}

    //}

    //class Rectangle
    //{
    //    double length;
    //    double breadth;

    //    public Rectangle()
    //    {
    //        length = 13.5;
    //        breadth = 20.5;
    //    }

    //    public Rectangle(double x, double y)
    //    {
    //        length = x;
    //        breadth = y;
    //    }

    //    public double Area()
    //    {
    //        return length * breadth;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Rectangle rectangle = new Rectangle();
    //        Console.WriteLine(rectangle.Area());

    //        Rectangle rectangle1 = new Rectangle(2.5, 6.5);
    //        Console.WriteLine(rectangle1.Area());
    //        Console.ReadLine();
    //    }

    //}

    //class Employee
    //{
    //    private int empid;
    //    private string empname;
    //    private int age;
    //    private double salary;

    //    Employee(int id, string name, int age, double salary)
    //    {
    //        Console.WriteLine("Constructor for Employee called");
    //        empid = id;
    //        empname = name;
    //        this.age = age;
    //        this.salary = salary;
    //    }

    //    ~Employee()
    //    {
    //        Console.WriteLine("Destructor for employee called");
    //    }

    //    static void Main(string[] args)
    //    {
    //        Employee objEmp = new Employee(1, "john", 45, 35000);
    //        Console.WriteLine("EmployeeID: " + objEmp.empid);
    //        Console.WriteLine("EmployeeName: " + objEmp.empname);
    //        Console.WriteLine("Age: " + objEmp.age);
    //        Console.WriteLine("Salary: " + objEmp.salary);
    //        Console.ReadLine();
    //    }
    //}

    //using System;

    //class Employee
    //{
    //    public int EmpID;
    //    public string EmpName;
    //    public int Age;
    //    public string ContactNo;
    //}

    //// child/derived class
    //class VisitingEmployee : Employee
    //{
    //    public int VisitingHours;
    //    public int VisitingSalary;
    //}

    //class PermanentEmployee : Employee
    //{
    //    public int PermanentHours;
    //    public int PermanentSalary;
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        VisitingEmployee emp1 = new VisitingEmployee();
    //        emp1.EmpID = 1;
    //        emp1.Age = 24;
    //        emp1.EmpName = "Umer";
    //        emp1.VisitingSalary = 500000;
    //        emp1.VisitingHours = 8;

    //        Console.WriteLine("Visiting Employee Name: " + emp1.EmpName);
    //        Console.WriteLine("Visiting Salary: " + emp1.VisitingSalary);

    //        PermanentEmployee emp2 = new PermanentEmployee();
    //        emp2.EmpID = 2;
    //        emp2.EmpName = "Ali";
    //        emp2.ContactNo = "456654654";

    //        Console.WriteLine("\nPermanent Employee Name: " + emp2.EmpName);
    //        Console.WriteLine("Contact No: " + emp2.ContactNo);

    //        Console.ReadLine();
    //    }
    //}

    //using System;

    //class Animal
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("Every animal eats everything");
    //    }
    //}

    //class Mammal : Animal
    //{
    //    public void Feature()
    //    {
    //        Console.WriteLine("Mammals give birth to young one");
    //    }
    //}

    //class Dog : Mammal
    //{
    //    public void Noise()
    //    {
    //        Console.WriteLine("Dog Barks");
    //    }

    //    static void Main(string[] args)
    //    {
    //        Dog objDog = new Dog();
    //        objDog.Eat();
    //        objDog.Feature();
    //        objDog.Noise();
    //    }
    //}

    //using System;

    //class Animal
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("Animal Eats Everything");
    //    }

    //    public void DoSomething()
    //    {
    //        Console.WriteLine("Every animal does Something");
    //    }
    //}

    //class Cat : Animal
    //{
    //    static void Main(string[] args)
    //    {
    //        Cat objCat = new Cat();
    //        objCat.Eat();
    //        objCat.DoSomething();
    //    }
    //}
    //using System;

    //class Employees
    //{
    //    int empId = 1;
    //    string empName = "James Anderson";
    //    int age = 25;

    //    public void Display()
    //    {
    //        Console.WriteLine("Employee Id"+empId);
    //        Console.WriteLine("Employee Name"+empName);
    //        Console.WriteLine("Employee Age"+age);
    //    }
    //}

    //class Departement
    //{
    //    int depId = 501;
    //    string depName = "sales";

    //    public void Display()
    //    {
    //        Console.WriteLine("Departement ID: " + depId);
    //        Console.WriteLine("Departement Name: " + depName);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Departement objDep = new Departement();
    //        objDep.Display();

    //    }
    //}

    //using System;

    //class Student
    //{
    //    string _studentName = "James";
    //    string _address = "California";

    //    // Virtual method (can be overridden in derived class)
    //    public virtual void PrintDetails()
    //    {
    //        Console.WriteLine("Student Name: " + _studentName);
    //        Console.WriteLine("Address: " + _address);
    //    }
    //}

    //class Grade : Student
    //{
    //    string _class = "Four";
    //    float _percent = 71.25f;

    //    // Overriding the base class method
    //    public override void PrintDetails()
    //    {
    //        Console.WriteLine("Class: " + _class);
    //        Console.WriteLine("Percentage: " + _percent);
    //    }

    //    // Entry point of the program
    //    static void Main(string[] args)
    //    {
    //        Student objStudent = new Student(); // Base class object
    //        Grade objGrade = new Grade();       // Derived class object

    //        objStudent.PrintDetails(); // Calls Student.PrintDetails()
    //        objGrade.PrintDetails();   // Calls Grade.PrintDetails()
    //    }
    //}

    //class Vehicle
    //{
    //    public virtual void Honk()
    //    {
    //        Console.WriteLine("Generic vehicle Honk!!!");
    //    }
    //}
    //class Car : Vehicle
    //{
    //    public override void Honk()
    //    {
    //        Console.WriteLine("Car Honk: Beep Beep!");
    //    }


    //}
    //class Bike : Vehicle
    //{
    //    public override void Honk()
    //    {
    //        Console.WriteLine("Bike Honk: Peep Peep!");
    //    }
    //}
    //class Truck : Vehicle
    //{
    //    public override void Honk()
    //    {
    //        Console.WriteLine("Truck Honk: HOOOONNNKK!");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Car Alto = new Car();
    //        Alto.Honk();

    //        Bike Honda = new Bike();
    //        Honda.Honk();

    //    }
    //}

    //pg 230 code 9
    //class Student
    //{
    //    string StudentName = "James";
    //    string address = "California";

    //    public virtual void BioData()
    //    {
    //        Console.WriteLine("Student Name: "+ StudentName);
    //        Console.WriteLine("Student Address: "+ address);
    //    }
    //}

    //class Grade : Student
    //{
    //    string grade = "Four";
    //    float percentage = 81.7f;

    //    public override void BioData()
    //    {
    //        Console.WriteLine("Class: "+ grade);
    //        Console.WriteLine("Percentage: "+ percentage);
    //    }
    //    static void Main()
    //    {
    //        Student student = new Student();
    //        student.BioData();

    //        Student grade = new Grade();
    //        grade.BioData();
    //    }
    //}

    //Types of inheritance in c#
    //SINGLE

    //class Father
    //{
    //    public void Speak()
    //    {
    //        Console.WriteLine("I am a Father");
    //    }
    //}
    //class Son : Father
    //{
    //    public void Play()
    //    {
    //        Console.WriteLine("I love to play circket");
    //    }
    //    static void Main()
    //    {
    //        Son son = new Son();
    //        son.Speak();
    //        son.Play();
    //    }
    //}

    //MULTI LEVEL
    //class GrandFather
    //{
    //    public void Legacy()
    //    {
    //        Console.WriteLine("This is the GrandFather legacy");
    //    }
    //}
    //class Father:GrandFather
    //{
    //    public void Wisdom()
    //    {
    //        Console.WriteLine("Father wisdom passed door");
    //    }
    //}
    //class Son : Father
    //{
    //    public void Play()
    //    {
    //        Console.WriteLine("Son love to play");
    //    }

    //static void Main()
    //    {
    //        Son Ali = new Son();
    //        Ali.Play();
    //        Ali.Wisdom();
    //        Ali.Legacy();
    //    }
    //}

    //HIERARICLE // one parent multiple children

    //using System;

    //namespace HierarchicalInheritanceExample
    //{
    //    // Base Class
    //    class Teacher
    //    {
    //        public void Teach()
    //        {
    //            Console.WriteLine("Teaching...");
    //        }
    //    }

    //    // Derived Class 1
    //    class MathTeacher : Teacher
    //    {
    //        public void Solve()
    //        {
    //            Console.WriteLine("Solving Math problems");
    //        }
    //    }

    //    // Derived Class 2
    //    class ScienceTeacher : Teacher
    //    {
    //        public void DoExperiment()
    //        {
    //            Console.WriteLine("Doing Science Experiments");
    //        }
    //    }

    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            // Create MathTeacher object
    //            MathTeacher mathTeacher = new MathTeacher();
    //            Console.WriteLine("Math Teacher:");
    //            mathTeacher.Teach();   // From Teacher class
    //            mathTeacher.Solve();   // From MathTeacher class

    //            Console.WriteLine();

    //            // Create ScienceTeacher object
    //            ScienceTeacher scienceTeacher = new ScienceTeacher();
    //            Console.WriteLine("Science Teacher:");
    //            scienceTeacher.Teach();        // From Teacher class
    //            scienceTeacher.DoExperiment(); // From ScienceTeacher class

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //Multiple Inheritance
    //one class inherit from multiple classes
    //Smartphone inherit from camera and phone

    //using System;

    //namespace MultipleInheritanceWithInterfaces
    //{
    //    // Interface 1
    //    interface Camera
    //    {
    //        void Takephoto();
    //    }

    //    // Interface 2
    //    interface Phone
    //    {
    //        void MakeCall();
    //    }

    //    // Class implementing both interfaces
    //    class SmartPhone : Phone, Camera
    //    {
    //        public void MakeCall()
    //        {
    //            Console.WriteLine("Making a phone call");
    //        }

    //        public void Takephoto()
    //        {
    //            Console.WriteLine("Taking a photo");
    //        }
    //    }

    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            SmartPhone myPhone = new SmartPhone();

    //            myPhone.MakeCall();   // From Phone interface
    //            myPhone.Takephoto();  // From Camera interface

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //HYBRID INHERITANCE
    //combination of multiple types

    using System;

    namespace InterfaceExample
    {
        // Base class
        class Person
        {
            public void Walk()
            {
                Console.WriteLine("Person is walking");
            }
        }

        // Interface 1
        interface IStudent
        {
            void Study();
        }

        // Interface 2
        interface IEmployee
        {
            void Work();
        }

        // Derived class implementing both interfaces and inheriting from Person
        class WorkingStudent : Person, IStudent, IEmployee
        {
            public void Study()
            {
                Console.WriteLine("Studying at night");
            }

            public void Work()
            {
                Console.WriteLine("Work at day");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                WorkingStudent ws = new WorkingStudent();

                Console.WriteLine("Working Student Activities:");
                ws.Walk();   // Inherited from Person
                ws.Study();  // From IStudent
                ws.Work();   // From IEmployee

                Console.ReadLine();  // Optional, to keep console open
            }
        }
    }
}
//

///rest of the work

//class Person
    //{
        //public void Walk()
        //{
        //    Console.WriteLine("Person is walking.");
      //  }
    //}

    //interface IStudent
    //{
      //  void Study();
    //}

    //interface IEmployee
    //{
  //      void Work();
//    }

    //class WorkingStudent : Person, IStudent, IEmployee
    //{
        //public void Study()
        //{
          //  Console.WriteLine("Studying at night.");
        //}

        //public void Work()
        //{
        //    Console.WriteLine("Working during the day.");
      //  }
    //}

    //class Program
    //{
        //static void Main()
        //{
            //WorkingStudent ws = new WorkingStudent();

          //  ws.Walk();     // from Person
        //    ws.Study();    // from IStudent
       //     ws.Work();     // from IEmployee
     //   }
    //}
