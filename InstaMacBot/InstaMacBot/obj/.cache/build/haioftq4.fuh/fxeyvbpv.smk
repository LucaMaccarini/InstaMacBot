<!DOCTYPE html>
<!--[if IE]><![endif]-->
<html>
  
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <title>Namespace InstaMacBot.classes
   </title>
    <meta name="viewport" content="width=device-width">
    <meta name="title" content="Namespace InstaMacBot.classes
   ">
    <meta name="generator" content="docfx 2.58.0.0">
    
    <link rel="shortcut icon" href="../favicon.ico">
    <link rel="stylesheet" href="../styles/docfx.vendor.css">
    <link rel="stylesheet" href="../styles/docfx.css">
    <link rel="stylesheet" href="../styles/main.css">
    <meta property="docfx:navrel" content="../toc.html">
    <meta property="docfx:tocrel" content="toc.html">
    
    
    
  </head>
  <body data-spy="scroll" data-target="#affix" data-offset="120">
    <div id="wrapper">
      <header>
        
        <nav id="autocollapse" class="navbar navbar-inverse ng-scope" role="navigation">
          <div class="container">
            <div class="navbar-header">
              <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navbar">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
              </button>
              
              <a class="navbar-brand" href="../index.html">
                <img id="logo" class="svg" src="../logo.svg" alt="">
              </a>
            </div>
            <div class="collapse navbar-collapse" id="navbar">
              <form class="navbar-form navbar-right" role="search" id="search">
                <div class="form-group">
                  <input type="text" class="form-control" id="search-query" placeholder="Search" autocomplete="off">
                </div>
              </form>
            </div>
          </div>
        </nav>
        
        <div class="subnav navbar navbar-default">
          <div class="container hide-when-search" id="breadcrumb">
            <ul class="breadcrumb">
              <li></li>
            </ul>
          </div>
        </div>
      </header>
      <div role="main" class="container body-content hide-when-search">
        
        <div class="sidenav hide-when-search">
          <a class="btn toc-toggle collapse" data-toggle="collapse" href="#sidetoggle" aria-expanded="false" aria-controls="sidetoggle">Show / Hide Table of Contents</a>
          <div class="sidetoggle collapse" id="sidetoggle">
            <div id="sidetoc"></div>
          </div>
        </div>
        <div class="article row grid-right">
          <div class="col-md-10">
            <article class="content wrap" id="_content" data-uid="InstaMacBot.classes">
  
  <h1 id="InstaMacBot_classes" data-uid="InstaMacBot.classes" class="text-break">Namespace InstaMacBot.classes
  </h1>
  <div class="markdown level0 summary"></div>
  <div class="markdown level0 conceptual"></div>
  <div class="markdown level0 remarks"></div>
    <h3 id="classes">Classes
  </h3>
      <h4><a class="xref" href="InstaMacBot.classes.bot_file_entry_list.html">bot_file_entry_list</a></h4>
      <section><p sourcefile="obj/api/InstaMacBot.classes.bot_file_entry_list.yml" sourcestartlinenumber="2" sourceendlinenumber="3">the object of this class rapresents a file created from once of the StartStopBot
objects of this class are immutable</p>
</section>
      <h4><a class="xref" href="InstaMacBot.classes.bot_file_list.html">bot_file_list</a></h4>
      <section><p>the object of this class rapresents a list of bot_file_entry_list 
used to store all bot files of the user that is using the bot client and display the list inside a lisatbox</p>
<p>objects of this class are mutable</p>
</section>
      <h4><a class="xref" href="InstaMacBot.classes.BotClient.html">BotClient</a></h4>
      <section><p sourcefile="obj/api/InstaMacBot.classes.BotClient.yml" sourcestartlinenumber="2" sourceendlinenumber="3">the objects of this class are bots manager they contains a map with [name,SSSbot]
are used just to have an organizzation of all bots grouped in a client and with an unique name for bot</p>
</section>
      <h4><a class="xref" href="InstaMacBot.classes.DesktopBotFileSaver.html">DesktopBotFileSaver</a></h4>
      <section><p>this class rappresents an entity that can override, append or create a file with some text saved in</p>
<p>objects of this class are immutable</p>
</section>
      <h4><a class="xref" href="InstaMacBot.classes.DesktopTextBoxConsole.html">DesktopTextBoxConsole</a></h4>
      <section><p>this class rappresents a console for desktop client that wraps a textbox</p>
<p>objects of this class are mutable</p>
</section>
      <h4><a class="xref" href="InstaMacBot.classes.FollowLikeLastsPicBot.html">FollowLikeLastsPicBot</a></h4>
      <section><p sourcefile="obj/api/InstaMacBot.classes.FollowLikeLastsPicBot.yml" sourcestartlinenumber="2" sourceendlinenumber="4">this class represents a follow, like lasts pics bot that works with a list of username
for each username on list: follow and like lasts pics
objects of this class are mutable</p>
</section>
      <h4><a class="xref" href="InstaMacBot.classes.ScrapeAccountsFromHastagBot.html">ScrapeAccountsFromHastagBot</a></h4>
      <section><p sourcefile="obj/api/InstaMacBot.classes.ScrapeAccountsFromHastagBot.yml" sourcestartlinenumber="2" sourceendlinenumber="3">this class represents a screaper bot that extract all accounts that had recently posted a photo tagging a target hastag (limit about 20.000 accounts)
