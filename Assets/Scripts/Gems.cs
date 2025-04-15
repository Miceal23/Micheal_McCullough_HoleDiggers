using TMPro;
using UnityEngine;

public class Gems : MonoBehaviour
{

    [SerializeField] int wormGems = 0;
    [SerializeField] int playerGems = 0;
    [SerializeField] TextMeshProUGUI WormGemText;
    [SerializeField] TextMeshProUGUI PlayerGemText;
    public bool isMore;

    public void PlayerGemUpdate()
    { 
        playerGems++;
        PlayerGemText.text = "Player Gems: " + playerGems.ToString();
    }

    public void WormGemUpdate()
    {
        wormGems++;
        WormGemText.text = "Worm Gems: " + wormGems.ToString();
    }

    void Update()
    {
        if (playerGems > wormGems)
        {
            isMore = true;
        }
        
        if (playerGems < wormGems)
        {
            isMore = false;
        }
    }
}