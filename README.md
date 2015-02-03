



<!DOCTYPE html>
<html lang="en" class="">
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# object: http://ogp.me/ns/object# article: http://ogp.me/ns/article# profile: http://ogp.me/ns/profile#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    
    
    <title>CSharp-Part-2/README.md at master · TelerikAcademy/CSharp-Part-2</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub">
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub">
    <link rel="apple-touch-icon" sizes="57x57" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="114x114" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="72x72" href="/apple-touch-icon-144.png">
    <link rel="apple-touch-icon" sizes="144x144" href="/apple-touch-icon-144.png">
    <meta property="fb:app_id" content="1401488693436528">

      <meta content="@github" name="twitter:site" /><meta content="summary" name="twitter:card" /><meta content="TelerikAcademy/CSharp-Part-2" name="twitter:title" /><meta content="CSharp-Part-2 - Repository for the course &amp;quot;C# part 2&amp;quot;" name="twitter:description" /><meta content="https://avatars2.githubusercontent.com/u/1455020?v=3&amp;s=400" name="twitter:image:src" />
<meta content="GitHub" property="og:site_name" /><meta content="object" property="og:type" /><meta content="https://avatars2.githubusercontent.com/u/1455020?v=3&amp;s=400" property="og:image" /><meta content="TelerikAcademy/CSharp-Part-2" property="og:title" /><meta content="https://github.com/TelerikAcademy/CSharp-Part-2" property="og:url" /><meta content="CSharp-Part-2 - Repository for the course &quot;C# part 2&quot;" property="og:description" />

      <meta name="browser-stats-url" content="/_stats">
    <link rel="assets" href="https://assets-cdn.github.com/">
    <link rel="conduit-xhr" href="https://ghconduit.com:25035">
    <link rel="xhr-socket" href="/_sockets">
    <meta name="pjax-timeout" content="1000">
    <link rel="sudo-modal" href="/sessions/sudo_modal">

    <meta name="msapplication-TileImage" content="/windows-tile.png">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="selected-link" value="repo_source" data-pjax-transient>
      <meta name="google-analytics" content="UA-3769691-2">

    <meta content="collector.githubapp.com" name="octolytics-host" /><meta content="collector-cdn.github.com" name="octolytics-script-host" /><meta content="github" name="octolytics-app-id" /><meta content="C6245751:72C6:9528F8C:54D0E16B" name="octolytics-dimension-request_id" /><meta content="10468274" name="octolytics-actor-id" /><meta content="atanas-georgiev" name="octolytics-actor-login" /><meta content="90ab182c6c899c84016f22fb12b710da63858a8dc2fed8685e231099c273373c" name="octolytics-actor-hash" />
    
    <meta content="Rails, view, blob#show" name="analytics-event" />

    
    
    <link rel="icon" type="image/x-icon" href="https://assets-cdn.github.com/favicon.ico">


    <meta content="authenticity_token" name="csrf-param" />
<meta content="vnv7ylQ0SR0mTaGHZ6my4TfH82/mYjxINgBKPFRFtfIjzbzINB0w/+SzZjp/iuwvX8NlfuCV0AL2/1zs/rB8nA==" name="csrf-token" />

    <link href="https://assets-cdn.github.com/assets/github-e3321d79480f0738576ff81cb2f3f717fdbb0bf35ea5938c30005a3349371133.css" media="all" rel="stylesheet" type="text/css" />
    <link href="https://assets-cdn.github.com/assets/github2-43f272124a3022796fb21764ef209f84576d8d88ddc3a6bd0e4849aaeec0ec8c.css" media="all" rel="stylesheet" type="text/css" />
    
    


    <meta http-equiv="x-pjax-version" content="9d39ed06d15e02c983eff8d2a2777f64">

      
  <meta name="description" content="CSharp-Part-2 - Repository for the course &quot;C# part 2&quot;">
  <meta name="go-import" content="github.com/TelerikAcademy/CSharp-Part-2 git https://github.com/TelerikAcademy/CSharp-Part-2.git">

  <meta content="1455020" name="octolytics-dimension-user_id" /><meta content="TelerikAcademy" name="octolytics-dimension-user_login" /><meta content="28328944" name="octolytics-dimension-repository_id" /><meta content="TelerikAcademy/CSharp-Part-2" name="octolytics-dimension-repository_nwo" /><meta content="true" name="octolytics-dimension-repository_public" /><meta content="false" name="octolytics-dimension-repository_is_fork" /><meta content="28328944" name="octolytics-dimension-repository_network_root_id" /><meta content="TelerikAcademy/CSharp-Part-2" name="octolytics-dimension-repository_network_root_nwo" />
  <link href="https://github.com/TelerikAcademy/CSharp-Part-2/commits/master.atom" rel="alternate" title="Recent Commits to CSharp-Part-2:master" type="application/atom+xml">

  </head>


  <body class="logged_in  env-production windows vis-public page-blob">
    <a href="#start-of-content" tabindex="1" class="accessibility-aid js-skip-to-content">Skip to content</a>
    <div class="wrapper">
      
      
      
      


      <div class="header header-logged-in true" role="banner">
  <div class="container clearfix">

    <a class="header-logo-invertocat" href="https://github.com/" data-hotkey="g d" aria-label="Homepage" ga-data-click="Header, go to dashboard, icon:logo">
  <span class="mega-octicon octicon-mark-github"></span>
