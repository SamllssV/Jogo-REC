using UnityEngine;

public class SpawnThrowables : MonoBehaviour
{
    [SerializeField] private GameObject [] throwablePrefab;
    public Transform spawnPoint;
    
    public void StartSpawn()
    {   
        RandomPositionSpawn();
        RandomObjectSpawn();
    }

    void RandomPositionSpawn()
    {
        float randomX = Random.Range(-5f, 5f);
        float randomY = Random.Range(-5f, 5f);
        spawnPoint.position = new Vector3(randomX, randomY, spawnPoint.position.z);
    }
    void RandomObjectSpawn()
    {
        int randomIndex = Random.Range(0, throwablePrefab.Length);
        GameObject selectedPrefab = throwablePrefab[randomIndex];
        Instantiate(selectedPrefab, spawnPoint.position, Quaternion.identity);
    }


    void Update()
    {
        
    }
}
