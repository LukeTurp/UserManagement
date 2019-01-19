# UserManagement

## Features
1. Currently supports Post method for new user.
    - User format is as follows:
    ```javascript
    {
        "userName":"testUsername",
        "password":"testPassword1!",
        "email":"test@example.com"
    }
    ```
    - Post returns with a string message stating your user was successfully created.
        - Currently the user is not yet stored. This is simply the default success message.

2. Docker container:
    - Removed HTTPS redirection for Kestrel.
        - This will be handled by Nginx.
    - Docker build:
        ```
        docker build -t usermanagement .
        ```
    - Currently using the following command to run the docker image:
        ```
        docker run --name usermanagement --env ASPNETCORE_ENVIRONMENT=Production -p80:80 usermanagement:latest
        ```
        - Alternatively run in Debug if debugging.
