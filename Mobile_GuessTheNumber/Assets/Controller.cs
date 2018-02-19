using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Controller : MonoBehaviour {

    public InputField txt;
    public Text lbl;

    private int num;

	// Use this for initialization
	void Start () {
        num = Mathf.RoundToInt(Random.Range(0, 20));
	}

    public void Check ()
    {
        int input_number = int.Parse(txt.text);

        string message = "";
        if (input_number == num)
        { message = "YOU ARE TOTALLY RIGHT!!"; }
        else if (input_number > num)
        { message = "Your number is GREATER than the actual number."; }
        else
        { message = "Your number is LESS than the actual number."; }

        lbl.text = message;
    }
	
}
