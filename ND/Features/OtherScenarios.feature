Feature: OtherScenarios
Background:
Given I navigate to the app

Scenario: Verify warning message if enter incomplete phone number
	When I enter incomplete phone number
	Then I verify if Введите телефон в формате +7(911)111-11-11 message is visiable

Scenario: Verify warning message if enter unregistered phone number
    When I enter unregistered phone number 
    Then I verify if Номер не зарегистрирован message is visiable

Scenario: Verify warning message if enter password less then 6 symbols
    When I enter 5 symbols in password field
    Then I verify if Значение должно быть не менее 6 знаков message is visiable

Scenario: Verify warning message if enter password 6 or more then 6 symbols
    When I enter 6 symbols in password field
    Then I verify if Значение должно быть не менее 6 знаков message isn't visiable

    Scenario: Verify if user is able log in to personal account when enter unregistered phone number
    When I enter unregistered phone number
    And I enter password
    Then I verify  Войти в личный кабинет isn't clickable

Scenario: Verify redirection to password recovery page
    When I click Восстановить пароль
    Then I verify if Восстановление пароля message is visiable

Scenario: Verify if user is able return to login page from password recovery page
    When I click Восстановить пароль
    And I click Назад
    Then I verify welcome message is visible

Scenario: Verify if user is able send a code to a phone if enter unregistered phone number
    When I click Восстановить пароль
    And I enter unregistered phone number
    Then I verify Отправить код isn't clickable

Scenario: Verify if user is able navigate to account creation page
    When I click Заведите аккаунт
    Then I verify if Кажется, вы у нас впервые message is visible

Scenario: Verify if user is able send a code to a phone if enter unregistered phone number on account creation page
    When I click Заведите аккаунт
    And I enter unregistered phone number
    Then I verify Отправить код isn't clickable

Scenario: Verify warning message if enter incomplete phone number on account creation page
    When I click Заведите аккаунт
    And I enter incomplete phone number
	Then I verify if Неверный формат message is visiable

Scenario: Verify if user is able return to login page from account creation page
    When I click Заведите аккаунт
    And I click Войдите
    Then I verify welcome message is visible