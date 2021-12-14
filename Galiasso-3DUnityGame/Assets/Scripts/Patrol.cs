/*
 * Created by: Andres Galiasso
 * Date created: 12.10.2021
 * 
 * Edited by: Andres Galiasso
 * Last edited: 12.13.2021
 * 
 * Description: Monster patrols to multiple areas at random
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class Patrol : MonoBehaviour
{
    /**** VARIABLES ****/

    [SerializeField] private Transform[] patrolSpots = null;
    private NavMeshAgent agent = null;
    private bool hasNoGoal = true;

    private void Awake()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        if (hasNoGoal)
        {
            SetLocation();
        }

        if (agent.remainingDistance <= 0.2f)
        {
            hasNoGoal = true;
        }
    }

    private void SetLocation()
    {
        if (patrolSpots.Length > 0)
        {
            float spot = Random.Range(0, patrolSpots.Length);
            agent.SetDestination(patrolSpots[(int)spot].position);
            hasNoGoal = false;

        }
    }

}
