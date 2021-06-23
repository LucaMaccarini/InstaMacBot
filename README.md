# InstaMacBot 
![class](https://github.com/MaccariniLuca/InstaMacBot/blob/main/resources/Instagram_logo_2016.ico)

c# classes + desktop client bot for istagram

# NOTE
the code that is downloaded by cloning the repository is in the testing phase and could lead to problems in using the bot, if you intend to use the bot download it from the releases page obviously by downloading the latest one: [RELEASES](https://github.com/MaccariniLuca/InstaMacBot/releases)

# Description
this project is composed by 2 parts:
- Set of c# classes to split api and bot logic with desktop client implementation
- Desktop client

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
  quick draft showing the main classes of the bot logic
  (is an svg open in your browser for a better view)
  to see the details of the various classes and interfaces, look at the documentation
  
  ![class](https://github.com/MaccariniLuca/InstaMacBot/blob/main/documentation/quick%20class%20diagram.svg)
  
  
 ## 2) Desktop Client
 - A basic client that uses these classes, (bot is in beta testing)
 - In the future I will develop a client for android that will use these classes to bring the bot to a mobile platform
    
 # Terms and Conditions
 use this bot at you own risk!
 # Legal
This code is in no way affiliated with, authorized, maintained, sponsored or endorsed by Instagram or any of its affiliates or subsidiaries. This is an independent and unofficial instagram bot
 
# Installation (plug and play)
just download and start:
1) go to [release page](https://github.com/MaccariniLuca/InstaMacBot/releases)
2) download the plug and play zip
3) extract the zip
4) now you have the bot folder, open the exefile inside it

Attention
- It is important to do not touch the files inside the folder!
- to edit the project: download the source code zip and is just a c# project open the solution file with visual studio

# Usage
inside debug folder you can see the exe file and some folders:

all folders are client's bots folders where each bot can save its informarion or outputs for now bots saves informations on txt files cause is a beta after i will change method

other files are files of InstagramApiSharp the api that my bot use (don't touch them)
## bots
1) ScrapeAccountsFromHastagBot: used to extract accounts from an hastag (accounts that recently posted with the target hastag) 
2) ScrapeAccountsFromLocation: used to extract accounts from an instagram place (accounts that recently posted with the target location)   
3) ScrapeFollowersBot: used to extract accounts from the followers of public instagram user (private only if following)
4) FollowLikeLastsPicBot use the extracted followes: for follow and left some likes at lasts pics   
5) UnfollowBot use the followed list of FollowLikeLastsPicBot to unfollow all person in the list   
6) UnfollowBot use a list of accounts to send them a Direct Message

# Bug or Bad choises
- currently my classes open files only with openfiledialog, this method doesen't work on android same when bots saves them infos on files, i am searching an alternative
- async stop of procedura_bot() small active wait if the bot is scheduled to stop in a short time
- perhaps the extract.....Bots, like ExtractAccountsFromHastagBot or ExtractFollowersBot, that extends sssbot make a 'fake' override of stop() method because of the extract process that can't be stopped

# To do
- better bots file management maybe removing all files and creating one json file for each account that uses the bot
- like console class: wrap saving system to dissociate desktop openfiledialog and savefiledialog to another saving system that could be used for android
- 2 factors login
- better interface

# Developer
me :), my instagram is: https://www.instagram.com/iammacca_/ dm me for questions