</a>


      <div class="site-search repo-scope js-site-search" role="search">
          <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-2/search" class="js-site-search-form" data-global-search-url="/search" data-repo-search-url="/TelerikAcademy/CSharp-Part-2/search" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
  <input type="text"
    class="js-site-search-field is-clearable"
    data-hotkey="s"
    name="q"
    placeholder="Search"
    data-global-scope-placeholder="Search GitHub"
    data-repo-scope-placeholder="Search"
    tabindex="1"
    autocapitalize="off">
  <div class="scope-badge">This repository</div>
</form>
      </div>
      <ul class="header-nav left" role="navigation">
        <li class="header-nav-item explore">
          <a class="header-nav-link" href="/explore" data-ga-click="Header, go to explore, text:explore">Explore</a>
        </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="https://gist.github.com" data-ga-click="Header, go to gist, text:gist">Gist</a>
          </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="/blog" data-ga-click="Header, go to blog, text:blog">Blog</a>
          </li>
        <li class="header-nav-item">
          <a class="header-nav-link" href="https://help.github.com" data-ga-click="Header, go to help, text:help">Help</a>
        </li>
      </ul>

    
<ul class="header-nav user-nav right" id="user-links">
  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link name" href="/atanas-georgiev" data-ga-click="Header, go to profile, text:username">
      <img alt="atanas-georgiev" class="avatar" data-user="10468274" height="20" src="https://avatars3.githubusercontent.com/u/10468274?v=3&amp;s=40" width="20" />
      <span class="css-truncate">
        <span class="css-truncate-target">atanas-georgiev</span>
      </span>
    </a>
  </li>

  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link js-menu-target tooltipped tooltipped-s" href="#" aria-label="Create new..." data-ga-click="Header, create new, icon:add">
      <span class="octicon octicon-plus"></span>
      <span class="dropdown-caret"></span>
    </a>

    <div class="dropdown-menu-content js-menu-content">
      
<ul class="dropdown-menu">
  <li>
    <a href="/new" data-ga-click="Header, create new repository, icon:repo"><span class="octicon octicon-repo"></span> New repository</a>
  </li>
  <li>
    <a href="/organizations/new" data-ga-click="Header, create new organization, icon:organization"><span class="octicon octicon-organization"></span> New organization</a>
  </li>


    <li class="dropdown-divider"></li>
    <li class="dropdown-header">
      <span title="TelerikAcademy/CSharp-Part-2">This repository</span>
    </li>
      <li>
        <a href="/TelerikAcademy/CSharp-Part-2/issues/new" data-ga-click="Header, create new issue, icon:issue"><span class="octicon octicon-issue-opened"></span> New issue</a>
      </li>
</ul>

    </div>
  </li>

  <li class="header-nav-item">
        <a href="/notifications" aria-label="You have no unread notifications" class="header-nav-link notification-indicator tooltipped tooltipped-s" data-ga-click="Header, go to notifications, icon:read" data-hotkey="g n">
        <span class="mail-status all-read"></span>
        <span class="octicon octicon-inbox"></span>
</a>
  </li>

  <li class="header-nav-item">
    <a class="header-nav-link tooltipped tooltipped-s" href="/settings/profile" id="account_settings" aria-label="Settings" data-ga-click="Header, go to settings, icon:settings">
      <span class="octicon octicon-gear"></span>
    </a>
  </li>

  <li class="header-nav-item">
    <form accept-charset="UTF-8" action="/logout" class="logout-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="1JDj0UZwnwOqKNBb2nDoc0PD+vJXlHowiKrs8cjJ17rb4kBNSi0onZtvO3yOR31Ez9THmTuvZNAbswBV9I78mA==" /></div>
      <button class="header-nav-link sign-out-button tooltipped tooltipped-s" aria-label="Sign out" data-ga-click="Header, sign out, icon:logout">
        <span class="octicon octicon-sign-out"></span>
      </button>
</form>  </li>

</ul>


    
  </div>
</div>

      

        


      <div id="start-of-content" class="accessibility-aid"></div>
          <div class="site" itemscope itemtype="http://schema.org/WebPage">
    <div id="js-flash-container">
      
    </div>
    <div class="pagehead repohead instapaper_ignore readability-menu">
      <div class="container">
        
