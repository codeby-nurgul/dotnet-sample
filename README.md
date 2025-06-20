# dotnet-sample

This is a sample .NET Web API project containerized with Docker and equipped with a GitHub Actions CI/CD pipeline. It demonstrates environment-specific deployment workflows using `test` and `main` branches.

---

## 🚀 Project Overview

- Built with **ASP.NET Core Web API**
- Containerized using **Docker**
- CI/CD implemented via **GitHub Actions**
- Quality and security checks powered by **SonarCloud** and **Trivy**
- Images are automatically pushed to **Docker Hub** with `test` and `main` tags

---

## 🛠️ Technologies Used

- [.NET 8](https://dotnet.microsoft.com/)
- Docker & Docker Compose
- GitHub Actions
- [SonarCloud](https://sonarcloud.io)
- [Trivy](https://aquasecurity.github.io/trivy/)

---

## 📁 Branch-based Deployment

| Branch | Action Trigger     | Docker Tag | Description                    |
|--------|--------------------|------------|--------------------------------|
| `test` | Push               | `:test`    | For testing and staging builds |
| `main` | Merge from `test`  | `:main`    | For production-ready builds    |

Each branch has its own GitHub Actions workflow that builds, scans, and pushes the Docker image to Docker Hub.

---

## 📦 Docker Hub

View published images on Docker Hub:  
👉 [https://hub.docker.com/r/codebynurgul/dotnet-sample](https://hub.docker.com/r/codebynurgul/dotnet-sample)

---

## 🧪 Quality & Security Automation

This project includes automatic checks as part of the CI pipeline:

### 🔍 SonarCloud Analysis

- Performs **static code analysis** on every push to `main`
- Checks for:
  - Bugs
  - Code smells
  - Maintainability issues
  - Security hotspots
- Results visible publicly on SonarCloud  
  🔗 [SonarCloud Dashboard](https://sonarcloud.io/project/overview?id=codeby-nurgul_dotnet-sample)

### 🔒 Trivy Security Scan

- Scans the **project file system** during each CI build
- Detects:
  - Known vulnerabilities (CVEs)
  - Dependency flaws in NuGet packages
- Ensures secure and compliant builds

---

## 🐳 Running Locally

Clone the repository and use Docker Compose depending on the environment you want to simulate.

### ▶️ For test image
```bash
docker-compose -f docker-compose.test.yml up -d
