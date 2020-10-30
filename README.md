# env-var-configuration-example

To get my head around configuration .NET when moving hierarchical `appsettings.json`
files to environment variables on a Linux box. I wrote some words about it 
[here](http://fjukstad.github.io/blog/config-and-environment-variables/).

```bash
$ dotnet run
This works, and the value is: `example-value`
This does not work:
This works as well, and the value is: `example-value-2`
```
