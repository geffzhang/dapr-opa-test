# Dapr Opa Example

## Step 1
Build both projects into docker images locally by running build-image.sh in each one.

## Step 2
Run services and Dapr system using docker-compose.

## Step 3
Execute an HTTP post to localhost:8080/foo with a json payload like `{ Message: "foo" }`.
This will cause foo-service to invoke a method on bar-service, which should be blocked by the OPA policy configured for bar-service.
