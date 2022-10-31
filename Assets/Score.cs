using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
	[SerializeField]
	TextMeshProUGUI scoreText;
	int score = 0;

	void Update()
	{
		UpdateScore();

	}

	void UpdateScore()
	{
		score++;
		scoreText.text = string.Format( "{0:00000000000000}", score );
		scoreText.color = Color.HSVToRGB( score % 360.0f / 360.0f, 1.0f, 1.0f );
    }
}
