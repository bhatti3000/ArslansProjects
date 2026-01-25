DevSecOps CI/CD Pipeline Project

Overview This project demonstrates a complete DevSecOps CI/CD pipeline
using Jenkins, SonarQube, Docker, and Trivy on an AWS Ubuntu EC2
instance. The goal is to automate build, security scanning, code quality
analysis, and deployment of a web application container.

Tools and Technologies 
- AWS EC2 (Ubuntu) 
- Jenkins (CI/CD automation) 
- SonarQube (Static code analysis and Quality Gates) 
- Docker (Containerization and deployment) 
- Trivy (Security vulnerability scanning) 
- Nginx (Web server inside container) 
- GitHub (Source code repository)

Pipeline Workflow 
1. Code is pushed to GitHub 
2. Jenkins pulls code from GitHub 
3. SonarQube performs code quality analysis 
4. Jenkins waits for SonarQube Quality Gate 
5. Trivy scans filesystem for vulnerabilities 
6. Docker image is built 
7. Docker image is pushed to Docker Hub 
8. Trivy scans Docker image 
9. Application container is deployed on EC2

Jenkins Pipeline Stages 
- Clean Workspace 
- Checkout from Git 
- SonarQube Analysis 
- Quality Gate 
- Trivy Filesystem Scan 
- Docker Build and Push 
- Trivy Image Scan 
- Deploy to Container

SonarQube Setup Run SonarQube using Docker: docker run -d –name
sonarqube -p 9000:9000 -e SONAR_ES_BOOTSTRAP_CHECKS_DISABLE=true
sonarqube:lts-community

Access SonarQube at: http://:9000

Jenkins Setup 
- Install Jenkins on Ubuntu 
- Configure Java in Jenkins tools 
- Install SonarQube Scanner plugin 
- Configure SonarQube server in Jenkins 
- Add SonarQube token in Jenkins credentials

Trivy Setup 
- Install Trivy on EC2 
- Use Trivy for filesystem and Docker image scans

AWS Configuration 
- Open ports in EC2 Security Group: 22 (SSH) 8080
(Jenkins) 9000 (SonarQube) 8081 (Application) 
- Assign Elastisc IP 
- Ensure sufficient disk space
