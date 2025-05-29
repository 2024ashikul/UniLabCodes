//Source Code: 

using System; 
 
class Employee{ 
public int ID; 
public string Name; 
public Employee(int ID, string Name){ 
this.ID = ID; 
this.Name = Name; 
} 
public virtual void DisplayInfo(){ 
Console.Write($"[Manager] ID: {ID} , Name : {Name}\n"); 
} 
public virtual int CalculateBonus(){ 
return 1000; 
} 
} 
 
class Manager : Employee 
{ 
int TeamSize; 
 
public Manager(int ID, string Name, int TeamSize) : base(ID, Name){ 
this.TeamSize = TeamSize; 
} 
public override void DisplayInfo(){ 
Console.Write($"[Manager] ID: {ID} , Name : {Name} , Team Size: {TeamSize}"); 
} 
public override int CalculateBonus(){ 
return base.CalculateBonus() + 1000 + 200 * TeamSize; 
} 
} 
 
class Developer : Employee 
{ 
string ProgrammingLanguage; 
public Developer(int ID, string Name, string ProgrammingLanguage) : base(ID, Name){ 
this.ProgrammingLanguage = ProgrammingLanguage; 
} 
public override void DisplayInfo(){ 
Console.Write($"[Developer] ID: {ID} , Name : {Name} , Programming Language: {ProgrammingLanguage}"); 
} 
public override int CalculateBonus() 
{ 
if (ProgrammingLanguage == "C#"){ 
return base.CalculateBonus() + 1000 + 500; 
}else{ 
return base.CalculateBonus() + 1000 + 300; 
} 
} 
} 
 
class Program 
{ 
public static void Main(){ 
List<Employee> employees = new List<Employee>(); 
employees.Add(new Manager(001, "Ashikul", 5)); 
employees.Add(new Developer(002, "Rabiul", "C#")); 
employees.Add(new Developer(003, "Hasan", "Python")); 
employees.Add(new Manager(004, "Ahmed", 5)); 
employees.Add(new Developer(005, "Javed", "Javascript")); 
foreach (Employee i in employees){ 
i.DisplayInfo(); 
Console.Write($", Bonus : ${i.CalculateBonus()}\n"); 
}  
} 
} 
 
 