using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Movements;
using RPG.Core;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        [SerializeField] float weaponRange = 2f;


        Transform target;

        //Update for movement for an object
        private void Update()
        {
            //If we are not fighting, the stop component will not fire and the object can move
            if (target == null) return;

            //If we are fighting and are not in range, the object will move in range, else it will stop
            if (target != null && !GetIsInRange())
            {
                GetComponent<Movement>().Moveto(target.position);
            }
            else
            {
                GetComponent<Movement>().Stop();
            }
        }

        //This calculates distance between you and the target
        private bool GetIsInRange()
        {
            return Vector3.Distance(transform.position, target.position) < weaponRange;
        }

        public void Cancel()
        {
            target = null;
        }
        
        public void Attack(CombatTarget combatTarget)
        {
            GetComponent<ActionScheduler>().StartAction(this);
            target = combatTarget.transform;
        }
    }
}