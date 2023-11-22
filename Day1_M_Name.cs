
// Review1.cs

int d; // elapsed time in days
int elapsedTimeInDays;


// Review2.cs

var dataFromDb = db.GetFromService().ToList(); // Get List of employees 

var listOfEmployee = employeeService.GetEmployees().ToList();  // code readability 

// Review3.cs

int iCounter;
string strFullName;
DateTime dModifiedDate;

//avoid hungarian notation

int counter;
string fullName;
DateTime modifiedDate;

//Review4.cs

public bool IsShopOpen(string pDay, int pAmount)
{
    // some logic
}

public bool isShopOpen(string Days, int Amount)
{
   // some logic
}

//Review5.cs
const int DAYS_IN_WEEK = 7;
const int daysInMonth = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var Artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool EraseDatabase() {}
bool Restore_database() {}

class animal {}
class Alpaca {}

//Ans

const int daysInWeek = 7;
const int daysInMonth = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool eraseDatabase() {}
bool restoreDatabase() {}

class animal {}
class alpaca {}

// Review6.cs

public class Employee
{
    public Datetime sWorkDate { get; set; } // get set Start Working Date
    public Datetime modTime { get; set; } // get set Modification Time
}

public class employee
{
    public Datetime startWorkingDate { get; set; } // get set Start Working Date
    public Datetime modificationTime { get; set; } // get set Modification Time
}

//review7.cs

var employeephone;

public double CalculateSalary(int workingdays, int workinghours)
{
    // some logic
}
//camelCasing

var employeePhone;

public double calculateSalary(int workingDays, int workingHours)
{
    // some logic
}



