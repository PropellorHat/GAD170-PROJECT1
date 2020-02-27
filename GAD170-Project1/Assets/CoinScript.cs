using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float spinSpeed = 100f;

    void Update()
    {
        this.transform.Rotate(0f, Time.deltaTime * this.spinSpeed, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
