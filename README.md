# MobileBlazorBindings.Tests

Proof of concept for writing unit tests for Blazor Mobile Components. 

#### UnitTest

```csharp
var testContext = new TestContextBuilder().Build();
var page = await testContext.Start<Counter>();

var label = page.FindFirst<Label>();
var button = page.FindFirst<Button>();

Assert.Equal("The button was clicked 0 times", label.Text);

button.Click();

Assert.Equal("The button was clicked 1 times", label.Text);
            
button.Click();
button.Click();
            
Assert.Equal("The button was clicked 3 times", label.Text);
```

#### Counter Component

```
<ContentPage>
    <StackLayout>
        <Button Text="Increment" OnClick="IncrementCount" />
        <Label Text="@("The button was clicked " + count + " times")" />
    </StackLayout>
</ContentPage>

@code
{
    int count;
    void IncrementCount()
    {
        count++;
    }
}
```
