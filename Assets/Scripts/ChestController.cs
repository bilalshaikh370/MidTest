using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    [SerializeField] private GameObject itemFeedback;

    private bool hasBeenCollected = false;
    private bool isColided = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !hasBeenCollected)
        {
            isColided = true;
           
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.E))
        {
            hasBeenCollected = true;
        }

        if (hasBeenCollected)
        {
            Instantiate(itemFeedback, this.transform.position, this.transform.rotation);
        }
    }

}