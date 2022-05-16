# Features pattern

The features pattern is a pattern I prefer when I am allowed to use it ;-) Utilizing MediatR, AutoMapper and FluentValidation, allows for a really easy pipeline, that is both extensible and easy to understand.

The pattern maps well with use cases as the queries and commands are not limited in what they can handle. As such the pattern puts the CRUD operations belonging to a specific use case under that use cases namespace, and the implementation uses whatever it needs to extend the pipeline to e.g., be able to run some algorithm, retrieve orders from a database, or read characters from the star wars universe from Heartcore 😉 This mapping makes it super quick to maintain a codebase, if issues are mapped to use cases in the issue board.
