// Based on Jeff Wilcox' Syntax highlighter: http://www.jeff.wilcox.name/2010/03/syntax-highlighting-text-block/
// He really deservces most of the credits...

// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.
// <auto-generated />
// No style analysis for imported project.

using System;
using System.Collections.Generic;
using System.Threading;

namespace Raven.ManagementStudio.UI.Silverlight.Controls.JeffWilcox.SyntaxHighlighting
{
    internal class LanguageRepository : ILanguageRepository
    {
        private readonly Dictionary<string, ILanguage> loadedLanguages;

        public LanguageRepository(Dictionary<string, ILanguage> loadedLanguages)
        {
            this.loadedLanguages = loadedLanguages;
        }

        public IEnumerable<ILanguage> All
        {
            get { return loadedLanguages.Values; }
        }

        public ILanguage FindById(string languageId)
        {
            Guard.ArgNotNullAndNotEmpty(languageId, "languageId");
            
            ILanguage language = null;
            
                if (loadedLanguages.ContainsKey(languageId))
                    language = loadedLanguages[languageId];

            return language;
        }

        public void Load(ILanguage language)
        {
            Guard.ArgNotNull(language, "language");

            if (string.IsNullOrEmpty(language.Id))
                throw new ArgumentException("The language identifier must not be null or empty.", "language");

                loadedLanguages[language.Id] = language;
        }
    }
}