<ul class="pagehead-actions">

    <li class="subscription">
      <form accept-charset="UTF-8" action="/notifications/subscribe" class="js-social-container" data-autosubmit="true" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="tnz85jcayB9bQLKY0Y9lSzW/7h/+ujv4ZN0PRi8O4UIKGEXkFxRQGMD6QIdfBsCN4SqdI719+FYJcVJmesKA/A==" /></div>  <input id="repository_id" name="repository_id" type="hidden" value="28328944" />

    <div class="select-menu js-menu-container js-select-menu">
      <a class="social-count js-social-count" href="/TelerikAcademy/CSharp-Part-2/watchers">
        9
      </a>
      <a href="/TelerikAcademy/CSharp-Part-2/subscription"
        class="minibutton select-menu-button with-count js-menu-target" role="button" tabindex="0" aria-haspopup="true">
        <span class="js-select-button">
          <span class="octicon octicon-eye"></span>
          Watch
        </span>
      </a>

      <div class="select-menu-modal-holder">
        <div class="select-menu-modal subscription-menu-modal js-menu-content" aria-hidden="true">
          <div class="select-menu-header">
            <span class="select-menu-title">Notifications</span>
            <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
          </div> <!-- /.select-menu-header -->

          <div class="select-menu-list js-navigation-container" role="menu">

            <div class="select-menu-item js-navigation-item selected" role="menuitem" tabindex="0">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input checked="checked" id="do_included" name="do" type="radio" value="included" />
                <h4>Not watching</h4>
                <span class="description">Be notified when participating or @mentioned.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-eye"></span>
                  Watch
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

            <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
              <span class="select-menu-item-icon octicon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input id="do_subscribed" name="do" type="radio" value="subscribed" />
                <h4>Watching</h4>
                <span class="description">Be notified of all conversations.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-eye"></span>
                  Unwatch
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

            <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input id="do_ignore" name="do" type="radio" value="ignore" />
                <h4>Ignoring</h4>
                <span class="description">Never be notified.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-mute"></span>
                  Stop ignoring
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

          </div> <!-- /.select-menu-list -->

        </div> <!-- /.select-menu-modal -->
      </div> <!-- /.select-menu-modal-holder -->
    </div> <!-- /.select-menu -->

</form>
    </li>

  <li>
    
  <div class="js-toggler-container js-social-container starring-container ">

    <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-2/unstar" class="js-toggler-form starred js-unstar-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="/b9iy1m6KcCKOdEiz5Vs3FpxDK9q2OgaSPcEbOCUgHc6aGc0l0Lp+pPlj7A6qEqYtddwVzf4I3cW7OXuBQQh6w==" /></div>
      <button
        class="minibutton with-count js-toggler-target star-button"
        aria-label="Unstar this repository" title="Unstar TelerikAcademy/CSharp-Part-2">
        <span class="octicon octicon-star"></span>
        Unstar
      </button>
        <a class="social-count js-social-count" href="/TelerikAcademy/CSharp-Part-2/stargazers">
          2
        </a>
</form>
    <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-2/star" class="js-toggler-form unstarred js-star-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="R2yPMH2tV5KTXxW1MUQavzgCuA97RQXUrlIXevpS5Rk64DkHPRBEzgofpYLXcrK9e7LbLj5qKPUiqnIy7BNDhg==" /></div>
      <button
        class="minibutton with-count js-toggler-target star-button"
        aria-label="Star this repository" title="Star TelerikAcademy/CSharp-Part-2">
        <span class="octicon octicon-star"></span>
        Star
      </button>
        <a class="social-count js-social-count" href="/TelerikAcademy/CSharp-Part-2/stargazers">
          2
        </a>
</form>  </div>

  </li>


        <li>
          <a href="/TelerikAcademy/CSharp-Part-2/fork" class="minibutton with-count js-toggler-target fork-button tooltipped-n" title="Fork your own copy of TelerikAcademy/CSharp-Part-2 to your account" aria-label="Fork your own copy of TelerikAcademy/CSharp-Part-2 to your account" rel="nofollow" data-method="post">
            <span class="octicon octicon-repo-forked"></span>
            Fork
          </a>
          <a href="/TelerikAcademy/CSharp-Part-2/network" class="social-count">3</a>
        </li>

</ul>

        <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public">
          <span class="mega-octicon octicon-repo"></span>
          <span class="author"><a href="/TelerikAcademy" class="url fn" itemprop="url" rel="author"><span itemprop="title">TelerikAcademy</span></a></span><!--
       --><span class="path-divider">/</span><!--
       --><strong><a href="/TelerikAcademy/CSharp-Part-2" class="js-current-repository" data-pjax="#js-repo-pjax-container">CSharp-Part-2</a></strong>

          <span class="page-context-loader">
            <img alt="" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
          </span>

        </h1>
      </div><!-- /.container -->
    </div><!-- /.repohead -->

    <div class="container">
      <div class="repository-with-sidebar repo-container new-discussion-timeline  ">
        <div class="repository-sidebar clearfix">
            
