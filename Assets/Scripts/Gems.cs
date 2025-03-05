using Autodesk.Fbx;
using TMPro;
using UnityEngine;

public class Gems : MonoBehaviour
{
    public int PlayerGems = 0;
    public int WormGems = 0;
    public TextMeshProUGUI PlayerGemText;
    public TextMeshProUGUI WormGemText;
    public bool isMore;

    private void OnTriggerEnter(Collider other)
    {
        //if(other.transform.tag == "Gem")
        //{
        //    Gem++;
        //    gemText.text = "Player Gems: " + Gem.ToString();
        //    Debug.Log(Gem);
        //    Destroy(other.gameObject);
        //}

        if(tag == "Player")
        {
            if (other.transform.tag == "Gem")
            {
                PlayerGems++;
                PlayerGemText.text = "Player Gems: " + PlayerGems.ToString();
                Debug.Log("Gem");
                Destroy(other.gameObject);
            }
        }

        if(tag == "Worm")
        {
            if (other.transform.tag == "Gem")
            {
                WormGems++;
                WormGemText.text = "Worm Gems: " + WormGems.ToString();
                Debug.Log("Gem");
                Destroy(other.gameObject);
            }
        }

    }
    private void Update()
    {
        if (PlayerGems > WormGems)
        {
            isMore = true;
        }
        else
        {
            isMore = false;
        }
    }
}