using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    bool hasCrashed = false;

    [SerializeField] float invokeDelay = 2f;
    [SerializeField] ParticleSystem crashFx;
    [SerializeField] AudioClip crashSFX;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            crashFx.Play();
            FindObjectOfType<PlayerController>().DisableControls();
            GetComponent<AudioSource>().PlayOneShot(crashSFX, 0.5f);
            Invoke("ReloadScene", invokeDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
