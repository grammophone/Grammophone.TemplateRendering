# Grammophone.TemplateRendering
This .NET Standard 2.0 library defines a contract for template rendering engines.
It is typically used for generation of e-mail messages, workflow messages and others.

The contract is expressed by the `IRenderProvider` interface. It contains two methods, `Render` and `Render<M>`, for
rendering a template with a set of dynamic parameters in the form of `IDictionary<string, object>` or
a strong-type model whose type is the generic type argument `M`.

For a concrete implementation for rendering via the Razor engine of ASP.NET MVC,
see the library [Grammophone.TemplateRendering.RazorEngine](https://github.com/grammophone/Grammophone.TemplateRendering.RazorEngine)

This library has no dependencies.
