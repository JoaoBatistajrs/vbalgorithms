# CardDeck & Palindrome Business Logic

This project provides core business logic for two main features:
- **Palindrome Checker**: Determines if a given integer is a palindrome.
- **Poker Hand Evaluator**: Analyzes a list of 5 cards and returns the poker hand ranking.

A dedicated test project is included to ensure code reliability.

## Features

### 1. Palindrome Checker

Checks if an integer reads the same forwards and backwards.

**Example:**

Dim isPal = Service.IsPalindrome(12321) ' Returns: True 
Dim isPal2 = Service.IsPalindrome(12345) ' Returns: False

### 2. Poker Hand Evaluator

Evaluates a poker hand (5 cards) and returns its ranking (e.g., "Full House", "Flush", "Pair", etc.).

**Card Format:**  
Each card is a string, e.g., `"AS"` (Ace of Spades), `"TD"` (Ten of Diamonds), `"7H"` (Seven of Hearts).

**Example:**

Dim hand = New List(Of String) From {"AS", "KS", "QS", "JS", "TS"} Dim result = Service.EvaluatePokerHand(hand) ' Returns: "Royal Flush"

## Test Project

The solution includes a test project (`WebAppVB_Tests\TestCardDeck.vb`) with unit tests for both palindrome and poker hand evaluation logic.  
Run the tests to verify correctness and reliability.

## Getting Started

1. Clone the repository.
2. Open the solution in Visual Studio 2022.
3. Build the solution.
4. Run the test project to validate functionality.

## Project Structure

- `BusinessLogic\Service.vb` — Core logic for palindrome and poker hand evaluation.
- `WebAppVB_Tests\TestCardDeck.vb` — Unit tests for business logic.

## Requirements

- .NET Framework (4.8.1)
- Visual Studio 2022

