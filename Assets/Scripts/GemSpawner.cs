using UnityEngine;

public class GemSpawner : MonoBehaviour
{

    public GameObject Gem;

    public void SpawnGems()
    {
        int spawnPointX = Random.Range(-11, 11);
        int spawnPointY = Random.Range(1, 1);
        int spawnPointZ = Random.Range(-11, 11);

        Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);

        Instantiate(Gem, spawnPosition, Quaternion.identity);

    }

}
