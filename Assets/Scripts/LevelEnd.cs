using UnityEditor.Rendering.Universal.ShaderGraph;
using UnityEditor.SearchService;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] private GameObject Lose;
    [SerializeField] private GameObject Win;
    public Gems gems;
    public GameObject player;

    //public void Components()
    //{
    //    player = GetComponent<GameObject>();
    //    gems = GetComponent<Gems>();
    //}
    void Update()
    {   
        if (timer.remainingTime <= 0)
        {
            if (gems.isMore == true)
            {
                //player.GetComponent<CharacterController>().enabled = false;
                Win.SetActive(true);
            }

            else
            {
                //player.GetComponent<CharacterController>().enabled = false;
                Lose.SetActive(true);
            }
        }

        if (Lose == true || Win == true)
        {
            //Video link for reset level & set active = true
            //https://www.youtube.com/watch?v=TVSLCZWYL_E
        }
    }
}
