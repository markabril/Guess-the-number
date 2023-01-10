using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject Enemy;
    [SerializeField]
    private float interval;
    void Start()
    {
        StartCoroutine(SpawnEnemy(interval, Enemy));
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    private IEnumerator SpawnEnemy(float interval, GameObject obj)
    {
        yield return new WaitForSeconds(interval);
        GameObject enemy = Instantiate(obj, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-6f, 6f)), Quaternion.identity);
        StartCoroutine(SpawnEnemy(interval, obj));
    }
}
