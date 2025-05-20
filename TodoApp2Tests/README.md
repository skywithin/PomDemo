https://playwright.dev/dotnet/docs/next/running-tests
https://www.youtube.com/watch?v=ZZXNPboS0v8
https://try.playwright.tech/?l=csharp

# Getting Started Tips
- Start in PowerShell. 
- Navigate to `bin\Debug\net{version}`
- You will need to run `playwright.ps1 install` in order to install the necessary browsers for testing.
- Once installed, keep the PowerShell terminal to trigger `codegen` for assistance in writing tests.


# Codegen
- Start the server first. The app must be running for codegen to work.
- `playwright` refers to `bin\Debug\net{version}\playwright.ps1`

- Run:
```
playwright codegen {url}
```
- Manually walk it through actions
- Used to generate the code for actions
- DOES NOT generate the code for assertions


# Run tests in headed mode
```
$env:HEADED="1"
dotnet test
```
or
```
dotnet test -- Playwright.LaunchOptions.Headless=false
```


Run tests on different browsers: Browser env

```
$env:BROWSER="webkit"
dotnet test
```


Run tests on different browsers: launch configuration
Specify which browser you would like to run your tests on via the BROWSER environment variable.

```
dotnet test -- Playwright.BrowserName=webkit
```

To run your test on multiple browsers or configurations, you need to invoke the dotnet test command multiple times. 
There you can then either specify the BROWSER environment variable or set the Playwright.BrowserName via the runsettings file:

```
dotnet test --settings:chromium.runsettings
dotnet test --settings:firefox.runsettings
dotnet test --settings:webkit.runsettings
```
=
```
<?xml version="1.0" encoding="utf-8"?>
  <RunSettings>
    <Playwright>
      <BrowserName>chromium</BrowserName>
    </Playwright>
  </RunSettings>
```


```
dotnet test -- Playwright.BrowserName=chromium Playwright.LaunchOptions.Headless=false Playwright.LaunchOptions.Channel=msedge
```
=
```
<?xml version="1.0" encoding="utf-8"?>
<RunSettings>
  <Playwright>
    <BrowserName>chromium</BrowserName>
    <LaunchOptions>
      <Headless>false</Headless>
      <Channel>msedge</Channel>
    </LaunchOptions>
  </Playwright>
</RunSettings>
```

```
<?xml version="1.0" encoding="utf-8"?>
<RunSettings>
  <!-- See https://xunit.net/docs/runsettings -->
  <xUnit>
    <MaxParallelThreads>1</MaxParallelThreads>
  </xUnit>
  <!-- General run configuration -->
  <RunConfiguration>
    <EnvironmentVariables>
      <!-- For debugging selectors, it's recommend to set the following environment variable -->
      <DEBUG>pw:api</DEBUG>
    </EnvironmentVariables>
  </RunConfiguration>
  <!-- Playwright -->  
  <Playwright>
    <BrowserName>chromium</BrowserName>
    <ExpectTimeout>5000</ExpectTimeout>
    <LaunchOptions>
      <Headless>false</Headless>
      <Channel>msedge</Channel>
    </LaunchOptions>
  </Playwright>
</RunSettings>
```



Run specific tests
To run a single test file, use the filter flag followed by the class name of the test you want to run.

```
dotnet test --filter "ExampleTest"
```

To run a set of test files, use the filter flag followed by the class names of the tests you want to run.

```
dotnet test --filter "ExampleTest1|ExampleTest2"
```

To run a test with a specific title use the filter flag followed by Name~ and the title of the test.

```
dotnet test --filter "Name~GetStartedLink"
```


Run tests with multiple workers:
```
dotnet test -- xUnit.MaxParallelThreads=5
```






=========================================================================================
https://playwright.dev/dotnet/docs/next/test-runners
Base classes for Playwright

PageTest


ContextTest


BrowserTest


PlaywrightTest	




===========================================================================================
https://playwright.dev/dotnet/docs/next/codegen-intro
Running Codegen

```
pwsh bin/Debug/net9.0/playwright.ps1 codegen https://localhost:7243/counter
```