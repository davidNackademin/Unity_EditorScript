using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareManager : MonoBehaviour {

    public GameObject square;



    public void NewSquare() {

        Instantiate(square);
    }



}