objects of this class are mutable</p>
</section>
      <h4><a class="xref" href="InstaMacBot.classes.ScrapeAccountsFromLocationBot.html">ScrapeAccountsFromLocationBot</a></h4>
      <section><p sourcefile="obj/api/InstaMacBot.classes.ScrapeAccountsFromLocationBot.yml" sourcestartlinenumber="2" sourceendlinenumber="3">this class represents a screaper bot that extract all accounts that had recently posted a photo tagging a target location (limit about 20.000 accounts)
objects of this class are mutable</p>
</section>
      <h4><a class="xref" href="InstaMacBot.classes.ScrapeFollowersBot.html">ScrapeFollowersBot</a></h4>
      <section><p sourcefile="obj/api/InstaMacBot.classes.ScrapeFollowersBot.yml" sourcestartlinenumber="2" sourceendlinenumber="3">this class represents a screaper bot that extract all accounts that are following a targhet account (limit about 20.000 accounts)
objects of this class are mutable</p>
</section>
      <h4><a class="xref" href="InstaMacBot.classes.SendDmBot.html">SendDmBot</a></h4>
      <section><p sourcefile="obj/api/InstaMacBot.classes.SendDmBot.yml" sourcestartlinenumber="2" sourceendlinenumber="3">this class represents a send dms bot that works on a list of username for each username on list sends a dm
objects of this class are mutable</p>
</section>
      <h4><a class="xref" href="InstaMacBot.classes.SSSBot.html">SSSBot</a></h4>
      <section><p sourcefile="obj/api/InstaMacBot.classes.SSSBot.yml" sourcestartlinenumber="2" sourceendlinenumber="2">this abstract class define a status bot -&gt; a StartStopBot with status field, so is possible check if is running</p>
</section>
      <h4><a class="xref" href="InstaMacBot.classes.UnfollowBot.html">UnfollowBot</a></h4>
      <section><p sourcefile="obj/api/InstaMacBot.classes.UnfollowBot.yml" sourcestartlinenumber="2" sourceendlinenumber="3">this class represents an unfollow bot that works on a list of username and it unfollows all users on the list
objects of this class are mutable</p>
</section>
      <h4><a class="xref" href="InstaMacBot.classes.UserApi.html">UserApi</a></h4>
      <section><p sourcefile="obj/api/InstaMacBot.classes.UserApi.yml" sourcestartlinenumber="2" sourceendlinenumber="4">this class represents the instagram user and contains the api taken from InstagramApiSharp (github project: <a href="https://github.com/ramtinak/InstagramApiSharp" data-raw-source="https://github.com/ramtinak/InstagramApiSharp" sourcefile="obj/api/InstaMacBot.classes.UserApi.yml" sourcestartlinenumber="2" sourceendlinenumber="2">https://github.com/ramtinak/InstagramApiSharp</a>) 
to do all action on instagram
the objects of this class are mutable</p>
</section>
    <h3 id="interfaces">Interfaces
  </h3>
      <h4><a class="xref" href="InstaMacBot.classes.BotConsole.html">BotConsole</a></h4>
      <section><p sourcefile="obj/api/InstaMacBot.classes.BotConsole.yml" sourcestartlinenumber="2" sourceendlinenumber="2">this interface rappresents a console where is possible write in</p>
</section>
      <h4><a class="xref" href="InstaMacBot.classes.BotFileSaver.html">BotFileSaver</a></h4>
      <section><p sourcefile="obj/api/InstaMacBot.classes.BotFileSaver.yml" sourcestartlinenumber="2" sourceendlinenumber="2">this interface rapresents an entity able to save a list of strings or only a string row in a file</p>
</section>
      <h4><a class="xref" href="InstaMacBot.classes.StartStopBot.html">StartStopBot</a></h4>
      <section><p sourcefile="obj/api/InstaMacBot.classes.StartStopBot.yml" sourcestartlinenumber="2" sourceendlinenumber="2">this interface define a start stop bot -&gt; a bot that is possible start or stop itself</p>
</section>
</article>
          </div>
          
          <div class="hidden-sm col-md-2" role="complementary">
            <div class="sideaffix">
              <div class="contribution">
                <ul class="nav">
                </ul>
              </div>
              <nav class="bs-docs-sidebar hidden-print hidden-xs hidden-sm affix" id="affix">
                <h5>In This Article</h5>
                <div></div>
              </nav>
            </div>
          </div>
        </div>
      </div>
      
      <footer>
        <div class="grad-bottom"></div>
        <div class="footer">
          <div class="container">
            <span class="pull-right">
              <a href="#top">Back to top</a>
            </span>
            
            <span>Generated by <strong>DocFX</strong></span>
          </div>
        </div>
      </footer>
    </div>
    
    <script type="text/javascript" src="../styles/docfx.vendor.js"></script>
    <script type="text/javascript" src="../styles/docfx.js"></script>
    <script type="text/javascript" src="../styles/main.js"></script>
  </body>
</html>