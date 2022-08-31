# Invent BT Full Stack Technical Test

## Getting Started
### Frontend

#### Option 1 = ExpressJS with Nunjucks (Node 16)
> To start the frontend ensure you are in the `/frontend/nunjucks` and run `npm run dev` the service will start on http://localhost:8000

#### Option 2 = React (Typescript) with Bootstrap (Node 16)
> To start the frontend ensure you are in the `/frontend/react-typescript` and run `npm start` the service will start on http://localhost:3000

#### Option 3 = React (Javascript) with Bootstrap (Node 16)
> To start the frontend ensure you are in the `/frontend/react-javascript` and run `npm start` the service will start on http://localhost:3000


### Backend
- Java 11 - with Spring Boot 2.6.6
> To start the backend ensure you are in the `/backend/java` and run `mvn spring-boot:run` the service will start on http://localhost:8080

- Typescript
> To start the backend ensure you are in the `/backend/typescript` and run `npm run build` and `npm start` the service will start on http://localhost:3010

- C# - with .NET Core 3.1
> To start the backend ensure you are in the `/backend/csharp/dotnetcore3` and run `dotnet run` the service will start on http://localhost:5000

---
## Tasks
Allow one hour to complete as much as possible. 
Please work as you would normally do

> Advice: We would rather you did it properly and completed less than completed it all with poor quality or attendtion to details. Please dont worry about styling the frontend - this will not get you any "extra credit" if the solution is unfinished or incomplete.
### Step 1: Shopping cart

- You are building a checkout system for a shop which only sells apples and oranges.

- Apples cost 60p and oranges cost 25p.

- Build a checkout system which takes a list of items scanned at the till and outputs the total cost

- For example: [ Apple, Apple, Orange, Apple ] => £2.05

- Make reasonable assumptions about the inputs to your solution; for example, many candidates take a list of strings as input

### Step 2: Simple offers

- The shop decides to introduce two new offers

    - buy one, get one free on Apples

    - 3 for the price of 2 on Oranges

- Update your checkout functions accordingly