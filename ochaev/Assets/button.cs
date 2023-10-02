using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject activegameObject;

    public void ActivateObject()
    {
        if (activegameObject.activeSelf != true)
        {
            activegameObject.SetActive(true);
        }
        else
        {
            activegameObject.SetActive(false);
        }
    }
}
