# agoda-coding-test
## How to Run
1. Create a new folder in your computer
2. Open command prompt and navigate to the folder
3. Initialize git
```
git init
```
4. Pull git repository to the folder
```
git pull https://github.com/dream254111/agoda-coding-test.git master
```
5. Run the program by using [dotnet](https://dotnet.microsoft.com/)
```
dotnet run
```
6. Using any tool to send POST request to API (recommend [Postman](https://www.postman.com/))
## API
### Request Header
Content-type: application/json
### Request Body
numbers: {{ array of integers }}
## Example
### Request
```JSON
{
    "numbers": [20, 25, 11125, 3435, 33435, 45]
}
```
### Response
```JSON
{
    "GCD": 5
}
```
