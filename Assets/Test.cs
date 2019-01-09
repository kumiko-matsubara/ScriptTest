using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start() {
        //要素の個数が５の配列
        int[] array = new int[5];


        //配列の各要素の値を代入する
        array [0] = 30;
        array [1] = 20;
        array [2] = 50;
        array [3] = 10;
        array [4] = 80;

        //配列の要素をすべて表示する
        for (int i = 0; i < 5; i++) {
            Debug.Log (array[i]);

        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
