import UnityEngine

#Default Value is 5 (float), Range is (4 to 6) approx.
Balloon_Speed = 5

#Default Value is 1 (float), Range is (0.1 to 1), Lower the number increase the speed.
Balloon_Spawn_Speed = 1

#Default Value is 1 (int), Range is (1 to 8) approx.
Balloon_Spawn_Rate = 1

#Deafult Value is 10 (int), Range is (1 to 100...)
Allow_Escape_Ballon = 10

go = UnityEngine.GameObject.Find('Main Camera')
script = go.GetComponent('GameSetting')

script.BalloonSpeed(Balloon_Speed)

script.BalloonSpawnSpeed(Balloon_Spawn_Speed)

script.BalloonSpawnRate(Balloon_Spawn_Rate)

script.AllowEscapeBallon(Allow_Escape_Ballon)
