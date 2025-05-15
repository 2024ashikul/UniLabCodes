using System; 

 

//Short notes: You can not make a instance of a Abstract Class 

//Declaring the Classes 

abstract class Subject 

{ 

public abstract void GetDetails(); 

public int SubjectId; 

} 

 

//Declaring the subject class 

class Course : Subject 

{ 

static public int CourseCount = 0; 

string Title; 

int CreditHours; 

public Course(int SubjectId, string Title, int CreditHours){ 

this.SubjectId = SubjectId; 

this.Title = Title; 

this.CreditHours = CreditHours; 

} 

public override void GetDetails(){ 

Console.WriteLine($"{this.SubjectId} Course Title:{this.Title}, Credits : {this.CreditHours}"); 

} 

} 

 

//Declaring Seminar class 

class Seminar : Subject{ 

static public int SeminarCount=0; 

string Title; 

double duration; 

public Seminar(int SubjectId,string Title,double duration){ 

this.SubjectId = SubjectId; 

this.Title = Title; 

this.duration = duration; 

} 

public override void GetDetails(){ 

Console.WriteLine($"{this.SubjectId} Seminar Title:{this.Title}, Duration : {this.duration}hrs"); 

} 

} 

 

class Lab : Subject{ 

static public int LabCount = 0; 

string Title; 

int EquipmentCount; 

public Lab(int SubjectId,string Title,int EquipmentCount){ 

this.SubjectId = SubjectId; 

this.Title = Title; 

this.EquipmentCount = EquipmentCount; 

} 

public override void GetDetails(){ 

Console.WriteLine($"{this.SubjectId} Lab Title:{this.Title}, Equipment Count : {this.EquipmentCount}"); 

} 

} 

 

 

class Program{ 

static void Main() 

{ 

//Generalized a function that takes string input and throws an error if the string is empty 

string TakeString(){ 

string temp; 

temp1: 

temp = Console.ReadLine(); 

if (temp == ""){ 

Console.WriteLine("Invalid Title, Please give me a valid non-empty string"); 

goto temp1; 

} 

return temp; 

} 

//Took input of integer, if there is non-integer value then it throws an error 

int TakeInt(){ 

int temp; 

inputtingN: 

try{ 

temp = Convert.ToInt32(Console.ReadLine()); 

} 

catch (Exception e) 

{ 

Console.WriteLine("Please give me a valid input"); 

goto inputtingN; 

} 

return temp; 

} 

//Took input of Double, if there is non-double value then it throws an error 

double TakeDouble(){ 

double temp; 

inputtingN: 

try{ 

temp = Convert.ToDouble(Console.ReadLine()); 

} 

catch (Exception e) 

{ 

Console.WriteLine("Please give me a valid input"); 

goto inputtingN; 

} 

return temp; 

} 

//Declared the lists 

List<Course> Courses = new List<Course>(); 

List<Seminar> Seminars = new List<Seminar>(); 

List<Lab> Labs = new List<Lab>(); 

int test = 1; 

//Start of the main program 

while (true){ 

if (test == 0){ 

break; 

} 

//MENU 

Console.WriteLine("\nPlease select a option"); 

Console.WriteLine("1. Add a Course"); 

Console.WriteLine("2. Add a Seminar"); 

Console.WriteLine("3. Add a Lab"); 

Console.WriteLine("4. List Subjects"); 

Console.WriteLine("5. Exit"); 

int n = TakeInt(); 

switch (n) 

{ 

//Conditions for the courses 

case 1: 

Console.Write("Course Title :"); 

string t1 = TakeString(); 

Console.Write("Credit Hours:"); 

int CreditHours = TakeInt(); 

Course.CourseCount++; 

int c1 = Course.CourseCount; 

Courses.Add(new Course(c1, t1, CreditHours)); 

Console.WriteLine("Course added successfully\n"); 

break; 

//Conditions for the seminars 

case 2: 

Console.Write("Seminar Title:"); 

string t2 = TakeString(); 

Console.Write("Duration :"); 

double duration = TakeDouble(); 

Seminar.SeminarCount++; 

int c2 = Seminar.SeminarCount; 

Seminars.Add(new Seminar(c2, t2, duration)); 

Console.WriteLine("Seminar added successfully\n"); 

break; 

//Conditions for the labs 

case 3: 

Console.Write("Lab Title:"); 

string t3 = TakeString(); 

Console.Write("Equipment count:"); 

int EquipmentCount = TakeInt(); 

Lab.LabCount++; 

int c3 = Lab.LabCount; 

Labs.Add(new Lab(c3, t3, EquipmentCount)); 

Console.WriteLine("Lab added successfully\n"); 

break; 

case 4: 

//Printing Details 

Console.WriteLine("\n--- Course List ---"); 

Console.WriteLine("ID Type Details "); 

Console.WriteLine("============================"); 

 

foreach (Course i in Courses){ 

i.GetDetails(); 

} 

Console.WriteLine("\n--- Seminar List ---"); 

Console.WriteLine("ID Type Details "); 

Console.WriteLine("============================"); 

 

foreach (Seminar i in Seminars){ 

i.GetDetails(); 

} 

Console.WriteLine("\n--- Lab List ---"); 

Console.WriteLine("ID Type Details "); 

Console.WriteLine("============================"); 

 

foreach (Lab i in Labs){ 

i.GetDetails(); 

} 

Console.WriteLine($"\nTotal Courses : {Course.CourseCount}"); 

Console.WriteLine($"Total Seminars : {Seminar.SeminarCount}"); 

Console.WriteLine($"Total Labs : {Lab.LabCount}"); 

break; 

 

case 5: 

Console.WriteLine("Exiting....\n"); 

test = 0; 

break; 

} 

} 

} 

} 

 