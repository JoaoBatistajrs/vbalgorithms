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
                <h2 id="hostingTitle">Web Hosting</h2>
                <p>
                    You can easily find a web hosting company that offers the right mix of features and price for your applications.
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
                </p>
            </section>
        </div>
    </main>

</asp:Content>
