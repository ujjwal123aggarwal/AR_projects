using UnityEngine;
using System.Collections;

public class painting : MonoBehaviour {
    public GameObject bluepaint;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(2))
        {
            Instantiate(bluepaint, transform.position, transform.rotation);
        }
	}
}
