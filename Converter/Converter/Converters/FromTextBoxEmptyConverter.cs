using Microsoft.UI.Xaml.Data;

namespace Converter.Converters
{
	public class FromTextBoxEmptyConverter : IValueConverter
	{
		public object? HeaderOnlyValue { get; set; }

		public object? HeaderAndPlaceholderValue { get; set; }

		public object? Convert(object value, Type targetType, object parameter, string language)
		{
			var textBox = value as TextBox;

			if (textBox is not null)
			{
				var noText = string.IsNullOrEmpty(textBox.Text);

				if (noText)
				{
					return HeaderAndPlaceholderValue;
				}

			}
			return HeaderOnlyValue;
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotSupportedException();
		}
	}
}
