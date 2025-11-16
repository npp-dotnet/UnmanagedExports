// Decompiled with ILSpy version 9.1.0.7988+03b7444943e720b3134d296c0c8dd3876f8ea4ce

using System;
using System.Runtime.InteropServices;

namespace RGiesecke.DllExport
{
	[Serializable]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class DllExportAttribute : Attribute
	{
		public CallingConvention CallingConvention { get; set; }

		public string ExportName { get; set; }

		public DllExportAttribute()
		{
		}

		public DllExportAttribute(string exportName)
			: this(exportName, CallingConvention.StdCall)
		{
		}

		public DllExportAttribute(string exportName, CallingConvention callingConvention)
		{
			ExportName = exportName;
			CallingConvention = callingConvention;
		}
	}
}
