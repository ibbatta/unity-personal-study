using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField] float invokeDelay = 0.75f;
    [SerializeField] ParticleSystem finishFx;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            finishFx.Play();
            Invoke("ReloadScene", invokeDelay);
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene("Level1");
    }

}
