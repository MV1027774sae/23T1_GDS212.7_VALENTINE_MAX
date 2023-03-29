using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    [SerializeField] private float countdown = 20f;
    [SerializeField] private int scene;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip narrationClip;
    [SerializeField] private Animator anim;

    public void StartNarration()
    {
        audioSource.PlayOneShot(narrationClip);
    }

    public void SceneTimer()
    {
        BeginTimer();
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator BeginTimer()
    {
        yield return new WaitForSeconds(countdown);
    }

    IEnumerator LoadScene(int levelIndex)
    {
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelIndex);

    }
}
