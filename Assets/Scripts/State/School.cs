using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : MonoBehaviour
{
    
    private void Start()
    {
        Student student = new Student();
        student.Study();

        student.health = 20;
        student.Study();
    }
}
