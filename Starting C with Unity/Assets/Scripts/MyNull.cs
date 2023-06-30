using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNull : MonoBehaviour
{
    string firstName = "Mo";
    string lastName = null;
    int? meaningOfLife = null;
    // Start is called before the first frame update
    void Start()
    {
        int? anotherNumber = null;
        int trueNumber = meaningOfLife ?? anotherNumber ?? 42;
        Debug.Log(trueNumber);
        // Debug.Log($"{firstName} {lastName}");
        // lastName.ToUpper();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
