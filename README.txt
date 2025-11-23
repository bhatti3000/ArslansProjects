1. AWS EC2 Setup

LinuxMachine-1 (Target Server)
- Default user: ec2-user
- SSH connection example:
  ssh -i LinuxMachine1 ec2-user@<public-dns>

WebServer02 (Target Server)
- Created as a second machine to be managed by the control server.
- Successfully connected using PuTTY and SSH key.

Control Machine (Ansible)
- A separate AWS EC2 instance used as the Ansible control node.
- Responsible for managing LinuxMachine-1 and WebServer02.

2. SSH Key Management

File Transfers Between Servers
Private keys were securely copied to the control machine:
scp -i ControlMachineKEY.pem PEM_LM_1.pem ec2-user@<control-server-ip>:/home/ec2-user/

Keys were moved to the Ansible working directory:
sudo mv PEM_LM_1.pem ~/Ansible/
sudo mv Webserver02KEY.pem ~/Ansible/

Inventory updated accordingly after private key changes.

3. Ansible Installation and Setup
Ansible was installed successfully on the control machine, and connectivity to both servers was tested using:
ansible all -m ping -i inventory.yml

Both machines responded successfully.

4. Inventory Configuration

Final Example (hosts.yml)
all:
  hosts:
    LinuxMachine-1:
      ansible_host: 100.xxx.xx.xxx
      ansible_user: ec2-user
      ansible_ssh_private_key_file: /home/ec2-user/Ansible/LinuxMachine1

    WebServer02:
      ansible_host: 35.xxx.xx.xxx
      ansible_user: ec2-user
      ansible_ssh_private_key_file: /home/ec2-user/Ansible/Webserver02KEY.pem

A group for web servers was also created:
children:
  webservers:
    hosts:
      LinuxMachine-1: {}
      WebServer02: {}

5. Ansible Playbook (setup_servers.yml)
A playbook was written to manage hostnames and perform basic server setup:

Example Tasks:
- Set hostname for each machine
- Install required packages
- Start web services
- Deploy HTML content onto WebServer02

The playbook was executed using:
ansible-playbook playbooks/setup_servers.yml -i inventory/hosts.yml

6. HTML Deployment
An index.html file was created and copied into the Ansible folder to be deployed to the target web server as part of the automation workflow.