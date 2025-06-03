# List Occurrence Counter API

This is a simple ASP.NET Core Web API that counts the number of times each item appears in a list.  
It supports counting occurrences of strings, integers, and characters.

##  Technologies Used

- ASP.NET Core Web API
- C#
- Swagger (for API testing and documentation)
- .NET 6+

---

##  Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- Visual Studio or VS Code
- Git

---

###  Cloning the Repository

```bash
git clone https://github.com/NtshebetsengM/listOccurenceCounterAPI.git
cd listOccurrenceCounterAPI
```

## Running the API Locally
```bash
dotnet run
```
Then open your browser and navigate to:
`https://localhost:5001/swagger` 
to access the Swagger UI.

##  API Endpoints

All endpoints are `POST` requests that accept a JSON array.

| Endpoint                 | Description                | Example Input                    |
|--------------------------|----------------------------|----------------------------------|
| `/api/counter/strings`   | Count string occurrences   | `["apple", "banana", "apple"]`   |
| `/api/counter/ints`      | Count integer occurrences  | `[1, 2, 1, 3]`                    |
| `/api/counter/chars`     | Count character occurrences| `["a", "b", "a"]`                |

## Sample Request

**POST** `/api/counter/strings`

``` json
[
  "apple",
  "banana",
  "apple"
]
```

## Sample Response
``` json
{
  "apple": 2,
  "banana": 1
}
```

## Hosting
The live API is hosted on Render and is available here:
TBD

## Project Structure
``` 
ListCounterAPI/
├── Controllers/
│   └── CounterController.cs
├── Services/
│   └── Counter.cs
├── Program.cs
├── ListCounterAPI.csproj
└── README.md
```

