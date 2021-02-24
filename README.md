[![ShipEngine](https://shipengine.github.io/img/shipengine-logo-wide.png)](https://shipengine.com)

# ShipEngine .NET

:warning: **WARNING**: This is alpha software under active development. `Caveat emptor` until a 0.1.0 release is ready.

A C# library built on the [ShipEngine API](https://shipengine.com) offering low-level access as well as convenience methods.

<hr />

## TESTS

In order for tests to pass, you need to have [hoverfly installed](https://docs.hoverfly.io/en/latest/pages/introduction/downloadinstallation.html).

Run the following command:

```
%> hoverfly -webserver -response-body-files-path simengine &
%> hoverctl import simengine/rpc/rpc.json
%> dotnet test
```
