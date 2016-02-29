using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
//using System.Linq;

public class startScript : MonoBehaviour {

														// 5 first input fields && 2 buttons

	public InputField inputField1;
	public InputField inputField2;
	string variable1;
	string variable2;
	char myChar1;
	char myChar2;
	
	public InputField inputField3;
	string starter;
	char[] myStarterChar; 

	public InputField inputField4;
	public InputField inputField5;
	string ruleString1;
	string ruleString2;

	char[] ruleChar1;
	char[] ruleChar2;

	public InputField inputFieldN;
	string nString;
	int nInt;
														 // list for organizing 

	List<char> listA = new List<char>();
	List<char> listB = new List<char>();


	public List<char> listC = new List<char>();


	bool first = true;


														// constraints

	public InputField savingField;
	string save;
	char saver;

	public InputField terminatorField;
	string terminate;
	char terminator;

	public InputField consField1;
	string constr1;
	char con1;

	public InputField constraintField1;
	string constrain1;
	float constraint1;

	public InputField cons2Field;
	string constr2;
	char con2;

	public InputField constraint2Field;
	string constrain2;
	float constraint2;

														// unity objects
	public GameObject adder;
	
	public GameObject theOrigin;
	
	public GameObject pointer;
	
	public Transform objectSpawn;
	
	public float rotation = 25.7F;
														// other variables used throughout the code
	int theBool = 0;

	public float countdown = 2.0f;

	public GameObject cami;

	bool leafRule = false;								// variables for leaves
	public GameObject leaf;

	//bool manual = false;								// variables for manual tree growth
	//int total = 0;
	//int manual = 1;
	//List<int> manualList = new List<int>();
	//int manualCounter = 0;


	int x = 1;
	int e = 0;

	float q;

	void Start () {


	}

	void Update () {




		if (theBool == 1) {
		
			
		//	if (e == manualList [manualCounter]) {
			//	manual = 0;
		//	}
														// once init() is complete the program will be running in real time

			//if(manual == 1){
					countdown -= Time.deltaTime;	
						if(countdown <= 0.0f){
							creation();
							countdown = 0.0000001f;
							}
				//	}
	
		//	if(Input.GetKeyDown(KeyCode.V)){

					
			//		manualCounter++;
			//		manual = 1;
			//

			//}
		}
	}

    public void init()
    {	
															// checks all inputs and if existant stores them in chars
		if (inputField1.text != "") {
			variable1 = inputField1.text;
			myChar1 = variable1 [0];
		}

		if (inputField2.text != "") {
			variable2 = inputField2.text;
			myChar2 = variable2 [0];
		}

		if (inputField3.text != "") {
			starter = inputField3.text;
			myStarterChar = starter.ToCharArray();
		}

		if (inputField4.text != "") {
			ruleString1 = inputField4.text;
			ruleChar1 = ruleString1.ToCharArray ();
		}

		if (inputField5.text != "") {
			ruleString2 = inputField5.text;
			ruleChar2 = ruleString2.ToCharArray ();
		}

															// checks and stores the constraints that will be later used
		if (savingField.text != "") {
			save = savingField.text;
			saver = save [0];
		}

		if (terminatorField.text != "") {
			terminate = terminatorField.text;
			terminator = terminate [0];
		}

		if (consField1.text != "") {
			constr1 = consField1.text;
			con1 = constr1 [0];
		}

		if (constraintField1.text != "") {
			constrain1 = constraintField1.text;
			constraint1 = float.Parse(constrain1);
		}	

		if (cons2Field.text != "") {
			constr2 = cons2Field.text;
			con2 = constr2 [0];
		}

		if (constraint2Field.text != "") {
			constrain2 = constraint2Field.text;
			constraint2 =  float.Parse(constrain2);
		}

		if (inputFieldN.text != "") {
			nString = inputFieldN.text;
			nInt = int.Parse(nString);
		}
															// ads the axiom to the list, the starting point that will only be added once
		if (first) {
			for(int p = 0; p < myStarterChar.Length; p++){
			listA.Add (myStarterChar[p]);
			}
			first = false;
		}
															// the main program which will loop as many times as we wish and will create the final complete list
		for (int k = 0; k < nInt; k++) {

			if (listA.Count != 0) {
				for (int i = 0; i < listA.Count; i++) {
					
					if (listA [i] == myChar1 && inputField1.text != "" ) {
						
						for (int j = 0; j < ruleChar1.Length; j++) {

							listB.Add (ruleChar1 [j]);

						}
					} else if (listA [i] == myChar2 && inputField2.text != "") {
						for (int j = 0; j < ruleChar2.Length; j++) {
						
							listB.Add (ruleChar2 [j]);
						}
					} else {
						listB.Add (listA [i]);
					}
				}

				//manualList.Add (listA.Count - total);
			//	total = total + listA.Count;
				listA.Clear ();
			}
			 else if (listB.Count != 0) {
				for (int i = 0; i < listB.Count; i++) {
				
					if (listB [i] == myChar1 && inputField1.text != "") {
					
						for (int j = 0; j < ruleChar1.Length; j++) {
						
							listA.Add (ruleChar1 [j]);
						
						}
					} else if (listB [i] == myChar2 && inputField2.text != "") {
						for (int j = 0; j < ruleChar2.Length; j++) {
						
							listA.Add (ruleChar2 [j]);
						}
					} else {
						listA.Add (listB [i]);
					}
				}

			//	manualList.Add (listB.Count - total);
		//		total = total + listB.Count;
				listB.Clear ();

			}
    
		}

	
		if (listA.Count != 0) {
			listC = new List<char>(listA);
		} else if (listB.Count !=0){
			listC = new List<char>(listB);
		}
		theBool = 1;	
	}

													
																		// Reload scene to remove existing building blocks
	public void renew(){
		Application.LoadLevel("l-systemScene");
	}



