using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour {
    [SerializeField] GameObject enemy;
    public float timeBetweenGenerations = 1, spawnLineLength = 2;

    void Start() {
        StartCoroutine(GenerateEnemy());
    }

    IEnumerator GenerateEnemy() {
        while (true) {
            GameObject newEnemy = Instantiate(enemy);
            yield return new WaitForSeconds(timeBetweenGenerations);
        }
    }
}
