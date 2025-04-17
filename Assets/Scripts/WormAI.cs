using UnityEngine;
using UnityEngine.AI;

public class WormAI : MonoBehaviour
{

    public GameObject targetObject;
    public GameObject[] allObjectsWithTag;
    private NavMeshAgent agent;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        allObjectsWithTag = GameObject.FindGameObjectsWithTag("Gem");
    }

    private void Update()
    {   
        FindNearest();
    }

    void FindNearest()
    {
        GameObject nearestObject = allObjectsWithTag[0];
        float distanceToNearest = Vector3.Distance(targetObject.transform.position, nearestObject.transform.position);
        agent.SetDestination(nearestObject.transform.position); // this works but then the nearest object gets destroyed

            for (int i = 1; i < allObjectsWithTag.Length; i++)
            {

                float distanceToCurrent = Vector3.Distance(targetObject.transform.position, allObjectsWithTag[i].transform.position);

                if (distanceToCurrent < distanceToNearest)
                {

                    nearestObject = allObjectsWithTag[i];
                    distanceToNearest = distanceToCurrent;

                }

            }
    }
}
