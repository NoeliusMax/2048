using Godot;
using System;

public partial class Score : Control
{
	private Label scoreLabel;
	private int currentValue;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		scoreLabel = GetNode<Label>("Panel/ScoreText");
		currentValue = 0;
	}

	public void AddToScore(int addValue) {
		currentValue = currentValue + addValue;
		scoreLabel.Text = "Score: " + currentValue;

	}

	public void Reset() {
		currentValue = 0;
		scoreLabel.Text = "Score: " + currentValue;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
