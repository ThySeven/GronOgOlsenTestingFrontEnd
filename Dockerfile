# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy global.json and verify SDK version, if it exists
COPY global.json* ./
RUN dotnet --info

# Copy the entire project
COPY . ./

# Restore dependencies
RUN dotnet restore

# Build and publish the application
RUN dotnet publish "GronOgOlsenFrontEnd.csproj" -c Release -o /app/publish

# Stage 2: Serve the application
# Use a base image appropriate for serving static files
FROM nginx:alpine AS runtime
WORKDIR /usr/share/nginx/html

# Copy the published Blazor app
COPY --from=build /app/publish/wwwroot .

# Copy custom nginx configuration
COPY nginx.conf /etc/nginx/conf.d/default.conf

# Expose port 80 to the outside world
EXPOSE 80

# Start Nginx server
CMD ["nginx", "-g", "daemon off;"]