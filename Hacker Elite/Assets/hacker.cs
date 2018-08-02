using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hacker : MonoBehaviour {

	// Use this for initialization
	void Start  () {
        ShowMainMenu();
    }

    void ShowMainMenu (){
        Terminal.ClearScreen ();
        var greeting = "Login Complete...";
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Welcome User");
        Terminal.WriteLine("" +
            "");
        Terminal.WriteLine("Which System You Like To Hack Into?");
        Terminal.WriteLine("" +
            "");
        Terminal.WriteLine("Press 1 for Town Hall");
        Terminal.WriteLine("Press 2 for State Capitol");
        Terminal.WriteLine("Press 3 for Pentagon");
        Terminal.WriteLine("" +
            "");
        Terminal.WriteLine("Enter Selection: ");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
