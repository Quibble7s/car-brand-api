# car-brand-api

A simple .NET CORE wep api configured to run with Postgres inside a container using Docker Compose.

## How to run the app
- If not set, set the *"docker-compose"* project has the startup project.
- Restore all the packages.
- Run the application.

Migrations will be applied automatically if necessary when the app runs. This will create the database, tables and seed them with data. 

## Endpoints
### brands

Gets the list of car brands.

URL : `/cars/brands`

Method : `GET`

Authorization: `None`

Authentication : `None`

#### Success Response

Code : `200 OK`

Content Example:

```json
[
  {
    "id": 1,
    "name": "BRAND 1"
  },
  {
    "id": 2,
    "name": "BRAND 2"
  },
]
```

#### Error Response

Code : `404 NOT FOUND`