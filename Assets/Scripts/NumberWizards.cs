using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	// Use this for initialization
	
	int max;
	int min;
	int guess;
	
	void StartGame (){
		min = 1;
		guess = (min + max)/2;
		
		print ("========================");
		print ("Welcome to Number Wizard");
		//print ("Pick a number in your head but don't tell me!");
		
		print ("The lowest number you can pick is " + min);
		
		print ("Pick a maximum number for me to work with. Just type in the number and then press Enter!!");
		max = userInput();
		
		print ("The highest number (as you told me) you can pick is " + max);
		max = max + 1;
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equal");
	}
	
	int userInput (){
		int maximumInput = 0;
		
		while(!(Input.GetKeyDown(KeyCode.Return)) || !(Input.GetKeyDown(KeyCode.KeypadEnter))){
			if(Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0)){
				print ("0 is registered");
				maximumInput = maximumInput*10 + 0;
			}
		
			if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)){
				print ("1 is registered");
				maximumInput = maximumInput*10 + 1;
			}
		
			if(Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)){
				print ("2 is registered");
				maximumInput = maximumInput*10 + 2;
			}
		
			if(Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)){
				print ("3 is registered");
				maximumInput = maximumInput*10 + 3;
			}
		
			if(Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4)){
				print ("4 is registered");
				maximumInput = maximumInput*10 + 4;
			}
		
			if(Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5)){
				print ("5 is registered");
				maximumInput = maximumInput*10 + 5;
			}
		
			if(Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6)){
				print ("6 is registered");
				maximumInput = maximumInput*10 + 6;
			}
		
			if(Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7)){
				print ("7 is registered");
				maximumInput = maximumInput*10 + 7;
			}
		
			if(Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8)){
				print ("8 is registered");
				maximumInput = maximumInput*10 + 8;
			}
		
			if(Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9)){
				print ("9 is registered");
				maximumInput = maximumInput*10 + 9;
			}
		}
		return maximumInput;
	}
	
	void Start () {
		StartGame();
	}
	
	void NextGuess (){
		guess = (min + max)/2;
		print ("Higher or lower than " + guess);
		print ("Up = higher, down = lower, return = equal");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess;
			NextGuess();
		}
		
		else if(Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			NextGuess();
		}
		
		else if(Input.GetKeyDown(KeyCode.Return)){
			print ("I won!!");
			print ("Your number is " + guess + "!!");
			StartGame();
		}
	}
}
