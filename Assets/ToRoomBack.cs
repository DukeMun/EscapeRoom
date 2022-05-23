using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToRoomBack : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToBack()
    {
        SceneManager.LoadScene("03.Back");
    }

}
