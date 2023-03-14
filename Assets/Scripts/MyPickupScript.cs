using UnityEngine;

public class MyPickupScript : MonoBehaviour
{
    public float interactDistance = 3f;
    public KeyCode pickupKey = KeyCode.E;

    private GameObject heldObject = null;
    
    private void Update()
    {
        if (Input.GetKeyDown(pickupKey))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, interactDistance))
            {
                if (hit.collider.CompareTag("Interactable"))
                {
                    if (heldObject != null)
                    {
                        DropObject();
                    }

                    heldObject = hit.collider.gameObject;
                    heldObject.transform.SetParent(transform);
                    heldObject.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.R) && heldObject != null)
        {
            DropObject();
        }
    }

    private void DropObject()
    {
        heldObject.transform.SetParent(null);
        heldObject.GetComponent<Rigidbody>().isKinematic = false;
        heldObject = null;
    }
}
