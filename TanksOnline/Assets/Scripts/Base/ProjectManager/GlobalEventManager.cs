using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalEventManager : MonoBehaviour
{
  public Action action;

  public void DoSomething()
  {
    if(action != null)
    {
      action.Invoke(); 
    }
  }
}
