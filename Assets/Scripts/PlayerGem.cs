using TMPro;
using Unity.Cinemachine;
using UnityEditor.PackageManager;
using UnityEngine;

public class PlayerGem : MonoBehaviour
{
    [SerializeField] Gems gems;
    public AudioSource audioo;
    public void OnTriggerEnter(Collider other)
    { 
        if (gameObject.tag == "Player")
        {
            if (other.transform.tag == "Gem")
            {
                gems.PlayerGemUpdate();
                audioo.Play();
                
                Destroy(other.gameObject);
                Debug.Log("Gem Collision");
            }
        }
    }
}