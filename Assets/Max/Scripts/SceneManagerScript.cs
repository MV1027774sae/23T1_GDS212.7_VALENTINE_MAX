using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    [SerializeField] private float timeUntilStart = 5f;
    [SerializeField] private float countdown = 20f;
    [SerializeField] private int scene;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip narrationClip;
    [SerializeField] private Animator anim;

    private void Start()
    {
        StartCoroutine(BeginTimer());
    }

    IEnumerator BeginTimer()
    {
        yield return new WaitForSeconds(timeUntilStart);
        StartNarration();

        yield return new WaitForSeconds(countdown);
        LoadNextScene();
    }

    public void StartNarration()
    {
        audioSource.PlayOneShot(narrationClip);
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadScene(int levelIndex)
    {
        anim.SetTrigger("Start");
        
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(levelIndex);
    }
}
