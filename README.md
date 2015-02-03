



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

    <meta content="collector.githubapp.com" name="octolytics-host" /><meta content="collector-cdn.github.com" name="octolytics-script-host" /><meta content="github" name="octolytics-app-id" /><meta content="C6245751:2BF1:79107C2:54D0E0F9" name="octolytics-dimension-request_id" /><meta content="10468274" name="octolytics-actor-id" /><meta content="atanas-georgiev" name="octolytics-actor-login" /><meta content="90ab182c6c899c84016f22fb12b710da63858a8dc2fed8685e231099c273373c" name="octolytics-actor-hash" />
    
    <meta content="Rails, view, blob#show" name="analytics-event" />

    
    
    <link rel="icon" type="image/x-icon" href="https://assets-cdn.github.com/favicon.ico">


    <meta content="authenticity_token" name="csrf-param" />
<meta content="GGC0yZvQIHCHVSLoC54hmQxfYoXDZIFiHQM0SHOPq1cb+8HQW6MM1ZTTCSBeD/d1blXORkrilKLykayjLb/sMA==" name="csrf-token" />

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
    <form accept-charset="UTF-8" action="/logout" class="logout-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="eZhJuis5dJItu0LWC69L8nruJjETUUIregfDgsi+m9MJLnutvJFU8uJSJiiGIBaU9KVhkatKrJ3LUI/ys6G9ag==" /></div>
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
      <form accept-charset="UTF-8" action="/notifications/subscribe" class="js-social-container" data-autosubmit="true" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="g/iApZ3PVMxmSx4JdTjUxnpi3zyMy10HICNexD/Ftk73jkpc5dFuvicA//r9eKVbyM/2REhn+kvd/Cxbb/sWfQ==" /></div>  <input id="repository_id" name="repository_id" type="hidden" value="28328944" />

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

    <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-2/unstar" class="js-toggler-form starred js-unstar-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="GMNV/+IzzPR2Kz+evyrmo2JCsOl5jx6k93jNH09ay8lIL0l9kM00rheHtciD/4aHH+pFlwJ8jJAMwckJQko4RA==" /></div>
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
    <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-2/star" class="js-toggler-form unstarred js-star-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="Npok+Wjo7tnExm6jwhK63QJD7ZBMoeG5DKyo/eXTYifFBNtKl460seY+rEdr+MQhPgQ23n77UPCPRb9roCJHsg==" /></div>
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
          

<a href="/TelerikAcademy/CSharp-Part-2/blob/3453c2ceb1bc0444cc300307b261fc1bbce2e961/01.%20Arrays/README.md" class="hidden js-permalink-shortcut" data-hotkey="y">Permalink</a>

<!-- blob contrib key: blob_contributors:v21:46e830be48ca4e2c20626ef976914dad -->

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
              <a href="/TelerikAcademy/CSharp-Part-2/blob/master/01.%20Arrays/README.md"
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
    <span class='repo-root js-repo-root'><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/TelerikAcademy/CSharp-Part-2" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">CSharp-Part-2</span></a></span></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/TelerikAcademy/CSharp-Part-2/tree/master/01.%20Arrays" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">01. Arrays</span></a></span><span class="separator">/</span><strong class="final-path">README.md</strong>
  </div>
</div>


  <div class="commit file-history-tease">
    <div class="file-history-tease-header">
        <img alt="evlogihr" class="avatar" data-user="3619393" height="24" src="https://avatars1.githubusercontent.com/u/3619393?v=3&amp;s=48" width="24" />
        <span class="author"><a href="/evlogihr" rel="contributor">evlogihr</a></span>
        <time datetime="2015-01-24T08:57:47Z" is="relative-time">Jan 24, 2015</time>
        <div class="commit-title">
            <a href="/TelerikAcademy/CSharp-Part-2/commit/ca3a6448ef85f7589bbd65e1ed77b044e9ca90ee" class="message" data-pjax="true" title="Update to homework for 01.Arrays">Update to homework for 01.Arrays</a>
        </div>
    </div>

    <div class="participation">
      <p class="quickstat">
        <a href="#blob_contributors_box" rel="facebox">
          <strong>1</strong>
           contributor
        </a>
      </p>
      
    </div>
    <div id="blob_contributors_box" style="display:none">
      <h2 class="facebox-header">Users who have contributed to this file</h2>
      <ul class="facebox-user-list">
          <li class="facebox-user-list-item">
            <img alt="evlogihr" data-user="3619393" height="24" src="https://avatars1.githubusercontent.com/u/3619393?v=3&amp;s=48" width="24" />
            <a href="/evlogihr">evlogihr</a>
          </li>
      </ul>
    </div>
  </div>

