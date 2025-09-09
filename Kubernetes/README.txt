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
   
   
 This project was made according to Udemy course "Kubernetes for the Absolute Beginners - Hands-on"