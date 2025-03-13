using UnityEditor.Rendering.Universal.ShaderGraph;
using UnityEditor.SearchService;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] private GameObject Lose;
    [SerializeField] private GameObject Win;
    [SerializeField] private GameObject Draw;
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
            if (gems.isMore == true && gems.Draw == false)
            {
                //player.GetComponent<CharacterController>().enabled = false;
                Win.SetActive(true);
            }

            if (gems.isMore == false && gems.Draw == false)
            {
                //player.GetComponent<CharacterController>().enabled = false;
                Lose.SetActive(true);
            }

            //if (gems.Draw == true)
            //{
            //    Draw.SetActive(true);
            //}

            //if (gems.Draw == false)
            //{
            //    Draw.SetActive(false);
            //}
        }

        if (Lose == true || Win == true)
        {
            //Video link for reset level & set active = true
            //https://www.youtube.com/watch?v=TVSLCZWYL_E
        }
    }
}
