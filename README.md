# Website Analytics

A simple C# console application for analyzing website product page visits.  
The project processes two CSV files representing visits on two separate days and identifies users who:

1. Visited pages on both days.  
2. On the second day, visited pages that they had **not visited on the first day**.

This tool is useful for marketing analytics to detect new product interactions by returning users.

## Features

- Efficiently parses large CSV files containing user activity.  
- Uses `Dictionary` and `HashSet` to track users and their visited products.
  

## Getting Started

### Prerequisites

- .NET 6.0 or later installed  
- Visual Studio 2022 / VS Code or any C# IDE

### Running the Project

1. Clone the repository:

``bash
git clone https://github.com/sqprrr/Website_analytics.git
cd Website_analytics
2. Build and run:

Visual Studio: Press F5 or Ctrl + F5

Command line: dotnet run
Ensure your CSV files for the two days are in the project folder or provide the correct paths.

The program will log user IDs who visited new pages on the second day.

Algorithm Explanation

The program uses the following approach:

Load CSV files into Dictionary<string, HashSet<string>>:

Key: user_id

Value: unique set of product_id visited

Iterate over users from the second day:

Check if the user exists on the first day

Compute newPages = day2[user] - day1[user]

If newPages is not empty, output user_id

License

This project is for educational purposes and can be freely modified and used for learning.