<nav class="sunken-menu repo-nav js-repo-nav js-sidenav-container-pjax js-octicon-loaders"
     role="navigation"
     data-pjax="#js-repo-pjax-container"
     data-issue-count-url="/TelerikAcademy/CSharp-Part-2/issues/counts">
  <ul class="sunken-menu-group">
    <li class="tooltipped tooltipped-w" aria-label="Code">
      <a href="/TelerikAcademy/CSharp-Part-2" aria-label="Code" class="selected js-selected-navigation-item sunken-menu-item" data-hotkey="g c" data-selected-links="repo_source repo_downloads repo_commits repo_releases repo_tags repo_branches /TelerikAcademy/CSharp-Part-2">
        <span class="octicon octicon-code"></span> <span class="full-word">Code</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>

      <li class="tooltipped tooltipped-w" aria-label="Issues">
        <a href="/TelerikAcademy/CSharp-Part-2/issues" aria-label="Issues" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g i" data-selected-links="repo_issues repo_labels repo_milestones /TelerikAcademy/CSharp-Part-2/issues">
          <span class="octicon octicon-issue-opened"></span> <span class="full-word">Issues</span>
          <span class="js-issue-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>

    <li class="tooltipped tooltipped-w" aria-label="Pull Requests">
      <a href="/TelerikAcademy/CSharp-Part-2/pulls" aria-label="Pull Requests" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g p" data-selected-links="repo_pulls /TelerikAcademy/CSharp-Part-2/pulls">
          <span class="octicon octicon-git-pull-request"></span> <span class="full-word">Pull Requests</span>
          <span class="js-pull-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>


  </ul>
  <div class="sunken-menu-separator"></div>
  <ul class="sunken-menu-group">

    <li class="tooltipped tooltipped-w" aria-label="Pulse">
      <a href="/TelerikAcademy/CSharp-Part-2/pulse" aria-label="Pulse" class="js-selected-navigation-item sunken-menu-item" data-selected-links="pulse /TelerikAcademy/CSharp-Part-2/pulse">
        <span class="octicon octicon-pulse"></span> <span class="full-word">Pulse</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>

    <li class="tooltipped tooltipped-w" aria-label="Graphs">
      <a href="/TelerikAcademy/CSharp-Part-2/graphs" aria-label="Graphs" class="js-selected-navigation-item sunken-menu-item" data-selected-links="repo_graphs repo_contributors /TelerikAcademy/CSharp-Part-2/graphs">
        <span class="octicon octicon-graph"></span> <span class="full-word">Graphs</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>
  </ul>


</nav>

              <div class="only-with-full-nav">
                
  
<div class="clone-url open"
  data-protocol-type="http"
  data-url="/users/set_protocol?protocol_selector=http&amp;protocol_type=clone">
  <h3><span class="text-emphasized">HTTPS</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/TelerikAcademy/CSharp-Part-2.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard minibutton zeroclipboard-button" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="ssh"
  data-url="/users/set_protocol?protocol_selector=ssh&amp;protocol_type=clone">
  <h3><span class="text-emphasized">SSH</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="git@github.com:TelerikAcademy/CSharp-Part-2.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard minibutton zeroclipboard-button" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="subversion"
  data-url="/users/set_protocol?protocol_selector=subversion&amp;protocol_type=clone">
  <h3><span class="text-emphasized">Subversion</span> checkout URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/TelerikAcademy/CSharp-Part-2" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard minibutton zeroclipboard-button" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>



<p class="clone-options">You can clone with
  <a href="#" class="js-clone-selector" data-protocol="http">HTTPS</a>, <a href="#" class="js-clone-selector" data-protocol="ssh">SSH</a>, or <a href="#" class="js-clone-selector" data-protocol="subversion">Subversion</a>.
  <a href="https://help.github.com/articles/which-remote-url-should-i-use" class="help tooltipped tooltipped-n" aria-label="Get help on which URL is right for you.">
    <span class="octicon octicon-question"></span>
  </a>
</p>


  <a href="github-windows://openRepo/https://github.com/TelerikAcademy/CSharp-Part-2" class="minibutton sidebar-button" title="Save TelerikAcademy/CSharp-Part-2 to your computer and use it in GitHub Desktop." aria-label="Save TelerikAcademy/CSharp-Part-2 to your computer and use it in GitHub Desktop.">
    <span class="octicon octicon-device-desktop"></span>
    Clone in Desktop
  </a>

                <a href="/TelerikAcademy/CSharp-Part-2/archive/master.zip"
                   class="minibutton sidebar-button"
                   aria-label="Download the contents of TelerikAcademy/CSharp-Part-2 as a zip file"
                   title="Download the contents of TelerikAcademy/CSharp-Part-2 as a zip file"
                   rel="nofollow">
                  <span class="octicon octicon-cloud-download"></span>
                  Download ZIP
                </a>
              </div>
        </div><!-- /.repository-sidebar -->

        <div id="js-repo-pjax-container" class="repository-content context-loader-container" data-pjax-container>
          

<a href="/TelerikAcademy/CSharp-Part-2/blob/3453c2ceb1bc0444cc300307b261fc1bbce2e961/06.%20Strings%20and%20Text%20Processing/README.md" class="hidden js-permalink-shortcut" data-hotkey="y">Permalink</a>

<!-- blob contrib key: blob_contributors:v21:1c6fff25480f52a351fa7fba72a7d2b4 -->

<div class="file-navigation js-zeroclipboard-container">
  
