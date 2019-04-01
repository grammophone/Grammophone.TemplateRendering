using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammophone.TemplateRendering
{
	/// <summary>
	/// Extension methods for <see cref="IRenderProvider"/> interface implementations.
	/// </summary>
	public static class RenderProviderExtensions
	{
		/// <summary>
		/// Render a template to string using a strong-type <paramref name="model"/>.
		/// </summary>
		/// <typeparam name="M">The type of the model.</typeparam>
		/// <param name="renderProvider">The render provider implementation.</param>
		/// <param name="templateKey">The key of the template.</param>
		/// <param name="model">The model.</param>
		/// <param name="dynamicProperties">Optional dynamic properties.</param>
		public static string RenderToString<M>(
			this IRenderProvider renderProvider,
			string templateKey,
			M model,
			IDictionary<string, object> dynamicProperties = null)
		{
			if (renderProvider == null) throw new ArgumentNullException(nameof(renderProvider));

			using (var writer = new System.IO.StringWriter())
			{
				renderProvider.Render(templateKey, writer, model, dynamicProperties);

				return writer.ToString();
			}
		}

		/// <summary>
		/// Render a template to string.
		/// </summary>
		/// <param name="renderProvider">The render provider implementation.</param>
		/// <param name="templateKey">The key of the template.</param>
		/// <param name="dynamicProperties">The dynamic properties.</param>
		public static string RenderToString(
			this IRenderProvider renderProvider,
			string templateKey,
			IDictionary<string, object> dynamicProperties)
		{
			if (renderProvider == null) throw new ArgumentNullException(nameof(renderProvider));

			using (var writer = new System.IO.StringWriter())
			{
				renderProvider.Render(templateKey, writer, dynamicProperties);

				return writer.ToString();
			}
		}
	}
}
