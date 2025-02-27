using TMPro;
using UnityEngine;

public class Gems : MonoBehaviour
{
    private int Gem = 0;
    public TextMeshProUGUI gemText;

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
                Gem++;
                gemText.text = "Player Gems: " + Gem.ToString();
                Debug.Log("Gem");
                Destroy(other.gameObject);
            }
        }

        if(tag == "Worm")
        {
            if (other.transform.tag == "Gem")
            {
                Gem++;
                gemText.text = "Worm Gems: " + Gem.ToString();
                Debug.Log("Gem");
                Destroy(other.gameObject);
            }
        }

    }
}