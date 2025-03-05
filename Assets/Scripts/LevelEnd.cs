using UnityEditor.Rendering.Universal.ShaderGraph;
using UnityEditor.SearchService;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] GameObject PlayerGems;
    [SerializeField] GameObject WormGems;
    [SerializeField] private GameObject Lose;
    [SerializeField] private GameObject Win;
    private Player player;
    public Gems gems;

    private void Start()
    {
        player = GetComponent<Player>();
        gems = GetComponent<Gems>();
    }
    void Update()
    {   
        if (timer.remainingTime <= 0)
        {
            if (gems.isMore == true)
            {
                CharacterController.Destroy(gameObject);
                Win.SetActive(true);
            }

            else
            {
                //CharacterController.Destroy(gameObject);
                Lose.SetActive(true);
            }
        }

       //if (timer.remainingTime == 0 && gems.isMore)
       //{
       //     CharacterController.Destroy(gameObject);
       //     Win.SetActive(true);
       //}
       //else
       //{
       //     CharacterController.Destroy(gameObject);
       //     Lose.SetActive(true);

       //}

        if (Lose == true || Win == true)
        {
            //Video link for reset level & set active = true
            //https://www.youtube.com/watch?v=TVSLCZWYL_E
        }
    }
}
