# Run Selenium Tests With xUnit On LambdaTest

![LambdaTest Logo](https://user-images.githubusercontent.com/70570645/171429042-610e8f3d-d2a4-4896-8bdb-8aeed87e0ce7.png)

*Learn how to run C# scripts using the xUnit framework.*

<p align="center">
  <a href="https://www.lambdatest.com/blog/" target="_bank">Blog</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.lambdatest.com/support/docs/" target="_bank">Docs</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.lambdatest.com/learning-hub/" target="_bank">Learning Hub</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.lambdatest.com/newsletter/" target="_bank">Newsletter</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.lambdatest.com/certifications/" target="_bank">Certifications</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.youtube.com/c/LambdaTest" target="_bank">YouTube</a>
</p>
&emsp;
&emsp;
&emsp;

[<img height="58" width="200" src="https://user-images.githubusercontent.com/70570645/171866795-52c11b49-0728-4229-b073-4b704209ddde.png">](https://accounts.lambdatest.com/register)

## Table of Contents:

* [Prerequisites](#prerequisites)
* [Run Your First Test](#run-your-first-test)
* [Parallel Testing With xUnit](#running-your-parallel-tests-using-xunit-testing-framework)
* [Local Testing With xUnit](#testing-locally-hosted-or-privately-hosted-projects)

## Prerequisites

Before you start performing **C#** automation testing with **Selenium** using xUnit, you need to:

* Download and install **Selenium WebDriver** from its [official website](https://www.selenium.dev/downloads/).
* Ensure you have the latest version of C#.
* **.NET** framework for guidelines while developing a range of applications using C#.
* Download [Selenium WebDriver Language Binding](https://www.selenium.dev/downloads/) for C# and extract them to the appropriate folder. Require a [.NET Core SDK](https://dotnet.microsoft.com/en-us/download) of 8.0 or greater version.

### Installing Selenium Dependencies And Tutorial Repo

**Step 1:** Clone the LambdaTest CSharp-xUnit-Selenium GitHub repository and navigate to the code directory:

```
git clone https://github.com/LambdaTest/CSharp-xUnit-Selenium
cd CSharp-xUnit-Selenium
```

### Setting up Your Authentication

Ensure you have your LambdaTest credentials to run C# automation scripts. Obtain these credentials from the [LambdaTest Automation Dashboard](https://automation.lambdatest.com/login) or your LambdaTest Profile.

**Step 2:** Set your LambdaTest Username and Access Key in environment variables.

**For Linux/macOS:**

```sh
export LT_USERNAME="YOUR_USERNAME" 
export LT_ACCESS_KEY="YOUR_ACCESS_KEY"
```

**For Windows:**

```sh
set LT_USERNAME="YOUR_USERNAME"
set LT_ACCESS_KEY="YOUR_ACCESS_KEY"
```

## Run Your First Test

> **Test Scenario**: Check out the sample SingleTest.cs file. This xUnit Selenium script tests a sample to-do list app by marking a couple of items as done, adding a new item to the list, and finally displaying the count of pending items as output.

**Step 3:** Navigate to [config.json](https://github.com/LambdaTest/CSharp-xUnit-Selenium/blob/master/XUnit-LambdaTest/config.json/) using VSCode. Replace this code in the config.json file in your project.

### Configuration of Your Test Capabilities

**Step 4:** In the config, update your test capabilities. We are passing browser, browser version, and operating system information, along with LambdaTest Selenium grid capabilities via the capabilities object. 

Example capabilities object:


```json
{
  "server": "hub.lambdatest.com",
  "user": "LT_USERNAME",
  "key": "LT_ACCESS_KEY",

  "capabilities": {
    "lt:options": {
      "buildName": "xunit build",
      "sessionName": "lambdatest xunit sample test",
      "visual": "true",
      "plugin": "xunit:sample"
    }
  },

  "environments": [
    {
      "browserName": "chrome"
    },
    {
      "browserName": "firefox"
    },
    {
      "browserName": "safari"
    }
  ],

  "TunnelOptions": {
    "tunnel": false
  }
}

```

**Note:** Generate capabilities for your test requirements with the help of the **[Desired Capability Generator](https://www.lambdatest.com/capabilities-generator/)**.

### Executing the Test

**Step 5:** Build the solution in Visual Studio.

**Step 6:** Run the

 tests from the Test Explorer in Visual Studio.

### Executing in Linux/macOS

* Clean and rebuild the project.

```sh
dotnet clean
```
* Execute Single Test 

```sh
dotnet test --filter "profile=single"
```

## Running Your Parallel Tests Using xUnit Testing Framework

**Executing Parallel tests in Windows**

Run all tests from the Test Explorer in Visual Studio for parallel execution.

**Executing parallel tests in Linux/MacOS**

```sh
dotnet test --filter "profile=parallel"
```

## Testing Locally Hosted Or Privately Hosted Projects

For testing locally hosted or privately hosted projects with LambdaTest Selenium grid using LambdaTest Tunnel, follow the [LambdaTest Tunnel documentation](https://www.lambdatest.com/support/docs/testing-locally-hosted-pages/).

Download the LambdaTest Tunnel binary for your OS and run the following command:

```bash
LT -user {user’s login email} -key {user’s access key}
```

**Tunnel Capability**

```json
"lt:options": {
      "buildName": "xunit build",
      "sessionName": "lambdatest xunit sample test",
      "visual": "true",
      "plugin": "xunit:sample",
      "tunnel": "true"
    }
```

## Tutorials 📙

*coming soon*

Subscribe To Our [LambdaTest YouTube Channel 🔔](https://www.youtube.com/c/LambdaTest) for the latest video tutorials.

## Documentation & Resources :books:

* [LambdaTest Documentation](https://www.lambdatest.com/support/docs/)
* [LambdaTest Blog](https://www.lambdatest.com/blog/)
* [LambdaTest Learning Hub](https://www.lambdatest.com/learning-hub/)    

## LambdaTest Community :busts_in_silhouette:

Join the [LambdaTest Community](https://community.lambdatest.com/) to interact with tech enthusiasts. Connect, ask questions, and learn from professionals worldwide.

## What's New At LambdaTest ❓

Stay updated with the latest features and product add-ons at [Changelog](https://changelog.lambdatest.com/).

## About LambdaTest

[LambdaTest](https://www.lambdatest.com/) is a leading test execution and orchestration platform. It allows users to run both manual and automated testing of web and mobile apps across various browsers, operating systems, and real device combinations. Over 500 enterprises and 1 million+ users across 130+ countries rely on LambdaTest for their testing needs.

### Features

* Run Selenium, Cypress, Puppeteer, Playwright, and Appium automation tests across 3000+ real desktop and mobile environments.
* Real-time Cross-browser testing on 3000+ environments.
* Test on Real device cloud.
* Blazing fast test automation with HyperExecute.
* Accelerate testing, shorten job times, and get faster feedback on code changes with Test At Scale.
* Smart Visual Regression Testing on the cloud.
* 120+ third-party integration with your favorite tools for CI/CD, Project Management, Codeless Automation, and more.
* Automated Screenshot testing across multiple browsers in a single click.
* Local testing of web and mobile apps.
* Online Accessibility Testing across 3000+ desktop and mobile browsers, browser versions, and operating systems.
* Geolocation testing of web and mobile apps across 53+ countries.
* LT Browser - for responsive testing across 50+ pre-installed mobile, tablets, desktop, and laptop viewports.

[<img height="58" width="200" src="https://user-images.githubusercontent.com/70570645/171866795-52c11b49-0728-4229-b073-4b704209ddde.png">](https://accounts.lambdatest.com/register)

## We Are Here to Help You :headphones:

* Have a query? We are available 24x7 to help. [Contact Us](mailto:support@lambdatest.com)
* For more info, visit [LambdaTest](https://www.lambdatest.com/)


