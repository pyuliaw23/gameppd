using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Nilai : MonoBehaviour
{
    public GameObject enemy;

    void Start()
    {
    }
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "tongSampah":
                Destroy(this.gameObject);
                Debug.Log("Masuk");
                break;
            case "Plan":
                Destroy(this.gameObject);
                Debug.Log("Tidak Masuk");
                break;
        }

    }


}
