using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StatePattern;

public class Fine : IState
{
    public void Study()
    {
        Debug.Log("멀쩡하게 공부합니다");
    }
}
