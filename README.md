# dotnet-sample

This is a sample .NET Web API project containerized with Docker and equipped with a GitHub Actions CI/CD pipeline. It demonstrates environment-specific deployment workflows using `test` and `main` branches.

---

## 🚀 Project Overview

- Built with **ASP.NET Core Web API**
- Containerized using **Docker**
- CI/CD implemented via **GitHub Actions**
- Images published to **Docker Hub** with environment-based tags

---

## 🛠️ Technologies Used

- [.NET 8](https://dotnet.microsoft.com/)
- Docker
- GitHub Actions

---

## 📁 Branch-based Deployment

| Branch | Action Trigger | Docker Tag | Description                    |
|--------|----------------|------------|--------------------------------|
| `test` | Push           | `:test`    | For testing and staging builds |
| `main` | Merge from test| `:main`    | For production-ready builds    |

Each branch has its own GitHub Actions workflow that builds and pushes the Docker image to Docker Hub.

---

## 📦 DockerHub

You can find the published images here:  
👉 [https://hub.docker.com/r/codebynurgul/dotnet-sample](https://hub.docker.com/r/codebynurgul/dotnet-sample)

---

## 🐳 Running Locally

Use the appropriate `docker-compose` file depending on the tag you want to run:

### ▶️ For test image
```bash
docker-compose -f docker-compose.test.yml up
