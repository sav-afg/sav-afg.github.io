# Portfolio Website

A minimal Blazor WebAssembly portfolio website for GitHub Pages.

## ?? Running Locally

**?? IMPORTANT: You cannot open the HTML files directly in a browser!** Blazor WebAssembly requires a web server.

### Option 1: Visual Studio
1. Open the solution in Visual Studio
2. Press `F5` or click the green Play button
3. Navigate to **http://localhost:5232**

### Option 2: .NET CLI
```bash
dotnet run
```
Then open **http://localhost:5232** in your browser

### Option 3: Hot Reload (Recommended for Development)
```bash
dotnet watch run
```

## ?? Building for Production

```bash
dotnet publish -c Release -o publish
```

## ?? Deploying to GitHub Pages

This repository is configured for automatic deployment.

### First-Time Setup
1. Go to GitHub repository settings
2. Navigate to **Pages**
3. Under **Source**, select "GitHub Actions"
4. Push to `main` branch

Every push will automatically deploy to: **https://sav-afg.github.io**

## ?? Project Structure

- `Components/` - Reusable UI components
- `Pages/` - Routed pages (Home, Projects, About, Contact)
- `Models/` - Data models
- `Data/` - Static project data
- `wwwroot/` - Static assets (CSS, images)

## ? Features

- Pure client-side Blazor WebAssembly
- No backend required
- Responsive design
- Custom CSS (no frameworks)
- GitHub Pages optimized

## ?? Troubleshooting

**404 Error Locally?**
- Don't open HTML files directly
- Run with `dotnet run` or Visual Studio
- Navigate to http://localhost:5232
