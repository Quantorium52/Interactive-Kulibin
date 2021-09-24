using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickedOnCube : MonoBehaviour
{
    private void OnMouseDown()
    {
        Camera.main.GetComponent<ProjectAppearence>().OnPartFind();
    }
}