<div class="file-box">
  <div class="file">
    <div class="meta clearfix">
      <div class="info file-name">
          <span>134 lines (92 sloc)</span>
          <span class="meta-divider"></span>
        <span>5.947 kb</span>
      </div>
      <div class="actions">
        <div class="button-group">
          <a href="/TelerikAcademy/CSharp-Part-2/raw/master/01.%20Arrays/README.md" class="minibutton " id="raw-url">Raw</a>
            <a href="/TelerikAcademy/CSharp-Part-2/blame/master/01.%20Arrays/README.md" class="minibutton js-update-url-with-hash">Blame</a>
          <a href="/TelerikAcademy/CSharp-Part-2/commits/master/01.%20Arrays/README.md" class="minibutton " rel="nofollow">History</a>
        </div><!-- /.button-group -->

          <a class="octicon-button tooltipped tooltipped-nw"
             href="github-windows://openRepo/https://github.com/TelerikAcademy/CSharp-Part-2?branch=master&amp;filepath=01.%20Arrays%2FREADME.md" aria-label="Open this file in GitHub for Windows">
              <span class="octicon octicon-device-desktop"></span>
          </a>

              <a class="octicon-button tooltipped tooltipped-n js-update-url-with-hash"
                 aria-label="Clicking this button will fork this project so you can edit the file"
                 href="/TelerikAcademy/CSharp-Part-2/edit/master/01.%20Arrays/README.md"
                 data-method="post" rel="nofollow"><span class="octicon octicon-pencil"></span></a>

            <a class="octicon-button danger tooltipped tooltipped-s"
               href="/TelerikAcademy/CSharp-Part-2/delete/master/01.%20Arrays/README.md"
               aria-label="Fork this project and delete file"
               data-method="post" data-test-id="delete-blob-file" rel="nofollow">
          <span class="octicon octicon-trashcan"></span>
        </a>
      </div><!-- /.actions -->
    </div>
    
  <div id="readme" class="blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="mainContentOfPage"><h1>
<a id="user-content-homework-arrays" class="anchor" href="#homework-arrays" aria-hidden="true"><span class="octicon octicon-link"></span></a>Homework: Arrays</h1>

<h3>
<a id="user-content-problem-1-allocate-array" class="anchor" href="#problem-1-allocate-array" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 1. Allocate array</h3>

<ul class="task-list">
<li>  Write a program that allocates array of <code>20</code> integers and initializes each element by its index multiplied by <code>5</code>.</li>
<li>  Print the obtained array on the console.</li>
</ul>

<h3>
<a id="user-content-problem-2-compare-arrays" class="anchor" href="#problem-2-compare-arrays" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 2. Compare arrays</h3>

<ul class="task-list">
<li>  Write a program that reads two <code>integer</code> arrays from the console and compares them element by element.</li>
</ul>

<h3>
<a id="user-content-problem-3-compare-char-arrays" class="anchor" href="#problem-3-compare-char-arrays" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 3. Compare char arrays</h3>

<ul class="task-list">
<li>  Write a program that compares two <code>char</code> arrays lexicographically (letter by letter).</li>
</ul>

<h3>
<a id="user-content-problem-4-maximal-sequence" class="anchor" href="#problem-4-maximal-sequence" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 4. Maximal sequence</h3>

<ul class="task-list">
<li>  Write a program that finds the <strong>maximal sequence</strong> of equal elements in an array.</li>
</ul>

<p><em>Example:</em></p>

<table>
<thead>
<tr>
<th>input</th>
<th>result</th>
</tr>
</thead>
<tbody>
<tr>
<td>2, 1, 1, 2, 3, 3, <strong>2, 2, 2</strong>, 1</td>
<td>2, 2, 2</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-5-maximal-increasing-sequence" class="anchor" href="#problem-5-maximal-increasing-sequence" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 5. Maximal increasing sequence</h3>

<ul class="task-list">
<li>  Write a program that finds the maximal increasing sequence in an array.</li>
</ul>

<p><em>Example:</em></p>

<table>
<thead>
<tr>
<th>input</th>
<th>result</th>
</tr>
</thead>
<tbody>
<tr>
<td>3, <strong>2, 3, 4</strong>, 2, 2, 4</td>
<td>2, 3, 4</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-6-maximal-k-sum" class="anchor" href="#problem-6-maximal-k-sum" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 6. Maximal K sum</h3>

