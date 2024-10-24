# Balloon Pop
Assignment: Basic Unity Game with Python Scripting and PlayFab Leaderboard

## Screenshots -
![StartScene](https://github.com/pranaysj/BalloonPop_VSQUARE/assets/75151973/8d93fcb6-e501-4b13-86fb-277cc98e05b4)
![GamePLayScene](https://github.com/pranaysj/BalloonPop_VSQUARE/assets/75151973/bd4b6866-6b2f-4a7b-8dc0-b95b0469d9a0)
![EndScene](https://github.com/pranaysj/BalloonPop_VSQUARE/assets/75151973/af3ac9fa-6ca1-487b-a203-63beabab1c0a)

## Gameplay Video -
https://github.com/pranaysj/BalloonPop_VSQUARE/assets/75151973/48f73bed-8a9a-40ec-9909-91efa99b9c9a

## Game Overview and Features -

The game is called Balloon Pop. It's a simple and easy game. When you start, balloons of different colors come from a rotating cannon and float up on the screen. You just need to click or tap on the balloons to get points. The game has a menu at the beginning, a part where you play the game, and another part at the end that shows your score. You can even submit your score to a leaderboard if you want. In the game, you earn points for popping balloons. But if you miss a balloon, your "escape points" go up. The game ends when your escape points reach a certain limit.

#### (Note - Select the Aspect Ratio to 16:9 before you will start the game.)

## Python Script Integration and Implementation -

To run the Python file, follow these steps:
1. Open the Gameplay scene in your game editor.
2. Click on the Main Camera GameObject.
3. Paste the file path of the Python file in the "Python File Path" field under the Game Setting Script.

This will ensure that the game uses the specified Python file for its settings during gameplay.

You can customize the following features by changing the variables inside the Python script:

1. **Increase the Floating Speed of Balloon:**
   - Modify the variable `Balloon_Speed` to adjust the speed of balloons floating.

2. **Balloon Spawn Rate:**
   - Adjust the variable `Balloon_Spawn_Rate` to change how many balloons appear per second.

3. **Balloon Spawning Speed:**
   - Change the variable `Balloon_Spawn_Speed` to control how quickly balloons appear.

4. **Change the Escape Balloon Limit:**
   - Customize the variable `Allow_Escape_Ballon` to set the limit for escaping balloons.

Simply update these variables in the Python script to tailor the game experience according to your preferences.

#### (Note - Open the Python file in your editor, make the desired changes to the variables, and save the file. Once saved, you'll observe the modifications reflected in the game as well.)


## PlayFab Integration -

1. **Install PlayFab Package:**
   - Followed the instructions provided in the [PlayFab Unity SDK Quickstart](https://learn.microsoft.com/en-us/gaming/playfab/sdks/unity3d/quickstart) to install the PlayFab package in your Unity project.

2. **Create Developer Account and Configure Settings:**
   - Successfully created a developer account on PlayFab.
   - Configured the required settings on the PlayFab dashboard to create a new leaderboard.

3. **PlayFab Manager Scripts:**
   - Developed PlayFab Manager scripts to handle custom login, send data to the leaderboard, and retrieve data from the leaderboard.

4. **Score Data Submission:**
   - Implemented a feature where the player's score data is sent to the PlayFab leaderboard upon clicking the submit button.

5. **Leaderboard Data Retrieval:**
   - Created a button that fetches leaderboard data from the PlayFab server.
   - Displayed the fetched leaderboard data on the game's leaderboard table.

By completing these steps, you've successfully integrated PlayFab into your Unity project, allowing for player data storage and retrieval through a leaderboard. This enhances the gaming experience by providing a competitive aspect and allowing players to compare their scores with others. Make sure to test thoroughly and handle any error scenarios to ensure a smooth player experience.


#### (Note - In the PlayFab server's Leaderboard Settings, we set it to "Latest (always update with the new value)". This is handy because each PC has its own username, and we can see any changes get updated right away on the leaderboard.)

