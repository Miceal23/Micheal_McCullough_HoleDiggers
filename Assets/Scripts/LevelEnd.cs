using UnityEditor.SearchService;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] Gems gems;

    void Update()
    {
       if(timer.remainingTime == 0)
       {    

            // in here will be something comparing worm and player gems. player gems => worm gems. player wins. else = player lose
       }
    }
}