<div class="select-menu js-menu-container js-select-menu left">
  <span class="minibutton select-menu-button js-menu-target css-truncate" data-hotkey="w"
    data-master-branch="master"
    data-ref="master"
    title="master"
    role="button" aria-label="Switch branches or tags" tabindex="0" aria-haspopup="true">
    <span class="octicon octicon-git-branch"></span>
    <i>branch:</i>
    <span class="js-select-button css-truncate-target">master</span>
  </span>

  <div class="select-menu-modal-holder js-menu-content js-navigation-container" data-pjax aria-hidden="true">

    <div class="select-menu-modal">
      <div class="select-menu-header">
        <span class="select-menu-title">Switch branches/tags</span>
        <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
      </div> <!-- /.select-menu-header -->

      <div class="select-menu-filters">
        <div class="select-menu-text-filter">
          <input type="text" aria-label="Filter branches/tags" id="context-commitish-filter-field" class="js-filterable-field js-navigation-enable" placeholder="Filter branches/tags">
        </div>
        <div class="select-menu-tabs">
          <ul>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="branches" class="js-select-menu-tab">Branches</a>
            </li>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="tags" class="js-select-menu-tab">Tags</a>
            </li>
          </ul>
        </div><!-- /.select-menu-tabs -->
      </div><!-- /.select-menu-filters -->

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="branches">

        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


            <div class="select-menu-item js-navigation-item selected">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/TelerikAcademy/CSharp-Part-2/blob/master/06.%20Strings%20and%20Text%20Processing/README.md"
                 data-name="master"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="master">master</a>
            </div> <!-- /.select-menu-item -->
        </div>

          <div class="select-menu-no-results">Nothing to show</div>
      </div> <!-- /.select-menu-list -->

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="tags">
        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


        </div>

        <div class="select-menu-no-results">Nothing to show</div>
      </div> <!-- /.select-menu-list -->

    </div> <!-- /.select-menu-modal -->
  </div> <!-- /.select-menu-modal-holder -->
</div> <!-- /.select-menu -->

  <div class="button-group right">
    <a href="/TelerikAcademy/CSharp-Part-2/find/master"
          class="js-show-file-finder minibutton empty-icon tooltipped tooltipped-s"
          data-pjax
          data-hotkey="t"
          aria-label="Quickly jump between files">
      <span class="octicon octicon-list-unordered"></span>
    </a>
    <button aria-label="Copy file path to clipboard" class="js-zeroclipboard minibutton zeroclipboard-button" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
  </div>

  <div class="breadcrumb js-zeroclipboard-target">
    <span class='repo-root js-repo-root'><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/TelerikAcademy/CSharp-Part-2" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">CSharp-Part-2</span></a></span></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/TelerikAcademy/CSharp-Part-2/tree/master/06.%20Strings%20and%20Text%20Processing" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">06. Strings and Text Processing</span></a></span><span class="separator">/</span><strong class="final-path">README.md</strong>
  </div>
</div>

<include-fragment class="commit commit-loader file-history-tease" src="/TelerikAcademy/CSharp-Part-2/contributors/master/06.%20Strings%20and%20Text%20Processing/README.md">
  <div class="file-history-tease-header">
    Fetching contributors&hellip;
  </div>

  <div class="participation">
    <p class="loader-loading"><img alt="" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32-EAF2F5.gif" width="16" /></p>
    <p class="loader-error">Cannot retrieve contributors at this time</p>
  </div>
</include-fragment>
<div class="file-box">
  <div class="file">
    <div class="meta clearfix">
      <div class="info file-name">
          <span>188 lines (126 sloc)</span>
          <span class="meta-divider"></span>
        <span>8.312 kb</span>
      </div>
      <div class="actions">
        <div class="button-group">
          <a href="/TelerikAcademy/CSharp-Part-2/raw/master/06.%20Strings%20and%20Text%20Processing/README.md" class="minibutton " id="raw-url">Raw</a>
            <a href="/TelerikAcademy/CSharp-Part-2/blame/master/06.%20Strings%20and%20Text%20Processing/README.md" class="minibutton js-update-url-with-hash">Blame</a>
          <a href="/TelerikAcademy/CSharp-Part-2/commits/master/06.%20Strings%20and%20Text%20Processing/README.md" class="minibutton " rel="nofollow">History</a>
        </div><!-- /.button-group -->

          <a class="octicon-button tooltipped tooltipped-nw"
             href="github-windows://openRepo/https://github.com/TelerikAcademy/CSharp-Part-2?branch=master&amp;filepath=06.%20Strings%20and%20Text%20Processing%2FREADME.md" aria-label="Open this file in GitHub for Windows">
              <span class="octicon octicon-device-desktop"></span>
          </a>

              <a class="octicon-button tooltipped tooltipped-n js-update-url-with-hash"
                 aria-label="Clicking this button will fork this project so you can edit the file"
                 href="/TelerikAcademy/CSharp-Part-2/edit/master/06.%20Strings%20and%20Text%20Processing/README.md"
                 data-method="post" rel="nofollow"><span class="octicon octicon-pencil"></span></a>

            <a class="octicon-button danger tooltipped tooltipped-s"
               href="/TelerikAcademy/CSharp-Part-2/delete/master/06.%20Strings%20and%20Text%20Processing/README.md"
               aria-label="Fork this project and delete file"
               data-method="post" data-test-id="delete-blob-file" rel="nofollow">
          <span class="octicon octicon-trashcan"></span>
        </a>
      </div><!-- /.actions -->
    </div>
    
  <div id="readme" class="blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="mainContentOfPage"><h1>
