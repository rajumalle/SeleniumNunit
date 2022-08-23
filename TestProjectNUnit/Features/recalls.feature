@ivt @recalls
Feature: Recalls regression test scenarios
    As a QA
    I want to test Regression test scenarios

    Background:
        Given I am on the main url with these extra parameters "/owners/recalls"

    Scenario: TC1_Recalls Page fields visible Test
        Then I validate recalls home page fields

    Scenario Outline:TC2_Recalls page validation with <VIN> and download recall PDf
        Then I validate recalls home page fields
        When I search VIN as "<VIN>" in recalls page
        Then I validate Vehicle Details in recalls page
        When I click on Confirm Button in recalls page
        Then I validate vehicle recalls details in recalls page
        Then I click on Download Recalls PDF in recalls page
        Examples:
            | VIN               |
            | JTHB21B1002002333 |

    Scenario Outline:<TestCase>_Recalls page validation with <VIN>
        Then I validate recalls home page fields
        When I search VIN as "<VIN>" in recalls page
        Then I validate Vehicle Details in recalls page
        When I click on Confirm Button in recalls page
        Then I validate vehicle recalls details in recalls page
        Examples:
            | TestCase | VIN               |
            | TC3      | JTHB21B1002002333 |
            | TC5      | JTDJT123100085813 |
            | TC6      | AHT54ZEC307000461 |
            | TC7      | MR0FB3CC600250114 |
            | TC8      | JTDBR22E000058838 |
            | TC9      | JTDZS3EU203090992 |
            | TC10     | AHT54ZEC206512396 |