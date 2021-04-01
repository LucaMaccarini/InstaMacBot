# InstaMacBot
a c# classes + desktop client bot for istagram
# Description
this project is composed by 2 parts:
### - Set of c# classes to split api and bot logic with desktop client implementation
### - Desktop client


## 1) Main Classes

  #### UserApi (Class): 
  >rappresents the instagram user and contains the api to do all action on instagram
  #### BotClient (Classs): 
  >rappresents a botClient with some different bots connected, haveing an organizzation of all bots grouped in a client and with an unic name for bot
  #### StartStopBot (interface): 
  >a startable or stoppable bot
  #### SSSBot (Abstract class, implemets StartStopBot):
  >rappresents a status bot or StartStopBot with status is_running
  >
  the other entities are class that extends SSSbot and implements the bot behavior
  
  ### Classes Diagram
  (is an svg open in your browser for a better view)
  
  ![class](https://github.com/MaccariniLuca/InstaMacBot/blob/main/documentation/Class%20Diagram.svg)
  
  
 ## 2) Desktop Client
    a basic client that use these classes
    (I am developing another client for android using these classes)
    
 # Terms and Conditions
 use this bot at you own risk!
 
#Installation
just download and start:
1) exe file is in InstaMacBot/InstaMacBot class/InstaMacBot/bin/Debug/
>- you can start InstaMacBot.exe or paste the entire debug folder on yout desktop and rename it just don't touch files inside
>- to edit the project is just a c# project open the solution file with visual studio

