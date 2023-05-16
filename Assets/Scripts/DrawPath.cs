using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class DrawPath : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform target;
    [SerializeField] LineRenderer line;
    [SerializeField] float heightOffset;
    [SerializeField] private Transform[] targetAreas;
    [SerializeField] private float pathUpdateInterval;

    List<Vector3> point;
    float interval;

    private void Start()
    {
        interval = pathUpdateInterval;
    }

    private void Update()
    {
        interval -= Time.deltaTime;

        if (interval <= 0)
        {
            agent.SetDestination(new(target.position.x, agent.transform.position.y, target.position.z));
            DisplayLine();
            interval = pathUpdateInterval;
        }
    }

    private void DisplayLine()
    {
        if (agent.path.corners.Length < 2) return;

        int i = 1;
        while (i < agent.path.corners.Length)
        {
            line.positionCount = agent.path.corners.Length;
            point = agent.path.corners.ToList();
            for (int j = 0; j < point.Count; j++)
                line.SetPosition(j, point[j] + new Vector3(0f, heightOffset, 0f));

            i++;
        }
    }
}
