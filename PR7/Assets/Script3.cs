using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    public GameObject Prefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            Instantiate(Prefab, transform.position, transform.rotation);
    }
}
