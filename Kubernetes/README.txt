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
	
Deployment Procedure for Azure Kubernetes Service (AKS)
------------------------------------------------------
1. Established the Votingapp-resourcegroup within Azure DevOps to serve as the logical container for all deployment resources, ensuring organized management and access control.

2. Conneting local kubectl (Kubernetes command-line tool) to a remote Azure Kubernetes Service (AKS) cluster
	az aks get-credentials --resource-group Votingapp-resourcegroup --name example-voting-app
	
3. Cloned the application source code repository from the designated Git URL to the local Azure Cloud Shell environment to obtain the latest version of the application artifacts and deployment manifests.

4. Executed the necessary Kubernetes manifest files (.yaml) to deploy the application components to the AKS cluster, creating all required pods, services, and deployments.

5. Verified successful deployment by retrieving the external IP address and port of the vote service using:
kubectl get service vote
The application was confirmed operational by accessing it through a web browser at the provided endpoint (<IP-Address>:<port>).

Construction of CI/CD Pipeline:
-------------------------------
1. Provisioned a Jenkins virtual machine in Azure.

2. Installed and configured Docker on the Jenkins instance.

3. Integrated GitHub credentials into Jenkins for source control access.

4. Wrote and successfully executed a Groovy-based pipeline to automate the build process.
   
