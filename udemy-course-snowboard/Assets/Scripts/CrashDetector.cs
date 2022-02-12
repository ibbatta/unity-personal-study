using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float invokeDelay = 2f;
    [SerializeField] ParticleSystem crashFx;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground"){
            crashFx.Play();
            Invoke("ReloadScene", invokeDelay);
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene("Level1");
    }
}
