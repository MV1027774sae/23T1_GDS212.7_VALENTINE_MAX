using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AshScript : MonoBehaviour
{
    [SerializeField] private GameObject ashes;

    private void Update()
    {
        ashes.transform.position += new Vector3(-0.5f * Time.deltaTime, 0, -0.5f * Time.deltaTime);
    }
}
