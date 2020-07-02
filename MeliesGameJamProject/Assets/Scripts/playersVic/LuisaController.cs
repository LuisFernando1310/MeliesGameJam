using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuisaController : MonoBehaviour
{

    public Rigidbody rdb;
    public GameObject lineCast;
    public bool estaNoChao = true;
    Vector3 velFinal;
    public float aceleracaoQueda = 2.8f;
    public LayerMask chao;


    // Start is called before the first frame update
    void Start()
    {
        rdb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void AplicaMovimento()
    {
        if (!estaNoChao)
        {
            velFinal.y += Physics.gravity.y * Time.deltaTime * aceleracaoQueda;
        }

        //velFinal += dashVec;
        //rdb.velocity = velFinal;


    }

    void ChecaChao()
    {
        RaycastHit hit;

        estaNoChao = false;
        if (Physics.Linecast(transform.position + Vector3.up, lineCast.transform.position, out hit, chao.value))
        {
            estaNoChao = true;
            Debug.DrawLine(transform.position + Vector3.up, lineCast.transform.position, Color.red);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawLine(transform.position + Vector3.up, lineCast.transform.position);
    }
}
