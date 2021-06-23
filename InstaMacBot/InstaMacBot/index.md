# InstaMacBot 
![class](images/Instagram_logo_2016.ico)


# Description
c# classes + desktop client bot for istagram

this project is composed by 2 parts:
- Set of c# classes to split api and bot logic with desktop client implementation
- Desktop client

## Video about this bot and its istallation
watch the video to understand how to use this bot since the management file is not very easy, but I promise to simplify it in the next versions
[click here for see the video](https://www.youtube.com/watch?v=2prio4o70BA)

# Note
in a few days a new version will be released with a total graphic restyling and a better file management

## 1) Main Classes
#### UserApi (Class): 
>rappresents the instagram user and contains the api to do all action on instagram

#### BotClient (Classes): 
>rappresents a botClient with some different bots connected, having an organizzation of all bots grouped in a client and with an unic name for the bot

#### StartStopBot (interface): 
>a startable or stoppable bot

#### SSSBot (Abstract class, implemets StartStopBot):
>rappresents a status bot or StartStopBot with status is_running
  
#### the other entities are: 
>classes that extend SSSbot: implement the bot behavior
>entities for file save management
>classes for display files inside listbox inside desktop client
  
  
## 2) Desktop Client
  - A basic client that uses these classes
  - In the future I will develop a client for android that will use these classes to bring the bot to a mobile platform
    
# Terms and Conditions
 use this bot at you own risk!
# Legal
This code is in no way affiliated with, authorized, maintained, sponsored or endorsed by Instagram or any of its affiliates or subsidiaries. This is an independent and unofficial instagram bot
 
# Installation (plug and play)
just download and start:
InstaMacBot.exe is in InstaMacBot/InstaMacBot/InstaMacBot/bin/Debug/
- you can start InstaMacBot.exe or paste the entire debug folder on your desktop and rename it. It is important to do not touch the files inside the folder!
- to edit the project is just a c# project open the solution file with visual studio

# Usage
inside debug folder you can see the exe file and some folders:

all folders are client's bots folders where each bot can save its informarion or outputs for now bots saves informations on txt files cause is a beta after i will change method

other files are files of InstagramApiSharp the api that my bot use (don't touch them)
#### Bots:
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