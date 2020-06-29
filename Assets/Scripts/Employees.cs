using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employees : MonoBehaviour
{
    public static string companyName = "Dragon Forge Creations";
    public string employeeName;

    public abstract void CalculateMonthlySalary();
}
