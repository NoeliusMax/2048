extends Control

func _on_reset_game_btn_pressed():
	$AudioPlayer_1.play();

func ResetButtonSoundFinished():
	$"..".Restart();


func _on_go_menu_btn_pressed():
	$AudioPlayer_2.play();


func GoMenuButtonSoundFinished():
	get_tree().change_scene_to_file("res://Scenes/main_menu.tscn");
