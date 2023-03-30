using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Manager : MonoBehaviour
{
    public GameObject presentObject;
    public GameObject prefab;
    [SerializeField] private Transform pos;
    [SerializeField] private float timeUntilStart;
    private bool prefabtrig;

    private void Start()
    {
        StartCoroutine(BeginTimer());

        prefabtrig = false;
    }

    IEnumerator BeginTimer()
    {
        yield return new WaitForSeconds(timeUntilStart);
        DestroyObject(presentObject);

        Instantiate(prefab, pos);

        prefabtrig = true;
    }

    private void Update()
    {
        if (prefabtrig)
        {
            prefab.transform.position = new Vector3(pos.position.x, pos.position.y, pos.position.z);
        }
    }
}
