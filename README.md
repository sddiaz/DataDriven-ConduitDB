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

- **GET /GetCables/{start}**: Retrieve a paginated list of cables. This endpoint returns the first 10 cables starting at index {start}. Ex: For start = 0, it returns cables 0-9. 
- **GET /GetCable/{ID}**: Retrieve details of a specific cable by ID.
- **POST /CreateCable**: Create a new cable entry.
- **PUT /UpdateCable/{ID}**: Update an existing cable by ID.
- **DELETE /DeleteCable/{ID}**: Delete a cable by ID.

## Models

The API uses two models: `BaseCable` and `Cable`.

- `BaseCable`: Represents the basic cable information with properties such as ID, OtiGUID, FromBus, and ToBus.

- `Cable`: Represents detailed cable information, including additional properties like PhaseValue, InService, Description, and more.

## Usage

- This API will be running on MKEC's internal network 24/7. Anyone connected to the network should be able to access it via the proper browser URLs.
- In order to properly utilize this API, one must download the MKEC Cable Manager Application here: (insert link). This will allow you to access the database. 


## Contact Information

- Developer: Santiago Diaz
- Email: [sddiaz2003@gmail.com](mailto:sddiaz2003@gmail.com)
- Senior Design Team: Data Driven
- University: Wichita State University
- Collaboration Partner: MKEC

For any questions, issues, or collaboration inquiries, please feel free to reach out to the developer via email.
