using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosao : MonoBehaviour
{
    public GameObject explosao;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(explosao, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
