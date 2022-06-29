using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Application.LoadLevel("Scene1");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel("Scene2");
        }
    }
}
