<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebFormsAlgorithms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">About Challenge Solver:</h1>
            <p class="lead">It is a specialized tool to validate code challenges</p>
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Getting started with Palindrome</h2>
                    <p>
                        A palindrome is a word, phrase, number, or other sequence of characters
                        which reads the same backward as forward. Punctuation and spacing are
                        typically ignored. Famous examples include "madam," "racecar," or even
                        phrases like "A man, a plan, a canal: Panama."
                    </p>
                    <p>
                        They are often used in computer science for educational purposes,
                        particularly when teaching string manipulation, recursion, or algorithms
                        for reversing sequences.
                    </p>
                    <p>
                        <a class="btn btn-default" href="https://en.wikipedia.org/wiki/Palindrome" target="_blank">Learn more about Palindromes &raquo;</a>
                    </p>
            </section>
            
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">Getting started with Poker Hand</h2>
                        <p>
                            In poker, a "hand" refers to the set of five cards a player holds, or the best five cards that can be made from a combination of a player's hole cards and community cards. The value of a hand is determined by a ranking system, where certain combinations of cards are more valuable than others.
                        </p>
                        <p>
                            Common poker hands include a Pair (two cards of the same rank), Two Pair, Three of a Kind, Straight (five cards in sequence), Flush (five cards of the same suit), Full House (three of a kind and a pair), Four of a Kind, Straight Flush, and the highly coveted Royal Flush.
                        </p>
                        <p>
                            <a class="btn btn-default" href="https://en.wikipedia.org/wiki/List_of_poker_hands" target="_blank">Learn more about Poker Hands &raquo;</a>
                        </p>
            </section>
        </div>
    </main>

</asp:Content>
