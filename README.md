# FnB Management Web Application (.NET 14 / C# 10)

This repository has been rewritten into an **FnB (Food & Beverage) management web application** using ASP.NET Core MVC.

> Note: the project is configured for `net14.0` per requirement and locks language version to C# 10.

## Features

- Dashboard with KPI cards
- Menu item management
- Inventory tracking with low-stock alerts
- Daily order registration and revenue summary

## Project structure

- `src/FnBManagement.Web` - ASP.NET Core MVC application
- `infra/aws` - AWS deployment assets (Dockerfile, ECS task definition, and deployment notes)

## Run locally (when .NET 14 SDK is available)

```bash
dotnet run --project src/FnBManagement.Web/FnBManagement.Web.csproj
```

## AWS deployment options

- Docker image -> Amazon ECS Fargate
- Docker image -> AWS App Runner
- Containerized deployment behind ALB with CloudWatch logging

See `infra/aws/DEPLOYMENT.md` for complete deployment steps.
