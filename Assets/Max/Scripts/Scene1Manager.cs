using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1Manager : MonoBehaviour
{
    [SerializeField] private float countdown = 20f;

    void Start()
    {
        
    }

    IEnumerator BeginTimer()
    {
        yield return new WaitForSeconds(countdown);

        SceneManager.LoadScene(1);
    }
}
