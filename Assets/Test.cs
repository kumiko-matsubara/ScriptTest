using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start() {
        //配列の宣言と初期化をする
        int[] array = { 30, 20, 50, 10, 80 };


        //配列の要素を逆順に表示
        for (int i = array.Length - 1; i>=0; i--) { 
            Debug.Log (array[i]);

        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
