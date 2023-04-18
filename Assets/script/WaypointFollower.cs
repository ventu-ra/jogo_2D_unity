using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{

  [SerializeField] private GameObject[] waypoints;
  private int currentWaypointIntIndex = 0;

  [SerializeField] private float speed = 2f;

  // Update is called once per frame
  void Update()
  {
    if (Vector2.Distance(waypoints[currentWaypointIntIndex].transform.position, transform.position) < .1f)
    {
      currentWaypointIntIndex++;

      if (currentWaypointIntIndex >= waypoints.Length) 
      { 
        currentWaypointIntIndex = 0; 
      }
    }

    transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIntIndex].transform.position, Time.deltaTime * speed);

  }
}
