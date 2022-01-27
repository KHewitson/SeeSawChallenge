# SeeSawChallenge
The SeeSaw Challenge is a logic puzzle that tests you to your limit. I stumbled upon the challenge itself on social media, and enjoyed it so much that I decided to write the code that would enable people to attempt to solve the puzzle with code.

The challenge parameters are simple:
* You have a seesaw (or balance of some sort)
* You have 12 people (labelled A->L for simplicity). 11 of those are of equal weight. 1 is either heavier or lighter than the rest
* The seesaw can only be used 3 times

This repository contains a Test class (powered by nunit, but you can change that if you wish), a Logic class and a reference to the binary that contains the code for the above parameters. The SeeSaw.Balance function will throw exceptions for certain unpalatable use cases, but otherwise will respond with Balanced, LeftSideUp or RightSideUp. The SeeSaw will select at random the person and whether they are heavier or lighter.

It is your task to write code in the Logic class that makes the test consistently pass (by guessing the correct person. I've included an "ISeeSaw" interface in the package, so you can use a mocking framework to test-drive your changes.
