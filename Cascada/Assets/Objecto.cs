using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecto : MonoBehaviour
{
    public GameObject objecto;

    public void Aparecer()
    {
        objecto.SetActive(true);
    }

    public void Desaparecer()
    {
        objecto.SetActive(false);

    }

}
