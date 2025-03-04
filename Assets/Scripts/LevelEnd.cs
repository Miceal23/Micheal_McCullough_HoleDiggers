using UnityEditor.SearchService;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] Gems gems;
    public Player player;

    private void Start()
    {
        player = GetComponent<Player>();
    }
    void Update()
    {
       if(timer.remainingTime == 0)
       {
            //Disable character controller
            // in here will be something comparing worm and player gems. player gems => worm gems. player wins. else = player lose

            //https://www.youtube.com/watch?v=TVSLCZWYL_E
        }
    }
}
