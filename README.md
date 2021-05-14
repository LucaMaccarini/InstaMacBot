# InstaMacBot 
![class](https://github.com/MaccariniLuca/InstaMacBot/blob/main/resources/Instagram_logo_2016.ico)
c# classes + desktop client bot for istagram
# Description
this project is composed by 2 parts:
- Set of c# classes to split api and bot logic with desktop client implementation
- Desktop client

## Video about InstaMacBot
https://www.youtube.com/watch?v=30x-tAKDVMQ


## 1) Main Classes

  #### UserApi (Class): 
  >rappresents the instagram user and contains the api to do all action on instagram
  #### BotClient (Classes): 
  >rappresents a botClient with some different bots connected, having an organizzation of all bots grouped in a client and with an unic name for the bot
  #### StartStopBot (interface): 
  >a startable or stoppable bot
  #### SSSBot (Abstract class, implemets StartStopBot):
  >rappresents a status bot or StartStopBot with status is_running
  >
  >the other entities are classes that extend SSSbot: implement the bot behavior
  
  ### Classes Diagram
  (is an svg open in your browser for a better view)
  
  ![class](https://github.com/MaccariniLuca/InstaMacBot/blob/main/documentation/Class%20Diagram.svg)
  
  
 ## 2) Desktop Client
 - A basic client that uses these classes, (bot is in beta testing)
 - In the future I will develop a client for android that will use these classes to bring the bot to a mobile platform
    
 # Terms and Conditions
 use this bot at you own risk!
 # Legal
This code is in no way affiliated with, authorized, maintained, sponsored or endorsed by Instagram or any of its affiliates or subsidiaries. This is an independent and unofficial instagram bot
 
# Installation
just download and start:
InstaMacBot.exe is in InstaMacBot/InstaMacBot/InstaMacBot/bin/Debug/
- you can start InstaMacBot.exe or paste the entire debug folder on your desktop and rename it. It is important to do not touch the files inside the folder!
- to edit the project is just a c# project open the solution file with visual studio

# Usage
inside debug folder you can see the exe file and some folders:

all folders are client's bots folders where each bot can save its informarion or outputs for now bots saves informations on txt files cause is a beta after i will change method

other files are files of InstagramApiSharp the api that my bot use (don't touch them)

1) bot ExtractFollowersBot: used to extract followers from a public instagram user
2) bot FollowLikeLastsPicBot use the extracted followes (bot 1) for follow and left some likes at lasts pics (likes from 1 to 3 settable: default 1)
3) bot Unfollow use the followed list from bot2 to unfollow all person in the list

# Bug or Bad choises
- currently my classes open files only with openfiledialog, this method doesen't work on android same when bots saves them infos on files, i am searching an alternative
- async stop of procedura_bot() small active wait if the bot is scheduled to stop in a short time
- perhaps the extract.....Bots, like ExtractAccountsFromHastagBot or ExtractFollowersBot, that extends sssbot make a 'fake' override of stop() method because of the extract process that can't be stopped

# To do
- better bots file management maybe with an xml saved for each user that uses ClientBot
- like console class: wrap saving system to dissociate desktop openfiledialog and savefiledialog to another saving system that could be used for android

# Developer
me :)

