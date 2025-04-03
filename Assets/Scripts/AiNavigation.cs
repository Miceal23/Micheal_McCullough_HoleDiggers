using UnityEngine;
using UnityEngine.AI;

public class AiNavigation : MonoBehaviour
{
    public GameObject Gem;
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        Gem = GameObject.FindWithTag("Gem"); //change this to closest one
        agent.SetDestination(Gem.transform.position);
    }
}
