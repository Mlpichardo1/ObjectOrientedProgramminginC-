using System;

namespace Mod2_Lab1
{
    class Employee 
    {
    // 3 private member variables: employeeName, employeeBaseSalary, and employeeId
private string employeeName;
private double employeeBaseSalary;
private int employeeId;

// Public properties
public string Name
{
    get
    {
        return employeeName;
    }

    set
    {
        employeeName = value;
    }
}
public double BaseSalary
{
    get
    {
        return employeeBaseSalary;
    }

    set
    {
        employeeBaseSalary = value;
    }
}
public int ID
{
    get
    {
        return employeeId;
    }

    set
    {
        employeeId = value;
    }
}
// Constructor
public Employee(String name, double baseSalary)
{
    this.Name = name;
    this.BaseSalary = baseSalary;
}
    }
}