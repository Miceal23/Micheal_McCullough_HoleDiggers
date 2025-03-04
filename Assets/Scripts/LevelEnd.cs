using UnityEditor.SearchService;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] Gems gems;
    [SerializeField] private GameObject Lose;
    [SerializeField] private GameObject Win;
    public Player player;

    private void Start()
    {
        player = GetComponent<Player>();
    }
    void Update()
    {
       if(timer.remainingTime == 0 && gems.isMore)
       {
            CharacterController.Destroy(gameObject);
            Win.SetActive(true);
       }
       else
       {
            CharacterController.Destroy(gameObject);
            Lose.SetActive(true);

       }

        if (Lose == true || Win == true)
        {
            //Video link for reset level & set active = true
            //https://www.youtube.com/watch?v=TVSLCZWYL_E
        }
    }
}
