using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gas : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
       car.instance.gas = 1f;
       Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
