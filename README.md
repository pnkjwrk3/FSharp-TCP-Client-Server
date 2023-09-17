# Concurrent Socket Communication in F#

This repository contains the source code for a concurrent client/server implementation for socket communication using F#.

## Description

The implementation consists of two main components:

1. **Server Program:** The server program, written in F#, listens for incoming client connections and responds to their requests. It handles multiple clients simultaneously.

2. **Client Programs:** Client program, also written in F#, can run concurrently and establish connections to the server. They send messages containing arithmetic calculation commands (e.g., add, subtract, multiply) along with input numbers (e.g., add 12 7) to the server. The server calculates the result and responds to each client with the computed value.

## Usage

To use this code for your own educational purposes or to complete the assignment, follow these steps:

1. Clone the repository to your local machine:

   ```bash
   git clone https://github.com/pnkjwrk3/FSharp-TCP-Client-Server.git
2. Navigate to the project directory:
   
   ```bash
   cd FSharp-TCP-Client-Server
3. Build the server and client program:
   
   ```bash
    make
4. Run the server program:
   
   ```bash
   mono Server.exe
5. Run the Client program, can run multiple clients simulataneously:

   ```bash
   mono Client.exe
## To-Do

List tasks that need to be completed or features that need to be added. You can use checkboxes to mark the completion status of each task.

- [X] server exception handling for more than 4 inputs
- [x] client handling initial Hello from server
- [X] terminate command exception handling, server side
- [ ] code cleanups
- [x] terminate command server side why exception?
- [x] Server keeping count of connected clients
- [ ] Updating the comments
- [ ] Update the documentation and report with usage examples
