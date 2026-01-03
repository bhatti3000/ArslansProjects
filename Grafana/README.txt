AWS Monitoring Stack – Prometheus & Grafana

This project demonstrates the setup, configuration, and troubleshooting of a
monitoring stack on AWS using Prometheus and Grafana. The work was performed on
an EC2 instance and focuses on hands-on DevOps practices including service
management, networking, and configuration validation.

Technologies used:
- AWS EC2
- Ubuntu Linux
- Prometheus
- Grafana
- systemd
- YAML
- Linux networking

Responsibilities and work performed:
- Created and managed an EC2 instance on AWS
- Configured inbound security group rules for required ports
- Installed Prometheus manually using the official binary distribution
- Created a dedicated Linux user for Prometheus
- Configured Prometheus as a systemd service
- Validated Prometheus configuration using promtool
- Diagnosed and fixed YAML syntax errors preventing service startup
- Verified Prometheus availability on port 9090
- Installed and configured Grafana
- Secured Grafana by changing default admin credentials
- Integrated Prometheus as a Grafana datasource using private IPv4
- Analyzed networking behavior between public IP, private IP, and localhost
- Applied best practices by keeping Prometheus non-public
- Performed AWS cleanup tasks (instance termination, S3 bucket deletion) to
  prevent unnecessary costs

Key learning outcomes:
- Understanding of AWS networking (public vs private IP usage)
- Practical experience with Linux service management
- Importance of configuration validation before service restart
- Secure exposure of monitoring components
- End-to-end setup of a monitoring pipeline in a cloud environment

Reference:
This project was built while following a hands-on tutorial:
https://www.youtube.com/watch?v=DuYnPOq4D6w

Purpose:
This repository serves as a practical DevOps learning project and a portfolio
example demonstrating cloud infrastructure setup, monitoring, and
troubleshooting skills.