<a id="user-content-homework-strings-and-text-processing" class="anchor" href="#homework-strings-and-text-processing" aria-hidden="true"><span class="octicon octicon-link"></span></a>Homework: Strings and Text Processing</h1>

<h3>
<a id="user-content-problem-1-strings-in-c" class="anchor" href="#problem-1-strings-in-c" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 1. Strings in C</h3>

<ul class="task-list">
<li>  Describe the strings in C#.</li>
<li>  What is typical for the string data type?</li>
<li>  Describe the most important methods of the String class.</li>
</ul>

<h3>
<a id="user-content-problem-2-reverse-string" class="anchor" href="#problem-2-reverse-string" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 2. Reverse string</h3>

<ul class="task-list">
<li>  Write a program that reads a string, reverses it and prints the result at the console.</li>
</ul>

<p><em>Example:</em></p>

<table>
<thead>
<tr>
<th align="center">input</th>
<th align="center">output</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">sample</td>
<td align="center">elpmas</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-3-correct-brackets" class="anchor" href="#problem-3-correct-brackets" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 3. Correct brackets</h3>

<ul class="task-list">
<li>  Write a program to check if in a given expression the brackets are put correctly.</li>
</ul>

<p><em>Example of correct expression:</em> <code>((a+b)/5-d)</code>.
<em>Example of incorrect expression:</em> <code>)(a+b))</code>.</p>

<h3>
<a id="user-content-problem-4-sub-string-in-text" class="anchor" href="#problem-4-sub-string-in-text" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 4. Sub-string in text</h3>

<ul class="task-list">
<li>  Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).</li>
</ul>

<p><em>Example:</em></p>

<p>The target sub-string is <code>in</code></p>

<p>The text is as follows:
We are liv<strong>in</strong>g <strong>in</strong> an yellow submar<strong>in</strong>e. We don't have anyth<strong>in</strong>g else. <strong>in</strong>side the submar<strong>in</strong>e is very tight. So we are dr<strong>in</strong>k<strong>in</strong>g all the day. We will move out of it <strong>in</strong> 5 days.</p>

<p>The result is: <code>9</code></p>

<h3>
<a id="user-content-problem-5-parse-tags" class="anchor" href="#problem-5-parse-tags" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 5. Parse tags</h3>

<ul class="task-list">
<li>  You are given a text. Write a program that changes the text in all regions surrounded by the tags <code>&lt;upcase&gt;</code> and <code>&lt;/upcase&gt;</code> to upper-case.</li>
<li>  The tags cannot be nested.</li>
</ul>

<p><em>Example:</em> We are living in a yellow submarine. We don't have anything else.</p>

<p><em>The expected result:</em> We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.</p>

<h3>
<a id="user-content-problem-6-string-length" class="anchor" href="#problem-6-string-length" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 6. String length</h3>

<ul class="task-list">
<li>  Write a program that reads from the console a string of maximum <code>20</code> characters. If the length of the string is less than <code>20</code>, the rest of the characters should be filled with <code>*</code>.</li>
<li>  Print the result string into the console.</li>
</ul>

<h3>
<a id="user-content-problem-7-encodedecode" class="anchor" href="#problem-7-encodedecode" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 7. Encode/decode</h3>

<ul class="task-list">
<li>  Write a program that encodes and decodes a string using given encryption key (cipher).</li>
<li>  The key consists of a sequence of characters. </li>
<li>  The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.</li>
</ul>

<h3>
<a id="user-content-problem-8-extract-sentences" class="anchor" href="#problem-8-extract-sentences" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 8. Extract sentences</h3>

<ul class="task-list">
<li>  Write a program that extracts from a given text all sentences containing given <strong>word</strong>.</li>
</ul>

<p><em>Example:</em></p>

<p><em>The word is:</em> <strong>in</strong></p>

<p><em>The text is:</em> We are living <strong>in</strong> a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it <strong>in</strong> 5 days.</p>

<p><em>The expected result is:</em> We are living in a yellow submarine. We will move out of it in 5 days.</p>

<p><em>Consider that the sentences are separated by <code>.</code> and the words – by <strong>non-letter symbols</strong>.</em></p>

<h3>
<a id="user-content-problem-9-forbidden-words" class="anchor" href="#problem-9-forbidden-words" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 9. Forbidden words</h3>

<ul class="task-list">
<li>  We are given a string containing a list of forbidden words and a text containing some of these words.</li>
<li>  Write a program that replaces the forbidden words with asterisks.</li>
</ul>

<p><em>Example text:</em> Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.</p>

<p><em>Forbidden words:</em> <code>PHP</code>, <code>CLR</code>, <code>Microsoft</code></p>

<p><em>The expected result:</em> <code>********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***</code>.</p>

<h3>
<a id="user-content-problem-10-unicode-characters" class="anchor" href="#problem-10-unicode-characters" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 10. Unicode characters</h3>

<ul class="task-list">
<li>  Write a program that converts a string to a sequence of C# Unicode character literals.</li>
<li>  Use format strings.</li>
</ul>

<p><em>Example:</em></p>

