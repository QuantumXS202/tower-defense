using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEditor;
using UnityEngine;  

public class Pathfolwwer : MonoBehaviour
{
    [SerializeField] Transform[] waypoints; 
    [SerializeField] private float _speed;
    

    int waypointIndex = 0;

    void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, _speed * Time.deltaTime);
        if(transform.position == waypoints [waypointIndex].transform.position)
        {
            waypointIndex += 1;
        }

        if (waypointIndex == waypoints.Length)
            waypointIndex = 0;

            
    }
}
