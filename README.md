# PrestoShop
This is the solution with tests for [PrestoShop](http://prestashop.qatestlab.com.ua/ru/) Web Application

## Features
- UI tests
- Logging
- Allure report

## Tests list

#### UI
- GoAddressInputTest
- Login
- LoginAndLogOut
- CheckErrorOnDelivery
- BuyProducts
- ErrorLogin
- AddProducts


## Technologies
**NuGet packages used in the solution:**
- Microsoft.Extensions.Configuration
- Allure.NUnit
- Bogus
- NLog
- NUnit
- Selenium.Support
- Selenium.WebDriver

**Approaches used in the development of the framework and tests:**
- Driver Factory
- Page Object
- Wrappers
- Chain of invocation

## Configuration
The solution uses a configuration JSON file:
```appsettings.json```
```JSON
  "Browser": {
    "Hedless": "true",
    "Type": "chrome",
    "TimeOut": 30,
    "Login": "ezulol@mail.ru",
    "Password": "qwerty123",
    "Url": "http://prestashop.qatestlab.com.ua/ru/authentication?back=my-account"
  }
```

## Installation
Register on the [PrestoShop](http://prestashop.qatestlab.com.ua/ru/)
Replace  **Url**, **Login**, **Password** in the config file
You are ready to run UI tests
