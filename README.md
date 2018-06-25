# Summary

This repo contains the challenges and my solution during the Microsoft Open Hack on Containers held at Sydney during 18 - 20 June.

# References and resources

1. Kelsey Hightower's highly acclaimed book: [Kubernetes up and running](http://shop.oreilly.com/product/0636920043874.do)
2. Getting Kubernetes: [Git Repo](https://github.com/kubernetes/kubernetes/blob/master/CHANGELOG-1.9.md#v198)
3. Get the Azure CLI 2.0 [HERE](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest)
4. Kubernetes Concepts [docs](https://kubernetes.io/docs/concepts/overview/working-with-objects/kubernetes-objects/)

# Basic cluster

(Requires Azure CLI and kubectl)
```
# Create a cluster
az aks create -n minecraft-readify -g rg-minecraftTable15 --node-count 1 --generate-ssh-keys

# Get credentials for the cluster
az aks get-credentials --resource-group rg-minecraftTable15 --name minecraft-readify

# Browse the cluster
az aks browse --resource-group rg-minecraftTable15 --name minecraft-readify
```
