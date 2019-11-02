# BrewBuddy Entity Naming Conventions

All entities must conform to the following naming conventions.

No _Controller_ may pass a _RequestDTO_ to a _Service_. The data must be transformed by the _Controller_.

No _Service_ may create a _ResponseDTO_. Only _Controllers_ are responsible for transforming *result*s to *ResponseDTO*s.

## Client

**Request** - Internal Data that is passed to the ApiClient. This data will be transformed by the ApiClient and transmitted as a _requestDTO_.

## Intermediate

**RequestDTO** - External data that a Server _Controller_ is receiving from a client.

**ResponseDTO** - External data that a Server _Controller_ is sending to a client.

## Server

**Query** - Internal data that a server _Service_ will process. *RequestDTO*s will be transformed to _query_ objects before being passed down to the appropriate _Service_.

**Result** - Internal data that a server _Service_ is passing back to the appropriate _Controller_. Results will be transformed to *ResponseDTO*s and sent to the client.

**Controller** - The API Enpoint that receives *RequestDTO*s from the clients.

**Service** - The internal business logic that does the necessary data processing.