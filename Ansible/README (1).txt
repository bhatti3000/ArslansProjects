Ansible AWS

This project uses an Ansible control machine on AWS to manage two EC2 instances: LinuxMachine-1 and WebServer02.

Setup:
- Control machine has Ansible installed.
- SSH keys for both servers are stored on the control machine.
- Inventory file defines both hosts with their public IPs and key paths.

Commands:
ansible all -m ping -i inventory/hosts.yml
ansible-playbook playbooks/setup_servers.yml -i inventory/hosts.yml

Structure:
inventory/hosts.yml
playbooks/setup_servers.yml
files/index.html

Purpose:
- Practice Ansible connectivity
- Set hostnames
- Prepare for web server setup

