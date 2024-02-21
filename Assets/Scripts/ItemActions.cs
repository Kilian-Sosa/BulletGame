using UnityEngine;

public class ItemActions : MonoBehaviour {
    [SerializeField] GameObject spikedballTrap, sawTrap;

    public void SpawnSpikedball() {
        if (GameObject.FindGameObjectWithTag("SpikedballTrap") == null) {
            Instantiate(spikedballTrap);
            Destroy(this.gameObject);
        }
    }

    public void SpawnSaw() {
        print("a");
        if (GameObject.FindGameObjectWithTag("SawTrap") == null) {
            print("b");
            Instantiate(sawTrap);
            Destroy(this.gameObject);
        }
    }
}
