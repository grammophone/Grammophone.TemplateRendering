using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammophone.TemplateRendering
{
	/// <summary>
	/// Contract for template rendering implementations,
	/// which must be thread-safe.
	/// </summary>
	public interface IRenderProvider : IDisposable
	{
		/// <summary>
		/// Render a template using a strong-type <paramref name="model"/>.
		/// </summary>
		/// <typeparam name="M">The type of the model.</typeparam>
		/// <param name="templateKey">The key of the template.</param>
		/// <param name="textWriter">The writer used for output.</param>
		/// <param name="model">The model.</param>
		/// <param name="dynamicProperties">Optional dynamic properties.</param>
		void Render<M>(
			string templateKey,
			TextWriter textWriter,
			M model,
			IDictionary<string, object> dynamicProperties = null);

		/// <summary>
		/// Render a template.
		/// </summary>
		/// <param name="templateKey">The key of the template.</param>
		/// <param name="textWriter">The writer used for output.</param>
		/// <param name="dynamicProperties">The dynamic properties.</param>
		void Render(
			string templateKey,
			TextWriter textWriter,
			IDictionary<string, object> dynamicProperties);
	}
}
