using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{

    public float number1 = 10f;
    public float number2 = 16.5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Class1.AddAndMult(number1, number2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
