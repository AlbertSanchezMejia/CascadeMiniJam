using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checking : MonoBehaviour
{
    public DragObject[] drags;
    public int aa;

    void Start()
    {
        
    }

    public void Check()
    {
        aa = 0;
        for (int i = 0; i < drags.Length; i++)
        {
            if(drags[i].victory == true)
            {
                aa++;
            }
        }

        if (aa == drags.Length)
        {
            Debug.Log("Ganaste");
        }

    }

}
