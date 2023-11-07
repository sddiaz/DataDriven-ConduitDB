# DataDriven-ConduitDB

# Data Driven Cable API

Welcome to the Data Driven Cable API, developed by Santiago Diaz for the Senior Design project at Wichita State University in collaboration with MKEC. This API serves as the backend for a cable database, providing CRUD (Create, Read, Update, Delete) access to cable-related information.

## Table of Contents
- [Overview](#overview)
- [Controller](#controller)
- [Models](#models)
- [Getting Started](#getting-started)
- [Contact Information](#contact-information)

## Overview

The Data Driven Cable API is designed to manage cable data for MKEC's database. It provides endpoints to retrieve cable information, create new cables, update existing cables, and delete cables.

## Controller

The main controller in the API is the `CableController`, which contains the following endpoints:

- **GET /GetCables**: Retrieve a paginated list of cables.
- **GET /GetCable/{ID}**: Retrieve details of a specific cable by ID.
- **POST /CreateCable**: Create a new cable entry.
- **PUT /UpdateCable/{ID}**: Update an existing cable by ID.
- **DELETE /DeleteCable/{ID}**: Delete a cable by ID.

## Models

The API uses two models: `BaseCable` and `Cable`.

- `BaseCable`: Represents the basic cable information with properties such as ID, OtiGUID, FromBus, and ToBus.

- `Cable`: Represents detailed cable information, including additional properties like PhaseValue, InService, Description, and more.

## Getting Started

To get started with the Data Driven Cable API, follow these steps:

1. **Clone the Repository**: Clone this repository to your local machine.

2. **Set Up the Connection String**: Follow the instructions in the [Connection String](#connection-string) section to configure the database connection.

3. **Run the API**: Build and run the API on your local environment.

4. **Access the Endpoints**: Use API endpoints to interact with the cable database. Refer to the [Controller](#controller) section for available endpoints.

## Connection String

To configure the database connection, set the connection string. You can use environment variables or a configuration file. Ensure sensitive information like the connection string is not stored in version control.

## Contact Information

- Developer: Santiago Diaz
- Email: [sddiaz2003@gmail.com](mailto:sddiaz2003@gmail.com)
- Senior Design Team: Data Driven
- University: Wichita State University
- Collaboration Partner: MKEC

For any questions, issues, or collaboration inquiries, please feel free to reach out to the developer via email.
