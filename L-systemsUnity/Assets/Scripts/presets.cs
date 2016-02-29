using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class presets : MonoBehaviour {

	public InputField inputField1;
	public InputField inputField2;
	public InputField inputField3;
	public InputField inputField4;
	public InputField inputField5;

	public InputField inputFieldN;

	public InputField savingField;
	public InputField terminatorField;

	public InputField consField1;
	public InputField constraintField1;
	public InputField cons2Field;
	public InputField constraint2Field;

	string x;
	string[] lines;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void preset1(){
		inputField1.text = "F";
		inputField2.text = "";
		inputField3.text = "F";
		inputField4.text = "F[+F]F[-F]F";
		inputField5.text = "";
		inputFieldN.text = "5";
		savingField.text = "[";
		terminatorField.text = "]";
		consField1.text = "+";
		constraintField1.text = "25.7";
		cons2Field.text = "-";
		constraint2Field.text = "25.7";
	}

	public void preset2(){
		inputField1.text = "F";
		inputField2.text = "";
		inputField3.text = "F";
		inputField4.text = "F[+F]F[-F][F]";
		inputField5.text = "";
		inputFieldN.text = "5";
		savingField.text = "[";
		terminatorField.text = "]";
		consField1.text = "+";
		constraintField1.text = "20";
		cons2Field.text = "-";
		constraint2Field.text = "20";
	}

	public void preset3(){
		inputField1.text = "F";
		inputField2.text = "";
		inputField3.text = "F";
		inputField4.text = "FF-[-F+F+F]+[+F-F-F]";
		inputField5.text = "";
		inputFieldN.text = "4";
		savingField.text = "[";
		terminatorField.text = "]";
		consField1.text = "+";
		constraintField1.text = "22.5";
		cons2Field.text = "-";
		constraint2Field.text = "22.5";
	}

	public void preset4(){
		inputField1.text = "X";
		inputField2.text = "F";
		inputField3.text = "X";
		inputField4.text = "F[+X]F[-X]+X";
		inputField5.text = "FF";
		inputFieldN.text = "7";
		savingField.text = "[";
		terminatorField.text = "]";
		consField1.text = "+";
		constraintField1.text = "20";
		cons2Field.text = "-";
		constraint2Field.text = "20";
	}

	public void preset5(){
		inputField1.text = "X";
		inputField2.text = "F";
		inputField3.text = "X";
		inputField4.text = "F[+X][-X]FX";
		inputField5.text = "FF";
		inputFieldN.text = "7";
		savingField.text = "[";
		terminatorField.text = "]";
		consField1.text = "+";
		constraintField1.text = "25.7";
		cons2Field.text = "-";
		constraint2Field.text = "25.7";
	}

	public void preset6(){
		inputField1.text = "X";
		inputField2.text = "F";
		inputField3.text = "X";
		inputField4.text = "F-[[X]+X]+F[+FX]-X";
		inputField5.text = "FF";
		inputFieldN.text = "5";
		savingField.text = "[";
		terminatorField.text = "]";
		consField1.text = "+";
		constraintField1.text = "22.5";
		cons2Field.text = "-";
		constraint2Field.text = "22.5";
	}

	public void preset7(){
		inputField1.text = "F";
		inputField2.text = "";
		inputField3.text = "F-F-F-F";
		inputField4.text = "FF-F-F-F-FF";
		inputField5.text = "";
		inputFieldN.text = "4";
		savingField.text = "[";
		terminatorField.text = "]";
		consField1.text = "+";
		constraintField1.text = "90";
		cons2Field.text = "-";
		constraint2Field.text = "90";
	}

	public void preset8(){
		inputField1.text = "F";
		inputField2.text = "X";
		inputField3.text = "F";
		inputField4.text = "X+F+X";
		inputField5.text = "F-X-F";
		inputFieldN.text = "8";
		savingField.text = "[";
		terminatorField.text = "]";
		consField1.text = "+";
		constraintField1.text = "60";
		cons2Field.text = "-";
		constraint2Field.text = "60";
	}

	public void readFromFile()
	{
		lines = System.IO.File.ReadAllLines("writeDataHere.txt");
		inputField1.text = lines[0];
		inputField2.text = lines[1];
		inputField3.text = lines[2];
		inputField4.text = lines[3];
		inputField5.text = lines[4];
		inputFieldN.text = lines[5];
		savingField.text = lines[6];
		terminatorField.text = lines[7];
		consField1.text = lines[8];
		constraintField1.text = lines[9];
		cons2Field.text = lines[10];
		constraint2Field.text = lines[11];
	}

}
