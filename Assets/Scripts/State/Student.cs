using StatePattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student
{
    /// <summary>
    /// 학생의 현재 상태
    /// </summary>
    private IState state;

    public int health = 100;

    public Student() 
    {
        SetState();
    }

    public void SetState()
    {
        if (health < 30)
            state = new Sleep();
        else
            state = new Fine();
    }

    public void Study()
    {
        SetState();
        state.Study();
    }
}
