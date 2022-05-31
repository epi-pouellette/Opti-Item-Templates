﻿using System;
using EPiServer.Core;
using EPiServer.PlugIn;
using EPiServer.Scheduler;

namespace $rootnamespace$
{
    [ScheduledPlugIn(DisplayName = "$safeitemrootname$", GUID = "$guid1$")]
    public class $safeitemrootname$ : ScheduledJobBase
	{
	    private bool _stopSignaled;

        //private readonly IContentLoader _contentLoader; 

        // Here you can add dependencies to constructor, In this example if the scheduled job has dependencies then they can be injected in the constructor. Here example of the job has dependency to IContentLoader  
        // public $safeitemrootname$(IContentLoader contentLoader)
        // {
        //  _contentLoader = contentLoader;
        //  IsStoppable = true;
        // }


        public $safeitemrootname$()
        {
            IsStoppable = true;
        }

        /// <summary>
        /// Called when a user clicks on Stop for a manually started job, or when ASP.NET shuts down.
        /// </summary>
        public override void Stop()
        {
            _stopSignaled = true;
        }

        /// <summary>
        /// Called when a scheduled job executes
        /// </summary>
        /// <returns>A status message to be stored in the database log and visible from admin mode</returns>
        public override string Execute()
        {
            //Call OnStatusChanged to periodically notify progress of job for manually started jobs
            OnStatusChanged(String.Format("Starting execution of {0}", this.GetType()));

            //Add implementation

            //For long running jobs periodically check if stop is signaled and if so stop execution
            if (_stopSignaled)
            {
                return "Stop of job was called";
            }

            return "Change to message that describes outcome of execution";
        }
    }
}
