using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] float delayDestroy;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("You have managed to fuck me!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package Picked Up");
            spriteRenderer.color = hasPackageColor;
            hasPackage = true;
            Destroy(other.gameObject, delayDestroy);
        }
       if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delievered!");
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }
    }
}
