using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] Transform target;

        // Update is called once per frame and follows the objects position
        void LateUpdate()
        {
            transform.position = target.position;
        }
    }
}