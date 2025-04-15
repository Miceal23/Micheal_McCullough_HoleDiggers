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

    void FixedUpdate()
    {   
        if (timer.remainingTime <= 0)
        {
            Cursor.lockState = CursorLockMode.None;

            if (gems.isMore == true)
            {
                player.GetComponent<CharacterController>().enabled = false;
                Win.SetActive(true);
                if (GameObject.FindWithTag("Worm").activeInHierarchy)
                {
                    GameObject.FindWithTag("Worm").SetActive(false);
                }

            }

            if (gems.isMore == false)
            {
                player.GetComponent<CharacterController>().enabled = false;
                Lose.SetActive(true);
                if (GameObject.FindWithTag("Worm").activeInHierarchy)
                {
                    GameObject.FindWithTag("Worm").SetActive(false);
                }
            }
        }
    }
}
