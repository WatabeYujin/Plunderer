using UnityEngine;
using System.Collections;

public class OpenBlock : MonoBehaviour {
    public GameObject openblock;
    public GameObject closeblock;
    public mokutekiti target;
    public Transform nextposition;
    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            target.target = nextposition;
            if (closeblock != null)closeblock.SetActive(false);
            if (openblock != null) openblock.SetActive(true);
            Destroy(gameObject);
        }
    }
}
