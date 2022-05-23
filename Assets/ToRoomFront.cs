using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToRoomFront : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToFront()
    {
        SceneManager.LoadScene("01.Front");
    }

}
