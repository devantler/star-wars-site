job "star-wars-site" {
  datacenters = ["dc1"]
  group "star-wars-site" {
    network {
      port  "http" {
        to = 80
      }
    }
    service {
      name = "star-wars-site"
      port = "http" 
      tags = [
        "traefik.enable=true",
        "traefik.http.routers.star-wars-site.entrypoints=websecure",
        "traefik.http.routers.star-wars-site.tls.certresolver=letsencrypt",
      ]
      check {
        type     = "tcp"
        interval = "10s"
        timeout  = "2s"
      }
    }
    task "star-wars-site" {
      driver = "docker"
      config {
        image = "ghcr.io/devantler/star-wars-site:main"
        ports = ["http"]
      }
    }
  }
}
