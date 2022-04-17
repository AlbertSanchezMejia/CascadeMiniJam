using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    Vector2 initialPosition;
    Vector3 mousePosition;
    GameObject marca;
    public Camera camara;

    void Start()
    {
        initialPosition = transform.position;
    }

    void OnMouseDrag()
    {
        mousePosition = Input.mousePosition;
        mousePosition = camara.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector3(mousePosition.x, mousePosition.y, 1f);
    }

    void OnMouseUp()
    {
        if(marca != null)
        {
            transform.position = new Vector3(marca.transform.position.x, marca.transform.position.y, 0);
        }
        else
        {
            transform.position = initialPosition;
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mark"))
        {
            marca = collision.gameObject;
        }

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mark"))
        {
            marca = null;
        }
    }

}
