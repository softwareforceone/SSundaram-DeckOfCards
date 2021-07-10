using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSundaram_DeckOfCards;
using System;
using System.Collections.Generic;

namespace SSundaram_DeckOfCards_Tests
{
    [TestClass]
    public class DeckTests
    {
        Deck deck = new Deck();

        [TestInitialize]
        public void TestsInitialize()
        {
            deck.InitializeDeck();
        }
        [TestMethod]
        public void TestScenario1() 
        {
            //Scenario1: The deck has 52 cards
            //Given a deck of cards
            //When I count each card
            //Then I have a total of 52 cards

            //Arrange
            int ExpectedValue = 52;
            int ActualValue = 0;

            //Act
            ActualValue = deck.CountCardsInDeck();

            //Assert
            Assert.AreEqual(ExpectedValue,ActualValue);
        }
        [TestMethod]
        public void TestScenario2()
        {
            //Scenario2: The deck has 4 suits
            //Given a deck of cards
            //When I check for suits
            //Then I see hearts, clubs, spades, and diamonds

            //Arrange
            List<string> ExpectedValue = new List<string>();
            ExpectedValue.Add("Hearts");
            ExpectedValue.Add("Clubs");
            ExpectedValue.Add("Spades");
            ExpectedValue.Add("Diamonds");
            List<string> ActualValue = null;

            //Act
            ActualValue = deck.GetSuitsPresentInDeck();

            //Assert
            CollectionAssert.AreEqual(ExpectedValue, ActualValue);
        }
        [TestMethod]
        public void TestScenario3()
        {
            //Scenario3: Each suit has 13 cards
            //Given a deck of cards
            //When I count all the cards in a single suit
            //Then I have 13 cards: ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King

            //Arrange
            int ExpectedValue = 13;
            int ActualValue = 0;
            //Act
            ActualValue = deck.GetCardsBySuitInDeck(SuitTypeEnum.SuitType.Hearts).Count;

            //Assert
            Assert.AreEqual(ExpectedValue, ActualValue);
        }

        [TestMethod]
        public void TestScenario4()
        {
            //Scenario Outline: Card values
            //Given a deck of cards
            //When I have a card with <face_value>
            //Then the card is worth <point_value>
            //| <face_value> | <point_value> |
            //| ace          | 1             |
            //| 2            | 2             |
            //| 10           | 10            |
            //| Jack         | 10            |
            //| Queen        | 10            |
            //| King         | 10            |


            //Arrange
            int ExpectedValue = 10;
            int ActualValue = 0;
            //Act
            ActualValue = deck.GetPointValueByFaceValueBySuit("King", SuitTypeEnum.SuitType.Hearts);

            //Assert
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [TestMethod]
        public void TestScenario5()
        {
            //Scenario: Face cards are ordered and all count as 10
            //Given a deck of cards
            //Then the face cards are ordered Jack, Queen, King
            //Arrange
            int ExpectedJackPosition = 11;
            int ExpectedQueenPosition = 12;
            int ExpectedKingPosition = 13;

            int ActualJackPosition = 0;
            int ActualQueenPosition = 0;
            int ActualKingPosition = 0;

            //Act
            ActualJackPosition = deck.GetPositionOfCardBySuit("Jack", SuitTypeEnum.SuitType.Hearts);
            ActualQueenPosition = deck.GetPositionOfCardBySuit("Queen", SuitTypeEnum.SuitType.Hearts);
            ActualKingPosition = deck.GetPositionOfCardBySuit("King", SuitTypeEnum.SuitType.Hearts);

            //Assert
            Assert.AreEqual(ExpectedJackPosition, ActualJackPosition);
            Assert.AreEqual(ExpectedQueenPosition, ActualQueenPosition);
            Assert.AreEqual(ExpectedKingPosition, ActualKingPosition);
        }
        [TestCleanup]
        public void TestsCleanUp()
        {

        }
    }
}
