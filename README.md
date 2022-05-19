# Star Wars Site README

This repository contains the following:

- A Star Wars site built with C#, Blazor (webassembly), and Umbraco Heartcore as a data source.
- A GitHub Action to publish a docker image for the star wars site.
- A Nomad Pack (similar to helm charts) to easily deploy the latest version of the star wars site to my HomeLab. (Check packs/star-wars-site/README.md for more info.)

I built the site and the setup with the following tools:

- VSCode (Yes I am a little crazy because I am not using a "real" IDE, and instead I am customizing VSCode to my needs. Maybe someday I will need to use a real IDE again 👀)
- .NET with HotReload. (ain't nobody got time for that)
- Docker.
- My High-Availability HomeLab (three RaspberryPis 4B with custom-built Raspbian distros) running HashiCorp Nomad, and HashiCorp Consul with integration to CloudFlare for Authentication purposes and DNS.


## Requirements

- .NET-6.0
- Volume turned on if running the local version. The site has some epic sounds! 🤩

## Reach the site here!

- <https://star-wars-site.devantler.com> - Hosted on my HomeLab with HashiCorp Nomad and my custom GitOps workflow
- Locally by running `dotnet run` in `src/StarWarsSite`
