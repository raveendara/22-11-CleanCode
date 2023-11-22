// review1.cs

public bool IsShopOpen(string day)
{
    if (!string.IsNullOrEmpty(day))
    {
        day = day.ToLower();
        if (day == "friday")
        {
            return true;
        }
        else if (day == "saturday")
        {
            return true;
        }
        else if (day == "sunday")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }

}
public bool IsShopOpen(string day)
{
    if (!string.IsNullOrEmpty(day))
    {
        day = day.ToLower();
        if (day == "friday" || "saturday" || "sunday")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
//review3.cs
public long Fibonacci(int n)
{
    if (n < 50)
    {
        if (n != 0)
        {
            if (n != 1)
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            else
            {
                return 1;
            }
        }
        else
        {
            return 0;
        }
    }
    else
    {
        throw new System.Exception("Not supported");
    }
}

public long Fibonacci(int n)
{
   long[] fib = new long[n + 1];
   fib[0] = 0;
   fib[1] = 1;
   for (int i = 2; i <= n; i++)
   {
       fib[i] = fib[i - 1] + fib[i - 2];
   }
   return fib[n];
}
//review4.cs
var location = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < l.Count(); i++)
{
    var locationi = l[i];
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(locationi);
}
//review5.cs
if (userRole == 8) // Check if Admin 
{
    
}

cinst string ADMIN_ROLE - "Admin"
if (userRole -- ADMIN_ROLE)
{
    
}
//review6.cs
public class Car
{
    public string CarMake { get; set; }
    public string CarModel { get; set; }
    public string CarColor { get; set; }

    //...
}
public class Car{
    //use it as an object
    //  we can use car.Make
}
//review7.cs
var ymdstr = DateTime.UtcNow.ToString("MMMM dd, yyyy");
var Day = DateTime.UtcNow.ToString("MMMM dd, yyyy");

//review9.cs

public void CreateMicrobrewery(string name = null)
{
    var breweryName = !string.IsNullOrEmpty(name) ? name : "Hipster Brew Co.";
    // ...
}

createMicrobrewert(string breweryName = "Hipster Brew Co.");


