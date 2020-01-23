Feature: Sharepoint based team calendar
    A Sharepoint based team calendar where people can track their vacation after logging in.

    Scenario: User can log in
        Given a browser window
        When logging in as 'user'
        Then the logged in user is 'user'