																		//
	void creation (){

	
		int holder = listC.Count;


		if (holder > e) {
			char o = listC [e];
			e++;

			if (o == saver) {

			
				Instantiate (pointer, objectSpawn.position, objectSpawn.rotation);
				if (GameObject.Find ("pointer" + x + "(Clone)")) {
					pointer = GameObject.Find ("pointer" + x + "(Clone)");
				

				} else if (GameObject.Find ("pointer" + x)) {
					pointer = GameObject.Find ("pointer" + x);
				} else {
					//x = 1;
					theOrigin.gameObject.name = "pointer" + x;
					pointer = theOrigin;
				}
			
				x++;
				pointer.gameObject.name = "pointer" + x;
				objectSpawn = pointer.transform;
				//			objectSpawn = Transform.position(pointer);
			}
		
		
			if (o == terminator) {
			
			
				if (GameObject.Find ("pointer" + x + "(Clone)")) {
					pointer = GameObject.Find ("pointer" + x + "(Clone)");
				} else if (GameObject.Find ("pointer" + x)) {
					pointer = GameObject.Find ("pointer" + x);
				} else {
					x = 1;
					theOrigin.gameObject.name = "pointer" + x;
					pointer = theOrigin;
				}
				if(leafRule){
				Instantiate (leaf, objectSpawn.position, objectSpawn.rotation);
				}
				Destroy (pointer);
				x--;
			
				if (GameObject.Find ("pointer" + x)) {
					pointer = GameObject.Find ("pointer" + x);
				} else {
					x = 1;
					theOrigin.gameObject.name = "pointer" + x;
					pointer = theOrigin;
				}
				objectSpawn = pointer.transform;
			}
		
		
			if (o == myChar1 || o == myChar2) {					

																						//check to see if more than 1 pointers exist and if so set the last pointer so we can move it
				if (GameObject.Find ("pointer" + x)) {
					pointer = GameObject.Find ("pointer" + x);
				} else {
					x = 1;
					theOrigin.gameObject.name = "pointer" + x;
					pointer = theOrigin;
				}
			
				objectSpawn = pointer.transform;										// CHECK HERE! FOR SOME REASON PROBABLY OBJECTSPAWN HAS NO VALUE EVEN IF WE DO ABOVE.
				Instantiate (adder, objectSpawn.position, objectSpawn.rotation);
				pointer.transform.Translate (Vector3.up * 2);
			}
		
			if (o == con1) {
			
				objectSpawn = pointer.transform;
				pointer.transform.Rotate (Vector3.forward * (constraint1));
				pointer.transform.Translate (Vector3.up * 1.5f);
			}
		
			if (o == con2) {

			
				objectSpawn = pointer.transform;
				pointer.transform.Rotate (Vector3.forward * (-constraint2));
				pointer.transform.Translate (Vector3.up * 1.5f);
			}
		
		} else {


			cami.transform.Translate(Vector3.back * Time.deltaTime * 50);
			cami.transform.Translate(Vector3.down * Time.deltaTime * 30);

		}



	}


	public void leavesOnOff(){
		if (leafRule) {
			leafRule = false;
		} else {
			leafRule = true;
		}
	}

	public void twoD(){
		Application.LoadLevel("l-systemScene");
	}

	public void threeD(){
		Application.LoadLevel("l-system3DScene");
	}
}