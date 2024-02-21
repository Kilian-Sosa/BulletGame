using System.Collections;
using UnityEngine;

public class ItemCreator : MonoBehaviour {
    [SerializeField] GameObject[] prefabs;
    [SerializeField] float disappearTime = 2f;
    public float probability = 0.1f;

    void Start() {
        
    }


    void Update() {
        
    }

    public void GenerateItem(Transform dropPosition) {
        int options = prefabs.Length;
        int randomOption = Random.Range(0, options);

        float randomProb = Random.Range(0, 1);

        if (randomProb <= probability) { 
            GameObject newItem = Instantiate(prefabs[randomOption], dropPosition);
            newItem.transform.SetParent(null);
            StartCoroutine(Disappear(newItem));
        }
    }

    IEnumerator Disappear(GameObject item) {
        while (true) {
            yield return new WaitForSeconds(disappearTime);
            if (item != null) Destroy(item);
            StopCoroutine("Disappear");
        }
    }
}
