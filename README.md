# Star Wars Site README

This repository contains the following:

- A Star Wars site built with C#, Blazor (webassembly), and Umbraco Heartcore as a data source.
- A GitHub Action to publish a docker image for the star wars site.
- A Nomad Pack (similar to helm charts) to easily deploy the latest version of the star wars site to my HomeLab. (Check packs/star-wars-site/README.md for more info.)

I built the site and the setup with the following tools:

- VSCode and Extensions
- .NET with HotReload. (ain't nobody got time for that)
- Docker
- A Feature Pattern utilizing MediatR in my data pipeline. (Check src/StarWarsSite/Features/README.md for more info.)
- My High-Availability HomeLab (three RaspberryPis 4B with custom-built Raspbian distros) running HashiCorp Nomad, and HashiCorp Consul with integration to CloudFlare for Authentication purposes and DNS.


## Requirements

- .NET-6.0
- Sound turned on. The site has some epic sounds! 🤩

## Reach the site here!

- <https://star-wars-site.devantler.com> - Hosted on my HomeLab with HashiCorp Nomad and Nomad Packs.
- Locally by running `dotnet run` in `src/StarWarsSite`