<table>
<thead>
<tr>
<th align="center">input</th>
<th align="center">output</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">Hi!</td>
<td align="center">\u0048\u0069\u0021</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-11-format-number" class="anchor" href="#problem-11-format-number" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 11. Format number</h3>

<ul class="task-list">
<li>  Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.</li>
<li>  Format the output aligned right in 15 symbols.</li>
</ul>

<h3>
<a id="user-content-problem-12-parse-url" class="anchor" href="#problem-12-parse-url" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 12. Parse URL</h3>

<ul class="task-list">
<li>  Write a program that parses an URL address given in the format: <code>[protocol]://[server]/[resource]</code> and extracts from it the <code>[protocol]</code>, <code>[server]</code> and <code>[resource]</code> elements.</li>
</ul>

<p><em>Example:</em> </p>

<table>
<thead>
<tr>
<th align="center">URL</th>
<th align="center">Information</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><code>http://telerikacademy.com/Courses/Courses/Details/212</code></td>
<td align="center">[protocol] = <code>http</code> <br> [server] = <code>telerikacademy.com</code> <br> [resource] = <code>/Courses/Courses/Details/212</code>
</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-13-reverse-sentence" class="anchor" href="#problem-13-reverse-sentence" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 13. Reverse sentence</h3>

<ul class="task-list">
<li>  Write a program that reverses the words in given sentence.</li>
</ul>

<p><em>Example:</em></p>

<table>
<thead>
<tr>
<th align="center">input</th>
<th align="center">output</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><code>C# is not C++, not PHP and not Delphi!</code></td>
<td align="center"><code>Delphi not and PHP, not C++ not is C#!</code></td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-14-word-dictionary" class="anchor" href="#problem-14-word-dictionary" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 14. Word dictionary</h3>

<ul class="task-list">
<li>  A dictionary is stored as a sequence of text lines containing words and their explanations.</li>
<li>  Write a program that enters a word and translates it by using the dictionary.</li>
</ul>

<p><em>Sample dictionary:</em></p>

<table>
<thead>
<tr>
<th align="center">input</th>
<th align="center">output</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">.NET</td>
<td align="center">platform for applications from Microsoft</td>
</tr>
<tr>
<td align="center">CLR</td>
<td align="center">managed execution environment for .NET</td>
</tr>
<tr>
<td align="center">namespace</td>
<td align="center">hierarchical organization of classes</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-15-replace-tags" class="anchor" href="#problem-15-replace-tags" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 15. Replace tags</h3>

<ul class="task-list">
<li>  Write a program that replaces in a HTML document given as string all the tags <code>&lt;a href="…"&gt;…&lt;/a&gt;</code> with corresponding tags <code>[URL=…]…/URL]</code>.</li>
</ul>

<p><em>Example:</em></p>

<table>
<thead>
<tr>
<th align="center">input</th>
<th align="center">output</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><code>&lt;p&gt;Please visit &lt;a href="http://academy.telerik. com"&gt;our site&lt;/a&gt; to choose a training course. Also visit &lt;a href="www.devbg.org"&gt;our forum&lt;/a&gt; to discuss the courses.&lt;/p&gt;</code></td>
<td align="center"><code>&lt;p&gt;Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.&lt;/p&gt;</code></td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-16-date-difference" class="anchor" href="#problem-16-date-difference" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 16. Date difference</h3>

<ul class="task-list">
<li>  Write a program that reads two dates in the format: <code>day.month.year</code> and calculates the number of days between them.</li>
</ul>

<p><em>Example:</em></p>

<pre><code>Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
</code></pre>

<h3>
<a id="user-content-problem-17-date-in-bulgarian" class="anchor" href="#problem-17-date-in-bulgarian" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 17. Date in Bulgarian</h3>

<ul class="task-list">
<li>  Write a program that reads a date and time given in the format: <code>day.month.year hour:minute:second</code> and prints the date and time after <code>6</code> hours and <code>30</code> minutes (in the same format) along with the day of week in Bulgarian.</li>
</ul>

<h3>
<a id="user-content-problem-18-extract-e-mails" class="anchor" href="#problem-18-extract-e-mails" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 18. Extract e-mails</h3>

<ul class="task-list">
<li>  Write a program for extracting all email addresses from given text.</li>
<li>  All sub-strings that match the format @… should be recognized as emails.</li>
</ul>

<h3>
<a id="user-content-problem-19-dates-from-text-in-canada" class="anchor" href="#problem-19-dates-from-text-in-canada" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 19. Dates from text in Canada</h3>

<ul class="task-list">
<li>  Write a program that extracts from a given text all dates that match the format <code>DD.MM.YYYY</code>.</li>
<li>  Display them in the standard date format for Canada.</li>
</ul>

<h3>
<a id="user-content-problem-20-palindromes" class="anchor" href="#problem-20-palindromes" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 20. Palindromes</h3>

<ul class="task-list">
<li>  Write a program that extracts from a given text all palindromes, e.g. <code>ABBA</code>, <code>lamal</code>, <code>exe</code>.</li>
</ul>

<h3>
<a id="user-content-problem-21-letters-count" class="anchor" href="#problem-21-letters-count" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 21. Letters count</h3>

