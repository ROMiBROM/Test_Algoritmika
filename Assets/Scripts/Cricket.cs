using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cricket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Find("Tree");
        if (obj != null)
        {
            Destroy(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("crickets");// Вывод в консоль строки "crickets"
    }
}
