using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This helps break the dependency of Mover and Fighter
namespace RPG.Core
{
    public class ActionScheduler : MonoBehaviour
    {
        MonoBehaviour currentAction;

       public void StartAction(MonoBehaviour action)
        {
            if (currentAction == action) return;
            if (currentAction != null)
            {
                print("Cancelling" + currentAction);
            }
            
            currentAction = action;
        }

    }
}