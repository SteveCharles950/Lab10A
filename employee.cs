using System;

class Employee{
    

    private int age;
  
    private double yearlysalary;

    private string FirstName{get; set;}

    private string LastName{get; set;}

    private int Age{
      get{ return age; }
      set{
        if (value < 18){
          age = 18;
        }else if(value == 0){
          age = 0;
        } else {
         age = value;
      }
      }
    }

    private double YearlySalary{
      get{ return yearlysalary; }
      set{
        if (value < 1000)
          yearlysalary= 1000;
        else
         yearlysalary = value;
      }
    }

    private string Id{get; set;}

    private string EmploymentStatus{get; set;}


    public Employee(){
      FirstName = "Unknown";
      LastName = "Unknown";
      Age = 0;
      Id = "Unknown";
      //EmploymentStatus = "active";
    }

    public Employee(string firstName, string lastName, int empage, string empid, int salary){
      FirstName = firstName;
      LastName = lastName;
      Age = empage;
      Id = empid;
      YearlySalary = salary;
    }

public void Intro(){
Console.WriteLine("Employee first name is " + FirstName);
Console.WriteLine("Employee last name is " + LastName);
Console.WriteLine("Employee Id is " + Id);
Console.WriteLine("Employee age is " + Age);
}

public void IncreaseSalary(double percent){
 percent= percent/100; 
  if ( percent <  0){
        Console.WriteLine("Invalid input. Yearly Salary not updated");
      }
      else
      {
        YearlySalary = YearlySalary + (YearlySalary * percent);
        Console.WriteLine("Yearly salary updated to "+YearlySalary);
      }
}

public void RemoveEmployee(){
  if ( EmploymentStatus == "inactive"){
        Console.WriteLine("Employee already inactive");
      }
      else
      {
        EmploymentStatus = "inactive";
        Console.WriteLine("Employee removed");
      }
}

}