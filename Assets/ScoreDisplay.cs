using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour {
    public FlyingSwatch gremlin;
    public UnityEngine.UI.Text text;

    private void Awake()
    {
        UpdateScore();
    }
    // Use this for initialization
    void Start ()
    {
        gremlin.onScoreUpdated.AddListener(UpdateScore);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateScore()
    {
        text.text = "Score: " + gremlin.score;
    }
}
