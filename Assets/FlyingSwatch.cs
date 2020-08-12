using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FlyingSwatch : MonoBehaviour {
    public float speed;
    public int score;
    public UnityEvent onScoreUpdated;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Time.deltaTime * new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0.0f
        ) * speed;

        if (Input.GetKey(KeyCode.Y))
        {
            AddScore(1);
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            AddScore(1);
        }
    }

    public void AddScore(int s)
    {
        score += s;
        onScoreUpdated.Invoke();
    }
}
