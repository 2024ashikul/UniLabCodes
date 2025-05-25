
using System; 
 
class userProfile 
{ 
string userId; 
string password; 
string email; 
double accountBalance; 
static int userCount = 0; 
public userProfile(string email,string password,double amount) { 
this.email = email; 
this.password = password; 
this.accountBalance = amount; 
userCount++; 
this.userId = "USR" + userCount.ToString("D3"); 
} 
public string UserId{ 
get {return userId;} 
} 
public string Email { 
get {return email;} 
set {email = value;} 
} 
public string Password { 
set {password = value;} 
} 
 
public double AccountBalance{ 
get {return accountBalance;} 
} 
 
public double AddBalance(double amount) { 
return accountBalance = accountBalance + amount; 
} 
 
public double MakePurchase(double amount) { 
if (amount <= accountBalance){ 
return accountBalance = accountBalance - amount; 
} 
else { 
Console.WriteLine("No sufficient Balance"); 
return accountBalance; 
} 
} 
 
public string ChangeEmail(string email) { 
if (email.Contains('@')) { 
return this.email = email; 
} else { 
Console.WriteLine("Not a valid email address"); 
return this.email; 
} 
} 
 
public bool Authenticate(string password) { 
if (this.password == password) { 
return true; 
} else { 
return false; 
} 
} 
 
} 
 
class Program 
{ 
public static void Main() { 
userProfile user = new userProfile("2020ashikul@gmail.com", "12345", 1000); 
Console.WriteLine(user.UserId); 
Console.WriteLine(user.Email); 
Console.WriteLine(user.AccountBalance); 
 
user.AddBalance(500); 
Console.WriteLine(user.AccountBalance); 
 
user.MakePurchase(300); 
Console.WriteLine(user.AccountBalance); 
 
user.ChangeEmail("2024ashikul@gmail.com"); 
Console.WriteLine(user.Email); 
 
bool isValid = user.Authenticate("12345"); 
Console.WriteLine(isValid); 
 
userProfile user1 = new userProfile("ashikul@gmail.com", "1", 600); 
Console.WriteLine(user1.UserId); 
 
user1.ChangeEmail("abcd"); 
user1.MakePurchase(900); 
isValid = user.Authenticate("12"); 
Console.WriteLine(isValid); 
 
} 
} 
 

 
 
 