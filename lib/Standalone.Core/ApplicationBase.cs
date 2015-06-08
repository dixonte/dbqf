﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using dbqf.Configuration;
using dbqf.Criterion;
using dbqf.Display;
using Standalone.Core.Data;
using Standalone.Core.Data.Processing;
using Standalone.Core.Export;
using System.IO;
using Standalone.Core.Serialization.Assemblers;
using Standalone.Core;
using PropertyChanged;

namespace Standalone.Core
{
    [ImplementPropertyChanged]
    public class ApplicationBase : IApplication
    {
        public Project Project { get; protected set; }
        public ExportServiceFactory ExportFactory { get; set; }
        public IViewPersistence ViewPersistence { get; set; }
    
        public string ApplicationTitle
        {
            get
            {
                return String.Concat("Database Query Framework",
                    String.IsNullOrWhiteSpace(Project.Title) ? "" : String.Concat(" - ", Project.Title));
            }
        }

        public IView CurrentView { get; set; }
        public BindingList<ISubject> SubjectSource { get; private set; }
        public virtual ISubject SelectedSubject { get; set; }
        public event EventHandler SelectedSubjectChanged = delegate { };
        private void OnSelectedSubjectChanged()
        {
            SelectedSubjectChanged(this, EventArgs.Empty);
        }

        public string ResultSQL { get; set; }

        [AlsoNotifyFor("IsSearching")]
        protected BackgroundWorker SearchWorker { get; set; }
        public bool IsSearching
        {
            get { return SearchWorker != null; }
        }

        public ApplicationBase(Project project)
        {
            Project = project;
            SubjectSource = new BindingList<ISubject>(Project.Configuration);
            SelectedSubject = SubjectSource[0];
        }

        public virtual void CancelSearch()
        {
            if (SearchWorker != null)
                SearchWorker.CancelAsync();
            SearchWorker = null;
        }

        public virtual void Export(string filename)
        {
            if (ExportFactory == null)
                return; 

            var ext = System.IO.Path.GetExtension(filename);
            ExportServiceFactory.ExportType etype;
            if (ext.Equals(".csv", StringComparison.OrdinalIgnoreCase))
                etype = ExportServiceFactory.ExportType.CommaSeparated;
            else if (ext.Equals(".txt", StringComparison.OrdinalIgnoreCase))
                etype = ExportServiceFactory.ExportType.TabDelimited;
            else
                throw new NotImplementedException(String.Concat("Export to file with extension ", ext, " not implemented."));

            Export(filename, ExportFactory.Create(etype));
        }
        protected virtual void Export(string filename, IExportService service)
        {
        }

        public virtual void Load(string filename)
        {
            if (ViewPersistence == null)
                return;

            // may throw a load exception
            SearchDocument doc = ViewPersistence.Load(filename);

            // TODO: set the current view
            // TODO: set output fields
            SelectedSubject = doc.Subject;
            CurrentView.SetParts(doc.Parts);
        }

        public virtual void Save(string filename)
        {
            if (ViewPersistence == null)
                return;

            var doc = new SearchDocument(Project)
            {
                SearchType = CurrentView.ToString(),
                Subject = SelectedSubject,
                Parts = new List<IPartView>()
            };

            // TODO: persist output fields

            // only save parts that have a parameter
            foreach (var p in CurrentView.GetParts())
            {
                if (p.GetParameter() != null)
                    doc.Parts.Add(p);
            }

            if (doc.Parts.Count > 0)
                ViewPersistence.Save(filename, doc);
            else
                throw new ArgumentException("Select at least one parameter to save.");
        }
    }
}
