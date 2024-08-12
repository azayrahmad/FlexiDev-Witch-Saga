# FlexiDev Witch Saga: Return of The Coder!

ASP .NET MVC web application that solves the witch's killing pattern by calculating average of people killed, based on code challenge by FlexiDev.

## Table of Contents

- [Demo](#demo)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Test](#test)

## Demo

You can view a live demo of the application on Azure: [Witch Saga](https://witchsagaweb20240812101657.azurewebsites.net/)

## Features

Allows user to enter two persons' ages and death dates and returns the average of people killed in their birth years. The number of people killed is decided by sum of Fibonacci numbers.

## Installation

1. Clone the repository using GitHub desktop or using these commands:

   ```bash
   git clone https://github.com/azayrahmad/FlexiDev-Witch-Saga.git
   ```

2. Ensure .NET 8.0 SDK is installed.

## Usage

1. Run the web app:

   ```bash
   dotnet run --project .\WitchSaga.Web\WitchSaga.Web.csproj
   ```

2. Open your browser and navigate to `http://localhost:5296` to view the application.

## Test

Run the unit tests using this command:

```bash
dotnet test
```
