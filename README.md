usemono-net
===========

![](https://travis-ci.org/maclennann/usemono-net.svg?branch=master)

Source to [usemono.net](http://usemono.net), a Mono advocacy site aimed at .NET developers.

Pull requests welcome for copy or resources. Project should work out of the box on Windows, OS X, or Linux (provided you have .NET or Mono installed, of course).

Installing Mono
===============

Ubuntu:

Use [this ppa](https://launchpad.net/~directhex/+archive/ubuntu/monoxide). Install mono-complete.

Alternatively, use [this ppa](https://launchpad.net/~ermshiperete/+archive/ubuntu/monodevelop) and install monodevelop 5. It will all be installed to `/opt` to remain self-contained, but everything should work fine.

CentOS/Fedora:

Use [this OBS repo](http://software.opensuse.org/download/package?project=home:tpokorra:mono&package=monodevelop-opt) and install monodevelop-opt. Like above, it will be contained to `/opt` but should all work correctly.

You can also use the Vagrant box found [here](https://github.com/maclennann/csharp-crossplat-service-demo) which will install Mono via puppet on startup. I'm in the process of making that better and will open source the module.
