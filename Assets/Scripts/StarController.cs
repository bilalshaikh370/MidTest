using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1f);
        GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.position.x, Random.Range(10, 15)));
    }
}
