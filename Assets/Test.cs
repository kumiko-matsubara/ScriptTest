using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start() {
        //要素数の個数が５の配列
        int[] array = new int[5];

        //配列の各要素に値を代入
        array[0] = 30;
        array[1] = 20;
        array[2] = 50;
        array[3] = 10;
        array[4] = 80;

        //配列の要素を逆順に表示
        for (int i = array.Length - 1; i>=0; i--) { 
            Debug.Log (array[i]);

        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
