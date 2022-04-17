using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    Vector2 initialPosition;
    Vector3 mousePosition;
    GameObject marca;
    [SerializeField] Camera camara;

    [SerializeField] GameObject choosenOne;
    public bool victory;

    void Start()
    {
        initialPosition = transform.position;
        victory = false;
    }

    void OnMouseDrag()
    {
        victory = false;
        mousePosition = Input.mousePosition;
        mousePosition = camara.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector3(mousePosition.x, mousePosition.y, 1f);
    }

    void OnMouseUp()
    {
        if(marca != null)
        {
            victory = (choosenOne == marca) ? true : false;
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
        }/*
        if (collision.gameObject.CompareTag("Puzzle"))
        {
            marca = null;
        }*/
    }

    public void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Puzzle"))
        {
            marca = null;
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