<ul class="task-list">
<li>  Write a program that reads two integer numbers <code>N</code> and <code>K</code> and an array of <code>N</code> elements from the console.</li>
<li>  Find in the array those <code>K</code> elements that have maximal sum.</li>
</ul>

<h3>
<a id="user-content-problem-7-selection-sort" class="anchor" href="#problem-7-selection-sort" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 7. Selection sort</h3>

<ul class="task-list">
<li>  <strong>Sorting</strong> an array means to arrange its elements in increasing order. Write a program to sort an array.</li>
<li>  Use the <a href="http://en.wikipedia.org/wiki/Selection_sort">Selection sort</a> algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.</li>
</ul>

<h3>
<a id="user-content-problem-8-maximal-sum" class="anchor" href="#problem-8-maximal-sum" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 8. Maximal sum</h3>

<ul class="task-list">
<li>  Write a program that finds the sequence of maximal sum in given array.</li>
</ul>

<p><em>Example:</em></p>

<table>
<thead>
<tr>
<th>input</th>
<th>result</th>
</tr>
</thead>
<tbody>
<tr>
<td>2, 3, -6, -1, <strong>2, -1, 6, 4</strong>, -8, 8</td>
<td>2, -1, 6, 4</td>
</tr>
</tbody>
</table>

<ul class="task-list">
<li>  <em>Can you do it with only one loop (with single scan through the elements of the array)?</em>
</li>
</ul>

<h3>
<a id="user-content-problem-9-frequent-number" class="anchor" href="#problem-9-frequent-number" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 9. Frequent number</h3>

<ul class="task-list">
<li>  Write a program that finds the most frequent number in an array.</li>
</ul>

<p><em>Example:</em></p>

<table>
<thead>
<tr>
<th>input</th>
<th>result</th>
</tr>
</thead>
<tbody>
<tr>
<td>
<strong>4</strong>, 1, 1, <strong>4</strong>, 2, 3, <strong>4</strong>, <strong>4</strong>, 1, 2, <strong>4</strong>, 9, 3</td>
<td>4 (5 times)</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-10-find-sum-in-array" class="anchor" href="#problem-10-find-sum-in-array" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 10. Find sum in array</h3>

<ul class="task-list">
<li>  Write a program that finds in given array of integers a sequence of given sum <code>S</code> (if present).</li>
</ul>

<p><em>Example:</em></p>

<table>
<thead>
<tr>
<th>array</th>
<th>S</th>
<th>result</th>
</tr>
</thead>
<tbody>
<tr>
<td>4, 3, 1, <strong>4, 2, 5</strong>, 8</td>
<td>11</td>
<td>4, 2, 5</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-11-binary-search" class="anchor" href="#problem-11-binary-search" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 11. Binary search</h3>

<ul class="task-list">
<li>  Write a program that finds the index of given element in a sorted array of integers by using the <a href="http://en.wikipedia.org/wiki/Binary_search_algorithm">Binary search</a> algorithm.</li>
</ul>

<h3>
<a id="user-content-problem-12-index-of-letters" class="anchor" href="#problem-12-index-of-letters" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 12. Index of letters</h3>

<ul class="task-list">
<li>  Write a program that creates an array containing all letters from the alphabet (<code>A-Z</code>).</li>
<li>  Read a word from the console and print the index of each of its letters in the array.</li>
</ul>

<h3>
<a id="user-content-problem-13--merge-sort" class="anchor" href="#problem-13--merge-sort" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 13.*  Merge sort</h3>

<ul class="task-list">
<li>  Write a program that sorts an array of integers using the <a href="http://en.wikipedia.org/wiki/Merge_sort">Merge sort</a> algorithm (find it in Wikipedia).</li>
</ul>

<h3>
<a id="user-content-problem-14-quick-sort" class="anchor" href="#problem-14-quick-sort" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 14. Quick sort</h3>

<ul class="task-list">
<li>  Write a program that sorts an array of strings using the <a href="http://en.wikipedia.org/wiki/Quicksort">Quick sort</a> algorithm (find it in Wikipedia).</li>
</ul>

<h3>
<a id="user-content-problem-15-prime-numbers" class="anchor" href="#problem-15-prime-numbers" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 15. Prime numbers</h3>

<ul class="task-list">
<li>  Write a program that finds all prime numbers in the range [<code>1...10 000 000</code>]. Use the <a href="http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes">Sieve of Eratosthenes</a> algorithm.</li>
</ul>

