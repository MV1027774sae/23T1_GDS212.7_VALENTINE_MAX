using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerManager : MonoBehaviour
{
    public GameObject prefab;
    [SerializeField] private Transform pos;

    private void Update()
    {
        prefab.transform.position = new Vector3(pos.position.x, pos.position.y, pos.position.z);
    }
}
