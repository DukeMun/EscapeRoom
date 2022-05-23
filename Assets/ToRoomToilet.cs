using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToRoomToilet : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToToilet(){
        SceneManager.LoadScene("05.Toilet");
    }
}
