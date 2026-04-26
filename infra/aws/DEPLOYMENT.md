# AWS Deployment Guide

## 1) Build and push image to ECR

```bash
aws ecr create-repository --repository-name fnb-management-web --region <REGION>
aws ecr get-login-password --region <REGION> | docker login --username AWS --password-stdin <ACCOUNT_ID>.dkr.ecr.<REGION>.amazonaws.com

docker build -f infra/aws/Dockerfile -t fnb-management-web:latest .
docker tag fnb-management-web:latest <ACCOUNT_ID>.dkr.ecr.<REGION>.amazonaws.com/fnb-management-web:latest
docker push <ACCOUNT_ID>.dkr.ecr.<REGION>.amazonaws.com/fnb-management-web:latest
```

## 2) Deploy to ECS Fargate

1. Create ECS cluster (networking in private/public subnets).
2. Register task definition from `infra/aws/ecs-task-definition.json`.
3. Create ECS service with desired count >= 2.
4. Attach ALB target group to container port `8080`.
5. Configure HTTPS listener (ACM certificate).

## 3) Runtime configuration

- Use AWS Systems Manager Parameter Store or Secrets Manager for app secrets.
- Send logs to CloudWatch using the included awslogs driver.
- Apply auto scaling policies on ECS service (CPU and request count).

## 4) Alternative

You can deploy the same container image to **AWS App Runner** if you want a simpler managed runtime.
