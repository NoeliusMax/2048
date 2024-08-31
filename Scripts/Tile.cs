using Godot;
using System;

public partial class Tile : Polygon2D
{
	private int value = 0;
	private Color tileColor;
	private Label label;
	private int currentDigits = 1;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		PlaySpawnAnim();
		UpdateLabel();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public int GetValue() { return value; }

	public void SetValue(int newVal) { value = newVal; UpdateLabel(); UpdateColor(); }

	private void PlaySpawnAnim() {
		Scale = new Vector2(0, 0);
		Position = Position + new Vector2(50, 50);

		Tween scaleAnim = CreateTween();
		Tween positionAnim = CreateTween();

		scaleAnim.TweenProperty(this, "scale", new Vector2(1,1), 0.2f);
		positionAnim.TweenProperty(this, "position", Position - new Vector2(50, 50), 0.2f);
	}

	private void UpdateColor() {
		switch(value) {
			case 2:
				tileColor = new Color("eee3da");
			break;

			case 4:
				tileColor = new Color("eddfc8");
			break;

			case 8:
				tileColor = new Color("f2b178");
			break;

			case 16:
				tileColor = new Color("f59562");
			break;

			case 32:
				tileColor = new Color("f57c5f");
			break;

			case 64:
				tileColor = new Color("f65e3a");
			break;

			case 128:
				tileColor = new Color("edcf73");
			break;

			case 256:
				tileColor = new Color("edcc61");
			break;

			case 512:
				tileColor = new Color("edc750");
			break;

			case 1024:
				tileColor = new Color("edc53e");
			break;

			case 2048:
				tileColor = new Color("edc22d");
			break;
		}

		Color = tileColor;
	}

	private void UpdateLabel() { 
		label = GetNode<Label>("Label");
		label.Text = value.ToString(); 

	}
}