<ul class="task-list">
<li>  Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. </li>
</ul>

<h3>
<a id="user-content-problem-22-words-count" class="anchor" href="#problem-22-words-count" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 22. Words count</h3>

<ul class="task-list">
<li>  Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.</li>
</ul>

<h3>
<a id="user-content-problem-23-series-of-letters" class="anchor" href="#problem-23-series-of-letters" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 23. Series of letters</h3>

<ul class="task-list">
<li>  Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.</li>
</ul>

<p><em>Example:</em></p>

<table>
<thead>
<tr>
<th align="center">input</th>
<th align="center">output</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">aaaaabbbbbcdddeeeedssaa</td>
<td align="center">abcdedsa</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-24-order-words" class="anchor" href="#problem-24-order-words" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 24. Order words</h3>

<ul class="task-list">
<li>  Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.</li>
</ul>

<h3>
<a id="user-content-problem-25-extract-text-from-html" class="anchor" href="#problem-25-extract-text-from-html" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 25. Extract text from HTML</h3>

<ul class="task-list">
<li>  Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.</li>
</ul>

<p><em>Example input:</em></p>

<pre><code>&lt;html&gt;
  &lt;head&gt;&lt;title&gt;News&lt;/title&gt;&lt;/head&gt;
  &lt;body&gt;&lt;p&gt;&lt;a href="http://academy.telerik.com"&gt;Telerik
    Academy&lt;/a&gt;aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.&lt;/p&gt;&lt;/body&gt;
&lt;/html&gt;
</code></pre>

<p><em>Output:</em> </p>

<p>Title: News</p>

<p>Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p>
</article>
  </div>

  </div>
</div>

<a href="#jump-to-line" rel="facebox[.linejump]" data-hotkey="l" style="display:none">Jump to Line</a>
<div id="jump-to-line" style="display:none">
  <form accept-charset="UTF-8" class="js-jump-to-line-form">
    <input class="linejump-input js-jump-to-line-field" type="text" placeholder="Jump to line&hellip;" autofocus>
    <button type="submit" class="button">Go</button>
  </form>
</div>

        </div>

      </div><!-- /.repo-container -->
      <div class="modal-backdrop"></div>
    </div><!-- /.container -->
  </div><!-- /.site -->


    </div><!-- /.wrapper -->

      <div class="container">
  <div class="site-footer" role="contentinfo">
    <ul class="site-footer-links right">
      <li><a href="https://status.github.com/">Status</a></li>
      <li><a href="https://developer.github.com">API</a></li>
      <li><a href="http://training.github.com">Training</a></li>
      <li><a href="http://shop.github.com">Shop</a></li>
      <li><a href="/blog">Blog</a></li>
      <li><a href="/about">About</a></li>

    </ul>

    <a href="/" aria-label="Homepage">
      <span class="mega-octicon octicon-mark-github" title="GitHub"></span>
    </a>

    <ul class="site-footer-links">
      <li>&copy; 2015 <span title="0.16932s from github-fe141-cp1-prd.iad.github.net">GitHub</span>, Inc.</li>
        <li><a href="/site/terms">Terms</a></li>
        <li><a href="/site/privacy">Privacy</a></li>
        <li><a href="/security">Security</a></li>
        <li><a href="/contact">Contact</a></li>
    </ul>
  </div><!-- /.site-footer -->
</div><!-- /.container -->


    <div class="fullscreen-overlay js-fullscreen-overlay" id="fullscreen_overlay">
  <div class="fullscreen-container js-suggester-container">
    <div class="textarea-wrap">
      <textarea name="fullscreen-contents" id="fullscreen-contents" class="fullscreen-contents js-fullscreen-contents" placeholder=""></textarea>
      <div class="suggester-container">
        <div class="suggester fullscreen-suggester js-suggester js-navigation-container"></div>
      </div>
    </div>
  </div>
  <div class="fullscreen-sidebar">
    <a href="#" class="exit-fullscreen js-exit-fullscreen tooltipped tooltipped-w" aria-label="Exit Zen Mode">
      <span class="mega-octicon octicon-screen-normal"></span>
    </a>
    <a href="#" class="theme-switcher js-theme-switcher tooltipped tooltipped-w"
      aria-label="Switch themes">
      <span class="octicon octicon-color-mode"></span>
    </a>
  </div>
</div>



    <div id="ajax-error-message" class="flash flash-error">
      <span class="octicon octicon-alert"></span>
      <a href="#" class="octicon octicon-x flash-close js-ajax-error-dismiss" aria-label="Dismiss error"></a>
      Something went wrong with that request. Please try again.
    </div>


      <script crossorigin="anonymous" src="https://assets-cdn.github.com/assets/frameworks-af95b05cb14b7a29b0457c26b4a1d24151f4a47842c8e74bd556622f347b9d3d.js" type="text/javascript"></script>
      <script async="async" crossorigin="anonymous" src="https://assets-cdn.github.com/assets/github-48e1b4f1ba19a995fb5b6503c23c059ae885b47f760a1ee39ea676b991de5046.js" type="text/javascript"></script>
      
      
  </body>
</html>

