# InstaMacBot 
![class](documentation_images/Instagram_logo_2016.ico)


# Description
c# classes + desktop client bot for istagram

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
  
#### the other entities are: 
>classes that extend SSSbot: implement the bot behavior
>entities for file save management
>classes for display files inside listbox inside desktop client
  
  
## 2) Desktop Client
  - A basic client that uses these classes
  - In the future I will develop a client for android that will use these classes to bring the bot to a mobile platform

# Developer
Luca Maccarini

Github link: https://github.com/MaccariniLuca/InstaMacBot