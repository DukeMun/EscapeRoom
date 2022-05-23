using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToRoomRight : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToRight(){
        SceneManager.LoadScene("02.Right");
    }
}
