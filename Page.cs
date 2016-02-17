﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoGSoCIdeasPage {
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    
    public partial class Page : PageBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 6 ""
            this.Write("---\r\ntitle: Projects\r\nredirect_from:\r\n  - /StudentProjects/\r\n  - /GSoC/\r\n---\r\n\r\nThis is the Mono Project's project ideas page. For general information and rules about participating in\r\n[Google Summer of Code (GSoC)](http://code.google.com/soc/) for the Mono Project, please see our\r\n[overview page](/community/google-summer-of-code/).\r\n\r\nThis page lists some ideas for Mono GSoC projects that students can apply for. Additionally, we encourage students\r\nto submit their own interesting Mono-related project proposals. In past years, roughly 20% of the accepted\r\nproposals were original ideas from students instead of from our suggestions. You can submit more than one proposal,\r\nso you can submit your own ideas as well as apply for one from this list - but only one can be chosen, of course!\r\n\r\nYou can use the following links to jump to sections that you're interested in:\r\n\r\n**[Other Ideas](#other-ideas)**<br/>\r\nSuggest your own ideas for a project\r\n\r\n**[Microsoft .NET and Mono integration](#microsoft-net-and-mono-integration)**<br/>\r\nWork on blending the worlds of open source .NET and Mono projects together\r\n\r\n**[Compilers and Tools](#compilers-and-tools)**<br/>\r\nWork on Mono's tools and compilers\r\n\r\n**[MonoDevelop / Xamarin Studio IDE](#monodevelop--xamarin-studio-ide)**<br/>\r\nHelp developers build applications by improving the cross-platform MonoDevelop / Xamarin Studio IDE\r\n\r\n**[Mono Runtime](#mono-runtime)**<br/>\r\nImprove the core Mono runtime and JIT\r\n\r\n**[GTK# and Bindings](#gtk-and-bindings)**<br/>\r\nGTK# Core, Bindings and Applications\r\n\r\n**[Contacting the Mono Team](#contacting-the-mono-team)**<br/>\r\nHow to get in touch with us and ask questions\r\n\r\nOther Ideas\r\n===========\r\n\r\nIf a project is not listed here, but you think you have a great idea, feel free to\r\n[contact the Mono team, mentors and org admins](#contacting-the-mono-team) to discuss or suggest your own project ideas.\r\n\r\nOver the past years we have picked projects that were not listed here because they were great ideas, and we had students\r\nthat were passionate about those projects. In the end, most of these projects were a success.\r\n\r\nDo not be afraid to pick up a project that would be interesting and also help the Mono universe.\r\n\r\nYou can find some additional ideas on the [MonkeySquare ideas page](http://monkeysquare.org/gsoc/projects), and on the\r\n[Gnome ideas page](https://live.gnome.org/SummerOfCode2013/Ideas) (Mono-based projects in Gnome: Banshee, Blam, Tasque,\r\nTomboy, GBrainy, Mistelix, F-Spot, ChronoJump, SparkleShare, LongoMatch).\r\n\r\nMicrosoft .NET and Mono Integration\r\n===================================\r\n\r\nMicrosoft open sourced large chunks of code this year:\r\n\r\n* ReferenceSource: the source code for the class libraries of .NET as it ships on Windows\r\n* CoreFX: a fresh take on the distribution of the class libraries for a new, slimmer, smaller runtime\r\n* CoreCLR: their C/C++ based runtime, JIT, GC for running on Mac, Linux and Windows\r\n* Roslyn: Microsoft's C# and VB compiler as a service\r\n* CodeContracts: the tools needed to instrument your code\r\n\r\nWe are tracking various ideas in the [.NET Integration in Mono](https://trello.com/b/vRPTMfdz/net-framework-integration-into-mono) trello board.\r\n");
            
            #line default
            #line hidden
            
            #line 72 ""
 WriteIdeas (MonoDotNetIntegration); 
            
            #line default
            #line hidden
            
            #line 73 ""
            this.Write("\r\nCompilers and Tools\r\n===================\r\n");
            
            #line default
            #line hidden
            
            #line 76 ""
 WriteIdeas (CompilersAndTools); 
            
            #line default
            #line hidden
            
            #line 77 ""
            this.Write("\r\nMonoDevelop / Xamarin Studio IDE\r\n================================\r\n");
            
            #line default
            #line hidden
            
            #line 80 ""
 WriteIdeas (MonoDevelop); 
            
            #line default
            #line hidden
            
            #line 81 ""
            this.Write("\r\nMono Runtime\r\n============\r\n");
            
            #line default
            #line hidden
            
            #line 84 ""
 WriteIdeas (MonoRuntime); 
            
            #line default
            #line hidden
            
            #line 85 ""
            this.Write("\r\nGTK# and Bindings\r\n==================\r\n");
            
            #line default
            #line hidden
            
            #line 88 ""
 WriteIdeas (GtkSharpAndBindings); 
            
            #line default
            #line hidden
            
            #line 89 ""
            this.Write("\r\nContacting the Mono Team\r\n========================\r\n\r\nIf you have questions or suggestions that you want to make in real-time and talk to a member of the team, please join us\r\non IRC on the server \"irc.gnome.org\" in channel \"#monosoc\", \"#monodev\" or the \"#mono\" channel. Various mentors and\r\nstudents from past years are usually there and can answer some quick questions about the program and about Mono.\r\n\r\nThe mailing lists are a very important communication channel, students should use them to get more information and\r\nfeedback about ideas and proposals. Community engagement is essential for a successful summer of code, so get involved!\r\n\r\nFor any questions you may have about the program itself and to talk to the Mono GSoC admin, you can use\r\n[soc@xamarin.com](mailto:soc@xamarin.com).\r\n\r\nMailing Lists\r\n-------------\r\n\r\n[http://lists.ximian.com/mailman/listinfo/mono-devel-list](http://lists.ximian.com/mailman/listinfo/mono-devel-list)\r\nA mailing list dedicated to discussions about developing Mono itself, such as development of the runtime, class libraries, and related Mono projects.\r\n\r\n[http://lists.ximian.com/mailman/listinfo/monodevelop-devel-list](http://lists.ximian.com/mailman/listinfo/monodevelop-devel-list)\r\nDiscussion on the development/implementation of MonoDevelop.\r\n\r\nA complete breakdown of all Mono mailing lists is available at [Mailing Lists](/community/help/mailing-lists/).");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class PageBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((value != null)) {
                        this.formatProvider = value;
                    }
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
