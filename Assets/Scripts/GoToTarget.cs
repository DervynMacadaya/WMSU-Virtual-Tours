using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class GoToTarget : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform target;
    [SerializeField] LineRenderer line;
    [SerializeField] float heightOffset;

    List<Vector3> point;

    private void Update()
    {
        agent.SetDestination(new(target.position.x, agent.transform.position.y, target.position.z));
        DisplayLine();
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
            {
                line.SetPosition(j, point[j] + new Vector3(0f, heightOffset, 0f));
            }

            i++;
        }
    }
}
