#!/usr/bin/env bash

# Check if the folder already exists
if [ -d "1-new_project" ]; then
    echo "Folder '1-new_project' already exists."
    exit 1
fi

# Create a new C# project and build it
dotnet new console -o 1-new_project && dotnet build 1-new_project
