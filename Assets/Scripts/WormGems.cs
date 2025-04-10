using TMPro;
using UnityEngine;

public class WormGems : MonoBehaviour
{
    [SerializeField] Gems gems;

    public void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Worm")
        {
            if (other.transform.tag == "Gem")
            {
                GameObject.Find("Gamemanager").GetComponent<Gems>().WormGemUpdate();
                Destroy(other.gameObject);
                Debug.Log("Worm Gem Collision");
            }
        }
    }
}