<h3>
<a id="user-content-problem-16-subset-with-sum-s" class="anchor" href="#problem-16-subset-with-sum-s" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 16.* Subset with sum S</h3>

<ul class="task-list">
<li>  We are given an array of integers and a number <code>S</code>.</li>
<li>  Write a program to find if there exists a subset of the elements of the array that has a sum <code>S</code>.</li>
</ul>

<p><em>Example:</em></p>

<table>
<thead>
<tr>
<th align="center">input array</th>
<th align="center">S</th>
<th align="center">result</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">2, <strong>1</strong>, <strong>2</strong>, 4, 3, <strong>5</strong>, 2, <strong>6</strong>
</td>
<td align="center">14</td>
<td align="center">yes</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-17-subset-k-with-sum-s" class="anchor" href="#problem-17-subset-k-with-sum-s" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 17.* Subset K with sum S</h3>

<ul class="task-list">
<li>  Write a program that reads three integer numbers <code>N</code>, <code>K</code> and <code>S</code> and an array of <code>N</code> elements from the console.</li>
<li>  Find in the array a subset of <code>K</code> elements that have sum <code>S</code> or indicate about its absence.</li>
</ul>

<h3>
<a id="user-content-problem-18-remove-elements-from-array" class="anchor" href="#problem-18-remove-elements-from-array" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 18.* Remove elements from array</h3>

<ul class="task-list">
<li>  Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.</li>
<li>  Print the remaining sorted array.</li>
</ul>

<p><em>Example:</em></p>

<table>
<thead>
<tr>
<th align="center">input</th>
<th align="center">result</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">6, <strong>1</strong>, 4, <strong>3</strong>, 0, <strong>3</strong>, 6, <strong>4</strong>, <strong>5</strong>
</td>
<td align="center">1, 3, 3, 4, 5</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-19-permutations-of-set" class="anchor" href="#problem-19-permutations-of-set" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 19.* Permutations of set</h3>

<ul class="task-list">
<li>  Write a program that reads a number <code>N</code> and generates and prints all the permutations of the numbers [<code>1 … N</code>].</li>
</ul>

<p><em>Example:</em></p>

<table>
<thead>
<tr>
<th align="center">N</th>
<th align="center">result</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">3</td>
<td align="center">
<code>{1, 2, 3}</code> <br> <code>{1, 3, 2}</code> <br> <code>{2, 1, 3}</code> <br> <code>{2, 3, 1}</code> <br> <code>{3, 1, 2}</code> <br> <code>{3, 2, 1}</code>
</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-20-variations-of-set" class="anchor" href="#problem-20-variations-of-set" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 20. Variations of set</h3>

<ul class="task-list">
<li>  Write a program that reads two numbers <code>N</code> and <code>K</code> and generates all the variations of <code>K</code> elements from the set [<code>1..N</code>].</li>
</ul>

<p><em>Example:</em></p>

<table>
<thead>
<tr>
<th align="center">N</th>
<th align="center">K</th>
<th align="center">result</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">3</td>
<td align="center">2</td>
<td align="center">
<code>{1, 1}</code> <br> <code>{1, 2}</code> <br> <code>{1, 3}</code> <br> <code>{2, 1}</code> <br> <code>{2, 2}</code> <br> <code>{2, 3}</code> <br> <code>{3, 1}</code> <br> <code>{3, 2}</code> <br> <code>{3, 3}</code>
</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-21-combinations-of-set" class="anchor" href="#problem-21-combinations-of-set" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 21. Combinations of set</h3>

<ul class="task-list">
<li>  Write a program that reads two numbers <code>N</code> and <code>K</code> and generates all the combinations of <code>K</code> distinct elements from the set [<code>1..N</code>].</li>
</ul>

<p><em>Example:</em></p>

<table>
<thead>
<tr>
<th align="center">N</th>
<th align="center">K</th>
<th align="center">result</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">5</td>
<td align="center">2</td>
<td align="center">
<code>{1, 2}</code> <br> <code>{1, 3}</code> <br> <code>{1, 4}</code> <br> <code>{1, 5}</code> <br> <code>{2, 3}</code> <br> <code>{2, 4}</code> <br> <code>{2, 5}</code> <br> <code>{3, 4}</code> <br> <code>{3, 5}</code> <br> <code>{4, 5}</code>
</td>
</tr>
</tbody>
</table>
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
      <li>&copy; 2015 <span title="0.05681s from github-fe140-cp1-prd.iad.github.net">GitHub</span>, Inc.</li>
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

