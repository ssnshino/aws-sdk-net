// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.NuGet
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\dev\net\v3\Xamarin\generator\ServiceClientGeneratorLib\Generators\NuGet\CoreNuspec.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class CoreNuspec : CoreNuspecBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<package> \r\n  <metadata> \r\n    <id>AWSS" +
                    "DK.Core</id>\r\n    <title>AWSSDK - Core Runtime</title>\r\n    <version>");
            
            #line 12 "C:\dev\net\v3\Xamarin\generator\ServiceClientGeneratorLib\Generators\NuGet\CoreNuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["FileVersion"]));
            
            #line default
            #line hidden
            this.Write("-preview</version> \r\n    <authors>Amazon Web Services</authors>\r\n    <description" +
                    ">The Amazon Web Services SDK for .NET - Core Runtime</description> \r\n    <langua" +
                    "ge>en-US</language>\r\n    <licenseUrl>http://aws.amazon.com/apache2.0/</licenseUr" +
                    "l>    \r\n    <projectUrl>https://github.com/aws/aws-sdk-net/tree/modularization/<" +
                    "/projectUrl>\r\n    <tags>AWS Amazon cloud</tags>\r\n    <iconUrl>http://media.amazo" +
                    "nwebservices.com/aws_singlebox_01.png</iconUrl>\r\n    <dependencies>\r\n      <grou" +
                    "p targetFramework=\"portable-net45+netcore45+wpa81+wp8+MonoAndroid10+xamarinios10" +
                    "+MonoTouch10\">\r\n        <dependency id=\"Microsoft.Net.Http\" version=\"2.2.29\" />\r" +
                    "\n\t\t<dependency id=\"PCLStorage\" version=\"1.0.2\" />\r\n        <dependency id=\"PCLCr" +
                    "ypto\" version=\"1.0.2.15130\" />\r\n      </group>\r\n      <group targetFramework=\"Mo" +
                    "noAndroid10\">\r\n        <dependency id=\"Microsoft.Net.Http\" version=\"2.2.29\" />\r\n" +
                    "        <dependency id=\"PCLStorage\" version=\"1.0.2\" />\r\n        <dependency id=\"" +
                    "PCLCrypto\" version=\"1.0.2.15130\" />\r\n      </group>\r\n      <group targetFramewor" +
                    "k=\"xamarinios10\">\r\n        <dependency id=\"Microsoft.Net.Http\" version=\"2.2.29\" " +
                    "/>\r\n        <dependency id=\"PCLStorage\" version=\"1.0.2\" />\r\n        <dependency " +
                    "id=\"PCLCrypto\" version=\"1.0.2.15130\" />\r\n      </group>\r\n      <group targetFram" +
                    "ework=\"MonoTouch10\">\r\n        <dependency id=\"Microsoft.Net.Http\" version=\"2.2.2" +
                    "9\" />\r\n        <dependency id=\"PCLStorage\" version=\"1.0.2\" />\r\n        <dependen" +
                    "cy id=\"PCLCrypto\" version=\"1.0.2.15130\" />\r\n      </group>\r\n\r\n    </dependencies" +
                    ">\r\n  </metadata> \r\n  <files>\r\n\r\n    <file src=\"..\\..\\nuget-content\\account-manag" +
                    "ement.ps1\" target=\"tools\" />\r\n\r\n    <file src=\".\\bin\\Release\\net35\\AWSSDK.Core.d" +
                    "ll\" target=\"lib\\net35\" />\r\n    <file src=\".\\bin\\Release\\net35\\AWSSDK.Core.xml\" t" +
                    "arget=\"lib\\net35\" />\r\n\t<file src=\".\\bin\\Release\\net35\\AWSSDK.Core.pdb\" target=\"l" +
                    "ib\\net35\" />\r\n\r\n    <file src=\".\\bin\\Release\\net45\\AWSSDK.Core.dll\" target=\"lib\\" +
                    "net45\" />\r\n    <file src=\".\\bin\\Release\\net45\\AWSSDK.Core.xml\" target=\"lib\\net45" +
                    "\" />\r\n\t<file src=\".\\bin\\Release\\net45\\AWSSDK.Core.pdb\" target=\"lib\\net45\" />\r\n\r\n" +
                    "    <file src=\".\\bin\\Release\\pcl\\AWSSDK.Core.dll\" target=\"lib\\portable-net45+net" +
                    "core45+wpa81+wp8+MonoAndroid10+xamarinios10+MonoTouch10\" />\r\n    <file src=\".\\bi" +
                    "n\\Release\\pcl\\AWSSDK.Core.xml\" target=\"lib\\portable-net45+netcore45+wpa81+wp8+Mo" +
                    "noAndroid10+xamarinios10+MonoTouch10\" />\r\n\t<file src=\".\\bin\\Release\\pcl\\AWSSDK.C" +
                    "ore.pdb\" target=\"lib\\portable-net45+netcore45+wpa81+wp8+MonoAndroid10+xamarinios" +
                    "10+MonoTouch10\" />\r\n    \r\n    <file src=\".\\bin\\Release\\Xamarin.iOS10\\AWSSDK.Core" +
                    ".dll\" target=\"lib\\Xamarin.iOS10\" />\r\n    <file src=\".\\bin\\Release\\Xamarin.iOS10\\" +
                    "AWSSDK.Core.xml\" target=\"lib\\Xamarin.iOS10\" />\r\n    \r\n    <file src=\".\\bin\\Relea" +
                    "se\\Xamarin.iOS10\\AWSSDK.Core.dll\" target=\"lib\\Xamarin.Mac20\" />\r\n    <file src=\"" +
                    ".\\bin\\Release\\Xamarin.iOS10\\AWSSDK.Core.xml\" target=\"lib\\Xamarin.Mac20\" />\r\n    " +
                    "\r\n    <file src=\".\\bin\\Release\\monoandroid\\AWSSDK.Core.dll\" target=\"lib\\monoandr" +
                    "oid\" />\r\n    <file src=\".\\bin\\Release\\monoandroid\\AWSSDK.Core.xml\" target=\"lib\\m" +
                    "onoandroid\" />\r\n\t<file src=\".\\bin\\Release\\monoandroid\\AWSSDK.Core.pdb\" target=\"l" +
                    "ib\\monoandroid\" />\r\n    \r\n    <file src=\".\\bin\\Release\\windows8\\AWSSDK.Core.dll\"" +
                    " target=\"lib\\windows8\" />\r\n    <file src=\".\\bin\\Release\\windows8\\AWSSDK.Core.xml" +
                    "\" target=\"lib\\windows8\" />\r\n\t<file src=\".\\bin\\Release\\windows8\\AWSSDK.Core.pdb\" " +
                    "target=\"lib\\windows8\" />\r\n    \r\n    <file src=\".\\bin\\Release\\wpa81\\AWSSDK.Core.d" +
                    "ll\" target=\"lib\\wpa81\" />\r\n    <file src=\".\\bin\\Release\\wpa81\\AWSSDK.Core.xml\" t" +
                    "arget=\"lib\\wpa81\" />\r\n\t<file src=\".\\bin\\Release\\wpa81\\AWSSDK.Core.pdb\" target=\"l" +
                    "ib\\wpa81\" />\r\n\r\n\t<file src=\".\\bin\\Release\\wp8\\AWSSDK.Core.dll\" target=\"lib\\wp8\" " +
                    "/>\r\n    <file src=\".\\bin\\Release\\wp8\\AWSSDK.Core.xml\" target=\"lib\\wp8\" />\r\n\t<fil" +
                    "e src=\".\\bin\\Release\\wp8\\AWSSDK.Core.pdb\" target=\"lib\\wp8\" />\r\n  </files>\r\n</pac" +
                    "kage>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class CoreNuspecBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}