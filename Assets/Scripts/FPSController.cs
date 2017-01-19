using UnityEngine;
using System.Collections;

public class FPSController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float forwardSpeed = Input.GetAxis("Vertical");
        Vector3 speed = new Vector3(0, 0, forwardSpeed); // x, y are 0, then forward speed z

        CharacterController cc = GetComponent<CharacterController>(); // Access controller where script is attached

        cc.SimpleMove(speed);
	}

    public void MoveUp () {
        Vector3 speed = new Vector3(0, 0, 1); // x, y are 0, then forward speed z
        CharacterController cc = GetComponent<CharacterController>(); // Access controller where script is attached
        cc.SimpleMove(speed);
    }

    bool MoveDown() {
        return false;
    }

    bool MoveLeft() {
        return false;
    }

    bool MoveRight() {
        return false;
    }
}
