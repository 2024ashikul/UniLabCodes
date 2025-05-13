using System;

//Short notes: You can not make a instance of a Abstract Class
abstract class Subject{
    public abstract void GetDetails();
    //public abstract int SubjectId;
}

class Course : Subject{
    static public int CourseCount=0;
    int SubjectId;
    string Title;
    int CreditHours;
    public Course(int SubjectId,string Title,int CreditHours){
        this.SubjectId = SubjectId;
        this.Title = Title;
        this.CreditHours = CreditHours;
    }
    public override void GetDetails()
    {
        Console.WriteLine($"{this.SubjectId}     Course      Title:{this.Title}, Credits : {this.CreditHours}");
    }
}



class Seminar : Subject{
    static public int SeminarCount=0;
    int SubjectId;
    string Title;
    double duration;
    public Seminar(int SubjectId,string Title,double duration){
        this.SubjectId = SubjectId;
        this.Title = Title;
        this.duration = duration;
    }
    public override void GetDetails()
    {
        Console.WriteLine($"{this.SubjectId}     Seminar      Title:{this.Title}, Duration : {this.duration}hrs");
    }
}

class Lab : Subject{
    static public int LabCount = 0;
    int SubjectId;
    string Title;
    int EquipmentCount;
    public Lab(int SubjectId,string Title,int EquipmentCount){
        this.SubjectId = SubjectId;
        this.Title = Title;
        this.EquipmentCount = EquipmentCount;
    }
    public override void GetDetails()
    {
        Console.WriteLine($"{this.SubjectId}     Lab      Title:{this.Title}, Equipment Count : {this.EquipmentCount}");
    }
}



class Program{
    static void Main(){
        List<Course> Courses = new List<Course>();
        List<Seminar> Seminars = new List<Seminar>();
        List<Lab> Labs = new List<Lab>();
        int test = 1;
        while(true){
            if(test == 0){
                break;
            }
            Console.WriteLine("\nPlease select a option");
            Console.WriteLine("1. Add a Course");
            Console.WriteLine("2. Add a Seminar");
            Console.WriteLine("3. Add a Lab");
            Console.WriteLine("4. List Subjects");
            Console.WriteLine("5. Exit");
            int n;
            inputtingN:
                try{
                    n = Convert.ToInt32(Console.ReadLine());
                }catch(Exception e){
                    
                    Console.WriteLine("Please give me a valid input");
                    goto inputtingN;
                }
            switch(n){
                
                case 1:
                    temp:
                        Console.Write("Course Title:");
                        string t1 = Console.ReadLine();
                        if(t1 == ""){
                            Console.WriteLine("Invalid Title, Please give me a valid non-empty string");
                            goto temp;
                        }
                    Console.Write("Credit  Hours:");
                    int CreditHours = Convert.ToInt32(Console.ReadLine());
                    Course.CourseCount++;
                    int c1 = Course.CourseCount;
                    Courses.Add(new Course(c1,t1,CreditHours));
                break;
                case 2:
                    Console.Write("Course Title:");
                    string t2 = Console.ReadLine();
                    Console.Write("Credit  Hours:");
                    double duration = Convert.ToDouble(Console.ReadLine());
                    Seminar.SeminarCount++;
                    int c2 = Seminar.SeminarCount;
                    Seminars.Add(new Seminar(c2,t2,duration));
                break;
                case 3:
                    Console.Write("Course Title:");
                    string t3 = Console.ReadLine();
                    Console.Write("Credit  Hours:");
                    int EquipmentCount = Convert.ToInt32(Console.ReadLine());
                    Lab.LabCount++;
                    int c3 = Lab.LabCount;
                    Labs.Add(new Lab(c3,t3,EquipmentCount));
                break;
                case 4:
                    Console.WriteLine("\n--- Course List ---");
                    Console.WriteLine("ID       Type        Details ");
                    Console.WriteLine("============================");
                    
                    foreach(Course i in Courses){
                            i.GetDetails();
                    }
                    Console.WriteLine("\n--- Seminar List ---");
                    Console.WriteLine("ID       Type        Details ");
                    Console.WriteLine("============================");
                    
                    foreach(Seminar i in Seminars){
                            i.GetDetails();
                    }
                    Console.WriteLine("\n--- Lab List ---");
                    Console.WriteLine("ID       Type        Details ");
                    Console.WriteLine("============================");
                    
                    foreach(Lab i in Labs){
                        i.GetDetails();
                    }
                    Console.WriteLine($"\nTotal Courses : {Course.CourseCount}");
                    Console.WriteLine($"Total Seminar : {Seminar.SeminarCount}");
                    Console.WriteLine($"Total Lab : {Lab.LabCount}");
                    break;
                    
                case 5:
                    Console.WriteLine("Exiting....\n");
                    test = 0;
                break;
            }
        }
    }
}