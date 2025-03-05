# Objective
## Core game
1. You'll never win rock, paper, scissors
2. Allow user input, reject anything else, allow shorthands

## Improvements to add
To iterate P1-RockPaperScissors with the following more advanced C# concepts:
1. Break out game logic into services and separate classes
2. Build RESTful API -- Make the game as a service so external clients can interact with it.
2. Utilise dependency injection and service layers
3. Handle exceptions using a global exception middleware and leverage built-in logging `Microsoft.Extensions.Logging` to track issues
4. Consume an API, for instance call a random Quranic quote after each game round and/or use a statistics API to fetch or record game scores over time.
5. Add unit tests for game logic and API endpoints