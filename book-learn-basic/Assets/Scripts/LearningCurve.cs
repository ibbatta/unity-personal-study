using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

    public float userAge = 33f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("---------------------- age: {0}", userAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
