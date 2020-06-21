using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //Create a random index
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                // Spawn a block:
                //Using the instatite function
                //we spawn a game object (block prefab)
                //at the spawnPoint[i]
                //And since we dont want to rotate anyting we use tghe Quaterninon.identity function
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);

            }
        }
    }


}
