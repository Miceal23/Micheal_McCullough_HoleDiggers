using UnityEngine;
using UnityEngine.AI;

public class AiNavigation : MonoBehaviour
{
    public Transform gems;
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.destination = gems.position;
    }
}
