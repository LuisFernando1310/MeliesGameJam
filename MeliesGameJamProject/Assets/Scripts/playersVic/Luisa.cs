using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luisa : MonoBehaviour
{

    public int chaves = 0;

    [SerializeField]
    BarraMedoo barraDeMedo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            other.gameObject.SetActive(false);
            chaves++;
        }

        if (other.tag == "Jorge")
            barraDeMedo.medo = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Jorge")
            barraDeMedo.medo = true;
    }
}
