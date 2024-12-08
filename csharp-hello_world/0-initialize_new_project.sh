#!/usr/bin/env bash

# Check if the folder already exists.
if [ -d "0-new_project" ]; then
    echo "Folder '0-new_project' already exists."
    exit 1
fi

# Create a new folder and initialize a C# project inside it.
dotnet new console -o 0-new_project

# Check if the project was successfully created.
if [ $? -eq 0 ]; then
    echo "The template \"Console Application\" was created successfully."
else
    echo "Failed to create the project."
    exit 1
fi