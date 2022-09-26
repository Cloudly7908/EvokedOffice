using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolWayPoints : MonoBehaviour
{
   
        public int GetNextIndex(int _waypoint)
        {
            if (_waypoint + 1 == transform.childCount)
            {
                return 0;
            }
            return _waypoint + 1;
        }

        public Vector3 GetWaypoint(int _waypoint)
        {
            return transform.GetChild(_waypoint).position;
        }
   
}
