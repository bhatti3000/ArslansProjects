PREREQUISITES:
-------------
- Virtualization is enabled
- Oracle VirtualBox is installed
- Minikube is installed and configured

Deploy the Application:
-----------------------
kubectl apply -f Deployment/Deployment-Definition-2.yml

Update the Image and Verify:
---------------------------
1. Update the container image:
   kubectl set image deployment/myapp-deployment nginx-containers=nginx:1.29.1

2. View the rollout history:
   kubectl rollout history deployment/myapp-deployment

3. Check the deployment to confirm the new NGINX version (1.29.1) is active:
   kubectl describe deployment/myapp-deployment
   
Deployment and Services in Kubernetes:
-------------------------------------
1. Create ReplicaSet and maintain 5 Pods
   kubectl create -f Deployment\Deployment-Definition-2.yml"
   
2. Exposing Service to NodePort:30004 
   kubectl create -f Services\service-definition.yml
   
3. Note the ip address
   kubectl get svc
   
4. NGINX is accessible to the IP-Addess from step 3
   IP-Addess:30004
   
   
Deploying voting-app on Kubernetes cluster
------------------------------------------
1. Remove all previous pods and apply following services.
   kubectl apply -f  VotingApp/.

2. Get IP address
   kubectl get node -o wide
   
3. Take the IP-Addess from step 2 and put the port from .yml file. Voting app would be visible on browser.
   e.g IP-Address:Port

Same procedure can be used while deploying the app on kubernetes using deployment
	kubectl apply -f  AppDeployment/.
   

This project was made according to Udemy course "Kubernetes for the Absolute Beginners - Hands-on"