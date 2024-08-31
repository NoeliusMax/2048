extends Control


func _on_start_game_btn_pressed():
	$AudioPlayer_1.play();

func StartButtonSoundFinished():
	get_tree().change_scene_to_file("res://Scenes/Game.tscn");


func _on_quit_game_btn_pressed():
	$AudioPlayer_2.play();


func QuitButtonSoundFinished():
	get_tree().quit();
