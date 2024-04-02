using StatePattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : IState
{
    public void Study()
    {
        Debug.Log("졸려서 공부가 안됩니다");
    }
}
