using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Test : MonoBehaviour
{

    private void Start()
    {
        Car myCar = new Car();

        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.honk();

        // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
        Debug.Log(myCar.brand + " " + myCar.modelName);
    }
}

class Vehicle  // base class (parent) 
{
    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method 
    {
        Debug.Log("Tuut, tuut!");
    }
}

class Car : Vehicle  // derived class (child)
{
    public string modelName = "Mustang";  // Car field
}

class Program : MonoBehaviour
{
    public void Start()
    {
        // Create a myCar object

    }
}