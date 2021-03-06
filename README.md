# CriffinMGNestTask
Machine gun nest job interview task for Criffin

1. Requirements  
- [X] 1.1. Aiming and shooting the mounted machine gun. -->  **Usable mounted machine gun**
- [X] 1.2. Enemies spawning in over time. -->  **Enemy spawn points with random spawn order (Supports more enemy types and spawn points)** 
- [X] 1.3. Enemies moving towards player position.  -->  **AI that moves towards nest with NavMesh**
- [X] 1.4. Basic environment.  -->  **Basic 3D Unity shapes**
- [X] 1.5. Developed on Unity 2019.4 or higher.  -->  **Unity 2019.4.34**
- [X] 1.6. Playable build for PC --> **A playable build can be found in the CriffinMGNestTask/CriffinNestTask/CriffinTaskWindowsBuild folder**
2. Suggestions  
- [ ] 2.1. Enemies not moving in a straight line (possibly using cover).  --> **No current implementation, although NavMesh makes them move smarter**
- [ ] 2.2. Suppression mechanic (scared enemies don't move).  --> **No current implementation**
- [X] 2.3. Score counting and game over scene. Restart button somewhere too.  --> **Score displayed for killing enemies, restart button at the end**
- [X] 2.4. Using Git with LFS (Large File Storage) for development. --> **Used LFS with the Github desktop sofware**

# About
Developed the application using Unity 2019.4.34 with using LFS through the Github Desktop sofware. To run the playable build, navigate to CriffinMGNestTask -> CriffinNestTask -> CriffinTaskWindowsBuild where you will find te .exe file  

After running the game, in the Menu you can choose to "Start" to start the game or "Quit" to quit the application. If you choose start, the game will start. You are placed in a high-ground nest where you can move your mounted machinegun around. Enemy AIs will spawn over time from various spawn points and they will strt moving towards the nest to attack it. Eliminate the enemies with shooting at them using your Left mouse click and earn 2 points for every elimination. If you can't eliminate them before they reach your nest, you will lose health and when all your health is gone, you fail the mission. After winning or losing, you will get a game over or congratulation message according to the outcome of your mission. This part contains a restart button to restart your game.
